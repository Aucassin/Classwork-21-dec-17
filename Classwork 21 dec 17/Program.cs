using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_21_dec_17
{
    enum Operations
    {
        Add = 1,
        Substract = 2,
        Multiply = 3,
        Divide = 4

    }
    //enum DaysOfWeek
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}

    class Program
    {
        static double MathOp(double a, double b, Operations op)
        {
            double result = 0.0;
            switch (op)
            {
                case Operations.Add:
                    result = a+b;
                    break;
                case Operations.Substract:
                    result = a - b;
                    break;
                case Operations.Multiply:
                    result = a * b;
                    break;
                case Operations.Divide:
                    result = a / b;
                    break;
            }
            return result;
        }

        //static public void GetAge(params int[] array)
        //{


        //    //    static public List<int> GetAge(out int x)
        //    //{
        //    //    x = 18;

        //    //    return new List<int>
        //    //    {
        //    //        2,4,6
        //    //    };

        //    //array[0] = 5;

        //    //array = new int[]
        //    //    {
        //    //        22,44,66
        //    //    };

        //}

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            double result = MathOp(10, 7, Operations.Divide);
            Console.WriteLine(result);
            Dictionary<string, Operations> dic = new Dictionary<string, Operations>();
            dic.Add(Console.ReadLine(), Operations.Add);

            //string f = "Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday";
            //string[] array = f.Split(',');
            //string[] week = new string[7];
            //week[(int)DaysOfWeek.Monday] = array[(int)DaysOfWeek.Monday];
            //week[(int)DaysOfWeek.Tuesday] = array[(int)DaysOfWeek.Tuesday];
            //week[(int)DaysOfWeek.Wednesday] = array[(int)DaysOfWeek.Wednesday];
            //week[(int)DaysOfWeek.Thursday] = array[(int)DaysOfWeek.Thursday];
            //week[(int)DaysOfWeek.Friday] = array[(int)DaysOfWeek.Friday];
            //week[(int)DaysOfWeek.Saturday] = array[(int)DaysOfWeek.Saturday];
            //week[(int)DaysOfWeek.Sunday] = array[(int)DaysOfWeek.Sunday];

            //foreach (var item in week)
            //{
            //    Console.WriteLine(item);
            //}

            //GetAge(2, 4, 6, 8, 10);


            //int x;
            //GetAge(out x);
            //Console.WriteLine(x);


            //int[] array = { 2, 4, 6 };
            //GetAge(ref array);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
