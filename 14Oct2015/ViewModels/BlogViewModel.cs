using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _14Oct2015.Models;

namespace _14Oct2015.ViewModels
{
    // Simplified view of the data coming from the database
    // Contrived simple view of a summary of the db
    public class BlogViewModel
    {
        public int NumberOfBlogs { get; set; }
        public List<Blog> Blogs { get; set; }
        // end BlogViewModel
    }
}
