using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nine
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}