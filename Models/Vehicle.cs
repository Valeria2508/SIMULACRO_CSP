using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_c_Sharp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string EngineNumber { get; set; }
        public string SerialNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public Driver Owner { get; set; }

        public Vehicle(int id, string placa, string tipo, string engineNumber, string serialNumber, byte peopleCapacity, Driver owner)
        {
            Id = id;
            Placa = placa;
            Tipo = tipo;
            EngineNumber = engineNumber;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;
            Owner = owner;
        }

        public void DeleteVehiculo(int id, List<Vehicle> vehiclesList){
            var vehicleToDelete = vehiclesList.Find(vehicle => vehicle.Id == id);
            if(vehicleToDelete != null){
                vehiclesList.Remove(vehicleToDelete);
                Console.WriteLine("Vehicle deleted successfully");
            }else{
                Console.WriteLine("Vehicle not found");
            }
        }

    }
}