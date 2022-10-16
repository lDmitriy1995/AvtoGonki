using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Game
    {
        public void Start()
        {
            SportCar sportCar = new SportCar() { MaxSpeed = 8, DrivenDistance = 0 };
            PassengerCar passengerCar = new PassengerCar() { MaxSpeed = 5, DrivenDistance = 0 };
            CargoCar cargoCar = new CargoCar() { MaxSpeed = 3, DrivenDistance = 0 };
            Bus bus = new Bus() { MaxSpeed = 4, DrivenDistance = 0 };

            sportCar.Finish += () =>
            {
                Console.WriteLine("Спорткар доехал до финиша!!!");

            };
            passengerCar.Finish += () =>
            {
                Console.WriteLine("Легковое авто доехало до финиша!!!");
            };
            cargoCar.Finish += () =>
            {
                Console.WriteLine("Грузовое авто доехалл до финиша!!!");
            };
            bus.Finish += () =>
            {
                Console.WriteLine("Автобус доехал до финиша!!!");
            };

            int countSec = 1;
            Console.WriteLine("seconds\t\tsportCar\tpassangerCar\tcargoCar\tbus");
            Console.WriteLine("---------------------------------------------------------------");
            while (true)
            {
                sportCar.Drive();
                passengerCar.Drive();
                cargoCar.Drive();
                bus.Drive();
                Console.WriteLine("{0}\t\t{1}m\t\t{2}m\t\t{3}m\t\t{4}m", countSec++, sportCar.DrivenDistance, passengerCar.DrivenDistance, cargoCar.DrivenDistance, bus.DrivenDistance);
                
                if (sportCar.DrivenDistance >= 100 || passengerCar.DrivenDistance >= 100 || cargoCar.DrivenDistance >= 100 || bus.DrivenDistance >= 100)
                {
                    break;
                }
            }
                
			
                
                  
            
            
        }
    }
}
