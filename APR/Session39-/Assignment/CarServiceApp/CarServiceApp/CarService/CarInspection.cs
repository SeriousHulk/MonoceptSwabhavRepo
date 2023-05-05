using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp.CarService
{
    public class CarInspection : ICarService
    {
        public decimal GetCost()
        {
            return 250;
        }
    }
}
