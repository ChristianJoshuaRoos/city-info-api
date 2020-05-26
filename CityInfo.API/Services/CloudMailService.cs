using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private readonly IConfiguration _configuration;

        public CloudMailService(IConfiguration config)
        {
            _configuration = config ?? throw new ArgumentNullException(nameof(config));
        }

        public void Send(string subject, string message)
        {
            //Send mail, but really just output the mail to the debug window.
            Debug.WriteLine($"Mail from {_configuration["mailSettings:mailFromAddress"]} to {_configuration["mailSettings:mailToAddress"]} with Cloud Mail Service.");
            Debug.WriteLine($"Subject: {subject}");
            Debug.WriteLine($"Message: {message}");
        }
    }
}
