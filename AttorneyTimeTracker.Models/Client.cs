using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttorneyTimeTracker.Models
{
    public abstract class Client: Entity
    {
        private Address _mailingAddress;
        private Address _billingAddress;
        public ClientType Type { get; protected set; }

        public abstract string DisplayName { get; protected set; }

        public Address MailingAddress
        {
            get { return _mailingAddress; }
            set { _mailingAddress = value; OnPropertyChanged("MailingAddress"); }
        }

        public Address BillingAddress
        {
            get { return _billingAddress; }
            set { _billingAddress = value; OnPropertyChanged("BillingAddress");}
        }
    }
}
