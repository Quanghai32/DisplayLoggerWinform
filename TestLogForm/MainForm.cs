using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestLogForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            RecordDebug.SetLoggerForm(ucLogger);
        }

        TestLogger t1 = new TestLogger("Thread 1: ");
        TestLogger t2 = new TestLogger("Thread 2: ");

    }
}
