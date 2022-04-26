using Assignment5;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public abstract class MailHandler
    {
        protected MailHandler()
        {

        }


        public abstract bool ForReview { get; }

        public abstract void Handle(Mail mail, List<Mailbox> mailboxes);

    }
}
