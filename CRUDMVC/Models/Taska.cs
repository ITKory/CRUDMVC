using System;
using System.Collections.Generic;

#nullable disable

namespace CRUDMVC.Models
{
    public partial class Taska
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
    }
}
