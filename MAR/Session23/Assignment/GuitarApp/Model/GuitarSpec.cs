using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Model
{
    internal class GuitarSpec
    {
        private readonly Dictionary<string, object> properties;
        //Builder _builder;
        //string _model;
        //private Type _type;
        //Wood _backWood;
        //Wood _topWood;
        private GuitarSpecBuilder guitarSpecBuilder;

        //public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        //{
        //    _builder = builder;
        //    _model = model;
        //    _type = type;
        //    _backWood = backWood;
        //    _topWood = topWood;
        //}
        public GuitarSpec(Dictionary<string, object> properties)
        {
            this.properties = properties;
        }
        public GuitarSpec(GuitarSpecBuilder guitarSpecBuilder)
        {
            if (guitarSpecBuilder == null || guitarSpecBuilder.GetProperties() == null)
            {
                properties = new Dictionary<string, object>();
            }
            else
            {
                properties = guitarSpecBuilder.GetProperties();
            }
        }
        public object GetProperty(string propertyName)
        {
            if (properties.ContainsKey(propertyName))
            {
                return properties[propertyName];
            }
            else
            {
                return null;
            }
        }

        public IReadOnlyDictionary<string, object> GetProperties()
        {
            return properties;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is GuitarSpec))
            {
                return false;
            }
            GuitarSpec other = (GuitarSpec)obj;

            foreach (string propertyName in other.GetProperties().Keys)
            {
                if (!other.GetProperty(propertyName).Equals(GetProperty(propertyName)))
                {
                    return false;
                }
            }
            return true;
        }

        public override string ToString()
        {
            return properties.ToString();
        }
        //public Builder GetBuilder() { }
        //public string GetModel() { }
        //public Type GetType() { }
        //public Wood GetBackWood() { }
        //public Wood GetTopWood() { }
    }
}
