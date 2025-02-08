using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityGestionXD.Class
{
    public class Administrative : Employee
    {
        public string Department { get; set; }

        public void Manage()
        {
            Console.WriteLine($"{Name} manages the {Department} department.");
        }
    }
}
