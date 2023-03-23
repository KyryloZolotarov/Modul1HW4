namespace Modul1HW4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter array length");
            var input = Console.ReadLine();
            var n = Convert.ToInt32(input);
            var arr = new int[n];
            var counter = 0;
            var counter1 = 0;
            var counter2 = 0;
            var counter3 = 0;
            var alphabet = "AbcDEfgHIJklmnopqrstuvwxyz";
            var arr2 = new char[n];
            var arr3 = new char[n];
            for (int i = 0; i < arr.Length; i++)
            {
                var rand = new Random();
                arr[i] = rand.Next(0, 25);
                if (arr[i] % 2 == 0)
                {
                    arr2[counter] = alphabet[arr[i]];
                    if (char.IsUpper(arr2[counter]))
                    {
                        counter2++;
                    }

                    counter++;
                }
                else
                {
                    arr3[counter1] = alphabet[arr[i]];
                    if (char.IsUpper(arr3[counter1]))
                    {
                        counter3++;
                    }

                    counter1++;
                }
            }

            Array.Resize(ref arr2, counter);
            Array.Resize(ref arr3, counter1);
            var arr2str = $"arr1: {string.Join(" ", arr2)}";
            var arr3str = $"arr2: {string.Join(" ", arr3)}";

            if (counter2 > counter3)
            {
                Console.WriteLine("Array 1 has more upper letters");
                Console.WriteLine(arr2str);
                Console.WriteLine(arr3str);
            }
            else if (counter2 < counter3)
            {
                Console.WriteLine("Array 2 has more upper letters");
                Console.WriteLine(arr3str);
                Console.WriteLine(arr2str);
            }
            else
            {
                Console.WriteLine("Array 1 equel Array 2");
                Console.WriteLine(arr2str);
                Console.WriteLine(arr3str);
            }
        }
    }
}