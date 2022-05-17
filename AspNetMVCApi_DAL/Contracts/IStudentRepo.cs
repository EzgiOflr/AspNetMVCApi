using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMVCApi_EL.Models;
using AspNetMVCApi_DAL.Contracts;
namespace AspNetMVCApi_DAL.Contracts
{
    public interface IStudentRepo: IRepositoryBase<Student,int>
    {

    }
}
