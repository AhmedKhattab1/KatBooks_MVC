using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Utility
{
	public class EmailSender : IEmailSender
	{
		public string Secret { get; set; }
		public EmailSender(IConfiguration _config)
		{
			Secret = _config.GetValue<string>(":");
		}
		public Task SendEmailAsync(string email, string subject, string htmlMessage)
		{
			//logic to send email
			return Task.CompletedTask;
		}
	}
}
