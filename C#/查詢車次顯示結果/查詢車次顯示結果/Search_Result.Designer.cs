namespace 查詢車次顯示結果
{
    partial class Search_Result
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.車種 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.車次 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.經由 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.發車站 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.終點站 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.開車時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.抵達時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備註 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.訂票 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.車種,
            this.車次,
            this.經由,
            this.發車站,
            this.終點站,
            this.開車時間,
            this.抵達時間,
            this.備註,
            this.訂票});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 723);
            this.dataGridView1.TabIndex = 2;
            // 
            // 車種
            // 
            this.車種.HeaderText = "車種";
            this.車種.Name = "車種";
            // 
            // 車次
            // 
            this.車次.HeaderText = "車次";
            this.車次.Name = "車次";
            // 
            // 經由
            // 
            this.經由.HeaderText = "經由";
            this.經由.Name = "經由";
            // 
            // 發車站
            // 
            this.發車站.HeaderText = "發車站";
            this.發車站.Name = "發車站";
            // 
            // 終點站
            // 
            this.終點站.HeaderText = "終點站";
            this.終點站.Name = "終點站";
            // 
            // 開車時間
            // 
            this.開車時間.HeaderText = "開車時間";
            this.開車時間.Name = "開車時間";
            // 
            // 抵達時間
            // 
            this.抵達時間.HeaderText = "抵達時間";
            this.抵達時間.Name = "抵達時間";
            // 
            // 備註
            // 
            this.備註.HeaderText = "備註";
            this.備註.Name = "備註";
            // 
            // 訂票
            // 
            this.訂票.HeaderText = "訂票";
            this.訂票.Name = "訂票";
            // 
            // Search_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 747);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Search_Result";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 車種;
        private System.Windows.Forms.DataGridViewTextBoxColumn 車次;
        private System.Windows.Forms.DataGridViewTextBoxColumn 經由;
        private System.Windows.Forms.DataGridViewTextBoxColumn 發車站;
        private System.Windows.Forms.DataGridViewTextBoxColumn 終點站;
        private System.Windows.Forms.DataGridViewTextBoxColumn 開車時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn 抵達時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備註;
        private System.Windows.Forms.DataGridViewTextBoxColumn 訂票;
    }
}

