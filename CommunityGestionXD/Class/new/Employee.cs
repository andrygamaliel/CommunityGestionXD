using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityGestionXD.Class
{
    public class Employee : CommunityMember
    {
        public string JobTitle { get; set; }

        public void Work()
        {
            Console.WriteLine($"{Name} is workinj as a {JobTitle}.");
        }
    }
}
