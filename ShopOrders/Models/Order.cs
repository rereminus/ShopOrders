using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOrders.Models
{
    public class Order
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string Client { get; set; }
        public double Price { get; set; }
        public int TovarIds { get; set; }
        public int RecordID { get; set; }
    }
}
