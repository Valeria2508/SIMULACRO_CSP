using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_c_Sharp.Models
{
    public class Customer : User
    {
        public string MembershipLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }

        public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phone, string address, string membershipLevel, string preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phone, address)
        {
            MembershipLevel = membershipLevel.ToLower();
            PreferredPaymentMethod = preferredPaymentMethod.ToLower();
        }

        public override void ShowDetailsPublic()
        {
            base.ShowDetailsPublic();
            Console.WriteLine($@"
            MembershipLevel: {MembershipLevel}
            PreferredPaymentMethod: {PreferredPaymentMethod}");
            Console.WriteLine("---------------End Details---------------");
        }

        public void UpdateMembershipLevel(){
            Console.WriteLine("Please write your new membership level");
            var newMembershipLevel = Console.ReadLine().ToLower();
            MembershipLevel = newMembershipLevel;
            Console.WriteLine($"Your new membership level is: {MembershipLevel}");
        }
    }
}