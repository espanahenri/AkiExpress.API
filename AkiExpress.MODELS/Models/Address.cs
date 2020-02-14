using System;
using System.Collections.Generic;
using System.Text;

namespace AkiExpress.MODELS
{
    public class Address
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string streetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int zipCode { get; set; }
        public string country { get; set; }
    }
}
