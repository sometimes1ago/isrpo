
namespace SwimmingPool
{
    partial class Auth
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
            this.GreetingsLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.PasswordShower = new System.Windows.Forms.CheckBox();
            this.AuthStartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreetingsLabel.Location = new System.Drawing.Point(30, 34);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(187, 24);
            this.GreetingsLabel.TabIndex = 0;
            this.GreetingsLabel.Text = "Добро пожаловать!";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(71, 87);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(104, 17);
            this.LoginLabel.TabIndex = 1;
            this.LoginLabel.Text = "Введите логин";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(66, 167);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(114, 17);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Введите пароль";
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(32, 123);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(183, 20);
            this.LoginInput.TabIndex = 3;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(32, 202);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(183, 20);
            this.PasswordInput.TabIndex = 4;
            // 
            // PasswordShower
            // 
            this.PasswordShower.AutoSize = true;
            this.PasswordShower.Location = new System.Drawing.Point(74, 243);
            this.PasswordShower.Name = "PasswordShower";
            this.PasswordShower.Size = new System.Drawing.Size(114, 17);
            this.PasswordShower.TabIndex = 5;
            this.PasswordShower.Text = "Показать пароль";
            this.PasswordShower.UseVisualStyleBackColor = true;
            this.PasswordShower.CheckedChanged += new System.EventHandler(this.PasswordShower_CheckedChanged);
            // 
            // AuthStartBtn
            // 
            this.AuthStartBtn.Location = new System.Drawing.Point(32, 285);
            this.AuthStartBtn.Name = "AuthStartBtn";
            this.AuthStartBtn.Size = new System.Drawing.Size(185, 40);
            this.AuthStartBtn.TabIndex = 6;
            this.AuthStartBtn.Text = "Войти";
            this.AuthStartBtn.UseVisualStyleBackColor = true;
            this.AuthStartBtn.Click += new System.EventHandler(this.AuthStartBtn_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 349);
            this.Controls.Add(this.AuthStartBtn);
            this.Controls.Add(this.PasswordShower);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.GreetingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бассейн - Вход";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.CheckBox PasswordShower;
        private System.Windows.Forms.Button AuthStartBtn;
    }
}

