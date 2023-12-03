using System;
using FacadeLibrary.MortgageExample.Subsystem;

namespace FacadeLibrary.MortgageExample.Facade
{
    public class Mortgage
    {
        private readonly Bank bank;
        private readonly Loan loan;
        private readonly Credit credit;
        private readonly CustomerService customerService;

        public Mortgage()
        {
            bank = new Bank();
            loan = new Loan();
            credit = new Credit();
            customerService = new CustomerService();
        }

        public bool IsEligible(string customerName, decimal loanAmount)
        {
            Console.WriteLine($"The customer {customerName} wants to apply for {loanAmount:C} loan.\n");

            var customer = customerService.Find(customerName);

            if (bank.IsUntrustworthy(customer, loanAmount))
            {
                return false;
            }
            
            if (loan.HasBadLoans(customer))
            {
                return false;
            }

            if (credit.HasBadCredit(customer))
            {
                return false;
            }

            return true;
        }
    }
}