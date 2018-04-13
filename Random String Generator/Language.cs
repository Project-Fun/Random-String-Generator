using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_String_Generator
{
    public abstract class Language
    {
        protected string ui_txt_title;
        protected string ui_txt_tab_mode_simple;
        protected string ui_txt_tab_mode_advanced;
        protected string ui_menu_bar_Settings;
        protected string ui_menu_bar_Help;
        protected string ui_menu_bar_help_help;
        protected string ui_menu_bar_help_about;
        protected string ui_menu_bar_Settings_Language;

        protected string ui_chkbx_A_Z_No_I_O;
        protected string ui_chkbx_a_z_No_i_l_o;
        protected string ui_chkbx_0_9_No_0_1;
        protected string ui_lbl_Length;
        protected string ui_txtbx_Result_inti_txt;
        protected string ui_btn_Generate_Text;
        protected string ui_btn_Generate_Stop_Text;
        protected string ui_btn_Copy_to_clipboard_Text;
        protected string ui_lbl_Copy_to_clipboard;

        public string Ui_txt_title
        {
            get
            {
                return ui_txt_title;
            }

            set
            {
                ui_txt_title = value;
            }
        }

        public string Ui_txt_tab_mode_simple
        {
            get
            {
                return ui_txt_tab_mode_simple;
            }

            set
            {
                ui_txt_tab_mode_simple = value;
            }
        }

        public string Ui_txt_tab_mode_advanced
        {
            get
            {
                return ui_txt_tab_mode_advanced;
            }

            set
            {
                ui_txt_tab_mode_advanced = value;
            }
        }

        public string Ui_menu_bar_Settings
        {
            get
            {
                return ui_menu_bar_Settings;
            }

            set
            {
                ui_menu_bar_Settings = value;
            }
        }

        public string Ui_menu_bar_Help
        {
            get
            {
                return ui_menu_bar_Help;
            }

            set
            {
                ui_menu_bar_Help = value;
            }
        }

        public string Ui_menu_bar_help_help
        {
            get
            {
                return ui_menu_bar_help_help;
            }

            set
            {
                ui_menu_bar_help_help = value;
            }
        }

        public string Ui_menu_bar_help_about
        {
            get
            {
                return ui_menu_bar_help_about;
            }

            set
            {
                ui_menu_bar_help_about = value;
            }
        }

        public string Ui_menu_bar_Settings_Language
        {
            get
            {
                return ui_menu_bar_Settings_Language;
            }

            set
            {
                ui_menu_bar_Settings_Language = value;
            }
        }

        public string Ui_chkbx_A_Z_No_I_O
        {
            get
            {
                return ui_chkbx_A_Z_No_I_O;
            }

            set
            {
                ui_chkbx_A_Z_No_I_O = value;
            }
        }

        public string Ui_chkbx_a_z_No_i_l_o
        {
            get
            {
                return ui_chkbx_a_z_No_i_l_o;
            }

            set
            {
                ui_chkbx_a_z_No_i_l_o = value;
            }
        }

        public string Ui_chkbx_0_9_No_0_1
        {
            get
            {
                return ui_chkbx_0_9_No_0_1;
            }

            set
            {
                ui_chkbx_0_9_No_0_1 = value;
            }
        }

        public string Ui_lbl_Length
        {
            get
            {
                return ui_lbl_Length;
            }

            set
            {
                ui_lbl_Length = value;
            }
        }

        public string Ui_txtbx_Result_inti_txt
        {
            get
            {
                return ui_txtbx_Result_inti_txt;
            }

            set
            {
                ui_txtbx_Result_inti_txt = value;
            }
        }

        public string Ui_btn_Generate_Text
        {
            get
            {
                return ui_btn_Generate_Text;
            }

            set
            {
                ui_btn_Generate_Text = value;
            }
        }

        public string Ui_btn_Generate_Stop_Text
        {
            get
            {
                return ui_btn_Generate_Stop_Text;
            }

            set
            {
                ui_btn_Generate_Stop_Text = value;
            }
        }

        public string Ui_btn_Copy_to_clipboard_Text
        {
            get
            {
                return ui_btn_Copy_to_clipboard_Text;
            }

            set
            {
                ui_btn_Copy_to_clipboard_Text = value;
            }
        }

        public string Ui_lbl_Copy_to_clipboard
        {
            get
            {
                return ui_lbl_Copy_to_clipboard;
            }

            set
            {
                ui_lbl_Copy_to_clipboard = value;
            }
        }
    }
}