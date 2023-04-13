using LSPBirdsSolutionApp.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPBirdsSolutionApp.Model
{
    internal class Crow : Bird
    {
        public Crow(string name) : base(name)
        {
            SetName(name);
        }
        PrintToConsole p = new PrintToConsole();
        public override void SetName(string name) { _name = name; }
        public override void Fly(Bird bird)
        {
            p.PrintAction(bird);
        }
    }
}
