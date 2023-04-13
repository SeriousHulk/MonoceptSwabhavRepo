namespace ReflectionPOC.Model
{
    [Serializable]
    public class Movie
    {
        private string _name;
        private int _year;
        private string _directorName;

        public Movie()
        {
        }

        public Movie(string name, int year, string director)
        {
            _name = name;
            _year = year;
            _directorName = director;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public int Year { get { return _year; } set { _year = value; } }
        public string Director { get { return _directorName; } set { _directorName = value; } }
    }
}
