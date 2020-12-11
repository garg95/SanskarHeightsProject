using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SanskarHeights.Models
{
    public class StandardModel
    {
        public string Standard { get; set; }
        public List<SelectListItem> standards { get; set; }
        public List<Student> students { get; set; }
    }
}