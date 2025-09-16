using System.Data.Common;

namespace Test_Project
{
    public class Programm
    {
        public static void loginAuthentication(string username, string password)
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
                Console.WriteLine("The discount is 10%");
                newAmount = amount * 0.9;
                Console.WriteLine("The full price after discount is: " + newAmount);
            }
            else
            {
                Console.WriteLine("The discount is 5%");
                newAmount = amount * 0.95;
                Console.WriteLine("The full price after discount is: " + newAmount);
            }
        }

        public static void numberToDay(byte day)
        {
            int remains = day % 7;
            if (remains == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (remains == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (remains == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (remains == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (remains == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (remains == 6)
            {
                Console.WriteLine("Saturday");
            } else
            {
                Console.WriteLine("Sunday");
            }
        }

        public static void trafficLightSystem(string color)
        {
            if (color.Equals("Red"))
            {
                Console.WriteLine("STOP!!!!");
            }
            else if (color.Equals("Yellow"))
            {
                Console.WriteLine("Get Ready!");
            }
            else if (color.Equals("Green"))
            {
                Console.WriteLine("GO!");
            }
            else
            {
                Console.WriteLine("Wrong color! Enter Only Red, Yellow or Green!");
            }
        }

        public static void withdrawSimulator(int balance, int withdraw) {
            if (withdraw < 0)
            {
                Console.WriteLine("Invalid withdrawal amount");
            }
            else if (withdraw > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                Console.WriteLine("Withdrawal successful! Remaining balance: ..." + (balance-withdraw));
            }
        }

        public static void resultCalculator(int grade)
        {
            if (grade >= 50)
            {
                Console.WriteLine("Pass!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }
        }

        public static void superCalculator(double a, double b, char op)
        {
            if (op.Equals('+'))
            {
                Console.WriteLine(a + b);
            }
            else if (op.Equals('-'))
            {
                Console.WriteLine(a - b);
            }
            else if (op.Equals('*'))
            {
                Console.WriteLine(a * b);
            }
            else if (op.Equals('/'))
            {
                if (b == 0)
                {
                    Console.WriteLine("Error: Division by zero");
                }
                else
                {
                    Console.WriteLine(a / b);
                }
            }
            else
            {
                Console.WriteLine("Invalid Operation! Enter '+', '-', '*' or '/'");
            }
        }

        public static void cescoSimulator(byte age)
        {
            if (age < 0)
            {
                Console.WriteLine("Invalid age");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }
        }

        public static void bonusCalculator(string role, double salary)
        {
            double bonus = 0;
            if (role.Equals("Manager"))
            {
                if (salary > 2500)
                {
                    bonus = salary * 0.15;
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

        public static void Main(string[] args)
        {
            //(Login Authentication)
            Console.WriteLine("(Login Authentication)");
            Console.Write("Enter username(hint: admin): ");
            string username = Console.ReadLine();

            Console.Write("Enter password(hint: 13245): ");
            string password = Console.ReadLine();

            loginAuthentication(username, password);

            //(Grade Calculator)
            Console.WriteLine("(Grade Calculator)");
            Console.WriteLine("Enter your grade: ");
            int score = int.Parse(Console.ReadLine());

            gradeCalculator(score);

            //(Discount Calculation)
            Console.WriteLine("(Discount Calculation)");
            Console.WriteLine("Enter amount: ");
            int amount = int.Parse(Console.ReadLine());

            calculateDiscount(amount);

            //(Day of the Week)
            Console.WriteLine("(Day of the Week)");
            Console.WriteLine("Enter number to convert it to the day");
            byte day = byte.Parse(Console.ReadLine());
            numberToDay(day);

            //(Traffic Light System)
            Console.WriteLine("(Traffic Light System)");
            Console.WriteLine("Enter traffic light color(Red, Yellow, Green): ");
            string color = Console.ReadLine();
            trafficLightSystem(color);

            //(ATM Withdrawal Validation)
            Console.WriteLine("(ATM Withdrawal Validation)");
            Console.WriteLine("Enter your balance and withdraw amount");
            Console.WriteLine("Enter your balance: ");
            int balance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter withdraw amount: ");
            int withdraw = int.Parse(Console.ReadLine());
            withdrawSimulator(balance, withdraw);

            //(Pass/Fail Result)
            Console.WriteLine("(Pass/Fail Result)");
            Console.WriteLine("Enter your score: ");
            int grade = int.Parse(Console.ReadLine());
            resultCalculator(grade);

            //(Calculator Program)
            Console.WriteLine("(Calculator Program)");
            Console.WriteLine("Enter first and second numbers: ");
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter operation. '+', '-', '*' or '/'");
            char op = Console.ReadLine()[0];
            superCalculator(a, b, op);

            //(Voting Eligibility)
            Console.WriteLine("(Voting Eligibility)");
            Console.WriteLine("Enter your age: ");
            byte age = byte.Parse(Console.ReadLine());
            cescoSimulator(age);

            //(Employee Bonus Calculation)
            Console.WriteLine("(Employee Bonus Calculation)");
            Console.WriteLine("Enter your role: ");
            string role = Console.ReadLine();
            Console.WriteLine("Enter your salary: ");
            double salary = double.Parse(Console.ReadLine());
            bonusCalculator(role, salary);
        }
    }
}