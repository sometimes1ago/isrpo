
namespace SwimmingPool
{
    partial class Groups
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.GroupsData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MaxPollIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsData)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(700, 397);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // GroupsData
            // 
            this.GroupsData.AllowUserToAddRows = false;
            this.GroupsData.AllowUserToDeleteRows = false;
            this.GroupsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsData.Location = new System.Drawing.Point(30, 73);
            this.GroupsData.Name = "GroupsData";
            this.GroupsData.ReadOnly = true;
            this.GroupsData.Size = new System.Drawing.Size(745, 266);
            this.GroupsData.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Данные групп";
            // 
            // MaxPollIncome
            // 
            this.MaxPollIncome.Location = new System.Drawing.Point(30, 366);
            this.MaxPollIncome.Name = "MaxPollIncome";
            this.MaxPollIncome.Size = new System.Drawing.Size(114, 54);
            this.MaxPollIncome.TabIndex = 7;
            this.MaxPollIncome.Text = "Количество групп по дням недели";
            this.MaxPollIncome.UseVisualStyleBackColor = true;
            this.MaxPollIncome.Click += new System.EventHandler(this.MaxPollIncome_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaxPollIncome);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.GroupsData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бассейн - Группы";
            this.Load += new System.EventHandler(this.Groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView GroupsData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MaxPollIncome;
    }
}