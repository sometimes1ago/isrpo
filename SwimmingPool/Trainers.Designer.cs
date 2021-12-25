
namespace SwimmingPool
{
    partial class Trainers
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
            this.BeginnersTrainers = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.TrainersData = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.Label();
            this.AmountTrainersIncome = new System.Windows.Forms.Button();
            this.TrainersListByPool = new System.Windows.Forms.GroupBox();
            this.PoolsNames = new System.Windows.Forms.ComboBox();
            this.PoolsNamesLabel = new System.Windows.Forms.Label();
            this.GetTrainersIntoPoolBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrainersData)).BeginInit();
            this.TrainersListByPool.SuspendLayout();
            this.SuspendLayout();
            // 
            // BeginnersTrainers
            // 
            this.BeginnersTrainers.Location = new System.Drawing.Point(24, 358);
            this.BeginnersTrainers.Name = "BeginnersTrainers";
            this.BeginnersTrainers.Size = new System.Drawing.Size(114, 54);
            this.BeginnersTrainers.TabIndex = 7;
            this.BeginnersTrainers.Text = "Тренеры, работающие с начинающими";
            this.BeginnersTrainers.UseVisualStyleBackColor = true;
            this.BeginnersTrainers.Click += new System.EventHandler(this.BeginnersTrainers_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(694, 460);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 6;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // TrainersData
            // 
            this.TrainersData.AllowUserToAddRows = false;
            this.TrainersData.AllowUserToDeleteRows = false;
            this.TrainersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrainersData.Location = new System.Drawing.Point(24, 65);
            this.TrainersData.Name = "TrainersData";
            this.TrainersData.ReadOnly = true;
            this.TrainersData.Size = new System.Drawing.Size(745, 266);
            this.TrainersData.TabIndex = 5;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(20, 22);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(172, 24);
            this.Label.TabIndex = 4;
            this.Label.Text = "Данные тренеров";
            // 
            // AmountTrainersIncome
            // 
            this.AmountTrainersIncome.Location = new System.Drawing.Point(24, 429);
            this.AmountTrainersIncome.Name = "AmountTrainersIncome";
            this.AmountTrainersIncome.Size = new System.Drawing.Size(114, 54);
            this.AmountTrainersIncome.TabIndex = 8;
            this.AmountTrainersIncome.Text = "Итоговая прибиль тренеров в бассейнах";
            this.AmountTrainersIncome.UseVisualStyleBackColor = true;
            this.AmountTrainersIncome.Click += new System.EventHandler(this.AmountTrainersIncome_Click);
            // 
            // TrainersListByPool
            // 
            this.TrainersListByPool.Controls.Add(this.GetTrainersIntoPoolBtn);
            this.TrainersListByPool.Controls.Add(this.PoolsNamesLabel);
            this.TrainersListByPool.Controls.Add(this.PoolsNames);
            this.TrainersListByPool.Location = new System.Drawing.Point(173, 358);
            this.TrainersListByPool.Name = "TrainersListByPool";
            this.TrainersListByPool.Size = new System.Drawing.Size(195, 125);
            this.TrainersListByPool.TabIndex = 9;
            this.TrainersListByPool.TabStop = false;
            this.TrainersListByPool.Text = "Список тренеров по бассейнам";
            // 
            // PoolsNames
            // 
            this.PoolsNames.FormattingEnabled = true;
            this.PoolsNames.Location = new System.Drawing.Point(6, 57);
            this.PoolsNames.Name = "PoolsNames";
            this.PoolsNames.Size = new System.Drawing.Size(178, 21);
            this.PoolsNames.TabIndex = 0;
            // 
            // PoolsNamesLabel
            // 
            this.PoolsNamesLabel.AutoSize = true;
            this.PoolsNamesLabel.Location = new System.Drawing.Point(6, 31);
            this.PoolsNamesLabel.Name = "PoolsNamesLabel";
            this.PoolsNamesLabel.Size = new System.Drawing.Size(159, 13);
            this.PoolsNamesLabel.TabIndex = 1;
            this.PoolsNamesLabel.Text = "Выберите название бассейна";
            // 
            // GetTrainersIntoPoolBtn
            // 
            this.GetTrainersIntoPoolBtn.Location = new System.Drawing.Point(9, 87);
            this.GetTrainersIntoPoolBtn.Name = "GetTrainersIntoPoolBtn";
            this.GetTrainersIntoPoolBtn.Size = new System.Drawing.Size(175, 23);
            this.GetTrainersIntoPoolBtn.TabIndex = 2;
            this.GetTrainersIntoPoolBtn.Text = "Показать";
            this.GetTrainersIntoPoolBtn.UseVisualStyleBackColor = true;
            this.GetTrainersIntoPoolBtn.Click += new System.EventHandler(this.GetTrainersIntoPoolBtn_Click);
            // 
            // Trainers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.TrainersListByPool);
            this.Controls.Add(this.AmountTrainersIncome);
            this.Controls.Add(this.BeginnersTrainers);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TrainersData);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Trainers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бассейн - Тренеры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Trainers_FormClosing);
            this.Load += new System.EventHandler(this.Trainers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrainersData)).EndInit();
            this.TrainersListByPool.ResumeLayout(false);
            this.TrainersListByPool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BeginnersTrainers;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView TrainersData;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button AmountTrainersIncome;
        private System.Windows.Forms.GroupBox TrainersListByPool;
        private System.Windows.Forms.Button GetTrainersIntoPoolBtn;
        private System.Windows.Forms.Label PoolsNamesLabel;
        private System.Windows.Forms.ComboBox PoolsNames;
    }
}