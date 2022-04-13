using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles
{
    public interface ICanRun
    {
        public int RunSpeed { get; set; }

        public void Run();
    }
}
