using System;
using System.Collections.Generic;
using System.Text;

namespace ScientificCalculator
{
    class Parser
    {
        private Tokenizer tokenizer;
        public Parser()
        {
            tokenizer = new Tokenizer();
        }
        public double Evaluate(String Expression)
        {
      
            List<Token> tokens = tokenizer.Tokenize(Expression);
            foreach (Token t in tokens)
                Console.WriteLine(t.value);
            return 0;
        }
    }
}
