namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string s = Console.ReadLine();

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach(char c in s)
            {
                if (frequency.ContainsKey(c))
                {
                    frequency[c]++;
                }
                else
                {
                    frequency[c] = 1;   
                }
            }

            foreach(var i in frequency)
            {
                Console.WriteLine($"Frequency of {i.Key}: {i.Value}");
            }

            List<int> arr = new List<int>();

            arr.Add(Int32.Parse(Console.ReadLine()));

            Console.WriteLine($"{arr[0]}");


        }
    }
}
