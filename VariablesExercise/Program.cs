namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dogName; // This is declaration syntax

            dogName = "Bo"; // Initializing variable

            int dogAge = 3; // declaring and initializing

            char firstInitial = 'T';

            bool isHungry = true;

            decimal dogHeight = 15.0m;

            double dogWeight = 48.3;

            Console.WriteLine($"My dog's name is {dogName}. He is {dogAge} years old." +
                $" It is {isHungry} he is always hungry. " +
                $"He weighs {dogWeight} pounds and is {dogHeight} inches tall.");


        }
    }
}
