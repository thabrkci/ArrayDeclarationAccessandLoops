namespace ArrayDeclarationAccessandLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array Declaration
            /*string[] colors = new string[5];   // New string with size 5
            string[] animals = { "Bird", "Cat", "Dog" };  // Direct assignment of values
            int[] array;
            array = new int[5];  // Array with size 5

            // Array Value Assignment
            colors[0] = "blue";   // Assigning "blue" to index 0 in colors array
            array[3] = 10;        // Assigning 10 to index 3 in array
            colors[1] = "red";
            array[1] = 25;

            Console.WriteLine(animals[1]);       // Output: Cat
            Console.WriteLine(array[3]);         // Output: 10
            Console.WriteLine(colors[0] + array[1]);  // Output: blue25
            */

            Console.Write("Please enter the number of elements in the array: ");
            int arrayLength = int.Parse(Console.ReadLine()!); // Prompt the user to enter the number of array elements
            int[] numberArray = new int[arrayLength]; // Create an array with the specified length

            // Loop to populate the array with user-input values
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Please enter the {0}. number: ", i + 1); // i+1 is used because we don't want the user to enter the 0th number.
                numberArray[i] = int.Parse(Console.ReadLine()!);
            }

            int sum = 0;

            // Calculate the sum of array elements using a foreach loop
            foreach (var number in numberArray)
            {
                sum += number;
            }

            Console.WriteLine("Average: " + (sum / (double)arrayLength)); // Calculate and print the average of array elements
        }
    }
}
