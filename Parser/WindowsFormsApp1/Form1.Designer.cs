﻿namespace TPHParser
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
            this.titleText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorTextCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runBtn = new System.Windows.Forms.Button();
            this.csvBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.combineBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.exportBtn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.charBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineNum,
            this.titleText,
            this.DescText,
            this.EngText,
            this.ChnText,
            this.KorText,
            this.KorTextCN});
            this.dataGridView1.Location = new System.Drawing.Point(24, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(904, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // LineNum
            // 
            this.LineNum.HeaderText = "Line";
            this.LineNum.Name = "LineNum";
            // 
            // titleText
            // 
            this.titleText.HeaderText = "Title";
            this.titleText.Name = "titleText";
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
            this.ChnText.HeaderText = "2ndLanguage";
            this.ChnText.Name = "ChnText";
            // 
            // KorText
            // 
            this.KorText.HeaderText = "Korean";
            this.KorText.Name = "KorText";
            // 
            // KorTextCN
            // 
            this.KorTextCN.HeaderText = "Korean (from 2nd)";
            this.KorTextCN.Name = "KorTextCN";
            // 
            // runBtn
            // 
            this.runBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.runBtn.Location = new System.Drawing.Point(934, 19);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(107, 23);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "View File";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // csvBtn
            // 
            this.csvBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.csvBtn.Location = new System.Drawing.Point(934, 106);
            this.csvBtn.Name = "csvBtn";
            this.csvBtn.Size = new System.Drawing.Size(107, 23);
            this.csvBtn.TabIndex = 2;
            this.csvBtn.Text = "Export CSV";
            this.csvBtn.UseVisualStyleBackColor = true;
            this.csvBtn.Click += new System.EventHandler(this.csvBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadBtn.Location = new System.Drawing.Point(934, 135);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(107, 23);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Visible = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // combineBtn
            // 
            this.combineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combineBtn.Location = new System.Drawing.Point(934, 164);
            this.combineBtn.Name = "combineBtn";
            this.combineBtn.Size = new System.Drawing.Size(107, 23);
            this.combineBtn.TabIndex = 4;
            this.combineBtn.Text = "Combine";
            this.combineBtn.UseVisualStyleBackColor = true;
            this.combineBtn.Click += new System.EventHandler(this.combineBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportBtn.Location = new System.Drawing.Point(934, 48);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(107, 23);
            this.exportBtn.TabIndex = 5;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // importBtn
            // 
            this.importBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.importBtn.Location = new System.Drawing.Point(934, 77);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(107, 23);
            this.importBtn.TabIndex = 6;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
            // 
            // charBtn
            // 
            this.charBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.charBtn.Location = new System.Drawing.Point(934, 193);
            this.charBtn.Name = "charBtn";
            this.charBtn.Size = new System.Drawing.Size(107, 23);
            this.charBtn.TabIndex = 7;
            this.charBtn.Text = "Char List Up";
            this.charBtn.UseVisualStyleBackColor = true;
            this.charBtn.Click += new System.EventHandler(this.charBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.charBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.combineBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.csvBtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LineNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleText;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescText;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChnText;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorText;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorTextCN;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button combineBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Button csvBtn;
        private System.Windows.Forms.Button charBtn;
    }
}

