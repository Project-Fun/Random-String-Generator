using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_String_Generator
{
    //Place to store/change global variables
    public class myPublic
    {
        public static string Glo_my_Language = "en"; //ISO 639-1 code, zh, en
        public static string Glo_final_string = ""; //Final output string (result string)
        public static int Glo_progress_max; //Current required characters
        public static int Glo_progress_current; //Current string generation progress (count of current attempted characters)
        public static bool Glo_Cancel_job = false; //Calcel string generation
    }
}