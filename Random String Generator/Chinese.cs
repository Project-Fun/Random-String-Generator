using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Random_String_Generator
{
    public class Chinese : Language
    {
        public Chinese()
        {
            ui_txt_title = "随机 文本/密码 生成器";
            ui_txt_tab_mode_simple = "简易模式";
            ui_txt_tab_mode_advanced = "高级模式";
            ui_menu_bar_Settings = "设置(&S)";
            ui_menu_bar_Help = "帮助(&H)";
            ui_menu_bar_help_help = "帮助(&H)";
            ui_menu_bar_help_about = "关于(&A)";
            ui_menu_bar_Settings_Language = "语言(&L)";

            ui_chkbx_A_Z_No_I_O = "A-Z (不包括 'I', 'O')";
            ui_chkbx_a_z_No_i_l_o = "a-z (不包括 'i', 'l', 'o')";
            ui_chkbx_0_9_No_0_1 = "数字 / 2-9";
            ui_lbl_Length = "长度:";
            ui_txtbx_Result_inti_txt = "生成的文本/密码将会显示在这里。。。";
            ui_btn_Generate_Text = "生成 随机文本/密码";
            ui_btn_Generate_Stop_Text = "停止生成";
            ui_btn_Copy_to_clipboard_Text = "复制到剪切板";
            ui_lbl_Copy_to_clipboard = "已复制到剪切板！";
        }
    }
}