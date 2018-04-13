using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_String_Generator
{
    public class Generator : gen_interface
    {

        public string generate(Request rq)
        {
            string password = "";
            password = random(rq);
            return password;
        }

        private string random(Request rq)
        {
            try
            {
                myPublic.Glo_progress_max = rq.get_length() + 1; //For progress bar
                myPublic.Glo_progress_current = 0; //For progress bar

                string pool = rq.get_pool(); //get the required string
                string output_str; //initialize final output
                char[] output = new char[rq.get_length()];
                Random r = new Random(Guid.NewGuid().GetHashCode() + DateTime.Now.Millisecond);
                //e.g. r.Next(0,3), it will only return 0,1,2. MaxValue is excluded, but MinValue is included.
                int rInt;
                for (int i = 0; i < rq.get_length(); i++)
                {
                    if (myPublic.Glo_Cancel_job == false)
                    {
                        rInt = r.Next(0, pool.Length); //get a new random number
                        output[i] = pool[rInt]; //add a new character to output list
                        myPublic.Glo_progress_current++; //For progress bar
                    }
                    else
                    {
                        return "";
                    }
                }
                output_str = new string(output);
                myPublic.Glo_progress_current++;
                return output_str;
            }
            catch(System.OutOfMemoryException)
            {
                return "";
            }   
        }
    }
}