using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeaPulss.Models.API
{
    public class PostStudentApplicationsRequest
    {
        public string stu_name { get; set; }
        public string mail { get; set; }
        public string posistion { get; set; }
        public string about { get; set; }
        public string reason { get; set; }
    }
}
