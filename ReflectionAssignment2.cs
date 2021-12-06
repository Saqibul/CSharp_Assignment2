using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment2
{
    public class Employee
    {
        public string name, department;
        private int age;
        public bool working = false;

        public Employee(string name, string dept, int age)
        {
            this.name = name;
            this.department = dept;
            this.age = age;
        }

        public void work()
        {
            this.working = true;
            Console.WriteLine(this.name + " is working");
        }

        public void showEmployee()
        {
            Console.WriteLine(this.name + " from " + this.department + " is " + this.getAge() + " years old");
        }

        public void changeDept(string dept)
        {
            string prevDept = this.department;
            this.department = dept;
            Console.WriteLine(this.name + "'s department changed from " + prevDept + " to " + this.department);
        }

        public int getAge()
        {
            return this.age;
        }

    }
    class ReflectionAssignment2
    {
        
        //Asynchronous example
        //static async Task Main(string[] args)
        //{
        //    Stopwatch stopwatch = new Stopwatch();
        //    stopwatch.Start();

        //    var firstTask = AsyncAssignment2.asynctaskOne();
        //    var secondTask = AsyncAssignment2.asynctaskTwo();
        //    var thirdTask = AsyncAssignment2.asynctaskThree();
        //    var fourthTask = AsyncAssignment2.asynctaskFour();


        //    var first = await firstTask;
        //    var second = await secondTask;
        //    var third = await thirdTask;
        //    var fourth = await fourthTask;
        //    stopwatch.Stop();

        //    TimeSpan ts = stopwatch.Elapsed;

        //    // Format and display the TimeSpan value.
        //    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        //        ts.Hours, ts.Minutes, ts.Seconds,
        //        ts.Milliseconds / 10);
        //    Console.WriteLine("RunTime " + elapsedTime + " to complete in asynchronous way");
        //}

        static void Main(string[] args)
        {
            //Reflection example
            //Type myType = (typeof(Employee));
            //// Get the public methods.
            //MethodInfo[] myArrayMethodInfo = myType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            //Console.WriteLine("\nThe number of public methods is {0}.", myArrayMethodInfo.Length);
            //// Display all the methods.
            //DisplayMethodInfo(myArrayMethodInfo);
            //// Get the nonpublic methods.
            //MethodInfo[] myArrayMethodInfo1 = myType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            //Console.WriteLine("\nThe number of protected methods is {0}.", myArrayMethodInfo1.Length);
            //// Display information for all methods.
            //DisplayMethodInfo(myArrayMethodInfo1);

            //Synchronous Example
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //AsyncAssignment2.taskOne();
            //AsyncAssignment2.taskTwo();
            //AsyncAssignment2.taskThree();
            //AsyncAssignment2.taskFour();
            //stopwatch.Stop();
            //TimeSpan ts = stopwatch.Elapsed;

            //// Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //    ts.Hours, ts.Minutes, ts.Seconds,
            //    ts.Milliseconds / 10);
            //Console.WriteLine("RunTime " + elapsedTime + " to complete in synchronous way");


            //LINQ Example

            //string[] fruits = new string[] {"Apple", "Banana", "Pear","Jackfruit"};

            //IEnumerable<string> arrQuery = 
            //    from fruit in fruits 
            //    where fruit == "Banana" 
            //    select fruit;

            //foreach (string val in arrQuery) {
            //    Console.WriteLine(val );
            //}

            //Collection Example

            //var collection = new List<int> {55,66,77,88,3,44,12}; // collection initializer

            //foreach (int i in collection) {
            //    if (i % 2 == 0) {
            //        Console.WriteLine(i);
            //    }
            //}

            //Attribute Example
            deprecatedMethod();
        }

        //Added an attribute so that calling the deprecatedMethod would give an error during compilation that this method is obsolete.
        [Obsolete("Don't use deprecatedMethod, use newMethod instead.", true)]
        static void deprecatedMethod() {
            Console.WriteLine("Old Method");
        }

        static void newMethod() {
            Console.WriteLine("New Method");
        }
        
        //For Reflection
        public static void DisplayMethodInfo(MethodInfo[] myArrayMethodInfo)
        {
            // Display information for all methods.
            for (int i = 0; i < myArrayMethodInfo.Length; i++)
            {
                MethodInfo myMethodInfo = (MethodInfo)myArrayMethodInfo[i];
                Console.WriteLine("\nThe name of the method is {0}.", myMethodInfo.Name);
            }
        }
    }
}
