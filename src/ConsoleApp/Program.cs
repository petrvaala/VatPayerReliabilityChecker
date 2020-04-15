using System;
using PetrVala.VatPayerReliabilityChecker.ServiceLibrary;
using PetrVala.VatPayerReliabilityChecker.ServiceLibrary.Connected_Services.VatPayerReliabilityServiceReference;

namespace PetrVala.VatPayerReliabilityChecker.ConsoleApp
{
    internal class Program
    {
        private static void Main()
        {
            var wrapper = new ServiceFullWrapper();
            //var request = new getStatusNespolehlivyPlatceRequest { dic = new[] { "CZ27604977" } };
            //var resultTask = wrapper.GetStatusNespolehlivyPlatce(request);

            var request = new getStatusNespolehlivyPlatceRequest1 {dic = new[] {"CZ27604977"}};
            var resultTask = wrapper.GetStatusNespolehlivyPlatceRozsireny(request);

            //var request = new getSeznamNespolehlivyPlatceRequest();
            //var resultTask = wrapper.GetSeznamNespolehlivyPlatce(request);

            resultTask.Wait();

            var result = resultTask.Result;
            Console.WriteLine(result);
        }
    }
}