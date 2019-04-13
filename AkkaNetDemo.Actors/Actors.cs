using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;
using AkkaNetDemo.Models;

namespace AkkaNetDemo.Actors
{
    public class FinancialTransactionProcessorActor : ReceiveActor
    {
        public FinancialTransactionProcessorActor()
        {
            Receive<FinancialTransactionRequest>
                (t => Console.Write($"Here's a request for{t.AccountID} !"));
            Receive<FinancialTransactionResponse>
            (t => Console.Write($"Here's a response for{t.AccountID} !"));
        }
    }
}
