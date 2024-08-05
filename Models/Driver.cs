using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_c_Sharp.Models
{
    public class Driver : User
    {
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }
        public List<Vehicle> VehicleList { get; set; }
        public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phone, string address, string licenseNumber, string licenseCategory, int drivingExperience) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phone, address)
        {
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperience;
        }

        public override void ShowDetailsPublic()
        {
            base.ShowDetailsPublic();
            Console.WriteLine($@"
            LicenseNumber: {LicenseNumber}
            LicenseCategory: {LicenseCategory}
            DrivingExperience: {DrivingExperience}");
            Console.WriteLine("---------------End Details---------------");
        }

        public void UpdateLicenseCategory(string newLicenseCategory){
            LicenseCategory = newLicenseCategory;
            Console.WriteLine($"Your new license category is: {LicenseCategory}");
        }

        public void AddExperience(int years){
            DrivingExperience += years;
            Console.WriteLine($"Your driving experience is: {DrivingExperience}");
        }
    }
}