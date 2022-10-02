namespace MinecraftConsole
{
    partial class PlayerControl
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
            this.btnForeword = new System.Windows.Forms.Button();
            this.btnBackword = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForeword
            // 
            this.btnForeword.Location = new System.Drawing.Point(59, 12);
            this.btnForeword.Name = "btnForeword";
            this.btnForeword.Size = new System.Drawing.Size(41, 33);
            this.btnForeword.TabIndex = 0;
            this.btnForeword.Text = "前";
            this.btnForeword.UseVisualStyleBackColor = true;
            // 
            // btnBackword
            // 
            this.btnBackword.Location = new System.Drawing.Point(59, 51);
            this.btnBackword.Name = "btnBackword";
            this.btnBackword.Size = new System.Drawing.Size(41, 33);
            this.btnBackword.TabIndex = 1;
            this.btnBackword.Text = "后";
            this.btnBackword.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 51);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(41, 33);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "左";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(106, 51);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(41, 33);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "右";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(230, 12);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(63, 33);
            this.btnAttack.TabIndex = 4;
            this.btnAttack.Text = "攻击";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // PlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 247);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnBackword);
            this.Controls.Add(this.btnForeword);
            this.Name = "PlayerControl";
            this.Text = "玩家控制";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForeword;
        private System.Windows.Forms.Button btnBackword;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnAttack;
    }
}