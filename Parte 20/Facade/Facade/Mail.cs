﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class Mail
    {
        private SMTPSettings _conf;

        public Mail(SMTPSettings conf)
        {
            this._conf = conf;
        }

        public void Send(MailMessage message)
        {
            // usando configurações SMTP
            Console.WriteLine("Enviando mensagem...");
            Console.WriteLine(message.Message);
        }
    }
}
