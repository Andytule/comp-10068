using Assignment5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class ReviewHandler : MailHandler
    {
        public ReviewHandler()
        {

        }

        public override bool ForReview => true;

        public override void Handle(Mail mail, List<Mailbox> mailboxes)
        {
            Console.WriteLine($"Handled: {mail.Flagged}");
        }

    }
}
