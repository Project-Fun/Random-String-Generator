using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Random_String_Generator
{
    public class AdvRequest
    {
        protected Character charset = new Character(); //initialize a Character instance to be used
        protected string string_pool; //all characters to be randomly chosen
        private List<int> charTypeLength = new List<int>();
        private List<int> charTypeRepeat= new List<int>();

        public AdvRequest(List<int> options)
        {
            List<int> charOption = new List<int>();
            int adjustIndex;
            for(int i = 0; i < options.Count; i++)
            {
                adjustIndex = i * 3;
                charOption.Add(options[i]);
                charTypeLength.Add(options[i + 1]);
                charTypeRepeat.Add(options[i + 2]);
                if (adjustIndex >= options.Count) break;
            }
            string_pool = charset.all_string_option(charOption);
        }

        public string get_pool()
        {
            return string_pool;
        }
    }
}
