﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp1.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
    }
}