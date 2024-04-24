using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Portal.Helpers;

namespace Portal.Data.Context
{
    public interface IUnitOfWork : IDisposable
    {
        SaveResult SaveChanges();
        Task<SaveResult> SaveChangesAsync();


        bool BeginTransaction();
        bool CommitTransaction();
        bool RollBackTransaction();
    }

    public class UnitOfWork(DbContext dbContext) : IUnitOfWork
    {
        private readonly DbContext context = dbContext;
        private IDbContextTransaction _transation;

        #region IUnitOfWork Members

        public bool BeginTransaction()
        {
            try
            {
                _transation = context.Database.BeginTransaction();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CommitTransaction()
        {
            try
            {
                if (_transation == null)
                    return false;

                _transation.Commit();
                _transation = null;
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool RollBackTransaction()
        {
            try
            {
                if (_transation == null)
                    return false;

                _transation.Rollback();
                _transation = null;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        DateTime serverDate;
        public SaveResult SaveChanges()
        {
            var result = new SaveResult();

            try
            {
                context.SaveChanges();
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.errorMessage = ex.Message;
            }
            return result;
        }
        public async Task<SaveResult> SaveChangesAsync()
        {
            var result = new SaveResult();

            try
            {
                await context.SaveChangesAsync();
                result.isSuccess = true;
            }
            catch (Exception ex)
            {
                result.isSuccess = false;
                result.errorMessage = ex.Message;
            }
            return result;
        }

        DateTime getServerDate()
        {
            DateTime dateTime = DateTime.Now;
            string ConnStr = context.Database.GetConnectionString();
            using (SqlConnection sqlcon = new SqlConnection(ConnStr))
            {
                sqlcon.Open();
                using (SqlCommand sqlcmd = new SqlCommand())
                {
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "SELECT getdate()[ServerDate]";
                    using (SqlDataReader sqlrdr = sqlcmd.ExecuteReader())
                    {
                        while (sqlrdr.Read())
                        {
                            dateTime = Convert.ToDateTime(sqlrdr["ServerDate"]);
                        }
                    }

                }
            }
            return dateTime;
        }
        #endregion

        #region IDisposable Members
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }

            disposed = true;
        }
        public void Dispose()
        {
            //Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
