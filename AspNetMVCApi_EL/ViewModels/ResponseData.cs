using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVCApi_EL.ViewModels
{
   public class ResponseData
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public object Data { get; set; }
        public DateTime ResponseTime { get; set; } = DateTime.Now;

    }
}
