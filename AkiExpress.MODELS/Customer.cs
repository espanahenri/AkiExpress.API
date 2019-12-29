using System;
using System.Collections.Generic;

namespace AkiExpress.MODELS
{
    public class Customer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
