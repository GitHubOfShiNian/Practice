//using System;
//using System.Linq;

//namespace ConsolePractice
//{
//    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
//    public class DisplayNameAttribute : Attribute
//    {
//        private string name;
//        public DisplayNameAttribute(string namestring)
//        {
//            this.name = namestring;
//        }
//        public string Name { get { return name; } }
//    }

//    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
//    public class DeBugInfoAttribute : System.Attribute
//    {
//        private int bugNo;
//        private string developer;
//        private string lastReview;
//        public string message;

//        public DeBugInfoAttribute(int bg, string dev, string d)
//        {
//            this.bugNo = bg;
//            this.developer = dev;
//            this.lastReview = d;
//        }
//        public int BugNo
//        {
//            get
//            {
//                return bugNo;
//            }
//        }

//        public string Developer
//        {
//            get
//            {
//                return developer;
//            }
//        }

//        public string LastReview
//        {
//            get
//            {
//                return lastReview;
//            }
//        }

//        public string Message
//        {
//            get
//            {
//                return message;
//            }
//            set
//            {
//                message = value;
//            }
//        }

//    }
//    [DeBugInfo(1, "zf.wang", "2018/12/13", message = "Return type mismatch")]
//    [DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
//    class Rectangle
//    {
//        protected double length;
//        protected double width;

//        public Rectangle(double l, double w)
//        {
//            length = l;
//            width = w;
//        }
//        [DeBugInfo(55, "Zara Ali", "19/10/2012",
//      Message = "Return type mismatch")]
//        public double GetArea()
//        {
//            return length * width;
//        }
//        [DeBugInfo(56, "Zara Ali", "19/10/2012")]
//        public void Display()
//        {
//            Console.WriteLine("Length: {0}", length);
//            Console.WriteLine("Width: {0}", width);
//            Console.WriteLine("Area: {0}", GetArea());
//        }
//    }
//    [DisplayName("这是枚举")]
//    [DisplayName("这也是枚举")]
//    public enum TestEnum
//    {
//        [DisplayName("这是一")]
//        first = 1,
//        [DisplayName("这是二")]
//        second = 2,
//        [DisplayName("这是三")]
//        third = 3,
//        [DisplayName("这是四")]
//        fourth = 4,
//    }
//    public class ExecuteRectangle
//    {
//        internal static void Main(string[] args)
//        {
//            //TestEnum a = TestEnum.first;
//            Type type = typeof(TestEnum);
//            var name = Enum.GetName(type, 1);
//            DisplayNameAttribute namestring = (DisplayNameAttribute)type.GetField(name).GetCustomAttributes(typeof(DisplayNameAttribute), true).FirstOrDefault();
//            Console.WriteLine(namestring.Name);

//            //Rectangle r = new Rectangle(4.5, 7.5);
//            //r.Display();
//            //Type type = typeof(Rectangle);

//            //var attrs = type.GetCustomAttributes(typeof(DeBugInfoAttribute), true);
//            //foreach (DeBugInfoAttribute attr in attrs)
//            //{
//            //    Console.WriteLine(attr.BugNo);
//            //}
//            // 遍历 Rectangle 类的特性
//            //foreach (Object attributes in type.GetCustomAttributes(false))
//            //{
//            //    DeBugInfo dbi = (DeBugInfo)attributes;
//            //    if (null != dbi)
//            //    {
//            //        Console.WriteLine("Bug no: {0}", dbi.BugNo);
//            //        Console.WriteLine("Developer: {0}", dbi.Developer);
//            //        Console.WriteLine("Last Reviewed: {0}",
//            //             dbi.LastReview);
//            //        Console.WriteLine("Remarks: {0}", dbi.Message);
//            //    }
//            //}

//            //// 遍历方法特性
//            //foreach (MethodInfo m in type.GetMethods())
//            //{
//            //    foreach (Attribute a in m.GetCustomAttributes(true))
//            //    {
//            //        DeBugInfo dbi = (DeBugInfo)a;
//            //        if (null != dbi)
//            //        {
//            //            Console.WriteLine("Bug no: {0}, for Method: {1}",
//            //                  dbi.BugNo, m.Name);
//            //            Console.WriteLine("Developer: {0}", dbi.Developer);
//            //            Console.WriteLine("Last Reviewed: {0}",
//            //dbi.LastReview);
//            //            Console.WriteLine("Remarks: {0}", dbi.Message);
//            //        }
//            //    }
//            //}
//            Console.ReadLine();
//        }


//    }
//}
