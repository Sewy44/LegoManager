using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LegoManager.Controllers;

namespace LegoManager
{
    class Program
    {
        static void Main(string[] args)
        {
            LegoControllers manager = new LegoControllers();
            manager.Run();
        }
    }
}
