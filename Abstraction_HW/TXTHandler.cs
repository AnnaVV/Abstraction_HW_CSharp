using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_HW
{
    class TXTHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("opening txt file");
        }
        public override void Create()
        {
            Console.WriteLine("creating txt file");
        }
        public override void Change()
        {
            Console.WriteLine("changing txt file");
        }
        public override void Save()
        {
            Console.WriteLine("saving txt file");
        }
    }
}
