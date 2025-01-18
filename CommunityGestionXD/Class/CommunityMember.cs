using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityGestionXD.Class
{
    public class CommunityMember
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Agee: {Age}");
        }
    }
}
