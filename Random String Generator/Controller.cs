using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_String_Generator
{
    public class Controller
    {
        gen_interface gen = new Generator();
        public string generate_string(List<int> options, int length)
        {
            string output;
            Request rq = new Request(options, length);
            output = gen.generate(rq);
            return output;
        }

    }
}