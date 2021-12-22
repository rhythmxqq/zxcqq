using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace osu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private SoundPlayer sp;
        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Resource1.chel);
            player.Play();
            if (textBox1.Text == string.Empty)
            {
                
                MessageBox.Show("Введите никнейм");
                return;
            }
           
            Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
