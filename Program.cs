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
        public void SomeMethod() { }
    }
}
