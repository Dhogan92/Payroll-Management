using System;

namespace PaymentCalculator
{
    class Staff
    {   // FIELDS //
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        // PUBLIC ACCESS PROPERTY WHICH RETRIEVES HOURS WORKED FOR EMPLOYEE //
        public int HoursWorked
        {
            get
            {
                return hWorked;
            }
            set 
            {
                if (value > 0) 
                {
                    hWorked = value;
                }
                else
                {
                    hWorked = 0;
                }
            }
        }
        // REUSABLE MESSAGE METHOD //
        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }
        // PAYMENT CALCULATOR //
        public int CalculatePay()
        {
            PrintMessage();
            int staffPay;
            staffPay = hWorked * hourlyRate;
            if (hWorked > 0)
            {
                return staffPay;
            }
            else
            {
                return 0;
            }
        }
        public int CalculatePay(int bonus, int allowance)
        {
            PrintMessage();
            
            if (hWorked > 0)
            {
                return hWorked * hourlyRate + bonus + allowance;
            }
            else
            {
                return 0;
            }
        }
        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
        }
        // FIRST CONSTUCTOR OF STAFF CLASS //
        public Staff (string name)
        {
            nameOfStaff = name;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("----------------");
        }
        // SECOND CONSTUCTOR OF STAFF CLASS //
        public Staff(string firstName, string lastName)
        {
            nameOfStaff = firstName + " " + lastName;
            Console.WriteLine("\n" + nameOfStaff);
            Console.WriteLine("----------------");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            int pay;
            int payTwo;

            Staff staff1 = new Staff("Peter", "Pan");
            staff1.HoursWorked = 160;
            // CALCULATES PETER'S PAY USING SECOND CALCULATEPAY METHOD //
            pay = staff1.CalculatePay(1000,400);
            Console.WriteLine("Pay = {0}", pay);

            Staff staff2 = new Staff("Lily", "Lilac");
            staff2.HoursWorked = 165;
            payTwo = staff2.CalculatePay(1000, 450);
            Console.WriteLine("Pay = {0}", payTwo);
        }

    }
}
