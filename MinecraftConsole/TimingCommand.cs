using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BigCookieKit;

namespace MinecraftConsole
{
    public partial class TimingCommand : Form
    {
        public string Command
        {
            get => this.txtCommand.Text;
            set => this.txtCommand.Text = value;
        }

        public bool Start
        {
            get
            {
                this.timer1.Enabled = this.ckbStart.Checked;
                return this.ckbStart.Checked;
            }
            set
            {
                this.ckbStart.Checked = value;
                this.timer1.Enabled = value;
            }
        }

        public int Interval
        {
            get
            {
                object interval = 0;
                this.txtInterval.Text.TryParse<int>(out interval);
                this.timer1.Interval = (int)interval;
                return (int)interval;
            }
            set
            {
                this.txtInterval.Text = value.ToString();
                this.timer1.Interval = value;
            }
        }

        public TimingCommand(EventHandler handler)
        {
            InitializeComponent();

            this.timer1.Tick += handler;
        }
    }
}
