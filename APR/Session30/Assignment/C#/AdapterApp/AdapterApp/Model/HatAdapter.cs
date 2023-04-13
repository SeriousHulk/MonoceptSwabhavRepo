using FancyItemCoreLib;

namespace AdapterApp.Model
{
    public class HatAdapter : Item
    {
        private Hat hat;

        public HatAdapter(Hat hat)
        {
            this.hat = hat;
        }

        public string Name => hat.GetLongName();

        public double Price => hat.GetPrice();
    }
}
