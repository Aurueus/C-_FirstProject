using System.Data.Common;

namespace Test_Project
{
    public class Programm
    {
        public static void loginAuthentication(String username, String password)
        {
            string correctUsername = "admin";
            string correctPassword = "12345";

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("Invalid credentials!");
            }
        }

        public static void gradeCalculator(int score)
        {
            if (score >= 90)
            {
                Console.WriteLine("Grade: A+");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Grade: A");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Grade: B");
            }
            else
            {
                Console.WriteLine("Grade: C");
            }
        }

        public static void calculateDiscount(int amount)
        {
            double newAmount = 0;
            if (amount > 1000)
            {
                System.Console.WriteLine("The discount is 10%");
                newAmount = amount * 0.9;
                System.Console.WriteLine("The full price after discount is: " + newAmount);
            }
            else
            {
                System.Console.WriteLine("The discount is 5%");
                newAmount = amount * 0.95;
                System.Console.WriteLine("The full price after discount is: " + newAmount);
            }
        }

        public static void numberToDay(byte day)
        {
            int remains = day % 7;
            if (remains == 1)
            {
                System.Console.WriteLine("Monday");
            }
            else if (remains == 2)
            {
                System.Console.WriteLine("Tuesday");
            }
            else if (remains == 3)
            {
                System.Console.WriteLine("Wednsday");
            }
            else if (remains == 4)
            {
                System.Console.WriteLine("Thursday");
            }
            else if (remains == 5)
            {
                System.Console.WriteLine("Friday");
            }
            else if (remains == 6)
            {
                System.Console.WriteLine("Saturday");
            } else
            {
                System.Console.WriteLine("Sunday");
            }
        }

        public static void trafficLightSystem(string color)
        {
            if (color.Equals("Red"))
            {
                System.Console.WriteLine("STOP!!!!");
            }
            else if (color.Equals("Yellow"))
            {
                System.Console.WriteLine("Get Ready!");
            }
            else if (color.Equals("Green"))
            {
                System.Console.WriteLine("GO!");
            }
            else
            {
                System.Console.WriteLine("Wrong color! Enter Only Red, Yellow or Green!");
            }
        }

        public static void withdrawSimulator(int balance, int withdraw) {
            if (withdraw < 0)
            {
                System.Console.WriteLine("Invalid withdrawal amount");
            }
            else if (withdraw > balance)
            {
                System.Console.WriteLine("Insufficient balance");
            }
            else
            {
                System.Console.WriteLine("Withdrawal successful! Remaining balance: ..." + (balance-withdraw));
            }
        }

        public static void resultCalculator(int grade)
        {
            if (grade >= 50)
            {
                System.Console.WriteLine("Pass!");
            }
            else
            {
                System.Console.WriteLine("Fail!");
            }
        }

        public static void superCalculator(double a, double b, char op)
        {
            if (op.Equals('+'))
            {
                System.Console.WriteLine(a + b);
            }
            else if (op.Equals('-'))
            {
                System.Console.WriteLine(a - b);
            }
            else if (op.Equals('*'))
            {
                System.Console.WriteLine(a * b);
            }
            else if (op.Equals('/'))
            {
                if (b == 0)
                {
                    System.Console.WriteLine("Error: Division by zero");
                }
                else
                {
                    System.Console.WriteLine(a / b);
                }
            }
            else
            {
                System.Console.WriteLine("Invalid Operation! Enter '+', '-', '*' or '/'");
            }
        }

        public static void cescoSimulator(byte age)
        {
            if (age < 0)
            {
                System.Console.WriteLine("Invalid age");
            }
            else if (age >= 18)
            {
                System.Console.WriteLine("Eligible to vote");
            }
            else
            {
                System.Console.WriteLine("Not eligible to vote");
            }
        }

        public static void bonusCalculator(string role, double salary)
        {
            double bonus = 0;
            if (role.Equals("Manager"))
            {
                if (salary > 2500)
                {
                    bonus = 2500 * 0.15;
                }
                else
                {
                    bonus = salary * 0.1;
                }
            }
            else if (role.Equals("Developer"))
            {
                if (salary > 2000)
                {
                    bonus = salary * 0.12;
                }
                else
                {
                    bonus = salary * 0.08;
                }
            }
            else
            {
                bonus = salary * 0.05;
            }
            Console.WriteLine($"Role: {role}, Salary: {salary}, Bonus: {bonus}");
        }

        public static void Main(String[] args)
        {
            //(Login Authentication)
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            loginAuthentication(username, password);

            //(Grade Calculator)
            System.Console.WriteLine("Enter your grade: ");
            int score = int.Parse(Console.ReadLine());

            gradeCalculator(score);

            //(Discount Calculation)
            System.Console.WriteLine("Enter amount: ");
            int amount = int.Parse(Console.ReadLine());

            calculateDiscount(amount);

            //(Day of the Week)
            System.Console.WriteLine("Enter number to convert it to the day");
            byte day = byte.Parse(Console.ReadLine());
            numberToDay(day);

            //Traffic Light System
            System.Console.WriteLine("Enter traffic light color: ");
            string color = Console.ReadLine();
            trafficLightSystem(color);

            //(ATM Withdrawal Validation)
            System.Console.WriteLine("Enter your balance and withdraw amount");
            System.Console.WriteLine("Enter your balance: ");
            int balance = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter withdraw amount: ");
            int withdraw = int.Parse(Console.ReadLine());
            withdrawSimulator(balance, withdraw);

            //(Pass/Fail Result)
            System.Console.WriteLine("Enter your score: ");
            int grade = int.Parse(Console.ReadLine());
            resultCalculator(grade);

            //(Calculator Program)
            System.Console.WriteLine("Enter first and second numbers: ");
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter operation. '+', '-', '*' or '/'");
            char op = Console.ReadLine()[0];
            superCalculator(a, b, op);

            //(Voting Eligibility)
            System.Console.WriteLine("Enter your age: ");
            byte age = byte.Parse(Console.ReadLine());
            cescoSimulator(age);

            //(Employee Bonus Calculation)
            System.Console.WriteLine("Enter your role: ");
            string role = Console.ReadLine();
            System.Console.WriteLine("Enter your salary: ");
            double salary = double.Parse(Console.ReadLine());
            bonusCalculator(role, salary);
        }
    }
}