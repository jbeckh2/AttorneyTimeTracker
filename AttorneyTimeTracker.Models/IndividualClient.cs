using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttorneyTimeTracker.Common;

namespace AttorneyTimeTracker.Models
{
    public class IndividualClient : Client
    {
        private string _displayName;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _suffix;
        private string _prefix;

        public IndividualClient()
        {
            this.PropertyChanged += IndividualClient_PropertyChanged;
        }

        void IndividualClient_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "FirstName"
                || e.PropertyName == "LastName"
                || e.PropertyName == "MiddleName"
                || e.PropertyName == "Suffix"
                || e.PropertyName == "Prefix"
                )
            {
                UpdateDisplayName();
            }
        }

        private void UpdateDisplayName()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append(LastName);
            sb.Append(", ");

            sb.Append(FirstName);

            if (MiddleName != string.Empty)
            {
                sb.Append(" ");
                sb.Append(MiddleName);
            }
            sb.Append(LastName);

            if (Suffix != string.Empty)
            {
                sb.Append(", ");
                sb.Append(Suffix);
            }
            DisplayName = sb.ToString();
        }

        public override string DisplayName
        {
            get { return _displayName; }
            protected set { _displayName = value; OnPropertyChanged("DisplayName");}
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value.NullToEmpty(); OnPropertyChanged("FirstName"); }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value.NullToEmpty(); OnPropertyChanged("MiddleName"); }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value.NullToEmpty(); OnPropertyChanged("LastName"); }
        }

        public string Suffix
        {
            get { return _suffix; }
            set { _suffix = value.NullToEmpty(); OnPropertyChanged("Suffix"); }
        }

        public string Prefix
        {
            get { return _prefix; }
            set { _prefix = value.NullToEmpty(); OnPropertyChanged("Prefix"); }
        }
    }
}
