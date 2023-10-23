using System;
using System.Net;
using System.Net.Mail;
namespace TechConnect
{
    public class SendEmail
    {
        public static void BuildSendEmail(string body, string subject, string toEmail)
        {
            try
            {
                //SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587);
                //client.EnableSsl = true;
                //client.UseDefaultCredentials = false;
                //client.Credentials = new NetworkCredential("kesley.cunha@outlook.com.br", "Tec!2020");

                //MailMessage message = new MailMessage();
                //message.From = new MailAddress("kesley.cunha@outlook.com.br");
                //message.Subject = subject;
                //message.Body = body;
                //foreach (var email in toEmailList)
                //    message.To.Add(email);

                //client.Send(message);

                /* Cria a mensagem de email
                 * ===================================================*/
                //var minhaMensagemEmail = new SendGridMessage();
                //minhaMensagemEmail.AddTo(toEmail);
                //minhaMensagemEmail.From = new MailAddress("comunication@tech-connection.com");
                //minhaMensagemEmail.Subject = subject;
                //minhaMensagemEmail.Text = body;
                ///* Envia a menssasgem
                // * ===================================================*/
                //var credentials = new NetworkCredential("techconnectioncomunication@gmail.com", "techconnection23");
                //// Cria um transporte web para enviar email
                //var transporteWeb = new Web(credentials);
                //// Enviar email
                //transporteWeb.DeliverAsync(minhaMensagemEmail);


            }
            catch (Exception ex)
            {
            }
        }
    }

    public class BodyDefault
    {
        public const string changePassword = @"<!DOCTYPE html>
                                                    <html>
                                                    <head>
                                                        <style>
                                                            body {
                                                                font-family: Arial, sans-serif;
                                                            }
                                                            .container {
                                                                width: 100%;
                                                                max-width: 600px;
                                                                margin: 0 auto;
                                                                padding: 20px;
                                                            }
                                                            .header {
                                                                background-color: #007BFF;
                                                                color: #fff;
                                                                text-align: center;
                                                                padding: 20px;
                                                            }
                                                            .content {
                                                                padding: 20px;
                                                            }
                                                            .btn {
                                                                display: inline-block;
                                                                background-color: #007BFF;
                                                                color: #fff;
                                                                text-decoration: none;
                                                                padding: 10px 20px;
                                                                border-radius: 5px;
                                                            }
                                                            .footer {
                                                                background-color: #f0f0f0;
                                                                padding: 10px;
                                                                text-align: center;
                                                            }
                                                        </style>
                                                    </head>
                                                    <body>
                                                        <div class=""container"">
                                                            <div class=""header"">
                                                                <h1>Confirmação de alteração de senha</h1>
                                                            </div>
                                                            <div class=""content"">
                                                                <p>Olá,</p>
                                                                <p>Favor copiar e colar o token de validação a seguir na aplicação TechConnect:</p>
                                                                <p>{URL_DO_TOKEN}</p>
                                                            </div>
                                                            <div class=""footer"">
                                                                <p>Este é um e-mail automático. Por favor, não responda a este e-mail.</p>
                                                            </div>
                                                        </div>
                                                    </body>
                                                    </html>";
    }
}
