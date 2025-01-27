﻿using BooksEverywhere.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public LibraryUser LibraryUser { get; set; }
        public int LibraryUserId { get; set; }
    }
}
