using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTemplateMethodApp.Model
{
    public class HorrorComedy : MovieGenre
    {
        protected override void OtherGenre()
        {
            Console.WriteLine("Horror");
        }
    }
}
