using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_String_Generator
{
    public class English : Language
    {
        public English()
        {
            ui_txt_title = "Random Text/Password Generator";
            ui_txt_tab_mode_simple = "Simple Mode";
            ui_txt_tab_mode_advanced = "Advanced Mode";
            ui_menu_bar_Settings = "Settings(&S)";
            ui_menu_bar_Help = "Help(&H)";
            ui_menu_bar_help_help = "Help(&H)";
            ui_menu_bar_help_about = "About(&A)";
            ui_menu_bar_Settings_Language = "Language(&L)";

            ui_chkbx_A_Z_No_I_O = "A-Z (Without 'I', 'O')";
            ui_chkbx_a_z_No_i_l_o = "a-z (Without 'i', 'l', 'o')";
            ui_chkbx_0_9_No_0_1 = "Digits / 2-9";
            ui_lbl_Length = "Length:";
            ui_txtbx_Result_inti_txt = "Result will be displayed here...";
            ui_btn_Generate_Text = "Generate Text/Password";
            ui_btn_Generate_Stop_Text = "Stop Generation Process";
            ui_btn_Copy_to_clipboard_Text = "Copy to clipboard";
            ui_lbl_Copy_to_clipboard = "Copied to clipboard!";



        }
    }
}