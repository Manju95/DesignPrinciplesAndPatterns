using System;
using System.Net.Mail;
using DotnetTraining.DesignPrinciples.SOLID.Models;

namespace DotnetTraining.SOLID
{
	
	public class UserService_SRPExample
	{
		private EMailService _eMailService;

		public UserService_SRPExample(EMailService mailService)
		{
			_eMailService = mailService;
		}

        public void Register(User user)
        {
			var isValidEmail = _eMailService.ValidateEmailAddress(user.UserEmail);
			if (isValidEmail)
			{
				// some code to insert user into DB
				_eMailService.SendEmail();
			}
        }
    }

	public class EMailService
	{
		private readonly SmtpClient _client;

		public EMailService(SmtpClient smtp)
		{
			_client = smtp;
		}

		public bool ValidateEmailAddress(string email)
		{
			return email.Contains("@");
		}

		public bool SendEmail()
		{
			try
			{
                _client.SendMailAsync(new MailMessage()
                {
                    Subject = "Register successfull"
                });
				return true;

            }
			catch (Exception ex)
			{
				return false;
			}
			
		}
	}
}