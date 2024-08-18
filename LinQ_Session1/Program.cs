using LinqDemo;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml.Linq;
using static LinqDemo.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;


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



            // using where
            #region Filtration Category
            #region EX: Get product out of stock   
            //Get product out of stock
            //Fluent syntax
            // var Result = ProductList.Where(p => p.UnitsInStock == 0);//means get the product out of stock


            // Query Syntax

            //Result= from p in ProductList
            //        where p.UnitsInStock == 0
            //        select p;


            //foreach (var item in Result) 
            //    Console.WriteLine(item); 
            #endregion

            #region EX.2
            ////fluent syntax
            //var Result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry");

            ////Query Syntax
            //Result = from p in ProductList
            //         where p.UnitsInStock > 0 && p.Category == "Meat/Poultry"
            //         select p; 
            #endregion

            //Indexed Where
            #region EX3. get elements in first 10 elements  
            //using indexed where

            //var Result = ProductList.Where((p, i) => i < 10 && p.UnitsInStock == 0);
            ////search in first 10 elements only
            ////Indexed where is Valid with Fluent Symtax , can not Written using Query Syntax 
            #endregion

            #endregion

            //using select
            #region Transformation Category  

            #region EX1:Select ProductName
            ////Select Name

            ////Fluent Syntax
            ////  var Result = ProductList.Select(p => p.ProductName);

            ////Query Syntax
            //var Result = from p in ProductList  //to get priduct name
            //             select p.ProductName;


            //foreach (var item in Result) Console.WriteLine(item); 
            #endregion

            #region EX2: Select CustomerName
            //Fluent Syntax
            //var Result = CustomerList.Select(c => c.CustomerName);

            ////Query Syntax
            //Result = from c in CustomerList
            //         select c.CustomerName; 
            #endregion

            #region EX#: select Customer Orders
            //Fluent Syntax
            //var Result = CustomerList.SelectMany(c => c.Orders);

            //Query Syntax
            //var Result = from c in CustomerList               // select Many when select element from array
            //             from o in c.Orders
            //             select o;
            //foreach (var result in Result) Console.WriteLine(result); 
            #endregion

            #region EX4: Select ProductID & ProductName  
            // //Fluent Syntax
            // var Result = ProductList.Select(p => new  { ProductID = p.ProductID, ProductName = p.ProductName });
            // //use Anonymous type to view only the ID and Name


            // //Query Syntax
            //var Result02= from p in ProductList
            //         select new
            //         {
            //             ProductID = p.ProductID,
            //             ProductName = p.ProductName,
            //         };

            // foreach (var Product in Result)
            // {
            //     Console.WriteLine(Product);

            // } 
            #endregion

            #region EX5: select prod in stock and dis 10% on price  

            //Fluent Syntax
            //var Result = ProductList.Where(p => p.UnitsInStock > 0)
            //                         .Select(p => new
            //                         {
            //                             Id = p.ProductID,
            //                             Name = p.ProductName,
            //                             OldPrice = p.UnitPrice,
            //                             NewPrice = p.UnitPrice - (p.UnitPrice * 0.1M)

            //                         });

            //Query Syntax
            //var Result = from p in ProductList
            //             where p.UnitsInStock > 0
            //             select new
            //             {
            //                 Id = p.ProductID,
            //                 Name = p.ProductName,
            //                 oldPrice = p.UnitPrice,
            //                 NewPrice = p.UnitPrice - (p.UnitPrice * 0.1M),

            //             };

            // foreach (var Item in Result) Console.WriteLine(Item);


            #endregion


            //Indexed Select => valid only with Fluent Syntax
            #region Indexed Select
            //var Result = ProductList.Where(p => p.UnitsInStock > 0)
            //                        .Select((p, i) => new
            //                        {
            //                          Index = i,
            //                          Name = p.ProductName 


            //                        }); 
            #endregion

            #endregion

            #region Ordering Operator 
            //Asc - Desc - thenby - Reverse
            //get products ordered by Asc

            #region EX01: get products ordered by Asc  
            ////Fluent Syntax
            //var Result = ProductList.OrderBy(p => p.UnitPrice);// Ascending order

            ////Query Syntax
            //Result = from p in ProductList
            //         orderby p.UnitPrice
            //         select p; 
            #endregion


            #region EX02: get products ordered by Desc 

            ////Fluent Syntax
            //var Result = ProductList.OrderByDescending(p => p.UnitPrice);//descending order

            ////Query Syntax

            //Result = from p in ProductList
            //         orderby p.UnitPrice descending
            //         select p;

            #endregion


            #region EX03: Get ordered by price and number of items in stock  

            //  var Result = ProductList.OrderBy(p => p.UnitPrice).ThenBy(p => p.UnitsInStock);

            // var Result = ProductList.Where(p=> p.UnitsInStock==0).Reverse();

            #endregion


            #endregion

            #region Element Operator - Immediate Execution  

            ////First       =  FirstorDefault
            //var Result = ProductList.First();//get first element at sequence

            ////Last       = LastorDefault
            //Result = ProductList.Last();

            ////check nullable value
            //Console.WriteLine(Result?.ProductName ?? "NotFound");

            // var Result = ProductList.First(p=> p.UnitsInStock ==0);//get first element match the condition
            // Result = ProductList.Last(p => p.UnitsInStock == 0);//get last element match the condition

            //ElementAt        = ElementorDefault
            // var Result = ProductList.ElementAt(0);// get element at specific index

            //single           = SingleOrDefault
            //===> get if index has one element only (if more element will throw exception)


            #endregion

            #region Aggregate operators - Immediate Execution  
            #region Count 
            //var Result = ProductList.Count;//List property get the count of elements
            //Result = ProductList.Count(p => p.UnitsInStock ==0);// LinQ Operator ==> return number of elements match the condition 
            #endregion

            //var Result = ProductList.Max();// at least one object implement ICompareable.
            //product Must be Implement Interface ICompareable

            //var MaxLength = ProductList.Max(p=> p.ProductName.Length);

            //var Result =( from p in ProductList
            //             where p.ProductName.Length < MaxLength
            //             select p).FirstOrDefault();// get the first element match this condition


            ////sum
            //var sum = ProductList.Sum(p => p.UnitPrice);// sum of all price 

            ////Average
            //var average = ProductList.Average(p => p.UnitPrice);//get the average of prices

            //string[] Names = { "Aya", "Omar", "Amr", "mohamed" };

            //var Result = Names.Aggregate((str1, str2) => $"{str1} {str2}");// will add all in the array
            //                                                               // in Result variable
            //Console.WriteLine(Result);


            #endregion

            #region Casting Operator - Immediate Execution   
            // //ToList()
            // //List<Product> Result =  ProductList.Where(p => p.UnitsInStock == 0).ToList();

            // //ToArray()
            // // Product[] Result = ProductList.Where(p => p.UnitsInStock == 0).ToArray();//casting to Array

            // //ToDictionary()
            // // Dictionary<long,Product> Result = ProductList.Where(p => p.UnitsInStock == 0).ToDictionary(p=>p.ProductID);

            // //ToHashSet()
            // // HashSet<Product> Result = ProductList.Where(p => p.UnitsInStock == 0).ToHashSet();

            // //ToLookup()===> ILookup
            //// ILookup<long,Product> Result = ProductList.Where(p => p.UnitsInStock == 0).ToLookup(p=>p.ProductID);


            // foreach (var item in Result) Console.WriteLine(item); 
            #endregion

            #region Generation Operators - Differed Execution  
            //valid only with Fluent Syntax
            //the only way to call them is as static Method from class Enumerable(Enumerable.  )

            //Enumerable.Range
            // var Result = Enumerable.Range(0, 100);// print numbers from 0 - 99

            //Enumerable.Repeat
            // var Result = Enumerable.Repeat(new Product(), 100); //print 100 nullable product readings

            //Enumerable.Empty
            // var arrayProduct = Enumerable.Empty<Product>().ToArray();//return empty array
            //Product[]= new Product[0]; also will return empty array


            //var Result= Enumerable.Empty<Product>().ToList();//return empty list
            // List<Product> products = new List<Product>();//both return empty list


            // foreach (var item in Result) Console.WriteLine(item);
            #endregion

            #region Set operators - Differed Execution  
            //Union Family (union - UnionAll - Concat -Distinct)
            // var seq01 = Enumerable.Range(0, 100);// 0-99
            //  var seq02 = Enumerable.Range(50, 100);//50-149


            //Union ===========================
            // var Result=seq01.Union(seq02);//print from  0 -149 without duplicating

            //Concat ============================
            // var Result = seq01.Union(seq02);//print with duplication Like (UnionAll)


            //Distinct =======================
            //  Result = Result.Distinct();//Remove Duplicating


            //Intersect ========================================
            // var Result = seq01.Intersect(seq02);// 50 -99 // get the sharing data

            //Except      ========================
            //var Result = seq01.Except(seq02);//return elements in 1st sequence  and not exist in 2nd  sequence

            //foreach (var item in Result) Console.WriteLine(item);

            #endregion

            #region Quantifier Operators(return Boolean) - Differed Execution 
            //Any  => (if Any element match the condition return Boolean
            // var Result=ProductList.Any();//if sequence contain one element => true

            // Result = ProductList.Any(x => x.UnitsInStock == 0);//if at least one element
            // match the condition => True

            //All =============================================
            // var Result = ProductList.All(p=>p.UnitsInStock==0);//if All elements match the contion return Boolean

            //SequenceEqual

            //var seq01 = Enumerable.Range(0, 100);// 0-99
            //var seq02 = Enumerable.Range(50, 100);//50-149

            //var Result = seq01.SequenceEqual( seq02);// check if the elements equal the in both sequences are equal
            //Console.WriteLine(Result);


            #endregion

            #region Zip Operator - Differed Execution

            //produce a sequence with elements from the two or three specific sequences

            //string[] Names = { "omar", "Amr", "Ahmed", "May" };
            //int[] Numbers = Enumerable.Range(1,10).ToArray();
            //char[] chars = { 'a', 'b', 'c', 'd', 'e' };

            //// var Result = Names.Zip(Numbers);
            ////(omar , 1)
            ////(Amr , 2)
            ////(Ahmed, 3)
            ////(May ,4)

            //var Result = Names.Zip(Numbers,chars);
            ////(omar, 1,a)
            ////(Amr, 2,b)
            ////(Ahmed, 3,c)
            ////(May,4,d)

            //foreach (var item in Result) Console.WriteLine(item);


            #endregion

            #region Grouping Operators
            //groupBy
            //  var Result= ProductList.GroupBy(p => p.Category);//in category (key , value)

            //===========================================================

            //Query Syntax
            //var Result = from p in ProductList
            //          where p.UnitsInStock >0
            //          group p by p.Category
            //          into Category
            //          where Category.Count() >10
            //          select new { CategoryName = Category.Key, CountOfCategory = Category.Count() };

            // foreach(var item  in Result) Console.WriteLine(item);
            //=====================================================================================
            //Fluent Syntax
            //var Result = ProductList.Where(p => p.UnitsInStock > 0)
            //                        .GroupBy(p => p.Category)
            //                        .OrderBYDescending(c=>c.Count())
            //                        .Where(c => c.Count() > 10)
            //                        .Select(c => new { CategoryName = c.Key, CountOfCategory = c.Count() });

            //==================================================================================

            //foreach (var category in Result)
            //{
            //    Console.WriteLine(category.Key);
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"...{product}");
            //    }
            //}

            #endregion

            #region Partionining Operator - Differed Execution 
            //Take
            //var Result = ProductList.Take(10);// take number of element from first only

            //Result = ProductList.Where(p=>p.UnitsInStock >0).Take(5);//get the elements match the
            //                                                         //condition the first 5 takes only

            ////TakeLast
            //Result = ProductList.Where(p => p.UnitsInStock > 0).TakeLast(5);//get the last 5 elements
            //                                                                //match the condition

            ////skip
            //Result = ProductList.Where(p => p.UnitsInStock ==0).Skip(5);//get all elements match the condition
            //                                                            //then skip the first 5 readings
            //                                                            //

            ////SkipLast
            //Result = ProductList.Where(p => p.UnitsInStock == 0).SkipLast(5);//get all elements match the condition
            //                                                                 //then skip the Last 5 readings

            // Result = ProductList.Take(10).Skip(10);//take the first 10 elements then skip the second 10 elements


            //TakeWhile
            //===> a loop is working till condition turn false
            // int[] Numbers = { 5, 4, 3, 1, 9, 8, 7, 2 };

            // =============================================
            // var Result = Numbers.TakeWhile(num => num < 9);//print (5,4,3,1) till 9<9 is false
            //so the loop will stop

            // //there other  overload for take while to take 2 parameters
            // var Result = Numbers.TakeWhile((num,i)=>num>i);// the loop will stop till the condition turn false


            //skip while===> a loop when condition is true will (skip)
            //till the condition turn false so loop stop

            // var Result = Numbers.SkipWhile(num=>num %3 !=0);

            //  foreach (var item in Result) Console.WriteLine(item);


            #endregion

            #region Let And Into [Valid only with Query Syntax]  

            //using System.Text.RegularExpressions;
           // List<string> Names = new List<string>() { "Omar", "Ali", "Amr", "Saly" };

           // var Result = from n in Names
           //              select Regex.Replace(n, "[AOUIEaouie]", string.Empty)// replace the vowl letters
           //               into NoVowelName                                     // with empty string
           //              where NoVowelName.Length > 3
           //              select NoVowelName;
           // //Into => Restart Query with Introducing  a new  Range Variable : NovowelName
           // //into use it if u want to continue ur query
           ////==========================================================
           // //Let => Continue Query with Adding New Range Variable 
           // Result = from n in Names
           //          let NoVowelName = Regex.Replace(n, "[AOUIEaouie]", string.Empty)
           //          where NoVowelName.Length > 3
           //          select NoVowelName;
            #endregion
        }
    }
    
}
