using LinqDemo;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using static LinqDemo.ListGenerator;


namespace LinQ_Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Var
            #region C#-Keyword [Var]  
            // //C# Keywords: Implicitly type Local Variable [var - dynamic]

            // //var
            //  var Data01 = "Ahmed";// compiler will detect Datatype of local
            ////in this ex the var is string       // variable based on initial variable ("Ahmed")

            // var x = 12; // in this ex tge var is int

            // //var x; //Invalid

            //// var X = null;// Invalid // cannot initialize local variable with null

            // //Var is not datatype (cannot use it in function) or return type 
            #endregion

            //dynamic
            #region C#-Keyword [Dynamic]  
            // dynamic Data02 = "Ahmed";//like var in JS

            // //CLR will Detect Datatype of local variable based on last value ,at runtime

            // Data02 = 12;

            // Data02 = 'a';
            // Data02 = 1.2;

            // //here Data02 will be the last value (1.2)

            //// dynamic x;// Valid // donot need to be initialize

            //// dynamic y = null; //can initialize variable with null

            //// Console.WriteLine(Data02);// 1.2
            //// Console.WriteLine(Data02.GetType.Name);// double //print datatype of last variable

            // //deal with dynamic as an object
            // //becareful when using dynamic keyword 
            #endregion

            //Extension Method
            #region Extension Method  
            // int number = 6734218; // want to reverse it to 54321
            // int Result= InrExtension.Reverse(number);
            //var Result = number.Reverse();
            // Console.WriteLine(Result);

            //Extension method should be in satic class 
            #endregion

            //Anonymous Type

            #region Anonymous Type  
            //var Emp01 = new { Id = 1, Name = "Ahmed", Salary = 12000 };// Anonymous Type
            //var Emp02 = new { Id = 2, Name = "Ali", Salary = 10000 };
            ////class use one time only so can use Anonymous type
            //Console.WriteLine(Emp01);//compiler will print it

            //Console.WriteLine(Emp01.GetType().Name);// its type is Anonymous type

            //// Emp01.Id = 12;//Invalid - Immutable datatype - cannot change its value============

            //Emp02 = Emp01 with { Id = 12 }; //New Feature C# 10.0
            //Console.WriteLine(Emp01);
            //Console.WriteLine(Emp02);

            //if (Emp01.Equals(Emp02))// compare reference
            //{
            //    Console.WriteLine("equals");
            //}
            //else
            //{
            //    Console.WriteLine("!equals");
            //} 
            #endregion

            //LinQ - (Language Integrated Query)
            #region LinQ Fluent Syntax (Method Syntax)        
            ////unified syntax , type safety as using(Var)
            ////    : +40 Extension Methods in Interface:IEnumerable (LinQ Operators) using Against Any Data [Data in Sequence] 
            ////  LinQ Operator  :13 Category                                               //Regardless Data Store(sql,postgre,MySql)
            ////    : LinQ Operators Exists Class "Enumerable"

            //// Sequence :Object From Class Implment Interface "IEnumerable"

            ////Local Sequence: (L2O) LinQ to Object ,LinQ to XML (xml file store customer data for ex)
            ////Remote Sequence:(L2EF) LinQ to EF(Entity Framwork)(bridge from App and Database)

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, };//Local Sequence
            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);//2,4,6
            //}


            //List<int> oddNumbers = Numbers.Where(x => x % 2 == 1).ToList();
            //foreach (var item in oddNumbers) 
            //    Console.WriteLine(item); 
            #endregion


            //Query Syntax - another way in syntax like sql
            #region Query Syntax
            ////Query Expression => Like Sql Query
            ////start with "from"
            ////Introduce range variable (x) => represent each element in the sequence
            ////End with "select" or "group by"

            ////select Name
            ////from Student
            ////where Id=10

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, };//Local Sequence

            //var oddNumbers = from x in Numbers
            //                 where x %2==1
            //                 select x;
            //foreach( int item in oddNumbers ) Console.WriteLine(item); 
            #endregion

            #region LinQ Exectution ways   

            //every LinQ operators work Differed except 3 categories
            #region Differed Exectution 

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, };//Local Sequence
            //var oddNumbers = Numbers.Where(x => x % 2 == 1);
            //Numbers.AddRange([10,11,12,13,14,15,16,17,18,19,20]);

            //foreach(int item in oddNumbers) Console.WriteLine(item);//till odd number get executed will run every line
            //                                                        //between the odd number creation and the print

            #endregion

            //other way of executuion the other 3 categories using it
            #region Immediate Exectution  

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, };

            //var oddNumbers = Numbers.Where(x => x % 2 == 1);//===

            //Numbers.AddRange([10, 11, 12, 13, 14, 15]);

            //foreach (var item in oddNumbers) Console.WriteLine(item);// Immediate execution: will execute the line 
            //                                                         //  of oddnumber creation will run immediatly and ignore
            //                                                         //  any lines betweenthe creation and the print line


            #endregion

            #endregion

            Console.WriteLine(ListGenerator.ProductList[0]);
            Console.WriteLine(ListGenerator.CustomerList[0]);

        }
    }
}
