using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ten
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Type { get; set; }

        public override string ToString()
        {
            return Id + "," + Name + "," + IdentityNumber + "," + PhoneNumber + "," + Email + "," + Type;
        }
    }
}