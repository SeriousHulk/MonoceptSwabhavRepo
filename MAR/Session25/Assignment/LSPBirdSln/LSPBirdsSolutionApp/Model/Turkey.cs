namespace LSPBirdsSolutionApp.Model
{
    internal class Turkey :Bird
    {
        public Turkey(string name) :base(name)
        {
            SetName(name);
        }
        public override void SetName(string name) { _name = name; }
    }
}
