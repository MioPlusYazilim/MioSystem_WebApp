using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace Portal.Api.Helpers.Logging
{

    public class LoggerProvider : ILoggerProvider
    {
        public IWebHostEnvironment hostingEnvironment;
        public LoggerProvider(IWebHostEnvironment _hostingEnvironment) => hostingEnvironment = _hostingEnvironment;
        public ILogger CreateLogger(string categoryName) => new Logger(hostingEnvironment);
        public void Dispose() => throw new NotImplementedException();
    }
}
