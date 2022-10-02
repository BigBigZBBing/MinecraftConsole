using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftConsole
{
    public partial class GameMode : Form
    {
        public string ReturnValue { get; set; }

        public GameMode()
        {
            InitializeComponent();

            foreach (Control item in Controls)
            {
                if (item is Button btn)
                {
                    btn.Click += Btn_Click;
                }
            }

            StartPosition = FormStartPosition.CenterParent;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ReturnValue = btn.Tag?.ToString();
            this.Dispose();
        }
    }
}
