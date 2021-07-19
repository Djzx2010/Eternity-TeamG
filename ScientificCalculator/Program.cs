using System;
using System.Collections.Generic;
using System.IO;

public class ConsoleApp1
{


    public static void Main()
    {
        ScientificCalculator.Parser p = new ScientificCalculator.Parser();
        p.Evaluate("Sqrt(2, 3, 3)   +2   ");
        //ScientificCalculator.Interpreter interpreter = new ScientificCalculator.Interpreter();
        //interpreter.ConsoleUpdate();
    }
}
