using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_c_Sharp.Models
{
    public class AdminApp
    {
        public static List<Customer> CustomersList = new List<Customer>();
        public static List<Driver> DriversList =new List<Driver>();
        public static List<Vehicle> VehiclesList = new List<Vehicle>();

        public static void ShowCustomers(){
            foreach (var client in CustomersList)
            {
                client.ShowDetailsPublic();
            }
        }

        public static void ShowDrivers(){
            foreach (var driver in DriversList){
                driver.ShowDetailsPublic();
            }
        }

        public static void ExampleDrivers(){
            var driver = new Driver("camilo", "campillo", "CC","100245687", new DateOnly(1997, 08, 16),"camilo@correo.com","2354686", "street","102546", "A2", 5);
            var driver1 = new Driver("maria", "gomez", "CC", "200123456", new DateOnly(1990, 5, 20), "maria@email.com", "3219876543", "Calle 123", "4654884", "B2", 3);
            DriversList.Add(driver);
            DriversList.Add(driver1);

            var vehicle = new Vehicle(1, "ycs85d", "carro", "sdf4545sd", "55154654521", 4, driver);
            VehiclesList.Add(vehicle); 
        }
    }
}