using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public partial class Todoes
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Done { get; set; }
    }
}
