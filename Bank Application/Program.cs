using System;
using System.Threading;

namespace Bank_Application
{
    public delegate void Withdrawamount(double withdraw);
    
    class Program
    {
        public double balance = 500000;

        double totalsum;

        //public double Balance { get => balance; set => balance = value; }

       
        
       
       // Action<double, double> withdraws = (x, y) => x + y;
        
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter Your Choice");

                Console.WriteLine("1.Withdraw" + "\n" + "2.Customer Details" + "\n" + "3.Deposite" + "\n" + "4.CheckBalance");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                //withdraw function using Events
                    Program w = new Program();
                    Console.WriteLine("Enter WithDraw Amount");
                    double Withdraw = Convert.ToDouble(Console.ReadLine());
                    w.ProcessCompleted(Withdraw);
                }
                //CustomerDetails Using Generics
                if (n == 2)
                {
                    CustomerDetails<int> Id = new CustomerDetails<int>(1);
                    Id.Display();
                    CustomerDetails<string> Firstname = new CustomerDetails<string>("Jhon");
                    Firstname.Display();
                    CustomerDetails<string> Lastname = new CustomerDetails<string>("Jack");
                    Lastname.Display();
                    CustomerDetails<int> age = new CustomerDetails<int>(22);
                    age.Display();
                    CustomerDetails<string> email = new CustomerDetails<string>("Jhon@gmail.com");
                    email.Display();

                }
                //Deposite Using Linq
                if (n == 3)
                {
                    
                    Console.WriteLine("Enter Deposite Amount");
                    double deposite = Convert.ToDouble(Console.ReadLine());

                    if (deposite>=0)
                    {
                        Program p = new Program();
                        Func<double, double, double> Depositeamount = (x, y) => x + y;
                        Console.WriteLine(Depositeamount(deposite, p.balance));
                    }

                }
               // TotalBalance Balance by Delegates
                if (n == 4)
                {
                    Program p = new Program();
                    TotalBalance t = new TotalBalance();
                    t.TotalBalancess(p.balance);
                }
                else
                    Environment.Exit(0);


            }
        
        public event Withdrawamount ProcessCompleted;
        public Program()   
        {
            ProcessCompleted += new Withdrawamount(this.withdrawvalue);
        }
        public void withdrawvalue(double amount)
        {

            if (amount >= 0 && balance >= amount)
            {
            this.totalsum = (balance - amount);
                StartProcess();
            }
        }
        public void StartProcess()
        {


            Console.WriteLine("Transaction Is Processing...");
            Thread.Sleep(1000);
            TransactionCompleted();
        }

        public void TransactionCompleted()
        {
            Console.WriteLine("Transaction Completed Successfully");
            Console.WriteLine("Remaining Balance is" + totalsum);
        }

    }
}
