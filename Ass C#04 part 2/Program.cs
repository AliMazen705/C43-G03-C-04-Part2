namespace Ass_C_04_part_2
{
    internal class Program
    {
        #region Function q1
        //// 1- Passing by Value
        //static void update(int x)
        //{
        //    x = 20;
        //}
        //// 1- Passing by Referenc
        //static void updatere(ref int x)
        //{
        //    x = 20; // Modifies the original variable directly
        //}
        #endregion

        #region Function q2
        ////1- Passing by Value
        //static void update(Person p)
        //{
        //    p.Name = "Ali";
        //    p = new Person { Name = "Mazrn" }; 
        //}
        //// 1- Passing by Referenc
        //static void updatere(ref Person p)
        //{
        //    p.Name = "Ali"; 
        //    p = new Person { Name = "Mazen" };  
        //}
        #endregion

        #region Function q3 
        //static void calculator(int sum1, int sum2, int sub1, int sub2)
        //{
        //    int sum = sum1 + sum2;
        //    int sub = sub1 - sub2;
        //    Console.WriteLine($"Sum of first two numbers: {sum}");
        //    Console.WriteLine($"Difference of last two numbers: {sub}");

        //}
        #endregion

        #region Function  q4
        //static int sumDigits(int n)
        //{
        //    int sum = 0;
        //    while (n != 0)
        //    {
        //        sum += n % 10; // sum = 0 + 25 % 10 --> (sum = 5)first digit  , sum = 5 + 2 % 10 = 5 + 2 = 7
        //        n /= 10;       // n = 2      ,  n = 2 / 10 = 0.2  (n = 0)
        //    }
        //    return sum;
        //}
        #endregion

        #region Function q5
        //static bool IsPrime(int num)
        //{
        //    if (num <= 1)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(num); i++)
        //    {
        //        if (num % i == 0)
        //            return false; 
        //    }

        //    return true;
        //}
        #endregion

        #region Function q6
        //static void MinMaxArray(int[] numbers, ref int min, ref int max)
        //{

        //    min = numbers[0];
        //    max = numbers[0];


        //    for (int i = 1; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] < min)
        //        {
        //            min = numbers[i];
        //        }
        //        if (numbers[i] > max)
        //        {
        //            max = numbers[i];
        //        }
        //    }
        //}
        #endregion

        #region Function q7
        //static long CalculateFactorial(int number)
        //{
        //    long factorial = 1; // نبدأ من 1 لأن الضرب في 0 يعطينا 0

        //    for (int i = 1; i <= number; i++)
        //    {
        //        factorial *= i; // نضرب كل رقم في النتيجة السابقة
        //    }

        //    return factorial; // إرجاع النتيجة النهائية
        //}

        #endregion

        #region Function q8
        static string ChangeChar(string input, int position, char newChar)
        {

            if (position < 0 || position >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(position), "Position is out of range.");
            }


            char[] charArray = input.ToCharArray();


            charArray[position] = newChar;

            return new string(charArray);
        }
        #endregion

        static void Main(string[] args)
        {
            #region Functions 

            #region q1
            //// 1- Passing by Value:
            ////copy of the argument's value is passed to the method. The method works with this copy,
            ////and any changes made to the parameter inside the method do not affect the original
            ////variable outside the method
            //int num = 10;
            //update(num);
            //Console.WriteLine(num);  //Not Changes (num = 5)

            //// 2- Passing by Reference:
            ////the memory address of the original variable is passed to the method.
            ////This means that any changes made to the parameter inside the method will
            ////affect the original variable outside the method.

            //updatere(ref num);
            //Console.WriteLine(num); // output(num = 20)

            #endregion

            #region q2
            ////1- Passing Reference Type by Value
            //// a copy of the reference (i.e., memory address) is passed to the method.
            //// However, the method still works with the same object in memory.

            ////any changes made to the object's fields/properties inside the method will
            ////affect the original object. However, reassigning the reference to a new object
            ////inside the method does not affect the original reference outside the method
            ////EX:
            //Person person = new Person { Name = "Ahmed" };
            //update(person);
            //Console.WriteLine("Person's Name after method call: " + person.Name);

            ////2- Passing Reference Type by Reference:
            //// the method receives the memory address of the original object.
            //// This means the method can modify the original reference itself,
            //// not just the object it points to.
            //// and will affect the original variable in the calling method
            //Person personO1 = new Person { Name = "Ahmed" };
            //updatere(ref personO1); 
            //Console.WriteLine("Person's Name after method call: " + person.Name);

            #endregion

            #region q3
            //Console.WriteLine("Enter 4 Numbers ");
            //Console.WriteLine("Sum of first two numbers\nDifference of last two numbers\n");
            //Console.Write("Enter The 1st Number: ");
            //int.TryParse(Console.ReadLine(), out int num1);
            //Console.Write("Enter The 2nd Number: ");
            //int.TryParse(Console.ReadLine(), out int num2);
            //Console.Write("Enter The 3rd Number: ");
            //int.TryParse(Console.ReadLine(), out int num3);
            //Console.Write("Enter The 4th Number: ");
            //int.TryParse(Console.ReadLine(), out int num4);

            //calculator(num1, num2, num3, num4);
            #endregion

            #region q4
            //Console.Write("Enter A Number: ");
            //int.TryParse(Console.ReadLine(), out int sum);
            //Console.WriteLine($"The Sum Of The Digits Of The Number {sum}: {sumDigits(sum)}");
            #endregion

            #region q5
            //Console.Write("Enter A Number: ");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine(IsPrime(num));
            #endregion

            #region q6
            //int[] array = { 10, 3, 25, 7, 15, 2, 30 };


            //int min = 0, max = 0;



            //MinMaxArray(array, ref min, ref max);


            //Console.WriteLine("Array Elements: " + string.Join(", ", array));
            //Console.WriteLine("Minimum Value: " + min);
            //Console.WriteLine("Maximum Value: " + max);
            #endregion

            #region q7
            //Console.Write("Enter a number to calculate its factorial: ");
            //int num = Convert.ToInt32(Console.ReadLine());


            //if (num < 0)
            //{
            //    Console.WriteLine("Factorial is not defined for negative numbers.");
            //}
            //else
            //{

            //    long result = CalculateFactorial(num);


            //    Console.WriteLine($"The factorial of {num} is: {result}");
            //}
            #endregion

            #region q8
            //Console.Write("Enter a string: ");
            //string inputString = Console.ReadLine();

             
            //Console.Write("Enter the position of the letter to replace (0-based index): ");
            //int position = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the new character: ");
            //char newChar = Convert.ToChar(Console.ReadLine());

            //try
            //{
              
            //    string result = ChangeChar(inputString, position, newChar);

                
            //    Console.WriteLine("The modified string is: " + result);
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}
            #endregion












        }

    }
}
