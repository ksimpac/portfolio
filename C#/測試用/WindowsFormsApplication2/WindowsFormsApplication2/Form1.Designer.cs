namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.Area = new System.Windows.Forms.ComboBox();
            this.Station = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Area
            // 
            this.Area.FormattingEnabled = true;
            this.Area.Location = new System.Drawing.Point(49, 75);
            this.Area.Name = "Area";
            this.Area.Size = new System.Drawing.Size(121, 20);
            this.Area.TabIndex = 0;
            // 
            // Station
            // 
            this.Station.FormattingEnabled = true;
            this.Station.Location = new System.Drawing.Point(232, 75);
            this.Station.Name = "Station";
            this.Station.Size = new System.Drawing.Size(121, 20);
            this.Station.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 262);
            this.Controls.Add(this.Station);
            this.Controls.Add(this.Area);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Area;
        private System.Windows.Forms.ComboBox Station;
    }
}

