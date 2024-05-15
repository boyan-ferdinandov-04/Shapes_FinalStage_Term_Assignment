using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes_Paint
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
            
        }

        public void DisplayDetails(string details)
        {
            textBox1.Text = details;
        }
    }
}
