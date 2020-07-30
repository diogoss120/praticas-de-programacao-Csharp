using InterfaceExercicio.Entyties;
using System;

namespace InterfaceExercicio.Services
{
    class ContractService
    {
        public void ProcesContract(Contract contract, int months)
        {
            PaypalService paypalService = new PaypalService();
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date;
                double parcela = contract.TotalValue / months;
                double jurosDoMes = paypalService.Interest(parcela, i);
                double jurosFixo = paypalService.PaymentFee(jurosDoMes);
                contract.Instaments.Add(new Instaments(date.AddMonths(i), jurosFixo));
            }
        }
    }
}
