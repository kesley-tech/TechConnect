using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TechConnect
{
    public class SendEmail
    {
        //public async static Task BuildSendEmail(string body, string subject, string toEmail)
        //{

            //string sendGridApiKey = Environment.GetEnvironmentVariable("ngeVfQFYQlKU0ufo8x5d1A");

            //var client = new SendGridClient(sendGridApiKey);
            //var from = new EmailAddress("techconnectionnotification@gmail.com", "Tech Connection");
            //var to = new EmailAddress(toEmail, "Prezado");
            //var plainTextContent = "";
            //var htmlContent = body;

            //var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            //var response = await client.SendEmailAsync(msg);

            // Configure as credenciais do remetente
        //    string remetenteEmail = "techconnectionnotification@gmail.com";
        //    string remetenteSenha = "techconnection23";

        //    // Configure o servidor SMTP do Gmail
        //    SmtpClient client = new SmtpClient("smtp.gmail.com")
        //    {
        //        Port = 587,
        //        Credentials = new NetworkCredential(remetenteEmail, remetenteSenha),
        //        EnableSsl = true,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //    };

        //    // Crie a mensagem de e-mail
        //    MailMessage message = new MailMessage
        //    {
        //        From = new MailAddress(remetenteEmail),
        //        Subject = subject,
        //        Body = body,
        //        IsBodyHtml = true,
        //    };

        //    // Adicione o destinatário
        //    message.To.Add(toEmail);

        //    try
        //    {
        //        // Envie o e-mail
        //        client.Send(message);
        //        Console.WriteLine("E-mail enviado com sucesso.");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Erro ao enviar o e-mail: " + ex.Message);
        //    }
        //}
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
