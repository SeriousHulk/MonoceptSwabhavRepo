namespace HumanUnitTestApp.Model
{
    [Serializable]
    public class Human
    {
        private string _name;
        private int _age;
        private float _weight;
        private float _height;
        private Gender _gender;
        public Human(string name, int age, float weight, float height,Gender gender)
        {
            _name = name;
            _age = ValidateAge(age);
            _weight = ValidateWeight(weight);
            _height = ValidateHeight(height);
            _gender = gender;
        }
        public Human()
        {
        }
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return ValidateAge(_age); } set { _age = value; } }
        public float Weight { get { return ValidateWeight(_weight); } set { _weight = value; } }
        public float Height { get { return ValidateHeight(_height); } set { _height = value; } }
        public Gender Gender { get { return _gender; } set { _gender = value; } }
        public int ValidateAge(int age)
        {
            if (age == 0)
                throw new Exception("Age Cannot be Zero");
            else if (age < 0)
                throw new Exception("Age Cannot be Negative");
            return age;
        }
        public float ValidateWeight(float weight)
        {
            if (weight == 0)
                throw new Exception("Age Cannot be Zero");
            else if (weight < 0)
                throw new Exception("Age Cannot be Negative");
            return weight;
        }
        public float ValidateHeight(float height)
        {
            if (height == 0)
                throw new Exception("Age Cannot be Zero");
            else if (height < 0)
                throw new Exception("Age Cannot be Negative");
            return height;
        }
        public void Workout() => Weight -= .05f * Weight;
        public void Eat()
        {
            Height += .02f * Height;
            Weight += .01f * Weight;
        }
        public float CalculateBMI()
        {
            float heightInMeters = Height / 100f;
            float bodyMassIndex = Weight / (heightInMeters * heightInMeters);
            return bodyMassIndex;
        }
    }
}