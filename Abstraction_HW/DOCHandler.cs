using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_HW
{
    class DOCHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("opening doc file");
        }
        public override void Create()
        {
            Console.WriteLine("creating doc file");
        }
        public override void Change()
        {
            Console.WriteLine("changing doc file");
        }
        public override void Save()
        {
            Console.WriteLine("saving doc file");
        }
    }
}
