using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositorypattrenwithUOW.Core.Models
{
    public class ApiResponse
    {
        public object Data { get; set; }  
        public object Erorrs { get; set; }  
        public string StatusCode { get; set; }  

    }
}
