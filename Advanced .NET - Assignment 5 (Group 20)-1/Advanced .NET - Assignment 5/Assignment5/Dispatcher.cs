using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Assignment5;

namespace Problem3
{
    public class Dispatcher
    {
        private List<MailHandler> mailHandlers = new List<MailHandler>();
        private List<Mailbox> mailBoxes = new List<Mailbox>();

        public Dispatcher()
        {
            this.mailHandlers.AddRange(typeof(Dispatcher).Assembly.DefinedTypes.Where(c => typeof(MailHandler).IsAssignableFrom(c) && !c.IsAbstract && c.IsClass).Select(t => (MailHandler)Activator.CreateInstance(t)));
        }

        public void AddMailbox(Mailbox mailbox)
        {
            this.mailBoxes.Add(mailbox);
        }

        public void RemoveMailbox(Mailbox mailbox)
        {
            this.mailBoxes.Remove(mailbox);
        }

        public List<Mailbox> GetMailboxes()
        {
            return this.mailBoxes;
        }

        public void Handle(Mail mail)
        {
            var mailHandler = this.mailHandlers.FirstOrDefault(c => c.ForReview == mail.Flagged);

            if (mailHandler == null)
            {
                throw new InvalidOperationException("Unable to locate handler");
            }

            mailHandler.Handle(mail, mailBoxes);
        }

        
    }
}
