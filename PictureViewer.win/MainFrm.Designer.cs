namespace PictureViewer.win
{
    partial class MainFrm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.pbQuestionMarks = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQuestionMarks
            // 
            this.pbQuestionMarks.Image = global::PictureViewer.win.Properties.Resources._753146885b26eb66e334509e8c50b301;
            this.pbQuestionMarks.Location = new System.Drawing.Point(0, -1);
            this.pbQuestionMarks.Name = "pbQuestionMarks";
            this.pbQuestionMarks.Size = new System.Drawing.Size(170, 173);
            this.pbQuestionMarks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbQuestionMarks.TabIndex = 0;
            this.pbQuestionMarks.TabStop = false;
            this.pbQuestionMarks.Click += new System.EventHandler(this.pbQuestionMarks_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 635);
            this.Controls.Add(this.pbQuestionMarks);
            this.Name = "MainFrm";
            this.Text = "PictureViewer";
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestionMarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbQuestionMarks;
    }
}

