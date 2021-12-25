
namespace SwimmingPool
{
    partial class Pools
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
            this.label1 = new System.Windows.Forms.Label();
            this.PoolsData = new System.Windows.Forms.DataGridView();
            this.BackBtn = new System.Windows.Forms.Button();
            this.MaxPollIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PoolsData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данные бассейнов";
            // 
            // PoolsData
            // 
            this.PoolsData.AllowUserToAddRows = false;
            this.PoolsData.AllowUserToDeleteRows = false;
            this.PoolsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PoolsData.Location = new System.Drawing.Point(26, 65);
            this.PoolsData.Name = "PoolsData";
            this.PoolsData.ReadOnly = true;
            this.PoolsData.Size = new System.Drawing.Size(745, 266);
            this.PoolsData.TabIndex = 1;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(696, 389);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 2;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MaxPollIncome
            // 
            this.MaxPollIncome.Location = new System.Drawing.Point(26, 358);
            this.MaxPollIncome.Name = "MaxPollIncome";
            this.MaxPollIncome.Size = new System.Drawing.Size(114, 54);
            this.MaxPollIncome.TabIndex = 3;
            this.MaxPollIncome.Text = "Бассейн с максимальной прибылью";
            this.MaxPollIncome.UseVisualStyleBackColor = true;
            this.MaxPollIncome.Click += new System.EventHandler(this.MaxPollIncome_Click);
            // 
            // Pools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.MaxPollIncome);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.PoolsData);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Pools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бассейны - Бассейны";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pools_FormClosing);
            this.Load += new System.EventHandler(this.Pools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PoolsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PoolsData;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button MaxPollIncome;
    }
}