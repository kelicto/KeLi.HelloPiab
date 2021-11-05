using System;

namespace KeLi.HelloPIAB
{
    public class AopTest : IAopTest
    {
        //[CustomAop]
        [CustomAopCallHandler("Debug")]
        public void Test(string content)
        {
            if (string.IsNullOrEmpty(content))
                throw new Exception(nameof(content));

            Console.WriteLine(content);
        }
    }
}