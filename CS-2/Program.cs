namespace CS_2
{
    internal class Program
    {

        #region Protective code

        //static void DoSomeProtectiveCodes()
        //{
        //    int X, Y, Z;
        //    bool Flag;

        //    do
        //    {
        //        Console.WriteLine("enter first number : ");
        //        Flag = int.TryParse(Console.ReadLine(), out X);
        //    }
        //    while (!Flag);


        //    do
        //    {
        //        Console.WriteLine("enter second number : ");
        //        Flag = int.TryParse(Console.ReadLine(), out Y);
        //    }
        //    while (!Flag || Y == 0);

        //    Z = X / Y;
        //    int[] Numbers = null;
        //    if (Numbers?.Length > 10)
        //    {
        //        Numbers[10] = 1000;
        //    }


        //}

        #endregion

        #region Enum

        //public enum Days
        //{
        //    sat,sun,mon,tus,wedn,thurs,fri
        //}

        #endregion

        #region Enum Permissions
        //[Flags]
        //public enum Permissions
        //{
        //    Read = 1,
        //    Write = 2,
        //    Delete = 4,
        //    Execute = 8

        //}

        #endregion


        #region struct

        // struct ----> structure

        //public struct Point
        //{
        //    public int x;
        //    public int y;



        //    // user defined constructor 
        //    public Point(int x , int y) {
        //        this.x = x;
        //        this.y = y;
        //    }

        //    // user defined constructor
        //    public Point(int num)
        //    {
        //        this.x = this.y = num;
        //    }


        //    // override
        //    public override string ToString()
        //    {
        //        return $"({x},{y})";
        //    }


        //}


        #endregion


        static void Main(string[] args)
        {

            #region protective Code 
            //try
            //{
            //    DoSomeProtectiveCodes();
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}
            #endregion


            #region Enum 
            //Days days = Days.wedn;
            //Console.WriteLine(days);  // wedn

            //Days days = (Days)2;
            //Console.WriteLine(days);  // mon

            // [TryParse]
            //Console.WriteLine("enter Day Name : ");
            //bool result = Enum.TryParse(typeof(Days), Console.ReadLine() , out object day );
            //Console.WriteLine($"day is : {day}");



            // [TryParse<>] Generic method
            //Console.WriteLine("enter Day Name : ");
            //bool result = Enum.TryParse<Days>(Console.ReadLine(), true, out Days day);
            //Console.WriteLine($"day is : {day}");






            #endregion


            #region Enum Permissions
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



            #region Struct
            //Point p = new Point();
            //p.x = 10;
            //p.y = 20;


            //Point P;
            //P = new Point(10,30);   //-------> user defined constructor 1 
            //Console.WriteLine(P.ToString());

            //P = new Point(30);  //-------> user defined constructor 2
            //Console.WriteLine(P);


            #endregion



        }
    }
}
