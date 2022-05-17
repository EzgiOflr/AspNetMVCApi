using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMVCApi_DAL.Contracts;

namespace AspNetMVCApi_DAL.Contracts
{
    public interface IUnitOfWork
    {

        IStudentRepo StudentRepo { get; }

    }
}
