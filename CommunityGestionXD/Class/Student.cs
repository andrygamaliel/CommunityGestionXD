using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityGestionXD.Class
{
    public class Student : CommunityMember
    {
        public string Grade { get; set; }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying in grade: {Grade}.");
        }
    }
}
