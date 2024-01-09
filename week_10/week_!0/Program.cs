namespace week__0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FIRST_PART

            Laptop laptopObj = new Laptop("MSI",1399.0f);
            Product productObj = laptopObj;

            laptopObj.Report();

            productObj.Report();

            TouchscreenDevice toucObj = new TouchscreenDevice(17.0f, "Surface", 2000.0f);

            Laptop laptopObj2 = toucObj;

            Product prodObj = toucObj;

            PrintReport(toucObj);
            PrintReport(laptopObj2);
            /*
            CreateNewTouchScreen();
            CreateNewTouchScreen();
            CreateNewTouchScreen();
            CreateNewTouchScreen();
            System.GC.Collect();
            for (int i = 0; i < 10000000; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }*/

            #endregion

            /*string path = @"C:/Users/erden/OneDrive/Desktop/aaaa.txt";

            using (StreamReader strReader = new StreamReader(path))
            {
                string line = string.Empty;

                while ((line = strReader.ReadLine()) is not null)
                {
                    Console.WriteLine(line);
                }
            }*/

            using (TouchscreenDevice obj = new TouchscreenDevice(10.0f, "MSI", 1299.0f))
            {
                Console.WriteLine("Resource used");
            }

            Console.ReadKey();

            /*
            StreamReader strReader = new StreamReader(path);

            try
            {
                string line = string.Empty;

                throw new Exception();

                while ((line = strReader.ReadLine()) is not null)
                {
                    Console.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception handled");
            }
            finally
            {
                Console.WriteLine("Message from the finally block");
                strReader.Close(); //disposal method
                Console.WriteLine("End of finally block");
            }*/

            Console.ReadKey();

        }
        /*
        public static void CreateNewTouchScreen()
        {
            TouchscreenDevice obj = new TouchscreenDevice(17.0f, "Surface", 2000.0f);
        }*/

        public static void PrintReport(TouchscreenDevice t)
        {
            t.Report();
        }

        public static void PrintReport(Laptop l)
        {
            l.Report();
        }

        public static void PrintReport(Product prod)
        {
            prod.Report();
        }
    }
}