using AspNetMVCApi_BLL.ContractBLL;
using AspNetMVCApi_EL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AspNetMVCApi_PL.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        // GET api/<controller>
        public ResponseData GetAllStudents()
        {
            try
            {
                var result = _studentService.GetAllStudents();
                return new ResponseData() { IsSuccess = true, Data = result };
            }
            catch (Exception ex)
            {
                // ex loglanabilir
                return new ResponseData()
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }


        // GET api/<controller>/5

        // POST api/<controller>

        // PUT api/<controller>/5

        // DELETE api/<controller>/5
    }

}