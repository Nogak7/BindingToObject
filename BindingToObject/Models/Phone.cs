using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingToObject.Models
{
    public class Phone
    {
        public string PhoneNumber { get; set; } 
        public string Model { get; set; }   

        public string Image { get; set; }

        public Phone(string phoneNumber, string model, string image)
        {
            PhoneNumber = phoneNumber;
            Model = model;
            Image = image;
        }   
    }
}
