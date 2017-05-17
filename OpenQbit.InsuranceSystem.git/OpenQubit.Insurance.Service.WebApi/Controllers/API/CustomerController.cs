using OpenQubit.Insurance.Service.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OpenQubit.Insurance.Service.WebApi.Controllers.API
{
    public class CustomerController : ApiController
    {
        public ApiCustomerModel Get(int id)
        {
            ApiCustomerModel customer = new ApiCustomerModel
            {
                ID = 1,
                FirstName = "Pahansith",
                LastName = "Gunathilake",
                Address = "Matara",
                Birthday = new DateTime(1993, 08, 24),
                Email = "nuwanikodagoda@gmail.com",
                Mobile = "+94714303336",
                Telephone = "+94387398223"

            };

            return customer;
        }
    }
}
