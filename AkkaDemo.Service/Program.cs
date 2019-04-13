using System;
using AkkaNetDemo.Models;
using Akka.Actor;
using AkkaNetDemo.Actors;

namespace AkkaDemo.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Actor System...");
            var actorSystem = ActorSystem.Create("AkkaNetDemo");
            var actorRef = actorSystem.ActorOf<FinancialTransactionProcessorActor>("Actor_1");

            Console.WriteLine("Actor System started...");
            actorRef.Tell(new FinancialTransactionRequest() { AccountID = "MadDog19" });
            Console.ReadKey();
        }
    }
}
