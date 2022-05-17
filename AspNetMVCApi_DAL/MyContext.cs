using AspNetMVCApi_EL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVCApi_DAL
{
    public class MyContext:DbContext
    {
        public MyContext():base("name=MyCon")
        {
        }
        public DbSet<Student> Students { get; set; }


    }
}
