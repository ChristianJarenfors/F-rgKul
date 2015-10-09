using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lektion10._08genomgång
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(Stopper);
            timer1.Tick += new EventHandler(Colorer);
        }

        private void Colorer(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }

        private void Stopper(object ob, System.EventArgs eventis)
        {
            
            int i = int.Parse(label3.Text);
            i += 1;
            label3.Text = i.ToString();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label2.Text == "0")
            {
                timer1.Start();
            }
            Color CLR = new Color();
                Random rand = new Random();
                Point buttonpoint = new Point(rand.Next(1, 501), rand.Next(1, 251));
                button1.Location = buttonpoint;
                button1.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                Size size = new Size(rand.Next(15, 201), rand.Next(15, 201));
                button1.Size = size;
                int r = int.Parse(label2.Text);
            


            if (int.Parse(label3.Text) < 100)
            {
                r++;
                label2.Text = r.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Du klarade " + label2.Text + " klickningar");
                label3.Text = "0";
                label2.Text = "0";
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point p = label1.Location;
            if (checkBox1.Checked)
            {
                if ((label1.Text != "Right"))
                {
                    //p.X += 100;
                    //label1.Location = p;
                    label1.Text = "Right";
                    label1.TextAlign = ContentAlignment.MiddleLeft;
                }
                else if (label1.Text == "Right")
                {
                    //p.X -= 100;
                    //label1.Location = p;
                    label1.Text = "Left";
                    label1.TextAlign = ContentAlignment.MiddleRight;
                }
            }
        }
    }
}
