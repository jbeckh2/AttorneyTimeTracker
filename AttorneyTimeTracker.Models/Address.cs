using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttorneyTimeTracker.Common;

namespace AttorneyTimeTracker.Models
{
    public class Address : Entity
    {
        private string _addressType = string.Empty;
        private string _addressLine1 = string.Empty;
        private string _city = string.Empty;
        private string _state = string.Empty;
        private string _postalCode = string.Empty;

        public string AddressType
        {
            get { return _addressType; }
            set { _addressType = value.NullToEmpty(); OnPropertyChanged("AddressType"); }
        }

        public string AddressLine1
        {
            get { return _addressLine1; }
            set { _addressLine1 = value.NullToEmpty(); OnPropertyChanged("AddressLine1");}
        }

        public string City
        {
            get { return _city; }
            set { _city = value.NullToEmpty(); OnPropertyChanged("City");}
        }

        public string State
        {
            get { return _state; }
            set { _state = value.NullToEmpty(); OnPropertyChanged("State");}
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value.NullToEmpty(); OnPropertyChanged("PostalCode"); }
        }
    }
}
