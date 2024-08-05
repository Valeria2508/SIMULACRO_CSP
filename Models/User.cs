using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_c_Sharp.Models
{
    public class User
    {
        protected Guid Id { get; set; }
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string TypeDocument { get; set; }
        protected string IdentificationNumber { get; set; }
        protected DateOnly BirthDate { get; set; }
        protected string Email { get; set; }
        protected string Phone { get; set; }
        protected string Address { get; set; }

        protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phone, string address)
        {
            Id = Guid.NewGuid();
            Name = name.ToLower();
            LastName = lastName.ToLower();
            TypeDocument = typeDocument;
            IdentificationNumber = identificationNumber;
            BirthDate = birthDate;
            Email = email;
            Phone = phone;
            Address = address;            
        }

        protected void ShowDetails(){
            Console.WriteLine("-----------Information Details-----------");
            Console.WriteLine($@"
            Name: {Name} LastName: {LastName} 
            TypeDocument: {TypeDocument} IdentificationNumber: {IdentificationNumber}
            BirthDate: {BirthDate}
            Email: {Email}
            Phone: {Phone}
            Address: {Address}");
        }

        public virtual void ShowDetailsPublic(){
            ShowDetails();
        }

        protected int CalculateAge(){
            return DateTime.Now.Year - BirthDate.Year;
        }

        protected void ShowAge(){
            Console.WriteLine($"Age: {CalculateAge()}");
        }

    }
}