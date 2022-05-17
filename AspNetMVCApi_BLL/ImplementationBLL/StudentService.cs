using AspNetMVCApi_BLL.ContractBLL;
using AspNetMVCApi_DAL.Contracts;
using AspNetMVCApi_EL.Models;
using AspNetMVCApi_EL.ViewModels;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVCApi_BLL.ImplementationBLL
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ResponseData AddStudent(StudentVM student)
        {
            try
            {
                Student newStudent = student.Adapt<Student>();
                bool result = _unitOfWork.StudentRepo.Add(newStudent);
                if (result)
                {
                    return new ResponseData() { IsSuccess = true, Message = "Yeni Öğrenci eklendi!" };
                }
                else
                {

                    return new ResponseData() { IsSuccess = false, Message = "Beklenmedik bir hata oluştu!" };
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ResponseData DeleteStudent(int studentId)
        {
            try
            {
                if (studentId > 0)
                {
                    var student = _unitOfWork.StudentRepo.GetById(studentId);
                    if (student == null)
                    {
                        throw new Exception("HATA: Student bulunamadı!");
                    }
                    bool result = _unitOfWork.StudentRepo.Delete(student);
                    if (result)
                    {
                        return new ResponseData() { IsSuccess = true, Message = "Öğrenci silindi." };
                    }
                    else
                    {
                        return new ResponseData() { IsSuccess = false, Message = "HATA: Öğrenci silinemedi!" };
                    }
                }
                else
                {
                    throw new Exception("HATA: StudentId sıfırdan büyük olmalıdır!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ResponseData GetAllStudents()
        {
            try
            {
                var students = _unitOfWork.StudentRepo.GetAll();
                ICollection<StudentVM> resultData =
                    students.Adapt<ICollection<StudentVM>>();
                return new ResponseData()
                {
                    IsSuccess = true,
                    Data = resultData,
                    Message = $"{resultData.Count} adet öğrenci vardır."
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public ResponseData UpdateStudent(int studentId, string newName, string newSurname)
        {
            try
            {
                if (studentId > 0)
                {
                    var student = _unitOfWork.StudentRepo.GetById(studentId);
                    if (student == null)
                    {
                        throw new Exception("HATA: Öğrenci bulunamadı!");
                    }
                    student.Name = newName;
                    student.Surname = newSurname;
                    bool result = _unitOfWork.StudentRepo.Update(student); // burayı düzelticez
                    if (result)
                    {
                        return new ResponseData() { IsSuccess = true, Message = "Öğrenci güncellendi." };
                    }
                    else
                    {
                        return new ResponseData() { IsSuccess = false, Message = "HATA: Öğrenci güncelleme yapılırken beklenmedik bir hata oluştu!" };
                    }
                }
                else
                {
                    throw new Exception("HATA: StudentId sıfırdan büyük olmalıdır!");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
