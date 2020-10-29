using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Team
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
