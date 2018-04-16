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
        private List<char> finalCharSet = new List<char>();

        public AdvRequest(List<int> options)
        {
            List<int> charOption = new List<int>();
            int adjustIndex;
            int iteration = 1;
            for(int i = 0; i < options.Count; i++)
            {
                adjustIndex = i * 3;
                charOption.Add(options[adjustIndex]);
                charTypeLength.Add(options[adjustIndex + 1]);
                charTypeRepeat.Add(options[adjustIndex + 2]);
                if (iteration * 3 >= options.Count) break;
                iteration += 1;
            }
            List<char> tempCharSet;
            
            int rInt;
            for (int i = 0; i < charOption.Count; i++)
            {
                tempCharSet = new List<char>(charset.single_string_option(charOption[i]).ToCharArray());
                Random r = new Random(Guid.NewGuid().GetHashCode() + DateTime.Now.Millisecond);
                for (int j = 0; j < charTypeLength[i]; j++)
                {
                    if (myPublic.Glo_Cancel_job == false)
                    {
                        rInt = r.Next(0, tempCharSet.Count); //get a new random number
                        finalCharSet.Add(tempCharSet[rInt]); //add a new character to output list
                        if(charTypeRepeat[i] == 0)
                        {
                            tempCharSet.RemoveAt(rInt);
                        }
                        if(tempCharSet.Count == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public int getTotal()
        {
            int total = 0;
            foreach(var i in charTypeLength)
            {
                total += i;
            }
            return total;
        }

        public string get_pool()
        {
            return string_pool;
        }

        public List<char> get_pool_list()
        {
            return finalCharSet;
        }
    }
}
