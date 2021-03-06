﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StockManager.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public DateTime DateJoined { get; set; }
        public string Password { get; set; }
    }
}
