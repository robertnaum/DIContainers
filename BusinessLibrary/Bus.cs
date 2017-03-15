using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLibrary
{
    public class Bus : IDrivable
    {
        public string Drive()
        {
            return "I'm driving a bus";
        }
    }
}
