using System;
namespace HumanLib.Model
{
    [Serializable]
    public class Human
    {
        private string _name;
        private int _age;
        private float _weight;
        private float _height;
        public Human(string name, int age, float weight, float height)
        {
            _name = name;
            _age = age;
            _weight = weight;
            _height = height;
        }
        public Human()
        {
        }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public float Weight { get { return _weight; } set { _weight = value; } }
        public float Height { get { return _height; } set { _height = value; } }
        public void Workout() => Weight -= .05f * Weight;
        public void Eat()
        {
            Height += .02f * Height;
            Weight += .01f * Weight;
        }
    }
}