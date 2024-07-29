using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class StudentViewModel
    {
        public Student Student { get; set; }
        public List<Standard> Standards { get; set; }
    }
}