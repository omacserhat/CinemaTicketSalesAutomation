using CinemaTicketSalesAutomation.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Models
{
    public class Movie : BaseClass
    {
        public string picturePath { get; set; }
        public string minute { get; set; }
        public decimal price { get; set; }
        public Category category { get; set; }
        public List<Session> session { get; set; }
    }
}
