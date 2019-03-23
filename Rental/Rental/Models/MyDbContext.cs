using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext() { }
    }
}