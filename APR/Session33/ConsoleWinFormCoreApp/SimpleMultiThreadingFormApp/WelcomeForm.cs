using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleWinFormCoreDotNetFraApp
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
            button.Click += GodListener;
            button.Click += DevilListener;

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
