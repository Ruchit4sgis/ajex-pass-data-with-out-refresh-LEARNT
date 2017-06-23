using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace async_learn.Models
{
    public class Student_detail
    {
        public int id { get; set; }
        public string MemberId { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
        public string house { get; set; }

    }
    public class employee_details
    {
        public int id { get; set; }
        public string MemberId { get; set; }
        public string Name { get; set; }
        public string salary { get; set; }
        public string expirence { get; set; }
    }
    public class allmodel
    {
        
        public IEnumerable<employee_details> ed { get; set; }
        public IEnumerable<Student_detail>  sd { get; set; }
    }
}