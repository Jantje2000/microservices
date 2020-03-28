using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.AddLoan.Model
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Writer { get; set; }

        public string Language { get; set; }
        public int Edition { get; set; }

        public int Pages { get; set; }

        public bool Illustrations { get; set; }

        public string ISBN { get; set; }
    }
}
