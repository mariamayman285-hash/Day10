using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Day10
{
    internal class Program
    {
        public T GetDefault<T>()
        {
            return default(T);
        }
        //tested in problem 9




        //Question 11 (declare delegate + method)
        public delegate string StringTransformer(string str);

        public static List<string> TransFormList(List<string> list , StringTransformer transformer)
        {
            List<string> result = new List<string>();
            
            foreach (string str in list)
            {
                result.Add(transformer(str));
            }
            return result;
        }



        //Question 12 declare + method
        public delegate int TwoIntegers(int n1, int n2);

        public static int OperationOnTwoIntegers(int x, int y , TwoIntegers twoNumbers)
        {
            int result = twoNumbers(x,y);
            return result;
        }



        //Question 13 declare + mehod
        public delegate R TakesTReturnR<in T , out R>(T item);

        public static List<R> ChangeListType<T, R>(List<T> myList , TakesTReturnR<T,R> transformer)
        {
            List<R> result = new List<R>();

            foreach (T i in myList)
            {
                result.Add(transformer(i));
            }
            return result;
        }



        //Question 14 builtin delegate + method
        public static List<int> Power (List<int> numbers , Func< int , int > func)
        {
            List<int> result = new List<int>();

            foreach (int i in numbers)
            {
                result.Add(func(i));
            }
            return result;
        }



        //Question 15 builtin delegate + method
        public static void Print (List<string> list , Action<string> action)
        {
            foreach (string str in list)
            {
                action(str);
            }
        }



        //Question 16 builtin delegate + method
        public static List<int> IsEven (List<int> numbers , Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach(int i in numbers)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
              
            }
            return result;
        }



        //Question 17 builtin delegate + method
        public static List<string> Filter (List<string> list , Predicate<string> predicate)
        {
            List<string> result = new List<string>();

            foreach (string str in list)
            {
                if (predicate(str))
                {
                    result.Add (str);
                }
            }
            return result;
        }



        //Question 18 builtin delegate + method
        public static int Operation (int num1 , int num2 , Func<int , int , int> func)
        {
            return func(num1, num2);
        }



        //Question 19 builtin delegate + method
        public static List<string> FilterCondition(List<string> list , Predicate<string> predicate)
        {
            List<string> result = new List<string> ();
            foreach(string str in list)
            {
                if(predicate(str))
                {
                    result.Add (str);
                }
            }
            return result;
        }



        //Question 20 builtin delegate + method
        public static double Operation(double num1, double num2 ,  Func<double , double , double> func)
        {
            return func(num1, num2);
        }


        static void Main(string[] args)
        {
            #region Problem 1 testing
            //Employee[] arrayOfEmps =
            //{
            //    new Employee{Name="Mariam" , Salary=20000},
            //    new Employee{Name="Nada" , Salary=25000},
            //    new Employee{Name="Malak" , Salary=15000},
            //    new Employee{Name="sara" , Salary=7000}
            //};

            //SortingAlgorithm<Employee>.Sort(arrayOfEmps);

            //foreach (Employee emp in arrayOfEmps)
            //{
            //    Console.WriteLine(emp);
            //}
            ////using a generic sort is better than a normal sort as it can be used for different datatypes 
            #endregion

            #region Problem 2 testing
            //int[] arr = { 2, 6, 3, 9, 1, 0 };

            //SortingTwo<int>.Sort(arr, (x, y) => x < y);
            //foreach(int x in arr)
            //{
            //    Console.WriteLine(x);
            //}
            ////lambda expressions improve flexibility bec. it makes changing the implementation alot easier without changing the actual method code
            ////it also improve readability bec it lets you write the sorting rule directly in a simple,clear expression without needing a separate method 
            #endregion

            #region Problem 3 testing
            //string[] arrOfStrings = { "Mariam", "Ayman", "sara", "sam", "mohammed" };
            //SortingTwo<string>.Sort(arrOfStrings , (x,y) => x.Length >  y.Length);

            //foreach(string str in arrOfStrings)
            //{
            //    Console.WriteLine(str);
            //}
            ////dynamic comparator function makes the sorting method reusable for different datatypes and different sorting rules (like we did in this problem and the previous one with the exact same method) 
            #endregion

            #region Problem 4 testing
            //Manager[] managersArr =
            //{
            //    new Manager{Name="Mariam" , Salary=50000 },
            //    new Manager{Name="Mai" , Salary=20000 },
            //    new Manager{Name="Nadin" , Salary=30000 }
            //};

            //SortingTwo<Manager>.Sort(managersArr , (x,y)=> x.Salary > y.Salary);

            //foreach (Manager manager in managersArr)
            //{
            //    Console.WriteLine(manager);
            //}
            ////implementing Icomparable lets the class define its own default CompareTo implementation 
            #endregion

            #region Problem 5 testing
            //Employee[] employees =
            //{
            //    new Employee{Name="Mariam" , Salary=20000},
            //    new Employee{Name="Nada" , Salary=25000},
            //    new Employee{Name="Malak" , Salary=15000},
            //    new Employee{Name="sara" , Salary=7000}
            //};

            //SortingTwo<Employee>.Sort(employees, (x,y)=> x.Name.Length< y.Name.Length);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}
            //// using built-in delegates like Func<T, T, TResult> in generic programming is better than creating your own declaration each time 
            #endregion

            #region Problem 6 testing <-
            //int[] numbers = { 2, 6, 3, 9, 1, 0 };

            ////the anonymous function
            //SortingTwo<int>.Sort(numbers, delegate (int x, int y)
            //{
            //    return x > y;
            //});

            //foreach (int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            ////the lambda expression
            //SortingTwo<int>.Sort(numbers, (x, y) => x > y);

            //foreach (int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            ////anonymous function is longer, lambda is shorter and more readable (both have same performance) 
            #endregion

            #region Problem 7 testing
            //int[] arr = { 1, 2, 3, 4, 5, 6};
            //SortingAlgorithm<int>.Swap(ref arr[0], ref arr[5]); 

            //foreach (int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            ////generic methods are beneficial bec of the type safety 
            #endregion

            #region Problem 8 testing
            //Employee[] arr =
            //{
            //    new Employee{Name="Mariam" , Salary=20000},
            //    new Employee{Name="Nada" , Salary=25000},
            //    new Employee{Name="Malak" , Salary=15000},
            //    new Employee{Name="sara" , Salary=7000},
            //    new Employee{Name="marihan" , Salary=20000}
            //};

            //SortingTwo<Employee>.Sort(arr, (x, y) =>
            //{
            //    if (x.CompareTo(y) != 0)
            //    {
            //        return x.Salary < y.Salary;
            //    }
            //    else
            //    {
            //        return x.Name.Length < y.Name.Length;
            //    }
            //});

            //foreach (Employee emp in arr)
            //{
            //    Console.WriteLine(emp);
            //}
            ////Multi-criteria sorting makes a generic method much more flexible and reusable, but the comparison logic becomes more complex (especially when handling ties)  
            #endregion

            #region Problem 9 testing
            //Program p = new Program();
            //Console.WriteLine(p.GetDefault<int>());

            //Console.WriteLine(p.GetDefault<string>());
            ////default(T) gives the default value for the given datatype 
            #endregion

            #region Problem 10 testing
            //Employee emp1 = new Employee
            //{
            //    Name = "Mariam",
            //    Salary = 100000
            //};

            //Employee emp2 = (Employee)emp1.Clone();

            //Console.WriteLine(emp1);
            //Console.WriteLine(emp2);
            ////Constraints restrict generic types to valid types, ensuring type safety and preventing invalid types at compile time 
            #endregion

            #region Problem 11 testing
            //List<string> items = new List<string> { "mariam", "ayman", "nadin" };

            //List<string> upper = TransFormList(items , x => x.ToUpper());   //wrote method name directly without class name bec. it is a static method in the same class

            //foreach (string str in upper)
            //{
            //    Console.WriteLine(str);
            //}
            //// benefits of using delegates for string transformations in a functional programming style to make it reusable in many cases without the need to make another method to change only one line 
            #endregion

            #region Problem 12 testing
            //int num1=4, num2=3;
            //int multiplication = OperationOnTwoIntegers(num1, num2, (num1, num2) => num1 * num2);
            //Console.WriteLine(multiplication);

            //int sum = OperationOnTwoIntegers(num1 , num2 , (num1, num2) => num1 + num2);
            //Console.WriteLine(sum);
            ////delegates promote code reusability and flexibility in implementing mathematical operations bec u can apply different mathematical operations using the same method without the need to change anything in it  
            #endregion

            #region Problem 13 testing
            //List<int> list= new List<int>{1,2,3,4,5};
            //List<string> strArr = ChangeListType(list, x => x.ToString());

            //foreach (string str in strArr)
            //{
            //    Console.WriteLine(str);
            //    Console.WriteLine(str.GetType());
            //}
            ////advantages of using generic delegates in transforming data structures : transform from one type to another freely 
            #endregion

            #region Problem 14 testing
            //List<int> numbers = new List<int> { 1 , 2, 3 };

            //List<int> result = Power(numbers , num => num * num);

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            ////Func is a builtin delegate that takes 0:16 inputs and it must return (last type is always the return type) 
            #endregion

            #region Problem 15 testing
            //List<string> list = new List<string> { "mariam", "Ayman", "Nadon" };
            //Print(list , str => Console.WriteLine(str));

            ////Action is preferred for operations that do not return values bec. its return type is void (not like the other 2 built in delegates) 
            #endregion

            #region Problem 16 testing
            //List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            //List<int> result = IsEven(nums, x => x % 2 == 0);

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            ////Predicate: built in delegate that takes only one variable and it always return bool 
            #endregion

            #region Problem 17 testing
            //List<string> strings = new List<string> { "Mariam", "Ayman", "Malak", "Mohammed", "salem" };
            //List<string> m = Filter(strings, x =>
            //{
            //    return x.StartsWith("M");
            //});

            //foreach (string str in m)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine();

            //List<string> result = Filter(strings, x =>
            //{
            //    return x.Contains("Ma");
            //});

            //foreach (string str in result)
            //{
            //    Console.WriteLine(str);
            //}
            //// anonymous functions improve code modularity and customization by defining inline logic without needing a separate method name 
            #endregion

            #region Problem 18 testing
            //int n1=2, n2=3;
            //int addition = Operation(n1 , n2 , (x,y) =>
            //{
            //    return x + y;
            //});
            //Console.WriteLine(addition);

            //int subtraction = Operation(n1, n2, (x, y) =>
            //{
            //    return x - y;
            //});
            //Console.WriteLine(subtraction);

            //int multiplication = Operation(n1, n2, (x, y) =>
            //{
            //    return x * y;
            //});
            //Console.WriteLine(multiplication);
            ///*u should prefer anonymous functions over named methods in implementing mathematical operations 
            //   if you want to perform more than one mathematical operation using the same method withod changing it or creating another one
            //*/ 
            #endregion

            #region Problem 19 testing
            //List<string> strings = new List<string> { "mariam", "Ayman", "nadin", "malak" };
            //List<string> result = FilterCondition(strings, x => x.Length > 5);

            //foreach(string str in result)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine();

            //List<string> list2 = FilterCondition(strings, x => x.Contains("i"));

            //foreach(string str in list2)
            //{
            //    Console.WriteLine(str);
            //}
            ////lambda expressions are essential bec they provide an easy and readable way to write anonymous functions 
            #endregion

            #region Problem 20 testing
            //double n1 = 2.4, n2 = 2.2;
            //double division = Operation(n1, n2, (x, y) => x / y);
            //Console.WriteLine(division);

            //double power= Operation(n1 , n2 , (x, y) => Math.Pow(x, y));
            //Console.WriteLine(power);
            ////lambda expression enhance expressiveness by allowing inline mathematical operations without the need to change in the actual function 
            #endregion
        }
    }
}
