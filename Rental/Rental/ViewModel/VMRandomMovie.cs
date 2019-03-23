using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Rental.Models;

namespace Rental.ViewModel
{
    public class VMRandomMovie
    {
        public Movie movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}