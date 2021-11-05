using System;
using System.Diagnostics;

using Microsoft.Practices.EnterpriseLibrary.PolicyInjection;

namespace KeLi.HelloPIAB
{
    internal class Program
    {
        private static void Main()
        {
            try
            {
                var aop = PolicyInjection.Create<AopTest, IAopTest>();

                aop.Test("Running business...");
                aop.Test(null);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }

            Console.ReadKey();
        }
    }
}