﻿using System;

namespace AspNetCoreTest.DataAcces
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public bool IsMale { get; set; }

    }
}