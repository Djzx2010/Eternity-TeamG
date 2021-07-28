using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using DynamicExpresso;

namespace ScientificCalculator
{
    class Interpreter : DynamicExpresso.Interpreter
    {

        private delegate double Function1d(double x);
        private delegate double Function2d(double x, double y);
        private delegate double FunctionNd(params double[] x);
        private delegate double[] GetArray(params double[] x);

        private double answer;
        private double[] arr;

        private bool arrSet = false;

        public Interpreter() : base(InterpreterOptions.PrimitiveTypes)
        {
            answer = 0.0;
            arr = null;

            //Default type must be set to double so integer division is correct real number
            SetDefaultNumberType(DefaultNumberType.Double);

            //Create instances of the delegates
            Function1d squareDel = ScientificCalculator.Math.Square;
            Function1d sqrtDel = ScientificCalculator.Math.Sqrt;
            Function1d absDel = ScientificCalculator.Math.Abs;
            Function1d sinhDel = ScientificCalculator.Math.Sinh;
            Function1d gammaDel = ScientificCalculator.Math.Gamma;
            FunctionNd meanAbsDevDel = ScientificCalculator.Math.MeanAbsoluteDeviation;
            FunctionNd meanDel = ScientificCalculator.Math.Mean;
            FunctionNd stddevDel = ScientificCalculator.Math.StdDev;
            Function1d acosDel = ScientificCalculator.Math.Arccos;
            Function2d logDel = ScientificCalculator.Math.Log;
            Function2d powerDel = ScientificCalculator.Math.Power;
            GetArray getArrayDel = GetArr;

            //Bind the delegates to the tokens in the expression
            SetFunction("Square", squareDel);
            SetFunction("Sqrt", sqrtDel);
            SetFunction("Abs", absDel);
            SetFunction("Sinh", sinhDel);
            SetFunction("Gamma", gammaDel);
            SetFunction("MeanAbsDel", meanAbsDevDel);
            SetFunction("Mean", meanDel);
            SetFunction("StdDev", stddevDel);
            SetFunction("GetArr", getArrayDel);
            SetFunction("Arccos", acosDel);
            SetFunction("Log", logDel);
            SetFunction("Power", powerDel);
            SetVariable("ans", answer);
            SetVariable("arr", arr);
            SetVariable("PI", ScientificCalculator.Math.PI);
            SetVariable("e", 2.7182818284590452353602874713527);

        }


        public void LoadArrayFromCSV(String fileName, uint column)
        {
            //Incomplete
            using (var reader = new StreamReader(@fileName))
            {
                List<double> arrList = new List<double>();
                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    String[] tokens = line.Split(',');
                    if (column < tokens.Length && tokens[column] != "")
                        arrList.Add(Double.Parse(tokens[column]));
                }
                if (arrList.Count > 0)
                {
                    arr = arrList.ToArray();
                    SetVariable("arr", arr);
                    arrSet = true;
                }
            }
        }

        public double[] GetArr(params double[] x)
        {
            return x;
        }

        public void SetArr(params double[] x)
        {
            arr = x;
            SetVariable("arr", arr);
            arrSet = true;
        }

        public double EvaluateString(String expression)
        {
            expression = expression.Replace("x", "*");
            expression = expression.Replace("σ", "StdDev");
            expression = expression.Replace("√", "Sqrt");
            expression = expression.Replace("π", "PI");
            if(expression.Contains("arr"))
            {
                if (arrSet)
                    answer = Eval<double>(expression);
                else
                    answer = Double.NaN;
            }
            else
                answer = Eval<double>(expression);

            SetVariable("ans", answer);
            return answer;
        }

        public void ConsoleUpdate()
        {
            String expression = "";
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter 0: set a list, 1: evaluate an expression \n");
                    String option = Console.ReadLine();
                    if (option.Equals("0"))
                    {
                        Console.WriteLine("Enter a list of numbers separated by a comma (eg. 1, 2, 3):\n");
                        expression = Console.ReadLine();
                        expression = "GetArr(" + expression + ")";
                        arr = Eval<double[]>(expression);
                        SetVariable("arr", arr);
                    }
                    else if (option.Equals("1"))
                    {
                        Console.WriteLine("Enter a math expression: \n");
                        expression = Console.ReadLine();
                        expression = expression.Replace("x", "*");
                        EvaluateString(expression);
                        Console.WriteLine("\nanswer = " + answer + "\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}