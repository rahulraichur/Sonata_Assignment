public static int GetProduct(int res)
        {
            return res;
        }
        public static void Main()
        {
            int a, b, c,res;
            Console.WriteLine("Enter First Number");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Number");
            b =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number");
            c =int.Parse(Console.ReadLine());
            res = a * b * c;
            res = GetProduct(res);
            Console.WriteLine($"The Product is {res}");
        }