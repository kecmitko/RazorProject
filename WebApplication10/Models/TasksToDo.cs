using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class TasksToDo
    {
        public int RedenBroj { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsFinished { get; set; }

        public int?  NumberOfHours { get; set; }



    }



    public class Both
    {
        public Person Person { get; set; }
        public Address Address { get; set; }
    }
      
    public class Person
    {
        public string Name { get; set; }
    }


    public class Address
    {
        public string State { get; set; }
    }
}
