using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class MailingInformation
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public MailingInformation(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType())) {
                return false;
            }
            else
            {
                MailingInformation m = (MailingInformation) obj;
                return (Name == m.Name) && (Address == m.Address);
            }
            
        }

    }
}
