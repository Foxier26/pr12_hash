namespace pr6_sakharov
{
    partial class Form1AddUsers
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginTxt = new System.Windows.Forms.Label();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.AutoBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.PassTxt = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.Label();
            this.PassTxtBox = new System.Windows.Forms.TextBox();
            this.LogTxtBox = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTxt
            // 
            this.LoginTxt.AutoSize = true;
            this.LoginTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxt.Location = new System.Drawing.Point(12, 52);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(71, 25);
            this.LoginTxt.TabIndex = 0;
            this.LoginTxt.Text = "Login:";
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxtBox.Location = new System.Drawing.Point(140, 128);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(233, 35);
            this.NameTxtBox.TabIndex = 1;
            // 
            // AutoBtn
            // 
            this.AutoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoBtn.Location = new System.Drawing.Point(202, 324);
            this.AutoBtn.Name = "AutoBtn";
            this.AutoBtn.Size = new System.Drawing.Size(171, 34);
            this.AutoBtn.TabIndex = 2;
            this.AutoBtn.Text = "Авторизоваться";
            this.AutoBtn.UseVisualStyleBackColor = true;
            this.AutoBtn.Click += new System.EventHandler(this.AutoBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(379, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(409, 426);
            this.dataGridView.TabIndex = 3;
            // 
            // PassTxt
            // 
            this.PassTxt.AutoSize = true;
            this.PassTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTxt.Location = new System.Drawing.Point(12, 94);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(112, 25);
            this.PassTxt.TabIndex = 0;
            this.PassTxt.Text = "Password:";
            // 
            // NameTxt
            // 
            this.NameTxt.AutoSize = true;
            this.NameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTxt.Location = new System.Drawing.Point(12, 134);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(122, 25);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.Text = "First Name:";
            // 
            // PassTxtBox
            // 
            this.PassTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassTxtBox.Location = new System.Drawing.Point(140, 88);
            this.PassTxtBox.Name = "PassTxtBox";
            this.PassTxtBox.PasswordChar = '*';
            this.PassTxtBox.Size = new System.Drawing.Size(233, 35);
            this.PassTxtBox.TabIndex = 1;
            // 
            // LogTxtBox
            // 
            this.LogTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogTxtBox.Location = new System.Drawing.Point(140, 48);
            this.LogTxtBox.Name = "LogTxtBox";
            this.LogTxtBox.Size = new System.Drawing.Size(233, 35);
            this.LogTxtBox.TabIndex = 1;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddBtn.Location = new System.Drawing.Point(17, 324);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(171, 34);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Form1AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.AutoBtn);
            this.Controls.Add(this.LogTxtBox);
            this.Controls.Add(this.PassTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.LoginTxt);
            this.Name = "Form1AddUsers";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1AddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTxt;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.Button AutoBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label PassTxt;
        private System.Windows.Forms.Label NameTxt;
        private System.Windows.Forms.TextBox PassTxtBox;
        private System.Windows.Forms.TextBox LogTxtBox;
        private System.Windows.Forms.Button AddBtn;
    }
}

