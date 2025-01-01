namespace Ass05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region q1


            //Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            /*
             -->in the passing by value we take the copy from the orginal variable not take the original value so when change in the value 
                that not effect on the orginal 
                example 


            -->in the passing by reference we take the address the orignal varable and chang it 


            */
            //static void ByValueFunction(int x)
            //{
            //    x++;
            //    Console.WriteLine(x);

            //}

            //static void  ByReferenceFuction(ref int x)
            //{
            //    x++;    
            //    Console.WriteLine(x);
            //}

            //int c = 5;

            //Console.WriteLine($"the orginal value before pass by value:{c}");
            //ByValueFunction(c);
            //Console.WriteLine($"the orginal after  pass by value:{c}");



            //Console.WriteLine($"the orginal value before pass by reference : {c}");
            //ByReferenceFuction(ref c);
            //Console.WriteLine($"the orginal value after pass by reference : {c}");






            #endregion


            #region Q2
            /*
             * Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

             */


            //static void ModifyByValue(MyClass obj)
            //{
            //    obj.value = 20; 
            //    obj = new MyClass { value = 30 }; 
            //}


            //// Passing by Value
            //MyClass originalByValue = new MyClass { value = 10 };
            //ModifyByValue(originalByValue);
            //Console.WriteLine($"Passing by Value: {originalByValue.value}"); // Output: 20



            //static void ModifyByReference(ref MyClass obj)
            //{
            //    obj.value = 50;
            //    obj = new MyClass { value = 40 };


            //}




            ////passing by reference


            //MyClass originalByReference = new MyClass { value = 10 };
            //ModifyByReference(ref originalByReference);
            //Console.WriteLine($"Passing by reference:{originalByReference.value}");












            #endregion


            #region Q3

            //Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //static void calculate(int a, int b ,int c ,int d ,out int sum ,out int difference)
            //{

            //    sum = a + b;
            //    difference = d - c;



            //}


            //Console.WriteLine("enter the foure parameter ");
            //int x=int.Parse(Console.ReadLine());
            //int y=int.Parse(Console.ReadLine());
            //int z=int.Parse(Console.ReadLine());
            //int v=int.Parse(Console.ReadLine());

            //int sum, sub;
            //calculate(v,x,y,z,out sum,out sub);

            //Console.WriteLine($"the sum is: {sum} and the subtract is :{sub}");

            #endregion


            #region Q4


            /*
             Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        Output should be like 
        Enter a number: 25                                                                                            
        The sum of the digits of the number 25 is: 7

*/

            //static int sumDigit(int num)
            //{
            //    int sum = 0;
            //    while (num > 0)
            //    {

            //        sum = sum + num % 10;
            //        num = num / 10;


            //    }


            //    return sum;
            //}

            //Console.WriteLine("enter the number");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine(sumDigit(x));





            #endregion


            #region Q5
            //Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:


            //static void IsPrime(int num)
            //{
            //    int counter = 0;
            //    for (int i = 1; i <= num; i++)
            //    {

            //        if (num % i == 0)
            //        {
            //            counter++;
            //        }

            //    }

            //    if (counter == 2)
            //    {
            //        Console.WriteLine("it is prime number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("is not prime");
            //    }

            //}



            //Console.WriteLine("enter the nnumber");
            //int num =int.Parse(Console.ReadLine()); 

            //IsPrime(num);

            #endregion



            #region Q6


            //Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //static void  getMaxMinNum(int[] arr,ref int max ,ref int min)
            //{
            //    max = arr[0];
            //    min = arr[0];

            //    foreach (int i in arr)
            //    {
            //        if(i > max)
            //        {
            //            max = i;
            //        }
            //        if (i < min)
            //        {
            //            min= i;
            //        }





            //    }

            //}


            //int[] arr = { 10, 20, 60, 40, 30, 90 };

            //int max = 0;
            //int min = 0;

            //getMaxMinNum(arr, ref max, ref min);

            //Console.WriteLine($"the max: {max},and the min : {min }");  
            #endregion



            #region Q7


            //static long GetFactorial(int num)
            //{

            //    int factorial = 1;

            //    if (num == 0 || num == 1)
            //    {
            //        return 1;
            //    }
            //    else
            //    {
            //        for (int i = 1; i <= num; i++)
            //        {
            //            factorial *= i;
            //        }

            //    }

            //    return factorial;



            //}



            //Console.WriteLine("enter the number");
            //int n=int.Parse(Console.ReadLine());

            //Console.WriteLine($"the factorial is : {GetFactorial(n)}");



            #endregion
        }
    }
}
