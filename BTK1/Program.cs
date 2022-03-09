using System;

namespace BTK1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //CostumerManager costumerManager = new();


            //costumerManager.List();


            //Product product = new Product(1, "isak", 27);

            //Console.WriteLine("{0}{1}{2}",product.id,product.adi,product.yas);

            Employee employee = new Employee(new FileBase());
            
            employee.add();
        }

        #region Constructer
        //public class CostumerManager
        //{
        //    private int _count;
        //    public CostumerManager(int count)
        //    {
        //        _count = count;
        //    }

        //    public CostumerManager()
        //    {

        //    }
        //    public void List()
        //    {
        //        Console.WriteLine("Listed {0} ", _count);
        //    }


        //    public void Add()
        //    {
        //        Console.WriteLine("Added");
        //    }

        //    public Deneme deneme { get; set; }


        //}

        //public class Product // Bu sınıfı clasından nesne alırken değerleri tanımlada constructer kullanımı anlatılaca
        //{
        //    private int _id;
        //    private string _adi;
        //    private int _yas;

        //    public Product(int id, string adi, int yas)
        //    {
        //        _id = id;
        //        _adi = adi;
        //        _yas = yas;
        //    }
        //    public int id { get; set; }

        //    public string adi { get; set; }

        //    public int yas { get; set; }

        //}

        //public interface Deneme
        //{
        //    static void denemem(string deger)
        //    {
        //        Console.WriteLine("sabdjasd");
        //    }
        //}
        #endregion


        public interface Logger
        {
            void log();
        }


        public class DataBaseLogger : Logger
        {
            public void log()
            {
                Console.WriteLine("Logged to database");
            }
        }
        public class FileBase : Logger
        {
            public void log()
            {
                Console.WriteLine("Logged to File");
            }
        }

        //public class Employee /// propertise olarak logger ekleme
        //{
        //    public Logger Ilogger { get; set; }
        //    public void add()
        //    {
        //        Ilogger.log();
        //        Console.WriteLine("Added");
        //    }
        //}

        public class Employee
        {
            private Logger _logger;
            public Employee(Logger logger)
            {
                _logger = logger;
            }
            public void add()
            {
                _logger.log();
                Console.WriteLine("Added");
            }
        }
    }
}
