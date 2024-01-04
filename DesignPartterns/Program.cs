// See https://aka.ms/new-console-template for more information

using StructuralPatterns.AdapterBillingSystem;
using StructuralPatterns.AdapterECommerce;
using CreationalPatterns;

namespace DesignPartterns
{
    //Client 
    //The Client is Incompatible with ThirdPartyBillingSystem 
    class Program
    {
        private static void Main(string[] args)
        {
            // //Storing the Employees Data in a String Array
            // var employeesArray = new string[5, 4]
            // {
            //     {"101","John","SE","10000"},
            //     {"102","Smith","SE","20000"},
            //     {"103","Dev","SSE","30000"},
            //     {"104","Pam","SE","40000"},
            //     {"105","Sara","SSE","50000"}
            // };
            //
            // //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            // Console.WriteLine("HR system passes employee string array to Adapter\n");
            // ITarget target = new EmployeeAdapter();
            // target.ProcessCompanySalary(employeesArray);
            // var method = PaymentMethod.PayPal;
            // var paypalService = new Paypal();
            // var squareService = new Square();
            // var stripeService = new Stripe();
            //
            // var paymentProvider = new PaymentProvider(stripeService, squareService, paypalService);
            // paymentProvider.Pay(method);
            // Console.Read();

            // Thread process1 = new Thread(new ThreadStart(()=>TestSingleton("Foo")));
            // Thread process2 = new Thread(new ThreadStart(()=>TestSingleton("Bar")));
            //
            // process1.Name = "Process1";
            // process2.Name = "Process2";
            //
            // process1.Start();
            // process2.Start();
            //
            // process1.Join();
            // process1.Join();
            var semaphore = new SemaphoreTest();
            semaphore.Demo();
        }

        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}