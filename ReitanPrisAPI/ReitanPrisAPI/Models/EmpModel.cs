using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReitanPrisAPI.Models
{
    public class EmpModel
    {
        public EmpModel(int empId, string name, string city)
        {
            EmpId = empId;
            Name = name;
            City = city;
        }

        public int EmpId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}