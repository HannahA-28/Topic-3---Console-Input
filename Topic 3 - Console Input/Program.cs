namespace Topic_3___Console_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Greetings();

            Adder();

            Distance();

            Hypotenuse();
        }

        public static void Greetings()
        {
            string name, response;
            int age, birthYear, currentYear = DateTime.Now.Year;

            Console.WriteLine("1. Greetings");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + ", how old are you?");
            response = Console.ReadLine();
            Console.WriteLine("Wow, you are " + response);
            age = Convert.ToInt32(response);
            birthYear = currentYear - age;
            Console.WriteLine("Which means you were born in: " + birthYear);
        }

        public static void Adder()
        {
            string responseOne, responseTwo, responseThree;
            int num1, num2, num3, sum;

            Console.WriteLine("2. Adder");
            Console.WriteLine("Hello, pick any number");
            responseOne = Console.ReadLine();
            Console.WriteLine("Okay, pick a second number");
            responseTwo = Console.ReadLine();
            Console.WriteLine("Now pick your last number");
            responseThree = Console.ReadLine();
            Console.WriteLine("Now I am going to add your numbers...");
            num1 = Convert.ToInt32(responseOne);
            num2 = Convert.ToInt32(responseTwo);
            num3 = Convert.ToInt32(responseThree);
            sum = num1 + num2 + num3;
            Console.WriteLine("The sum of your numbers is: " + sum);
        }

        public static void Distance()
        {
            string response1, response2, response3;
            decimal number1, number2, number3, total;

            Console.WriteLine("3. Distance");
            Console.WriteLine("Hello, pick any decimal number");
            response1 = Console.ReadLine();
            Console.WriteLine("Pick another decimal number");
            response2 = Console.ReadLine();
            Console.WriteLine("Pick your last decimal number");
            response3 = Console.ReadLine();
            Console.WriteLine("I will now find the average of your numbers");
            number1 = Convert.ToDecimal(response1);
            number2 = Convert.ToDecimal(response2);
            number3 = Convert.ToDecimal(response3);
            total = (number1 + number2 + number3) / 3;
            Console.WriteLine("Your total number in km is: " + total + ("km"));
        }

        public static void Hypotenuse()
        {
            double Leg1, Leg2, hypotenuse;
            Console.WriteLine("4. Hypotenuse");
            Console.WriteLine("Enter the length of your first leg");
            Leg1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of your second leg");
            Leg2 = Convert.ToDouble(Console.ReadLine());
            hypotenuse = Math.Sqrt(Math.Pow(Leg1, 2) + Math.Pow(Leg2, 2));
            Console.WriteLine($"The length of the hypotenuse (c) is: {hypotenuse}");
        }
}
}
