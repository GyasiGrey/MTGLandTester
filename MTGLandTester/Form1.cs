using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGLandTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            LandTester lt = new LandTester();
            OutputText.Text = lt.TestLands(int.Parse(NumberBasics.Text), int.Parse(NumberNonBasics.Text), int.Parse(NumberSpells.Text), int.Parse(HandSize.Text), int.Parse(NumberOfDraws.Text));
        }
    }
}
