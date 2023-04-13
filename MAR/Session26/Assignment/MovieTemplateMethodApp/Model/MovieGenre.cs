using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTemplateMethodApp.Model
{
    public abstract class MovieGenre
    {
        public void PrintMovieGenre()
        {
            Console.WriteLine("Comedy");
            OtherGenre();
        }
        protected abstract void OtherGenre();
    }
}
