namespace Assignment_01OOP
{
    [Flags]
    public enum Permission : byte
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8
    }
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    [Flags]
    public enum WeekDays : byte
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 4,
        Thursday = 8,
        Friday = 16,
        Saturday = 32,
        Sunday = 64,
    }
    public enum Colors
    {
        Red, Green, Blue
    }

    public class Employee
    {
        public string Name = "";
        public int Age;
        public Permission Permission;

    }
    public class Program
    {
        public static void Main()
        {
            #region Q1
            //WeekDays weekDays = (WeekDays)127;
            //Console.WriteLine(weekDays); 
            #endregion

            #region Q2
            //string X = Console.ReadLine();

            //bool Flag = Enum.TryParse<Season>(X, true, out Season Result);
            //if (Flag == true)
            //{
            //    if (Result == Season.Spring)
            //    {
            //        Console.WriteLine("March To May");
            //    }
            //    else if (Result == Season.Summer)
            //    {
            //        Console.WriteLine("June To August");
            //    }
            //    else if (Result == Season.Autumn)
            //    {
            //        Console.WriteLine("September To November");
            //    }
            //    else if (Result == Season.Winter)
            //    {
            //        Console.WriteLine("December To February");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("NAN");
            //}
            #endregion

            #region Q3
            //Permission Permission = (Permission)2;
            //Console.WriteLine(Permission);

            //if ((Permission & Permission.Read) == Permission.Read)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Permission = Permission ^ Permission.Read;
            //}
            //Console.WriteLine(Permission);
            #endregion

            #region Q4
            //string Color = Console.ReadLine();

            //if (Enum.TryParse<Colors>(Color, true, out Colors Result))
            //{
            //    Console.WriteLine($"{Result} Is a Primary Color");
            //}
            //else
            //{
            //    Console.WriteLine($"{Result} Is Not a Primary Color");
            //}
            #endregion

            #region Q5
            //Point P01;
            //P01 = new Point(3,2);
            //Point P02;
            //P02 = new Point(6, 9);
            //Console.WriteLine(P01.CalcDistance(P01, P02));
            #endregion
        }
    }
}
