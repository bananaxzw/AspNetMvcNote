using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    public interface ILogger
    {
        void Write(string message);
    }
    public class FlatFileLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(String.Format("Message:{0}", message));
            Console.WriteLine("Target:FlatFile");
        }
    }
    class IocTester
    {
        private ILogger _logger;
        public IocTester(ILogger logger)
        {
            _logger = logger;
        }

        public void Test()
        {
            _logger.Write("Bruce Say: Hello Ninject!");
        }
    }
    class Program
    {
        private static Ninject.IKernel kernel = new Ninject.StandardKernel(new MyModule());
        static void Main(string[] args)
        {
            IocTester tester = new IocTester(kernel.GetService(typeof(ILogger)) as ILogger);

            tester.Test();
            Console.WriteLine("continues..");

            IocTester test2 = kernel.GetService(typeof(IocTester)) as IocTester;
            test2.Test();
            Console.Read();
        }
    }
    internal class MyModule :Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<FlatFileLogger>();
      
        }
    }
}
