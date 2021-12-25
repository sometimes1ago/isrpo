
namespace SwimmingPool
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.GetPoolsDataBtn = new System.Windows.Forms.Button();
            this.GetTrainersDataBtn = new System.Windows.Forms.Button();
            this.GetGroupsDataBtn = new System.Windows.Forms.Button();
            this.GetTicketsDataBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreetingsLabel
            // 
            this.GreetingsLabel.AutoSize = true;
            this.GreetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreetingsLabel.Location = new System.Drawing.Point(161, 28);
            this.GreetingsLabel.Name = "GreetingsLabel";
            this.GreetingsLabel.Size = new System.Drawing.Size(207, 26);
            this.GreetingsLabel.TabIndex = 0;
            this.GreetingsLabel.Text = "Добро пожаловать";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите просматриваемые данные";
            // 
            // GetPoolsDataBtn
            // 
            this.GetPoolsDataBtn.Location = new System.Drawing.Point(26, 128);
            this.GetPoolsDataBtn.Name = "GetPoolsDataBtn";
            this.GetPoolsDataBtn.Size = new System.Drawing.Size(106, 54);
            this.GetPoolsDataBtn.TabIndex = 2;
            this.GetPoolsDataBtn.Text = "Данные бассейнов";
            this.GetPoolsDataBtn.UseVisualStyleBackColor = true;
            this.GetPoolsDataBtn.Click += new System.EventHandler(this.GetPoolsDataBtn_Click);
            // 
            // GetTrainersDataBtn
            // 
            this.GetTrainersDataBtn.Location = new System.Drawing.Point(144, 128);
            this.GetTrainersDataBtn.Name = "GetTrainersDataBtn";
            this.GetTrainersDataBtn.Size = new System.Drawing.Size(106, 54);
            this.GetTrainersDataBtn.TabIndex = 3;
            this.GetTrainersDataBtn.Text = "Данные тренеров";
            this.GetTrainersDataBtn.UseVisualStyleBackColor = true;
            this.GetTrainersDataBtn.Click += new System.EventHandler(this.GetTrainersDataBtn_Click);
            // 
            // GetGroupsDataBtn
            // 
            this.GetGroupsDataBtn.Location = new System.Drawing.Point(262, 128);
            this.GetGroupsDataBtn.Name = "GetGroupsDataBtn";
            this.GetGroupsDataBtn.Size = new System.Drawing.Size(106, 54);
            this.GetGroupsDataBtn.TabIndex = 4;
            this.GetGroupsDataBtn.Text = "Данные групп";
            this.GetGroupsDataBtn.UseVisualStyleBackColor = true;
            this.GetGroupsDataBtn.Click += new System.EventHandler(this.GetGroupsDataBtn_Click);
            // 
            // GetTicketsDataBtn
            // 
            this.GetTicketsDataBtn.Location = new System.Drawing.Point(380, 128);
            this.GetTicketsDataBtn.Name = "GetTicketsDataBtn";
            this.GetTicketsDataBtn.Size = new System.Drawing.Size(106, 54);
            this.GetTicketsDataBtn.TabIndex = 5;
            this.GetTicketsDataBtn.Text = "Данные абониментов";
            this.GetTicketsDataBtn.UseVisualStyleBackColor = true;
            this.GetTicketsDataBtn.Click += new System.EventHandler(this.GetTicketsDataBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(380, 206);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(107, 23);
            this.LogoutBtn.TabIndex = 6;
            this.LogoutBtn.Text = "Выйти";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 243);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.GetTicketsDataBtn);
            this.Controls.Add(this.GetGroupsDataBtn);
            this.Controls.Add(this.GetTrainersDataBtn);
            this.Controls.Add(this.GetPoolsDataBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GreetingsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бассейн - Главная";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GreetingsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetPoolsDataBtn;
        private System.Windows.Forms.Button GetTrainersDataBtn;
        private System.Windows.Forms.Button GetGroupsDataBtn;
        private System.Windows.Forms.Button GetTicketsDataBtn;
        private System.Windows.Forms.Button LogoutBtn;
    }
}