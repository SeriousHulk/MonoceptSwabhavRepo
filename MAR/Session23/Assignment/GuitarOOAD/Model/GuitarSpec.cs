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
        private Builder _builder;
        private string _model;
        private GuitarType _type;
        private Wood _backWood;
        private Wood _topWood;
        private int _numStrings;

        public GuitarSpec(Builder builder, string model, GuitarType type, Wood backWood, Wood topWood, int numStrings)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _backWood = backWood;
            _topWood = topWood;
            _numStrings = numStrings;
        }

        public GuitarSpec()
        {
        }

        public Builder GetBuilder() {  return _builder;  }
        public Builder Builder(Builder builder) { return _builder = builder; }
        public string GetModel() { return _model; }
        public void Model(string model) { _model = model; }
        public GuitarType GetType() { return _type; }
        public void Type(GuitarType type) { _type = type; }
        public Wood GetBackWood() { return _backWood; }
        public void BackWood(Wood backWood) { _backWood = backWood; }
        public Wood GetTopWood() { return _topWood; }
        public void TopWood(Wood topWood) { _topWood = topWood; }
        public int GetNumStrings() { return _numStrings; }
        public void NumStrings(int numStrings) { _numStrings = numStrings; }
        public bool MatchesSpec(GuitarSpec otherSpec)
        {
            if (_builder != otherSpec._builder)
                return false;
            if ((_model != null) && (!_model.Equals("")) &&
                (!_model.Equals(otherSpec._model)))
                return false;
            if (_type != otherSpec._type)
                return false;
            if (_numStrings != otherSpec._numStrings)
                return false;
            if (_backWood != otherSpec._backWood)
                return false;
            if (_topWood != otherSpec._topWood)
                return false;
            return true;
        }
    }
}
