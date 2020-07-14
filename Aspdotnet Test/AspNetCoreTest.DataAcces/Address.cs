using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreTest.DataAcces
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public List<Person> People { get; set; }
    }
}
