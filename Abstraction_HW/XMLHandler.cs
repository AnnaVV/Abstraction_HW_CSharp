using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_HW
{
    class XMLHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("opening xml file");
        }
        public override void Create()
        {
            Console.WriteLine("creating xml file");
        }
        public override void Change()
        {
            Console.WriteLine("changing xml file");
        }
        public override void Save()
        {
            Console.WriteLine("saving xml file");
        }

        
    }
}
