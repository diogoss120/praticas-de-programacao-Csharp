using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExercicio.Entyties;

namespace InterfaceExercicio.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double amount, int month)
        {
            return amount + ((amount * 0.01) * month);
            //metodo para calcular os juros
        }

        public double PaymentFee(double amount)
        {
            return amount * 1.02;
            //metodo para calcular a taxa mensal
        }
    }
}
