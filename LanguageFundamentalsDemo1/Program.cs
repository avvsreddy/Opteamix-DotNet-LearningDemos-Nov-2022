namespace LanguageFundamentalsDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product();
            //p1.ProductID = 111;
            //p1.Name = "IPhone 14";
            //p1.Rate = 125000;
            //p1.Brand = "Apple";
            //p1.Catagory = "Mobiles";

            // Object Initialization Syntax
            var p2 = new { ProductID = 111, Name = "IPhone 14 Plus" };
            Product p3 = new Product { ProductID = 222 };
            Product p4 = new Product { Name = "IPhone" };


        }
    }

    class Employee
    {
        private double _badfsdfksdflskfsdfsadfasdf;

        public double Bonus { get; private set; } // Automatic properties
        public string FirstName { get; set; }

        private int empid;
        private string fname;
        private string name;

        private string _backingfield323232345345345;
        public double salary;


        public string Name
        {
            get; //{ return name; }
            set; //{ name = value; }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value <= 0)
                    salary = 1;
                else
                    salary = value;
            }
        }

        public int EmpId
        {
            get
            {
                return empid;
            }

            set
            {
                empid = value;
            }

        }

        public int GetEmpId()
        {
            return empid;
        }
        public void SetEmpId(int id)
        {
            empid = id;
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void SetSalary(double sal)
        {
            if (sal <= 0)
                salary = 1;
            else
                salary = sal;
        }



    }


    class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public string Brand { get; set; }
        public string Catagory { get; set; }


    }
}