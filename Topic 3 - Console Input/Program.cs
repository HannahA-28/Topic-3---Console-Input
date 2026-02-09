namespace Topic_3___Console_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Greetings");
            string name, response;
            int currentYear, age;
            currentYear = 2026;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + ", how old are you?");
            response = Console.ReadLine();
            Console.WriteLine("Wow, you are " +  response);
            Console.WriteLine("If you are " + response + ", that means you were born in " + (currentYear - response));
            

            Console.WriteLine("2. Adder");


            Console.WriteLine("3. Distance");


            Console.WriteLine("4. Hypotenuse");
        }
    }
}
