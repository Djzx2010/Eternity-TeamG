using System;
using System.Collections.Generic;
using System.Text;

namespace ScientificCalculator
{


    struct Token
    {
        public enum Type
        {
            OPERATOR = 0,
            FUNCTION = 1,
            NUMBER = 2
        }

        public Type type;
        public double num;
        public String value;

        public Token(Type t, String v)
        {
            type = t;
            value = v;
            if (type == Type.NUMBER)
            {
                num = Double.Parse(value);
            }
            else
                num = 0.0;
        }
    }


    class Tokenizer
    {

        private static String[] functionToks =
        {
        "Abs",
        "Square",
        "Sqrt",
        "Mean",
        "StdDev"
        };

        private static String[] operatorToks =
        {
        "+",
        "-",
        "*",
        "/",
        "x",
        "%",
        "(",
        ")",
        ","
        };



        public List<Token> Tokenize(String expression)
        {
            List<Token> tokens = new List<Token>();
            bool readingNumber = false;
            String number = "";
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (readingNumber)
                {
                    if (Char.IsDigit(c) || c == '.')
                    {
                        number += c;
                    }
                    else
                    {
                        tokens.Add(new Token(Token.Type.NUMBER, number));
                        number = "";
                        readingNumber = false;
                    }
                }

                if (Char.IsDigit(c) && !readingNumber)
                {
                    readingNumber = true;
                    number += c;
                }
                else if (!readingNumber)
                {

                    for (int j = 0; j < functionToks.Length; j++)
                    {
                        String test = functionToks[j];
                        if (i + test.Length < expression.Length)
                        {
                            if (test.Equals(expression.Substring(i, test.Length)))
                            {
                                i += test.Length;
                                tokens.Add(new Token(Token.Type.FUNCTION, test));
                            }
                        }
                    }
                    for (int j = 0; j < operatorToks.Length; j++)
                    {
                        String test = operatorToks[j];
                        if (test.Equals(expression.Substring(i, 1)))
                        {
                            tokens.Add(new Token(Token.Type.OPERATOR, test));
                        }
                    }
                }
            }
            if (!number.Equals(""))
                tokens.Add(new Token(Token.Type.NUMBER, number));

            return tokens;
        }
    }
}
