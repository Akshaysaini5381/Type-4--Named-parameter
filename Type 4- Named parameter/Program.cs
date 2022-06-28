using System;

namespace Type_4__Named_parameter
{
    class Program
    {
        public void show(int age, string name, double marks)
        {
            Console.WriteLine("My "+age+ " "+name+ " "+marks);
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.show(name: "akshay saini", marks: 500, age: 21);
            obj.show(marks: 500, name: "akshay saini",  age: 21);
        }
    }
}
