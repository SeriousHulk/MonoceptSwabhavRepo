using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows;

namespace SimpleMultiThreadingFormApp
{
    public class WelcomeForm :Form
    {
        public WelcomeForm() 
        {
            this.Text = "Vikrant's Form";
            this.Height = 500;
            this.Width = 500;
            Button button = new Button();
            button.Text = "Click";
            button.Click += ((sender, EventArgs) =>
            {
                MessageBox.Show("Hello There");
            });
            Button btnPrint = new Button();
            btnPrint.Text = "Print Inf";
            btnPrint.Location = new System.Drawing.Point(220,0);

            this.Controls.Add(button);
        }

        public void DevilListener(object s, EventArgs e)
        {
            Console.WriteLine("Devil is Listening");
        }

        public void GodListener(object s, EventArgs e)
        {
            Console.WriteLine("God is Listening");
        }
    }
}
