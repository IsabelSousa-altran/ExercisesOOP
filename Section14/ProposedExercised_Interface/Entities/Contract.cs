using System;
using System.Collections.Generic;
using System.Text;

namespace ProposedExercised_Interface.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime ContractDate { get; set; }
        public double ContractTotalValue { get; set; }
        
        public List<Installment> Installments { get; set; }

        public Contract(int contractNumber, DateTime contractDate, double contractTotalValue)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractTotalValue = contractTotalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallments(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
