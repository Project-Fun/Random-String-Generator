using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_String_Generator
{
    public partial class UI : Form
    {
        private BackgroundWorker bw = new BackgroundWorker();

        Controller control = new Controller();

        string ui_txt_title;
        string ui_txt_tab_mode_simple;
        string ui_txt_tab_mode_advanced;
        string ui_menu_bar_Settings;
        string ui_menu_bar_Help;
        string ui_menu_bar_help_help;
        string ui_menu_bar_help_about;
        string ui_menu_bar_Settings_Language;

        string ui_chkbx_A_Z_No_I_O;
        string ui_chkbx_a_z_No_i_l_o;
        string ui_chkbx_0_9_No_0_1;
        string ui_lbl_Length;
        string ui_txtbx_Result_inti_txt;
        string ui_btn_Generate_Text;
        string ui_btn_Generate_Stop_Text;
        string ui_btn_Copy_to_clipboard_Text;
        string ui_lbl_Copy_to_clipboard;

        public UI()
        {
            InitializeComponent();
            lbl_progress.Text = "";
            lbl_Status.Text = "";

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void UI_Load(object sender, EventArgs e)
        {
            // UI/Language inti
            Change_Language_String();


            //Language select, menu property, checked/unchecked
        }

        private void menu_bar_Settings_Language_Chinese_Click(object sender, EventArgs e)
        {
            menu_bar_Settings_Language_English.Checked = false;
            menu_bar_Settings_Language_Chinese.Checked = true;
            changelanguage(new Chinese());
        }

        private void menu_bar_Settings_Language_English_Click(object sender, EventArgs e)
        {
            menu_bar_Settings_Language_Chinese.Checked = false;
            menu_bar_Settings_Language_English.Checked = true;
            changelanguage(new English());
        }

        private void chkbx_A_Z_No_I_O_CheckedChanged(object sender, EventArgs e)
        {
            Change_btn_State();
        }

        private void chkbx_a_z_No_i_l_o_CheckedChanged(object sender, EventArgs e)
        {
            Change_btn_State();
        }

        private void chkbx_0_9_No_0_1_CheckedChanged(object sender, EventArgs e)
        {
            Change_btn_State();
        }
        private void Change_btn_State()
        {
            if (chkbx_A_Z_No_I_O.Checked || chkbx_a_z_No_i_l_o.Checked || chkbx_0_9_No_0_1.Checked)
            {
                btn_Generate_Text.Enabled = true;
            }
            else
            {
                btn_Generate_Text.Enabled = false;
            }
        }

        private void btn_Generate_Text_Click(object sender, EventArgs e)
        {
            //rihtxtbx_Result.Text = ""; //Clear inti text
            //rihtxtbx_Result.Font = new Font(rihtxtbx_Result.Font, FontStyle.Regular); //Change font to regular
            //List<int> request = new List<int>();
            //request = generate_request();
            //rihtxtbx_Result.Text = control.generate_string(request, Convert.ToInt32(num_UpDown_Length.Value));
            //rihtxtbx_Result.Enabled = true;


            if (bw.IsBusy != true)
            {
                myPublic.Glo_Cancel_job = false;
                rihtxtbx_Result.Text = ""; //Clear inti text
                rihtxtbx_Result.Font = new Font(rihtxtbx_Result.Font, FontStyle.Regular); //Change font to regular
                rihtxtbx_Result.Enabled = true;
                bw.RunWorkerAsync(); //Start job in another thread
                progressBar1.Maximum = myPublic.Glo_progress_max;
                progressBar1.Value = 0;
                lbl_progress.Text = "";
                timer1.Enabled = true;
                btn_Generate_Text.Text = Change_Gen_btn_String(true);
                menu_bar_Settings_Language.Enabled = false;
                lbl_Status.Text = "";
            }
            else
            {
                myPublic.Glo_Cancel_job = true;
                timer1.Enabled = false;
                progressBar1.Maximum = 0;
                progressBar1.Value = 0;
                lbl_progress.Text = "";
                btn_Generate_Text.Text = Change_Gen_btn_String(false);
                menu_bar_Settings_Language.Enabled = true;
                lbl_Status.Text = "";
            }
        }

        private List<int> generate_request()
        {
            List<int> request = new List<int>();
            if(chkbx_0_9_No_0_1.Checked)
            {
                request.Add(9);
            }
            if(chkbx_a_z_No_i_l_o.Checked)
            {
                request.Add(8);
            }
            if(chkbx_A_Z_No_I_O.Checked)
            {
                request.Add(7);
            }
            return request;
        }

        private void num_UpDown_Length_Leave(object sender, EventArgs e)
        {
            if (num_UpDown_Length.Text == "")
            {
                // If the value in the numeric updown is an empty string, replace with 0.
                num_UpDown_Length.Text = "0";
            }
        }

        private void Change_Language_String()
        {
            switch (myPublic.Glo_my_Language)
            {
                case "en":
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
                    break;
                case "zh":
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
                    break;
                default:
                    ui_txt_title = "Random Text Generator";
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
                    break;
            }
        }

        private void Change_Language_Apply()
        {
            Text = ui_txt_title;
            tab_pg_Simple_Mode.Text = ui_txt_tab_mode_simple;
            tab_pg_Advanced_Mode.Text = ui_txt_tab_mode_advanced;
            menu_bar_Settings.Text = ui_menu_bar_Settings;
            menu_bar_Help.Text = ui_menu_bar_Help;
            menu_bar_help_help.Text = ui_menu_bar_help_help;
            menu_bar_help_about.Text = ui_menu_bar_help_about;
            menu_bar_Settings_Language.Text = ui_menu_bar_Settings_Language;
            chkbx_A_Z_No_I_O.Text = ui_chkbx_A_Z_No_I_O;
            chkbx_a_z_No_i_l_o.Text = ui_chkbx_a_z_No_i_l_o;
            chkbx_0_9_No_0_1.Text = ui_chkbx_0_9_No_0_1;
            lbl_Length.Text = ui_lbl_Length;
            rihtxtbx_Result.Text = ui_txtbx_Result_inti_txt;
            btn_Copy_to_clipboard.Text = ui_btn_Copy_to_clipboard_Text;
        }

        //Change the text on the generate button when generation status changed
        private string Change_Gen_btn_String(bool running)
        {
            if (running == false)
            {
                //btn_Generate_Text.Text = ui_btn_Generate_Text;
                return ui_btn_Generate_Text;
            }
            else
            {
                //btn_Generate_Text.Text = ui_btn_Generate_Stop_Text;
                return ui_btn_Generate_Stop_Text;
            }
        }

        private void menu_bar_help_about_Click(object sender, EventArgs e)
        {
            About AboutFrm = new About();
            AboutFrm.ShowDialog();
        }

        //Do the heavy loop job in another thread
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            // Perform a time consuming operation and report progress.
            List<int> request = new List<int>();
            request = generate_request();
            myPublic.Glo_final_string = control.generate_string(request, Convert.ToInt32(num_UpDown_Length.Value));
        }

        //Output result to text box
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {

            }

            else if (!(e.Error == null))
            {
                //this.tbProgress.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                //this.tbProgress.Text = "Done!";
                //label.Content = "11";
                if (myPublic.Glo_Cancel_job == false)
                {
                    rihtxtbx_Result.Text = myPublic.Glo_final_string;
                }
                else
                {

                }
            }
        }
        
        //Keep it for thread progress
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this.tbProgress.Text = (e.ProgressPercentage.ToString() + "%");
            //label.Content = (e.ProgressPercentage.ToString() + "%");
            //progressBar1.Value = e.ProgressPercentage;
            //progressBar1.Value = myPublic.Glo_progress_current;
        }


        //Timer For progressbar
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Maximum != myPublic.Glo_progress_max)
            {
                progressBar1.Maximum = myPublic.Glo_progress_max;
            }

            if (progressBar1.Value < myPublic.Glo_progress_max)
            {
                progressBar1.Value = myPublic.Glo_progress_current;
                //lbl_progress.Text = Convert.ToString(myPublic.Glo_progress_current) + "/" + Convert.ToString(myPublic.Glo_progress_max);
                decimal tmp_progress;
                tmp_progress = Convert.ToDecimal(myPublic.Glo_progress_current) / Convert.ToDecimal(myPublic.Glo_progress_max);
                lbl_progress.Text = (tmp_progress*100).ToString("#") + "%";
            }
            else
            {
                btn_Generate_Text.Text = Change_Gen_btn_String(false);
                menu_bar_Settings_Language.Enabled = true;
                timer1.Enabled = false;
            }
        }

        //Button, copy result to clipboard
        private void btn_Copy_to_clipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rihtxtbx_Result.Text);
            lbl_Status.Text = ui_lbl_Copy_to_clipboard;
        }

        //Textbox text changed, copy to clipboard button enable toggle
        //private void rihtxtbx_Result_TextChanged(object sender, EventArgs e)
        //{
        //    if (rihtxtbx_Result.Text != ui_txtbx_Result_inti_txt && rihtxtbx_Result.Text != "")
        //    {
        //        btn_Copy_to_clipboard.Enabled = true;
        //    }
        //    else
        //    {
        //        btn_Copy_to_clipboard.Enabled = false;
        //    }
        //}

        private void changelanguage(Language lan_pack)
        {
            Text = lan_pack.Ui_txt_title;
            tab_pg_Simple_Mode.Text = lan_pack.Ui_txt_tab_mode_simple;
            tab_pg_Advanced_Mode.Text = lan_pack.Ui_txt_tab_mode_advanced;
            menu_bar_Settings.Text = lan_pack.Ui_menu_bar_Settings;
            menu_bar_Help.Text = lan_pack.Ui_menu_bar_Help;
            menu_bar_help_help.Text = lan_pack.Ui_menu_bar_help_help;
            menu_bar_help_about.Text = lan_pack.Ui_menu_bar_help_about;
            menu_bar_Settings_Language.Text = lan_pack.Ui_menu_bar_Settings_Language;
            chkbx_A_Z_No_I_O.Text = lan_pack.Ui_chkbx_A_Z_No_I_O;
            chkbx_a_z_No_i_l_o.Text = lan_pack.Ui_chkbx_a_z_No_i_l_o;
            chkbx_0_9_No_0_1.Text = lan_pack.Ui_chkbx_0_9_No_0_1;
            lbl_Length.Text = lan_pack.Ui_lbl_Length;
            rihtxtbx_Result.Text = lan_pack.Ui_txtbx_Result_inti_txt;
            btn_Copy_to_clipboard.Text = lan_pack.Ui_btn_Copy_to_clipboard_Text;
        }
    }
}

