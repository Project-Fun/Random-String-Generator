using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_String_Generator
{
    public class Request : AdvRequest
    {
        
        private int req_length; //length of the output
        public Request(List<int> options, int len) : base(options)
        {
            req_length = len;
        }

        

        public int get_length()
        {
            return req_length;
        }
    }
}