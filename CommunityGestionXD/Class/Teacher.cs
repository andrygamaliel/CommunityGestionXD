using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityGestionXD.Class
{
    public class Teacher : Employee
    {
        public string Subject { get; set; }

        public void Teach()
        {
            Console.WriteLine($"{Name} teachesss {Subject}.");
        }
    }
}
