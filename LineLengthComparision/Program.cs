namespace LineLengthComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] length = new double[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Welcome to Line Comparison Computation Program");
                int x1, y1;
                Console.WriteLine("Enter the 1st co-ordinates x1");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 1st co-ordinates y1");
                y1 = Convert.ToInt32(Console.ReadLine());
                int x2, y2;
                Console.WriteLine("Enter the 1st co-ordinates x2");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 1st co-ordinates y2");
                y2 = Convert.ToInt32(Console.ReadLine());
                length[i] = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            }
            if (length[0].CompareTo(length[1]) > 0)
            {
                Console.WriteLine("Line 01 is greater than line 02");
            }
            else if (length[0].CompareTo(length[1]) < 0)
            {
                Console.WriteLine("Line 02 is greater than line 01");
            }
            else
            {
                Console.WriteLine("Both Lines Are Equal");
            }
        }
    }
}