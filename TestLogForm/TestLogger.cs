using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLogForm
{
    class TestLogger
    {
        static int counter = 0;
        System.Timers.Timer t = new System.Timers.Timer(100);
        public string Name;
        public TestLogger(string name)
        {
            Name = name;
            t.Elapsed += T_Elapsed;
            t.Start();
        }
        private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            counter++;
            RecordDebug.Print(Name+counter.ToString());
        }
    }
}
