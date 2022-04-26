using Problem3;
using System;

namespace Assignment5
{
    public enum MailType
    {
        Package,
        Letter
    }
    
    public class Mail
    {
        public MailingInformation Sender { get; set; }
        public MailingInformation Receiver { get; set; }
        public double PostalCost { get; set; }
        public double Weight { get; set; }
        public MailType MailType { get; set; }
        public bool Flagged { get; set; }

        public Mail(MailingInformation sender, MailingInformation receiver, 
            double postalCost, double weight, MailType mailType, bool flaggedForReview)
        {
            Sender = sender;
            Receiver = receiver;
            PostalCost = postalCost;
            Weight = weight;
            MailType = mailType;
            Flagged = flaggedForReview;
        }
    }
}
