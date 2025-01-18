using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityGestionXD.Class
{
    public class FormerStudent : CommunityMember
    {
        public int GraduationYear { get; set; }

        public void Remember()
        {
            Console.WriteLine($"{Name} graduated in {GraduationYear}.");
        }
    }
}
