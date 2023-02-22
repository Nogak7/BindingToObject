using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToObject.Models
{
    public class Student:INotifyPropertyChanged              
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }
        private DateTime currDate;

        public event PropertyChangedEventHandler PropertyChanged;

        public DateTime CurrDate { get => currDate;  set { if(value!=currDate) currDate = value; OnPropertyChanged("CurrDate"); } }
        public int Age { get => (int)(CurrDate - BirthDate).TotalDays / 365; }

        public Student()
        {
            currDate = DateTime.Now;
        }
        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));  
        }
    }
}
