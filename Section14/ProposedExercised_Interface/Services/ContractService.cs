using System;
using ProposedExercised_Interface.Entities;
using System.Text;

namespace ProposedExercised_Interface.Services
{
    class ContractService
    {

        private ITaxService taxService;

        public ContractService(ITaxService taxService)
        {
            this.taxService = taxService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.ContractTotalValue / months;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.ContractDate.AddMonths(i);
                double updatedQuota = basicQuota + taxService.Interest(basicQuota, i);
                double fullQuota = updatedQuota + taxService.Tax(updatedQuota);
                contract.AddInstallments(new Installment(date, fullQuota));

            }
        }
    }
}
