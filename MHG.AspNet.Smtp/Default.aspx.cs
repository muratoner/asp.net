using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MHG.AspNet.Smtp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbPort.Text))
            {
                var smtp = new SmtpClient(tbHost.Text, int.Parse(tbPort.Text));

                var message = new MailMessage();
                message.From = new MailAddress(tbUsername.Text, tbUsername.Text, Encoding.UTF8);
                message.IsBodyHtml = true;
                message.Body = tbMessage.Text;
                message.Subject = tbSubject.Text;

                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(tbUsername.Text, tbPasword.Text);

                foreach (var item in tbTo.Text.Split(','))
                {
                    message.To.Add(new MailAddress(item.Trim()));
                }
                smtp.EnableSsl = cbSsl.Checked;
                smtp.Send(message);
            }
            else
            {
                Response.Write("Port girişi yapınız.");
            }
        }
    }
}