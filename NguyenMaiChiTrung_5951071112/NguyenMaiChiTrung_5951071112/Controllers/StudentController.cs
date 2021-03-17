using NguyenMaiChiTrung_5951071112.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenMaiChiTrung_5951071112.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentInfo> Get()
        {
            yield return new StudentInfo
            {
                Name = "Nguyen Mai Chi Trung",
                Age = 20
            };
            ;
        }
    }
}
