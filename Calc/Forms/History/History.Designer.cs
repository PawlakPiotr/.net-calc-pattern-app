namespace Calc.Forms.History
{
    partial class History
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
            this.btn_clrHistory = new System.Windows.Forms.Button();
            this.historyGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clrHistory
            // 
            this.btn_clrHistory.Location = new System.Drawing.Point(12, 312);
            this.btn_clrHistory.Name = "btn_clrHistory";
            this.btn_clrHistory.Size = new System.Drawing.Size(367, 50);
            this.btn_clrHistory.TabIndex = 0;
            this.btn_clrHistory.Text = "CLEAR HISTORY";
            this.btn_clrHistory.UseVisualStyleBackColor = true;
            // 
            // historyGrid
            // 
            this.historyGrid.AllowUserToAddRows = false;
            this.historyGrid.AllowUserToDeleteRows = false;
            this.historyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGrid.Location = new System.Drawing.Point(13, 17);
            this.historyGrid.Name = "historyGrid";
            this.historyGrid.ReadOnly = true;
            this.historyGrid.RowTemplate.Height = 28;
            this.historyGrid.Size = new System.Drawing.Size(366, 277);
            this.historyGrid.TabIndex = 1;
            this.historyGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 374);
            this.Controls.Add(this.historyGrid);
            this.Controls.Add(this.btn_clrHistory);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clrHistory;
        public System.Windows.Forms.DataGridView historyGrid;
    }
}