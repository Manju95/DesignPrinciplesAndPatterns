using System;
using DotnetTraining.DesignPrinciples.SOLID.Models;
using DotnetTraining.SOLID;

namespace DotnetTraining.DesignPrinciples.SOLID
{
	public class SOLIDService
	{
		
		public void SRPExample()
		{
			UserService_SRPExample srp = new UserService_SRPExample(new EMailService(new System.Net.Mail.SmtpClient()));
			User user = new User
			{
				UserEmail = "Manjunath.somawagol@TestDomain.com",
				Password = "123456789"
			};
			srp.Register(user);
		}

        public void OCPExample()
        {
            OCPExample ocp = new OCPExample();
            ocp.RunOCP();
        }

		public void LSPExample()
		{
			LSPExample lsp = new LSPExample();
			lsp.RunLSP();
		}

		public void ISPExample()
		{
			ISPExample isp = new ISPExample();
			isp.RunISP();
		}

		public void DIPExample()
		{
			DataExport_DIPExample dip = new DataExport_DIPExample();
			dip.ExportDataToFiles();
		}
    }
}

