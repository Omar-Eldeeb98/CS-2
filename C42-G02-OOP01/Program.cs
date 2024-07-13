namespace C42_G02_OOP01
{
    internal class Program
    {
        #region 1.Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum. 
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        #endregion


        #region  2.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)


        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }


        #endregion



        #region 3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        [Flags]
        public enum Permissions
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8

        }

        #endregion


        #region 4.Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not 

        public enum Colors
        {
            Red,
            Green,
            Blue
        }


        #endregion



        #region  5.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        public struct Point
        {
            public int x;   // properties
            public int y;



            public Point(int x, int y)  // user defined constructor
            {
                this.x = x;
                this.y = y;
            }



        }


        #endregion

        static void Main(string[] args)
        {


            #region Q - 1

            //string[] Days = Enum.GetNames(typeof(WeekDays));
            //for (int i = 0; i < Days.Length; i++)
            //{
            //    Console.WriteLine(Days[i]);
            //}

            #endregion


            #region Q - 2
            //Console.WriteLine("enter season name (Spring Or Summer Or Autumn Or  Winter) : ");
            //string SeasonName = Console.ReadLine();
            //bool Flag;
            //Flag = Enum.TryParse<Season>(SeasonName, true, out Season result);  // ([true, season ] , false)
            //Console.WriteLine(Flag);  // just for test
            //if (Flag == true)
            //{
            //    if (result == Season.Spring)
            //    {
            //        Console.WriteLine("Spring: March to May");
            //    }
            //    else if (result == Season.Summer)
            //    {
            //        Console.WriteLine("Summer: June to August");
            //    }
            //    else if (result == Season.Autumn)
            //    {
            //        Console.WriteLine("Autumn: September to November");
            //    }
            //    else if (result == Season.Winter)
            //    {
            //        Console.WriteLine("Winter: December to February");
            //    }
            //    else
            //    {
            //        Console.WriteLine("invalid season name ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season name, pls enter a valid season name ! : ");
            //}

            #endregion

            #region Q - 3

            //Permissions UserPermissions  = Permissions.Read;
            //Console.WriteLine("Before add or  remove UserPermissions =  " + UserPermissions);  // Read
            //Console.WriteLine("------------------------------------------------------------");



            //// check if specific Permission is existed inside variable  

            //if ((UserPermissions & Permissions.Write) == Permissions.Write)
            //{
            //    Console.WriteLine("Write is existed");
            //}
            //else
            //{
            //    Console.WriteLine("Write is not existed");

            //    // add Write to UserPermissions
            //    UserPermissions = UserPermissions ^ Permissions.Write;

            //    Console.WriteLine("after add (Write) UserPermissions = " + UserPermissions);
            //}

            //Console.WriteLine("------------------------------------------------------------");

            //// check if specific Permission is existed inside variable  
            //if ((UserPermissions & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read is existed");

            //    // Remove Read from UserPermissions
            //    UserPermissions = UserPermissions ^ Permissions.Read;

            //    Console.WriteLine("after Remove (Read) UserPermissions = " + UserPermissions);
            //}
            //else
            //{
            //    Console.WriteLine("Read is not existed");
            //}









            #endregion


            #region Q - 4
            //Console.WriteLine("enter color name (red or green or blue ) : ");
            //string ColorName  = Console.ReadLine();
            //bool Flag;
            //Flag = Enum.TryParse<Colors>(ColorName, true, out Colors Result);
            //Console.WriteLine(Flag);  // just for test
            //if (Flag == true)
            //{
            //    if(Result == Colors.Blue)
            //    {
            //        Console.WriteLine($"{Result} is a primary color.");
            //    }
            //    else if (Result == Colors.Red)
            //    {
            //        Console.WriteLine($"{Result} is a primary color.");
            //    }
            //   else if (Result == Colors.Green)
            //    {
            //        Console.WriteLine($"{Result} is a primary color.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Invalid, Please enter a valid color name.");
            //}

            #endregion



            #region Q - 5 

            //Console.Write("Enter the X coordinate of Point1: ");
            //int x1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the Y coordinate of Point1: ");
            //int y1 = int.Parse(Console.ReadLine());


            //Console.Write("Enter the X coordinate of Point2: ");
            //int x2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the Y coordinate of Point2: ");
            //int y2 = int.Parse(Console.ReadLine());



            //Point Point1 = new Point(x1, y1);
            //Point Point2 = new Point(x2, y2);



            //double Distance = Math.Sqrt(Math.Pow(Point2.x - Point1.x, 2) + Math.Pow(Point2.y - Point1.y, 2));

            //Console.WriteLine($"Distance between Point1 and Point2 = : {Distance:F2}");


            #endregion


        }
    }
}
