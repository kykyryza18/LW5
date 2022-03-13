using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                foreach (Control k in panel1.Controls)
                    panel1.Controls.Remove(k);
            }
            Random r1 = new Random();
            for (int j = 0; j <= 2; j++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    int x = r1.Next(20, 50);
                    int y = r1.Next(20, 50);
                    int k = r1.Next(1, 6);
                    switch (k)
                    {
                        case 1:
                            Button a = new Button();
                            a.Parent = panel1;
                            a.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            a.Size = new Size(x, y); break;
                        case 2:
                            Label b = new Label();
                            b.Parent = panel1;
                            b.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            b.Text = "label"; break;
                        case 3:
                            TextBox c = new TextBox();
                            c.Parent = panel1;
                            c.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            c.Size = new Size(x, y); break;
                        case 4:
                            CheckBox d = new CheckBox();
                            d.Parent = panel1;
                            d.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            d.Text = "*"; break;
                        case 5:
                            RadioButton f = new RadioButton();
                            f.Parent = panel1;
                            f.Location = new Point(40 + 200 * j, 40 + 100 * i);
                            f.Text = "#"; break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int f = 0;
            foreach (Control k in panel1.Controls)
            {
                if (k is Button)
                    a++;
                if (k is Label)
                    b++;
                if (k is TextBox)
                    c++;
                if (k is CheckBox)
                    d++;
                if (k is RadioButton)
                    f++;
            }
            textBox1.Text = " Button: " + a.ToString() + Environment.NewLine + " Label: " + b.ToString() + Environment.NewLine + " TextBox: " + c.ToString() + Environment.NewLine + " CheckBox: " + d.ToString() + Environment.NewLine + " RadioButton: " + f.ToString() + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
