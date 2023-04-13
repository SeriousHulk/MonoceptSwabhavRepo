using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class GuitarSpecBuilder
    {
        private Dictionary<string, object> properties = new Dictionary<string, object>();
        public Dictionary<string, object> GetProperties()
        {
            return properties;
        }
        public GuitarSpecBuilder Builder(Builder builder)
        {
            properties["builder"] = builder;
            return this;
        }
        public GuitarSpecBuilder Model(string model)
        {
            properties["model"] = model;
            return this;
        }
        public GuitarSpecBuilder Type(GuitarType type)
        {
            properties["type"] = type;
            return this;
        }
        public GuitarSpecBuilder BackWood(Wood backWood)
        {
            properties["backWood"] = backWood;
            return this;
        }
        public GuitarSpecBuilder TopWood(Wood topWood)
        {
            properties["topWood"] = topWood;
            return this;
        }
        public GuitarSpecBuilder NumStrings(int numStrings)
        {
            properties["numStrings"] = numStrings;
            return this;
        }
        public GuitarSpec Build()
        {
            return new GuitarSpec(this);
        }

    }
}
