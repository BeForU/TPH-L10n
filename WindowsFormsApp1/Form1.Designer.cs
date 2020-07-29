namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LineNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorTextCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNum,
            this.DescText,
            this.EngText,
            this.ChnText,
            this.KorText,
            this.KorTextCN});
            this.dataGridView1.Location = new System.Drawing.Point(24, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(580, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // LineNum
            // 
            this.LineNum.HeaderText = "Line";
            this.LineNum.Name = "LineNum";
            // 
            // DescText
            // 
            this.DescText.HeaderText = "Description";
            this.DescText.Name = "DescText";
            // 
            // EngText
            // 
            this.EngText.HeaderText = "English";
            this.EngText.Name = "EngText";
            // 
            // ChnText
            // 
            this.ChnText.HeaderText = "Traditional Chinese";
            this.ChnText.Name = "ChnText";
            // 
            // KorText
            // 
            this.KorText.HeaderText = "Korean";
            this.KorText.Name = "KorText";
            // 
            // KorTextCN
            // 
            this.KorTextCN.HeaderText = "Korean (from Chinese)";
            this.KorTextCN.Name = "KorTextCN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescText;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChnText;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorText;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorTextCN;
    }
}

