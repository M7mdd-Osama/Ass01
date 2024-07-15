using Common;
using System.Reflection;
using System.Threading.Channels;
namespace Demo
{
    public enum Days : int //Default
    {
        Saturdaty,
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    public enum Grades : byte
    {
        A, B, C, D, E, F
    }
    public enum Gender : int
    {
        Male, Female
    }
    [Flags]
    public enum Permission : byte
    {
        Delete = 1, Execute = 2, Read = 4, Write = 8
    }
    class Employee
    {
        public string Name;
        public int Age;
        public Gender Gender;
        public decimal Salary;
        public Permission Permission;
    }
    internal class Program
    {
        static void DoSomeCode()
        {
            try
            {
                int X, Y, Z;
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
                Z = X / Y;
                int[] Numbers = { 1, 2, 3 };
                Numbers[7] = 20;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void DoSomeProtectiveCode()
        {
            int X, Y, Z;
            bool Flag;
            do
            {
                Flag = int.TryParse(Console.ReadLine(), out X);
            } while (!Flag);
            do
            {
                Flag = int.TryParse(Console.ReadLine(), out Y);
            } while (!Flag || Y == 0);
            Z = X / Y;

            int[] Numbers = null;
            if (Numbers?.Length > 10)
            {
                Numbers[10] = 30;
            }
        }
        static void Main()
        {
            //try
            //{
            //    DoSomeProtectiveCode();
            //    throw new Exception();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("mmmmm");
            //}
            //Console.WriteLine("zzzz");
            //Gender gender = Gender.Male;

            //if (gender == Gender.Male) 
            //    Console.WriteLine(";)");
            //else
            //    Console.WriteLine(";(");
            //Gender z = (Gender)2;
            //Console.WriteLine(z);

            //Grades X = (Grades)Enum.Parse(typeof(Grades), Console.ReadLine());
            //bool Result = Enum.TryParse(typeof(Grades), Console.ReadLine(), out object X);
            //Console.WriteLine(Result);
            //Console.WriteLine(X);

            //string Grades = "b";
            //bool Flag = Enum.TryParse<Grades>(Grades , true, out Grades Result);
            //Console.WriteLine(Result);

            //Employee employee = new Employee();
            //employee.Name = "Mohamed";
            //employee.Gender = Gender.Male;
            //employee.Permission = (Permission)5;

            //employee.Permission = employee.Permission ^ Permission.Execute; //Add
            //employee.Permission = employee.Permission ^ Permission.Execute; //Deny
            //Console.WriteLine(employee.Permission);

            //if ((employee.Permission & Permission.Execute) == Permission.Execute)
            //    Console.WriteLine("Yes");
            //else
            //    employee.Permission = employee.Permission ^ Permission.Execute;
            //Console.WriteLine(employee.Permission);

            //employee.Permission = employee.Permission | Permission.Write; 
            //Console.WriteLine(employee.Permission);
            //Point P1;
            //P1 = new Point(50);
            //Console.WriteLine(P1.X);
            //Console.WriteLine(P1.Y);
            //Console.WriteLine(P1);
            //Point P02 = new ();
        }
    }
    //internal class Employee
    //{
    //    Days day = Days.Sunday;
    //    Gender gender = (Gender)2;
    //}
}
