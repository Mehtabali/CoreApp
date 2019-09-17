using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApplication.Core
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public Cusine Cusine { get; set; }
    }

}
