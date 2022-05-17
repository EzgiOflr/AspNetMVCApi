using AspNetMVCApi_DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVCApi_DAL.Implementations
{
   public  class UnitOfWork:IUnitOfWork
    {
        protected MyContext _myContext  ;
        public IStudentRepo StudentRepo { get; }
        
        public UnitOfWork(MyContext myContext)
        {
            _myContext = myContext;
            StudentRepo = new StudentRepo(_myContext);
        }


    }
}
