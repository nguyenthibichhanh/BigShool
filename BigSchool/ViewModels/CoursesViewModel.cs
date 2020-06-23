using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bigschool.Models;

namespace bigschool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}