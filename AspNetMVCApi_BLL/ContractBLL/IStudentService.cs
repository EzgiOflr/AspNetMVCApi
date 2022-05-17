using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspNetMVCApi_EL.ViewModels;

namespace AspNetMVCApi_BLL.ContractBLL
{
    public interface IStudentService
    {
        //viewmodellerle işlem yapacak. servicelerde.
        ResponseData GetAllStudents();
        ResponseData AddStudent(StudentVM student);
        ResponseData UpdateStudent(int studentId, string newName, string newSurname);
        ResponseData DeleteStudent(int studentId);



    }
}
