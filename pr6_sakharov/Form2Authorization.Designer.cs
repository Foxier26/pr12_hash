namespace pr6_sakharov.ModelEF
{
    partial class Form2Authorization
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
            this.EntBtn = new System.Windows.Forms.Button();
            this.LogTxtBox = new System.Windows.Forms.TextBox();
            this.PassTxtBox = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.Label();
            this.LoginTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EntBtn
            // 
            this.EntBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntBtn.Location = new System.Drawing.Point(297, 290);
            this.EntBtn.Name = "EntBtn";
            this.EntBtn.Size = new System.Drawing.Size(171, 34);
            this.EntBtn.TabIndex = 7;
            this.EntBtn.Text = "Войти";
            this.EntBtn.UseVisualStyleBackColor = true;
            this.EntBtn.Click += new System.EventHandler(this.EntBtn_Click);
            // 
            // LogTxtBox
            // 
            this.LogTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogTxtBox.Location = new System.Drawing.Point(368, 134);
            this.LogTxtBox.Name = "LogTxtBox";
            this.LogTxtBox.Size = new System.Drawing.Size(233, 35);
            this.LogTxtBox.TabIndex = 5;
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTxtBox.Location = new System.Drawing.Point(368, 174);
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.PasswordChar = '*';
            this.PassTxtBox.Size = new System.Drawing.Size(233, 35);
            this.PassTxtBox.TabIndex = 6;
            // 
            // PassTxt
            // 
            this.PassTxt.AutoSize = true;
            this.PassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTxt.Location = new System.Drawing.Point(208, 180);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(112, 25);
            this.PassTxt.TabIndex = 3;
            this.PassTxt.Text = "Password:";
            // 
            // LoginTxt
            // 
            this.LoginTxt.AutoSize = true;
            this.LoginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxt.Location = new System.Drawing.Point(208, 138);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(71, 25);
            this.LoginTxt.TabIndex = 4;
            this.LoginTxt.Text = "Login:";
            // 
            // Form2Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EntBtn);
            this.Controls.Add(this.LogTxtBox);
            this.Controls.Add(this.PassTxtBox);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.LoginTxt);
            this.Name = "Form2Authorization";
            this.Text = "Form2Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EntBtn;
        private System.Windows.Forms.TextBox LogTxtBox;
        private System.Windows.Forms.TextBox PassTxtBox;
        private System.Windows.Forms.Label PassTxt;
        private System.Windows.Forms.Label LoginTxt;
    }
}