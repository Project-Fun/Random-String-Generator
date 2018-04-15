using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_String_Generator
{
    public class Controller
    {
        Generator gen = new Generator();
        string output;
        public string generate_string(List<int> options, int length)
        {
            Request rq = new Request(options, length);
            output = gen.generate(rq);
            return output;
        }

        public string generate_adv_string(List<int> options)
        {
            AdvRequest rq = new AdvRequest(options);
            output = gen.generate(rq);
            return output;
        }

    }
}