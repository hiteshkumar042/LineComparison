namespace LineComparison
{
   class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem!");
            //Length of Line - UC1
            Console.WriteLine("Enter X1 co-ordinate : ");
            double x1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y1 co-ordinate : ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter X2 co-ordinate : ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y2 co-ordinate : ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("length of teh Line is : " + length);
        }
    }
}