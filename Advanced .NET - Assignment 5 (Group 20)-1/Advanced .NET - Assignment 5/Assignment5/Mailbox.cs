using Assignment5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class Mailbox
    {
        public MailingInformation MailingInformation { get; }

        private List<Mail> content = new List<Mail>();

        public Mailbox(MailingInformation mailingInformation)
        {
            MailingInformation = mailingInformation;
        }

        public void AddMail(Mail mail)
        {
            content.Add(mail);
        }

        public int GetSize()
        {
            return content.Count;
        }
    }
}
