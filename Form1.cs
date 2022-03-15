using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPWG {
    public partial class RPWG : Form {
        //RPWG v1.0
        public RPWG() {
            InitializeComponent();            
        }
        private void button1_Click(object sender, EventArgs e) {
            textBox1.Text = Program.RandGen();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (!(textBox1.Text == "")) {
                Clipboard.SetText(textBox1.Text);
            } 
        }
    }
}

