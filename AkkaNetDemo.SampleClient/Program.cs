using System;
using Akka.Actor;
using AkkaNetDemo.Actors;
using AkkaNetDemo.Models;

namespace AkkaNetDemo.SampleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var actorSystem 
            var actorRef = actorSystem.ActorSelection("/user/Actor_1");

            FinancialTransaction financialTransaction = new FinancialTransaction() { Amount = 12.00M, ID = "MD1", Type = FinancialTransactionType.Deposit };
            FinancialTransactionRequest financialTransactionRequest = new FinancialTransactionRequest() { AccountID = "maddog19", Transaction = financialTransaction };
            actorRef.Tell(financialTransactionRequest);
        }
    }
}
