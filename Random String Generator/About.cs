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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            if (myPublic.Glo_my_Language == "en")
            {
                Text = "About \"Random Text/Password Generator\"";
            }
            else if (myPublic.Glo_my_Language == "zh")
            {
                Text = "关于 \"随机 文本/密码 生成器\"";
            }

        }

        private void About_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Escape)
            {
                Close();
            }
        }
    }
}
