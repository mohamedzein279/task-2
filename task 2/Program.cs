using System.ComponentModel.Design;
using System.Drawing;

List<int> numbers = new List<int>();

 char choice;

do
{

    Console.WriteLine("P - Print numbers");
    Console.WriteLine("A - Add a number");
    Console.WriteLine("M - Display mean of the numbers");
    Console.WriteLine("S - Display the smallest number");
    Console.WriteLine("L - Display the largest number");
    Console.WriteLine("Q - Quit");

    Console.WriteLine("Enter your choice: ");
    choice = Convert.ToChar(Console.ReadLine().ToUpper());


    switch (choice)
    {
        case 'P':
            if (numbers.Count == 0)

                Console.WriteLine("[] - the list is empty");
            else
            {
                for (int i = 0; i < numbers.Count; i++)
                    Console.WriteLine(numbers[i]);
            }
            break;

        case 'A':
            Console.WriteLine("enter an integer");
            int num = Convert.ToInt32(Console.ReadLine());

            numbers.Add(num);
            Console.WriteLine($"{num} added");
            break;


        case 'M':
            if (numbers.Count == 0)
                Console.WriteLine("No data");
            else
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
                double mean = (double)sum / numbers.Count;
                Console.WriteLine($"Mean: {mean}");
            }
            break;


        case 'S':
            if (numbers.Count == 0)
                Console.WriteLine("Unable to determine the smallest number - list is empty");
            else
            {
                int smallest = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] < smallest)
                    {
                        smallest = numbers[i];
                    }
                }
                Console.WriteLine($"The smallest number is {smallest}");
            }
            break;




        case 'L':
            if (numbers.Count == 0)
                Console.WriteLine("Unable to determine the largest number - list is empty");
            else
            {
                int large = numbers[0];
                for (int i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] > large)
                    {
                        large = numbers[i];
                    }
                }
                Console.WriteLine($"The largest number is {large}");
            }
            break;


        case 'Q':
            Console.WriteLine("Goodbye");
            break;


        default:
            Console.WriteLine("Unknown selection, please try again");
            break;
    }
}
while (choice != 'Q');






















