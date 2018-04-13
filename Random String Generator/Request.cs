using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_String_Generator
{
    public class Request
    {
        Character charset = new Character(); //initialize a Character instance to be used
        private string string_pool; //all characters to be randomly chosen
        private int req_length; //length of the output
        public Request(List<int> options, int len)
        {
            string_pool = charset.all_string_option(options);
            req_length = len;
        }

        public string get_pool()
        {
            return string_pool;
        }

        public int get_length()
        {
            return req_length;
        }
    }
}