using System.Diagnostics;

namespace Demo
{
    internal class Program
    {
        //static function (class member function)
        //object member function
        public static void Swap(ref int X,ref int Y)
            //هخليها ref///////
        {
            int temp = X;
            X = Y;
            Y = X;
        }
        public static void SumMul(int X,int Y, out int Sum ,out int Mul)
        {
            Sum = Y+X;
            Mul = Y*X;
        }
        public static int SumArray(params int[] Arr)
        {//params اللي هو اني ادخل االارقام عادي علي طول من غير ما اعرفها
            int sum = 0;
            if (Arr is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    sum += Arr[i]; //sum =sum + arr[i]

                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region judged array
            // judged array =>array of array
            //int[][] Numbers = new int[3][];
            //Numbers[0]=new int[] {1,2,3 };
            //Numbers[1] = new int[] { 4,5};
            //Numbers[2] = new int []{ 6};
            //for (int i = 0; i<Numbers.Length; i++)
            //{
            //    for (int j = 0; j < Numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(Numbers[i][j]);
            //    }
            //}


            #endregion
            #region Passing By Value
            //int A = 5; int B = 6;
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Swap(ref A, ref B);
            //Console.WriteLine(A);
            //Console.WriteLine(B);

            #endregion
            #region Passing By Value
            //int A = 4, B = 5, SumResult , MulResult;
            //SumMul(B,A,out SumResult,out MulResult);
            //Console.WriteLine($"the sum={SumResult}");
            //Console.WriteLine($"the mul={MulResult}");
            #endregion
            #region Params
            //int[] Numbers = { 1, 2, 3, 4, 5, 6, };
            //int total = SumArray(1,2,3,4,5,6);
            //Console.WriteLine($"the sum of the array {total}");
            #endregion
            #region Boxing vs UnBoxing
            //Boxing=>casting from datatype [value type]to data type[refernce]
            //un Boxing=>casting from datatype [refernce type]to data type[value]  un safe
            #region ex1
            //object obj;
            ////declare for refernce of type object refering null
            ////this refernce obj can refer to an instance from type object
            //obj = new object();
            //obj = new string("ali");
            //obj = 'a';
            //obj = 3;
            //obj = true;
            //bool flag = (bool)obj;
            //Console.WriteLine(flag); //un boxing un safe
            #endregion
            #region ex2
            //int x = 5;
            //object o1 = x;
            ////casting from int [value type ] to object [ref]
            ////5------>new object (5) boxing
            ////parent=child
            ////animal=dog
            ////boxing safe casting // imlicit casting
            //Console.WriteLine(o1);
            //unboxing
            //object o2 = 10;
            //o2 = "ali";
            //int y = (int)o2;
            ////casting from ref to int //explicit
            ////unboxing unsafe casting
            ////new object(10)------10
            ////child=parent
            //Console.WriteLine(o2);
            #endregion

            #endregion
        }
    }
}
