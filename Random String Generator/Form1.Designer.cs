﻿namespace Random_String_Generator
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab_ctrl = new System.Windows.Forms.TabControl();
            this.tab_pg_Simple_Mode = new System.Windows.Forms.TabPage();
            this.btn_Copy_to_clipboard = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_progress = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.rihtxtbx_Result = new System.Windows.Forms.RichTextBox();
            this.lbl_Length = new System.Windows.Forms.Label();
            this.num_UpDown_Length = new System.Windows.Forms.NumericUpDown();
            this.chkbx_0_9_No_0_1 = new System.Windows.Forms.CheckBox();
            this.chkbx_a_z_No_i_l_o = new System.Windows.Forms.CheckBox();
            this.chkbx_A_Z_No_I_O = new System.Windows.Forms.CheckBox();
            this.btn_Generate_Text = new System.Windows.Forms.Button();
            this.tab_pg_Advanced_Mode = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_bar_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_bar_Settings_Language = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_bar_Settings_Language_Chinese = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_bar_Settings_Language_English = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_bar_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_bar_help_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_bar_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chkbx_adv_0_9 = new System.Windows.Forms.CheckBox();
            this.chkbx_adv_a_z_Low = new System.Windows.Forms.CheckBox();
            this.chkbx_adv_A_Z_Cap = new System.Windows.Forms.CheckBox();
            this.chkbx_adv_Chinese_Char = new System.Windows.Forms.CheckBox();
            this.chkbx_adv_Specified_text = new System.Windows.Forms.CheckBox();
            this.btn_adv_Copy_to_clipboard = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.progressBar1_adv = new System.Windows.Forms.ToolStripProgressBar();
            this.lbl_adv_progress = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_adv_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.rihtxtbx_adv_Result = new System.Windows.Forms.RichTextBox();
            this.btn_adv_Generate_Text = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.tab_ctrl.SuspendLayout();
            this.tab_pg_Simple_Mode.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UpDown_Length)).BeginInit();
            this.tab_pg_Advanced_Mode.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_ctrl
            // 
            this.tab_ctrl.Controls.Add(this.tab_pg_Simple_Mode);
            this.tab_ctrl.Controls.Add(this.tab_pg_Advanced_Mode);
            this.tab_ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_ctrl.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_ctrl.Location = new System.Drawing.Point(0, 31);
            this.tab_ctrl.Name = "tab_ctrl";
            this.tab_ctrl.SelectedIndex = 0;
            this.tab_ctrl.Size = new System.Drawing.Size(548, 554);
            this.tab_ctrl.TabIndex = 0;
            // 
            // tab_pg_Simple_Mode
            // 
            this.tab_pg_Simple_Mode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_pg_Simple_Mode.Controls.Add(this.btn_Copy_to_clipboard);
            this.tab_pg_Simple_Mode.Controls.Add(this.statusStrip1);
            this.tab_pg_Simple_Mode.Controls.Add(this.rihtxtbx_Result);
            this.tab_pg_Simple_Mode.Controls.Add(this.lbl_Length);
            this.tab_pg_Simple_Mode.Controls.Add(this.num_UpDown_Length);
            this.tab_pg_Simple_Mode.Controls.Add(this.chkbx_0_9_No_0_1);
            this.tab_pg_Simple_Mode.Controls.Add(this.chkbx_a_z_No_i_l_o);
            this.tab_pg_Simple_Mode.Controls.Add(this.chkbx_A_Z_No_I_O);
            this.tab_pg_Simple_Mode.Controls.Add(this.btn_Generate_Text);
            this.tab_pg_Simple_Mode.Location = new System.Drawing.Point(4, 31);
            this.tab_pg_Simple_Mode.Name = "tab_pg_Simple_Mode";
            this.tab_pg_Simple_Mode.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pg_Simple_Mode.Size = new System.Drawing.Size(540, 519);
            this.tab_pg_Simple_Mode.TabIndex = 0;
            this.tab_pg_Simple_Mode.Text = "Simple Mode";
            // 
            // btn_Copy_to_clipboard
            // 
            this.btn_Copy_to_clipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Copy_to_clipboard.Location = new System.Drawing.Point(411, 368);
            this.btn_Copy_to_clipboard.Name = "btn_Copy_to_clipboard";
            this.btn_Copy_to_clipboard.Size = new System.Drawing.Size(126, 60);
            this.btn_Copy_to_clipboard.TabIndex = 12;
            this.btn_Copy_to_clipboard.Text = "Copy to clipboard";
            this.btn_Copy_to_clipboard.UseVisualStyleBackColor = true;
            this.btn_Copy_to_clipboard.Click += new System.EventHandler(this.btn_Copy_to_clipboard_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1,
            this.lbl_progress,
            this.lbl_Status});
            this.statusStrip1.Location = new System.Drawing.Point(3, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(534, 24);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 18);
            // 
            // lbl_progress
            // 
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(29, 19);
            this.lbl_progress.Text = "0%";
            // 
            // lbl_Status
            // 
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(48, 19);
            this.lbl_Status.Text = "Status";
            // 
            // rihtxtbx_Result
            // 
            this.rihtxtbx_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rihtxtbx_Result.Enabled = false;
            this.rihtxtbx_Result.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rihtxtbx_Result.Location = new System.Drawing.Point(8, 384);
            this.rihtxtbx_Result.Multiline = false;
            this.rihtxtbx_Result.Name = "rihtxtbx_Result";
            this.rihtxtbx_Result.Size = new System.Drawing.Size(397, 30);
            this.rihtxtbx_Result.TabIndex = 5;
            this.rihtxtbx_Result.Text = "Result will be displayed here...";
            // 
            // lbl_Length
            // 
            this.lbl_Length.AutoSize = true;
            this.lbl_Length.Location = new System.Drawing.Point(18, 208);
            this.lbl_Length.Name = "lbl_Length";
            this.lbl_Length.Size = new System.Drawing.Size(68, 22);
            this.lbl_Length.TabIndex = 6;
            this.lbl_Length.Text = "Length:";
            // 
            // num_UpDown_Length
            // 
            this.num_UpDown_Length.Location = new System.Drawing.Point(92, 206);
            this.num_UpDown_Length.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.num_UpDown_Length.Name = "num_UpDown_Length";
            this.num_UpDown_Length.Size = new System.Drawing.Size(156, 30);
            this.num_UpDown_Length.TabIndex = 4;
            this.num_UpDown_Length.Leave += new System.EventHandler(this.num_UpDown_Length_Leave);
            // 
            // chkbx_0_9_No_0_1
            // 
            this.chkbx_0_9_No_0_1.AutoSize = true;
            this.chkbx_0_9_No_0_1.Location = new System.Drawing.Point(22, 104);
            this.chkbx_0_9_No_0_1.Name = "chkbx_0_9_No_0_1";
            this.chkbx_0_9_No_0_1.Size = new System.Drawing.Size(120, 26);
            this.chkbx_0_9_No_0_1.TabIndex = 3;
            this.chkbx_0_9_No_0_1.Text = "Digits / 2-9";
            this.chkbx_0_9_No_0_1.UseVisualStyleBackColor = true;
            this.chkbx_0_9_No_0_1.CheckedChanged += new System.EventHandler(this.chkbx_0_9_No_0_1_CheckedChanged);
            // 
            // chkbx_a_z_No_i_l_o
            // 
            this.chkbx_a_z_No_i_l_o.AutoSize = true;
            this.chkbx_a_z_No_i_l_o.Location = new System.Drawing.Point(22, 71);
            this.chkbx_a_z_No_i_l_o.Name = "chkbx_a_z_No_i_l_o";
            this.chkbx_a_z_No_i_l_o.Size = new System.Drawing.Size(204, 26);
            this.chkbx_a_z_No_i_l_o.TabIndex = 2;
            this.chkbx_a_z_No_i_l_o.Text = "a-z (Without \'i\', \'l\', \'o\')";
            this.chkbx_a_z_No_i_l_o.UseVisualStyleBackColor = true;
            this.chkbx_a_z_No_i_l_o.CheckedChanged += new System.EventHandler(this.chkbx_a_z_No_i_l_o_CheckedChanged);
            // 
            // chkbx_A_Z_No_I_O
            // 
            this.chkbx_A_Z_No_I_O.AutoSize = true;
            this.chkbx_A_Z_No_I_O.Location = new System.Drawing.Point(22, 38);
            this.chkbx_A_Z_No_I_O.Name = "chkbx_A_Z_No_I_O";
            this.chkbx_A_Z_No_I_O.Size = new System.Drawing.Size(192, 26);
            this.chkbx_A_Z_No_I_O.TabIndex = 1;
            this.chkbx_A_Z_No_I_O.Text = "A-Z (Without \'I\', \'O\')";
            this.chkbx_A_Z_No_I_O.UseVisualStyleBackColor = true;
            this.chkbx_A_Z_No_I_O.CheckedChanged += new System.EventHandler(this.chkbx_A_Z_No_I_O_CheckedChanged);
            // 
            // btn_Generate_Text
            // 
            this.btn_Generate_Text.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_Generate_Text.Enabled = false;
            this.btn_Generate_Text.Location = new System.Drawing.Point(143, 434);
            this.btn_Generate_Text.Name = "btn_Generate_Text";
            this.btn_Generate_Text.Size = new System.Drawing.Size(262, 50);
            this.btn_Generate_Text.TabIndex = 6;
            this.btn_Generate_Text.Text = "&Generate Text/Password";
            this.btn_Generate_Text.UseVisualStyleBackColor = true;
            this.btn_Generate_Text.Click += new System.EventHandler(this.btn_Generate_Text_Click);
            // 
            // tab_pg_Advanced_Mode
            // 
            this.tab_pg_Advanced_Mode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_pg_Advanced_Mode.Controls.Add(this.chkbx_adv_Specified_text);
            this.tab_pg_Advanced_Mode.Controls.Add(this.groupBox5);
            this.tab_pg_Advanced_Mode.Controls.Add(this.chkbx_adv_Chinese_Char);
            this.tab_pg_Advanced_Mode.Controls.Add(this.groupBox4);
            this.tab_pg_Advanced_Mode.Controls.Add(this.chkbx_adv_0_9);
            this.tab_pg_Advanced_Mode.Controls.Add(this.groupBox3);
            this.tab_pg_Advanced_Mode.Controls.Add(this.chkbx_adv_a_z_Low);
            this.tab_pg_Advanced_Mode.Controls.Add(this.groupBox2);
            this.tab_pg_Advanced_Mode.Controls.Add(this.chkbx_adv_A_Z_Cap);
            this.tab_pg_Advanced_Mode.Controls.Add(this.groupBox1);
            this.tab_pg_Advanced_Mode.Controls.Add(this.btn_adv_Copy_to_clipboard);
            this.tab_pg_Advanced_Mode.Controls.Add(this.statusStrip2);
            this.tab_pg_Advanced_Mode.Controls.Add(this.rihtxtbx_adv_Result);
            this.tab_pg_Advanced_Mode.Controls.Add(this.btn_adv_Generate_Text);
            this.tab_pg_Advanced_Mode.Location = new System.Drawing.Point(4, 31);
            this.tab_pg_Advanced_Mode.Name = "tab_pg_Advanced_Mode";
            this.tab_pg_Advanced_Mode.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pg_Advanced_Mode.Size = new System.Drawing.Size(540, 519);
            this.tab_pg_Advanced_Mode.TabIndex = 1;
            this.tab_pg_Advanced_Mode.Text = "Advanced Mode";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_bar_Settings,
            this.menu_bar_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_bar_Settings
            // 
            this.menu_bar_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_bar_Settings_Language});
            this.menu_bar_Settings.Name = "menu_bar_Settings";
            this.menu_bar_Settings.Size = new System.Drawing.Size(118, 27);
            this.menu_bar_Settings.Text = "Settings (&S)";
            // 
            // menu_bar_Settings_Language
            // 
            this.menu_bar_Settings_Language.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_bar_Settings_Language_Chinese,
            this.menu_bar_Settings_Language_English});
            this.menu_bar_Settings_Language.Name = "menu_bar_Settings_Language";
            this.menu_bar_Settings_Language.Size = new System.Drawing.Size(186, 28);
            this.menu_bar_Settings_Language.Text = "Language(&L)";
            // 
            // menu_bar_Settings_Language_Chinese
            // 
            this.menu_bar_Settings_Language_Chinese.Name = "menu_bar_Settings_Language_Chinese";
            this.menu_bar_Settings_Language_Chinese.Size = new System.Drawing.Size(210, 28);
            this.menu_bar_Settings_Language_Chinese.Text = "中文(简体)(&C)";
            this.menu_bar_Settings_Language_Chinese.Click += new System.EventHandler(this.menu_bar_Settings_Language_Chinese_Click);
            // 
            // menu_bar_Settings_Language_English
            // 
            this.menu_bar_Settings_Language_English.Checked = true;
            this.menu_bar_Settings_Language_English.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_bar_Settings_Language_English.Name = "menu_bar_Settings_Language_English";
            this.menu_bar_Settings_Language_English.Size = new System.Drawing.Size(210, 28);
            this.menu_bar_Settings_Language_English.Text = "English(&E)";
            this.menu_bar_Settings_Language_English.Click += new System.EventHandler(this.menu_bar_Settings_Language_English_Click);
            // 
            // menu_bar_Help
            // 
            this.menu_bar_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_bar_help_help,
            this.menu_bar_help_about});
            this.menu_bar_Help.Name = "menu_bar_Help";
            this.menu_bar_Help.Size = new System.Drawing.Size(91, 27);
            this.menu_bar_Help.Text = "Help(&H)";
            // 
            // menu_bar_help_help
            // 
            this.menu_bar_help_help.Name = "menu_bar_help_help";
            this.menu_bar_help_help.Size = new System.Drawing.Size(160, 28);
            this.menu_bar_help_help.Text = "Help(&H)";
            // 
            // menu_bar_help_about
            // 
            this.menu_bar_help_about.Name = "menu_bar_help_about";
            this.menu_bar_help_about.Size = new System.Drawing.Size(160, 28);
            this.menu_bar_help_about.Text = "About(&A)";
            this.menu_bar_help_about.Click += new System.EventHandler(this.menu_bar_help_about_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chkbx_adv_0_9
            // 
            this.chkbx_adv_0_9.AutoSize = true;
            this.chkbx_adv_0_9.Location = new System.Drawing.Point(8, 148);
            this.chkbx_adv_0_9.Name = "chkbx_adv_0_9";
            this.chkbx_adv_0_9.Size = new System.Drawing.Size(120, 26);
            this.chkbx_adv_0_9.TabIndex = 6;
            this.chkbx_adv_0_9.Text = "Digits / 0-9";
            this.chkbx_adv_0_9.UseVisualStyleBackColor = true;
            // 
            // chkbx_adv_a_z_Low
            // 
            this.chkbx_adv_a_z_Low.AutoSize = true;
            this.chkbx_adv_a_z_Low.Location = new System.Drawing.Point(8, 86);
            this.chkbx_adv_a_z_Low.Name = "chkbx_adv_a_z_Low";
            this.chkbx_adv_a_z_Low.Size = new System.Drawing.Size(165, 26);
            this.chkbx_adv_a_z_Low.TabIndex = 5;
            this.chkbx_adv_a_z_Low.Text = "lowercase letters";
            this.chkbx_adv_a_z_Low.UseVisualStyleBackColor = true;
            // 
            // chkbx_adv_A_Z_Cap
            // 
            this.chkbx_adv_A_Z_Cap.AutoSize = true;
            this.chkbx_adv_A_Z_Cap.Location = new System.Drawing.Point(8, 23);
            this.chkbx_adv_A_Z_Cap.Name = "chkbx_adv_A_Z_Cap";
            this.chkbx_adv_A_Z_Cap.Size = new System.Drawing.Size(195, 26);
            this.chkbx_adv_A_Z_Cap.TabIndex = 4;
            this.chkbx_adv_A_Z_Cap.Text = "CAPITAL LETTERS";
            this.chkbx_adv_A_Z_Cap.UseVisualStyleBackColor = true;
            // 
            // chkbx_adv_Chinese_Char
            // 
            this.chkbx_adv_Chinese_Char.AutoSize = true;
            this.chkbx_adv_Chinese_Char.Location = new System.Drawing.Point(8, 213);
            this.chkbx_adv_Chinese_Char.Name = "chkbx_adv_Chinese_Char";
            this.chkbx_adv_Chinese_Char.Size = new System.Drawing.Size(178, 26);
            this.chkbx_adv_Chinese_Char.TabIndex = 7;
            this.chkbx_adv_Chinese_Char.Text = "Chinese characters";
            this.chkbx_adv_Chinese_Char.UseVisualStyleBackColor = true;
            // 
            // chkbx_adv_Specified_text
            // 
            this.chkbx_adv_Specified_text.AutoSize = true;
            this.chkbx_adv_Specified_text.Location = new System.Drawing.Point(8, 287);
            this.chkbx_adv_Specified_text.Name = "chkbx_adv_Specified_text";
            this.chkbx_adv_Specified_text.Size = new System.Drawing.Size(144, 26);
            this.chkbx_adv_Specified_text.TabIndex = 8;
            this.chkbx_adv_Specified_text.Text = "Specified Text";
            this.chkbx_adv_Specified_text.UseVisualStyleBackColor = true;
            // 
            // btn_adv_Copy_to_clipboard
            // 
            this.btn_adv_Copy_to_clipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_adv_Copy_to_clipboard.Location = new System.Drawing.Point(411, 366);
            this.btn_adv_Copy_to_clipboard.Name = "btn_adv_Copy_to_clipboard";
            this.btn_adv_Copy_to_clipboard.Size = new System.Drawing.Size(126, 60);
            this.btn_adv_Copy_to_clipboard.TabIndex = 16;
            this.btn_adv_Copy_to_clipboard.Text = "Copy to clipboard";
            this.btn_adv_Copy_to_clipboard.UseVisualStyleBackColor = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1_adv,
            this.lbl_adv_progress,
            this.lbl_adv_Status});
            this.statusStrip2.Location = new System.Drawing.Point(3, 492);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(534, 24);
            this.statusStrip2.TabIndex = 15;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // progressBar1_adv
            // 
            this.progressBar1_adv.Name = "progressBar1_adv";
            this.progressBar1_adv.Size = new System.Drawing.Size(100, 18);
            // 
            // lbl_adv_progress
            // 
            this.lbl_adv_progress.Name = "lbl_adv_progress";
            this.lbl_adv_progress.Size = new System.Drawing.Size(29, 19);
            this.lbl_adv_progress.Text = "0%";
            // 
            // lbl_adv_Status
            // 
            this.lbl_adv_Status.Name = "lbl_adv_Status";
            this.lbl_adv_Status.Size = new System.Drawing.Size(48, 19);
            this.lbl_adv_Status.Text = "Status";
            // 
            // rihtxtbx_adv_Result
            // 
            this.rihtxtbx_adv_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rihtxtbx_adv_Result.Enabled = false;
            this.rihtxtbx_adv_Result.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rihtxtbx_adv_Result.Location = new System.Drawing.Point(8, 382);
            this.rihtxtbx_adv_Result.Multiline = false;
            this.rihtxtbx_adv_Result.Name = "rihtxtbx_adv_Result";
            this.rihtxtbx_adv_Result.Size = new System.Drawing.Size(397, 30);
            this.rihtxtbx_adv_Result.TabIndex = 13;
            this.rihtxtbx_adv_Result.Text = "Result will be displayed here...";
            // 
            // btn_adv_Generate_Text
            // 
            this.btn_adv_Generate_Text.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_adv_Generate_Text.Enabled = false;
            this.btn_adv_Generate_Text.Location = new System.Drawing.Point(143, 432);
            this.btn_adv_Generate_Text.Name = "btn_adv_Generate_Text";
            this.btn_adv_Generate_Text.Size = new System.Drawing.Size(262, 50);
            this.btn_adv_Generate_Text.TabIndex = 14;
            this.btn_adv_Generate_Text.Text = "&Generate Text/Password";
            this.btn_adv_Generate_Text.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 57);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 26);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "A-Z";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Location = new System.Drawing.Point(24, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 57);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(96, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(138, 26);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "A-Z (No I, O)";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(263, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 26);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "No repeat";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(402, 21);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(99, 30);
            this.numericUpDown1.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(402, 21);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(99, 30);
            this.numericUpDown2.TabIndex = 7;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(97, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 26);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "a-z (No i, l, o)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(6, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 26);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "a-z";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(264, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(107, 26);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "No repeat";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDown3);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Location = new System.Drawing.Point(25, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(508, 57);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Enabled = false;
            this.numericUpDown3.Location = new System.Drawing.Point(402, 21);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(99, 30);
            this.numericUpDown3.TabIndex = 7;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(96, 25);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(55, 26);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Text = "2-9";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Enabled = false;
            this.radioButton6.Location = new System.Drawing.Point(6, 25);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 26);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "0-9";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Enabled = false;
            this.checkBox3.Location = new System.Drawing.Point(263, 26);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(107, 26);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "No repeat";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDown4);
            this.groupBox4.Controls.Add(this.checkBox4);
            this.groupBox4.Location = new System.Drawing.Point(25, 213);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(508, 68);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Enabled = false;
            this.numericUpDown4.Location = new System.Drawing.Point(128, 29);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(99, 30);
            this.numericUpDown4.TabIndex = 7;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Enabled = false;
            this.checkBox4.Location = new System.Drawing.Point(6, 30);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(107, 26);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "No repeat";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown5);
            this.groupBox5.Controls.Add(this.checkBox5);
            this.groupBox5.Location = new System.Drawing.Point(25, 288);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(508, 68);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Enabled = false;
            this.numericUpDown5.Location = new System.Drawing.Point(128, 32);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(99, 30);
            this.numericUpDown5.TabIndex = 7;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Enabled = false;
            this.checkBox5.Location = new System.Drawing.Point(6, 36);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(107, 26);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.Text = "No repeat";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 585);
            this.Controls.Add(this.tab_ctrl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Text Generator";
            this.Load += new System.EventHandler(this.UI_Load);
            this.tab_ctrl.ResumeLayout(false);
            this.tab_pg_Simple_Mode.ResumeLayout(false);
            this.tab_pg_Simple_Mode.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_UpDown_Length)).EndInit();
            this.tab_pg_Advanced_Mode.ResumeLayout(false);
            this.tab_pg_Advanced_Mode.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tab_ctrl;
        private System.Windows.Forms.TabPage tab_pg_Simple_Mode;
        private System.Windows.Forms.TabPage tab_pg_Advanced_Mode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_bar_Settings;
        private System.Windows.Forms.ToolStripMenuItem menu_bar_Help;
        private System.Windows.Forms.ToolStripMenuItem menu_bar_help_help;
        private System.Windows.Forms.ToolStripMenuItem menu_bar_help_about;
        private System.Windows.Forms.ToolStripMenuItem menu_bar_Settings_Language;
        private System.Windows.Forms.ToolStripMenuItem menu_bar_Settings_Language_Chinese;
        private System.Windows.Forms.ToolStripMenuItem menu_bar_Settings_Language_English;
        private System.Windows.Forms.Button btn_Generate_Text;
        private System.Windows.Forms.CheckBox chkbx_0_9_No_0_1;
        private System.Windows.Forms.CheckBox chkbx_a_z_No_i_l_o;
        private System.Windows.Forms.CheckBox chkbx_A_Z_No_I_O;
        private System.Windows.Forms.NumericUpDown num_UpDown_Length;
        private System.Windows.Forms.Label lbl_Length;
        private System.Windows.Forms.RichTextBox rihtxtbx_Result;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_progress;
        private System.Windows.Forms.Button btn_Copy_to_clipboard;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Status;
        private System.Windows.Forms.CheckBox chkbx_adv_Specified_text;
        private System.Windows.Forms.CheckBox chkbx_adv_Chinese_Char;
        private System.Windows.Forms.CheckBox chkbx_adv_0_9;
        private System.Windows.Forms.CheckBox chkbx_adv_a_z_Low;
        private System.Windows.Forms.CheckBox chkbx_adv_A_Z_Cap;
        private System.Windows.Forms.Button btn_adv_Copy_to_clipboard;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripProgressBar progressBar1_adv;
        private System.Windows.Forms.ToolStripStatusLabel lbl_adv_progress;
        private System.Windows.Forms.ToolStripStatusLabel lbl_adv_Status;
        private System.Windows.Forms.RichTextBox rihtxtbx_adv_Result;
        private System.Windows.Forms.Button btn_adv_Generate_Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}
