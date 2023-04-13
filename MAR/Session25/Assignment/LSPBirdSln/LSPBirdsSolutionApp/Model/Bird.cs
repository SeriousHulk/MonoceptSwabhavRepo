namespace LSPBirdsSolutionApp.Model
{
    public abstract class Bird
    {
        protected string _name;

        protected Bird(string name)
        {
            _name = name;
        }
        public virtual void SetName(string name) {
            _name = name;
        }
        internal object GetName()
        {
            return _name;
        }
    }
}
