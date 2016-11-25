using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsAgainstHumanity
{
    public partial class Form1 : Form
    {
        private List<Player> players = new List<Player>();

        const int MIN_PLAYERS = 3;
        const int MAX_PLAYERS = 8;

        public Form1()
        {
            InitializeComponent();

        }

        private void sendButton_Click(object sender, EventArgs e)
        {

        }



    }
}
