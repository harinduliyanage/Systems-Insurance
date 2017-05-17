﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQubit.Insurance.Service.WebApi.Models.API
{
    public class ApiPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Telephone { get; set; }

    }
}