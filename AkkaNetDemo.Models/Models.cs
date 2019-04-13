using System;
using System.Collections.Generic;
using System.Text;

namespace AkkaNetDemo.Models
{
    public enum Status
    {
        New = 0,
        InProcess=1,
        Completed=2,
        Failed=3,
        Cancelled=4
    }

    public enum FinancialTransactionType
    {
        Deposit = 0,
        Withdrawal = 1,
        Inquiry = 2
    }

    public struct FinancialTransactionRequest
    {
        public string AccountID { get; set; }
        public FinancialTransaction Transaction { get; set; } 
    }

    public struct FinancialTransactionResponse
    {
        public string AccountID { get; set; }
        public FinancialTransaction Transaction { get; set; }
    }

    public struct FinancialTransaction
    {
        public string ID { get; set; }
        public decimal Amount { get; set; }
        public FinancialTransactionType Type { get; set; }


    }

}
