using CarServiceApp.CarService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceApp.Decorators
{
    public class TyreRotation : ICarService
    {
        private readonly ICarService _carService;

        public TyreRotation(ICarService carService)
        {
            _carService = carService;
        }
        public decimal GetCost()
        {
            return _carService.GetCost() + 350;
        }
    }
}
