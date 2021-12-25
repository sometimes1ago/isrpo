
namespace SwimmingPool
{
    partial class Tickets
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
            this.TicketsListByPool = new System.Windows.Forms.GroupBox();
            this.GetSelectedTicket = new System.Windows.Forms.Button();
            this.TicketsNamesLabel = new System.Windows.Forms.Label();
            this.Trainers = new System.Windows.Forms.ComboBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.TIcketsData = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.Label();
            this.TicketsListByPool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TIcketsData)).BeginInit();
            this.SuspendLayout();
            // 
            // TicketsListByPool
            // 
            this.TicketsListByPool.Controls.Add(this.GetSelectedTicket);
            this.TicketsListByPool.Controls.Add(this.TicketsNamesLabel);
            this.TicketsListByPool.Controls.Add(this.Trainers);
            this.TicketsListByPool.Location = new System.Drawing.Point(30, 344);
            this.TicketsListByPool.Name = "TicketsListByPool";
            this.TicketsListByPool.Size = new System.Drawing.Size(195, 125);
            this.TicketsListByPool.TabIndex = 13;
            this.TicketsListByPool.TabStop = false;
            this.TicketsListByPool.Text = "Список абониментов по тренеру";
            // 
            // GetSelectedTicket
            // 
            this.GetSelectedTicket.Location = new System.Drawing.Point(9, 87);
            this.GetSelectedTicket.Name = "GetSelectedTicket";
            this.GetSelectedTicket.Size = new System.Drawing.Size(175, 23);
            this.GetSelectedTicket.TabIndex = 2;
            this.GetSelectedTicket.Text = "Показать";
            this.GetSelectedTicket.UseVisualStyleBackColor = true;
            this.GetSelectedTicket.Click += new System.EventHandler(this.GetSelectedTicket_Click);
            // 
            // TicketsNamesLabel
            // 
            this.TicketsNamesLabel.AutoSize = true;
            this.TicketsNamesLabel.Location = new System.Drawing.Point(6, 31);
            this.TicketsNamesLabel.Name = "TicketsNamesLabel";
            this.TicketsNamesLabel.Size = new System.Drawing.Size(101, 13);
            this.TicketsNamesLabel.TabIndex = 1;
            this.TicketsNamesLabel.Text = "Выберите тренера";
            // 
            // Trainers
            // 
            this.Trainers.FormattingEnabled = true;
            this.Trainers.Location = new System.Drawing.Point(6, 57);
            this.Trainers.Name = "Trainers";
            this.Trainers.Size = new System.Drawing.Size(178, 21);
            this.Trainers.TabIndex = 0;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(700, 446);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 12;
            this.BackBtn.Text = "Назад";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // TIcketsData
            // 
            this.TIcketsData.AllowUserToAddRows = false;
            this.TIcketsData.AllowUserToDeleteRows = false;
            this.TIcketsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TIcketsData.Location = new System.Drawing.Point(30, 51);
            this.TIcketsData.Name = "TIcketsData";
            this.TIcketsData.ReadOnly = true;
            this.TIcketsData.Size = new System.Drawing.Size(745, 266);
            this.TIcketsData.TabIndex = 11;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(26, 8);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(206, 24);
            this.Label.TabIndex = 10;
            this.Label.Text = "Данные абониментов";
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.TicketsListByPool);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.TIcketsData);
            this.Controls.Add(this.Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бассейн - Абонименты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Tickets_FormClosing);
            this.Load += new System.EventHandler(this.Tickets_Load);
            this.TicketsListByPool.ResumeLayout(false);
            this.TicketsListByPool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TIcketsData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TicketsListByPool;
        private System.Windows.Forms.Button GetSelectedTicket;
        private System.Windows.Forms.Label TicketsNamesLabel;
        private System.Windows.Forms.ComboBox Trainers;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView TIcketsData;
        private System.Windows.Forms.Label Label;
    }
}