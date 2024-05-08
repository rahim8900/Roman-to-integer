namespace Roman_to_integer
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == "I") input[i] = "1";
                else if (input[i] == "V") input[i] = "5";
                else if (input[i] == "X") input[i] = "10";
                else if (input[i] == "L") input[i] = "50";
                else if (input[i] == "C") input[i] = "100";
                else if (input[i] == "D") input[i] = "500";
                else if (input[i] == "M") input[i] = "1000";
                else Console.WriteLine("Duzgun daxil edin!!!");
            }
            string[] array = input;
            sum = int.Parse(array[0]);
            for (int k = 1; k < input.Length; k++)
            {
                if (int.Parse(array[k]) <= int.Parse(array[k - 1])) sum += int.Parse(input[k]);
                else sum += int.Parse(input[k]) - 2 * int.Parse(input[k - 1]);
            }
            Console.WriteLine(Math.Abs(sum));
        }
    }
}
