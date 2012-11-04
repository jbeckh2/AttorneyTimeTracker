using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttorneyTimeTracker.Models
{
    public class Entity : ObservableBase
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set 
            { 
                _id = value;
                OnPropertyChanged("ID");
            }
        }
    }
}
