using System;
using System.Security.Cryptography;

namespace PRTest
{
    static class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var md5 = MD5.Create();
        }
    }

    class Foo
    {
        public void SomeMethod()
        {
            try
            {
                var emptyArray = new int[0];

                DoSomeStuff();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void DoSomeStuff()
        {
            throw new NotImplementedException();
        }
    }
}
