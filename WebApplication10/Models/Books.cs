using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class Books
    {

        public int Id { get; set; }

        public string BookName { get; set; }
        public string Author { get; set; }


        public DateTime? PublishedYear { get; set; }
    }
}
