using System;
using System.Collections.Generic;

namespace Hollywood
{
    public enum MailFormat
    {
        TXT, HTML
    }

    public interface IEmail
    {
        string Subject { get; set; }
        string Message { get; set; }
        MailFormat Format { get; set; }
    }

    public interface IEmailConstructor
    {
        IEmail CreateEmail();
        

    }

    public class Email : IEmail
    {
        public string Subject { get; set; }
        public string Message { get; set; }
        public MailFormat Format { get; set; }
    }

    public class EmailConstructor : IEmailConstructor
    {
        public IEmail CreateEmail()
        {
            return new Email();
        }
    }

    public class EmailSender
    {
        private EmailConstructor _emailConstructor;

        private void Send(IEmail email)
        {
            Console.WriteLine("Enviando email: Subject: {0}, Message: {1}", email.Subject, email.Message);
        }

        public void SendEmail(IEmailConstructor constructor, string Subject, string Message)
        {
            //_emailConstructor = new EmailConstructor();
            IEmail email = constructor.CreateEmail();
            email.Message = Message;
            email.Subject = Subject;
            Send(email);
        }
    }
}