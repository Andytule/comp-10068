using Assignment5;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Problem3
{
    public class DeliverHandler : MailHandler
    {
        public DeliverHandler()
        {

        }

        public override bool ForReview => false;

        public override void Handle(Mail mail, List<Mailbox> mailboxes)
        {
            Console.WriteLine($"Handled: {mail.Flagged}");
            foreach(Mailbox mailbox in mailboxes)
            {
                if (mailbox.MailingInformation.Equals(mail.Receiver)) {
                    Console.WriteLine($"Delivered: {mail.Receiver}");
                    mailbox.AddMail(mail);
                } 
                else
                {
                    Console.WriteLine("Recepient not found");
                }
            }
        }


    }
}
