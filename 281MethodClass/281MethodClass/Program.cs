namespace _281MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass Class = new MyClass(); //instatiating the class as Class
            Class.MyMethod(3, 4); //passing in two numbers; will print 4
            Class.MyMethod(int1: 2, int2: 5); //specify parameters by name; will print 5
        }
    }
}
