using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArmyBenchTest
{
    // Written by blokeley (see http://stewartr.blogspot.com/2006/09/debugging-nunit-in-visual-studio.html)
    class NUnitConsoleRunner
    {
        [STAThread]
        static void Main(string[] args)
        {
            NUnit.ConsoleRunner.Runner.Main(args);
        }
    }
}
