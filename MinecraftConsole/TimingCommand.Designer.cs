namespace MinecraftConsole
{
    partial class TimingCommand
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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbStart = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 12);
            this.txtCommand.Multiline = true;
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(339, 311);
            this.txtCommand.TabIndex = 0;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(194, 329);
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(100, 23);
            this.txtInterval.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = "间隔";
            // 
            // ckbStart
            // 
            this.ckbStart.AutoSize = true;
            this.ckbStart.Location = new System.Drawing.Point(300, 331);
            this.ckbStart.Name = "ckbStart";
            this.ckbStart.Size = new System.Drawing.Size(51, 21);
            this.ckbStart.TabIndex = 43;
            this.ckbStart.Text = "开启";
            this.ckbStart.UseVisualStyleBackColor = true;
            // 
            // TimingCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 364);
            this.Controls.Add(this.ckbStart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.txtCommand);
            this.MaximumSize = new System.Drawing.Size(379, 403);
            this.MinimumSize = new System.Drawing.Size(379, 403);
            this.Name = "TimingCommand";
            this.Text = "TimingCommand";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbStart;
        private System.Windows.Forms.Timer timer1;
    }
}