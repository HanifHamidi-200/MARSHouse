namespace GRADIE
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
            this.txtPart1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPart2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPart3 = new System.Windows.Forms.TextBox();
            this.btnEquation = new System.Windows.Forms.Button();
            this.lblEquation = new System.Windows.Forms.Label();
            this.btnAddX = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAddY = new System.Windows.Forms.Button();
            this.lstAddX = new System.Windows.Forms.ListBox();
            this.lstAddY = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPlot = new System.Windows.Forms.Button();
            this.btnQNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPart1
            // 
            this.txtPart1.Location = new System.Drawing.Point(36, 46);
            this.txtPart1.Name = "txtPart1";
            this.txtPart1.Size = new System.Drawing.Size(91, 20);
            this.txtPart1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x^2 +";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x +";
            // 
            // txtPart2
            // 
            this.txtPart2.Location = new System.Drawing.Point(208, 46);
            this.txtPart2.Name = "txtPart2";
            this.txtPart2.Size = new System.Drawing.Size(91, 20);
            this.txtPart2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "c";
            // 
            // txtPart3
            // 
            this.txtPart3.Location = new System.Drawing.Point(380, 46);
            this.txtPart3.Name = "txtPart3";
            this.txtPart3.Size = new System.Drawing.Size(91, 20);
            this.txtPart3.TabIndex = 4;
            // 
            // btnEquation
            // 
            this.btnEquation.BackColor = System.Drawing.Color.Yellow;
            this.btnEquation.Location = new System.Drawing.Point(537, 38);
            this.btnEquation.Name = "btnEquation";
            this.btnEquation.Size = new System.Drawing.Size(69, 34);
            this.btnEquation.TabIndex = 6;
            this.btnEquation.Text = "GO";
            this.btnEquation.UseVisualStyleBackColor = false;
            this.btnEquation.Click += new System.EventHandler(this.btnEquation_Click);
            // 
            // lblEquation
            // 
            this.lblEquation.AutoSize = true;
            this.lblEquation.BackColor = System.Drawing.Color.Red;
            this.lblEquation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquation.Location = new System.Drawing.Point(49, 94);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(64, 15);
            this.lblEquation.TabIndex = 7;
            this.lblEquation.Text = "Equation is:";
            // 
            // btnAddX
            // 
            this.btnAddX.BackColor = System.Drawing.Color.Yellow;
            this.btnAddX.Location = new System.Drawing.Point(152, 145);
            this.btnAddX.Name = "btnAddX";
            this.btnAddX.Size = new System.Drawing.Size(157, 34);
            this.btnAddX.TabIndex = 9;
            this.btnAddX.Text = "AddXPoint";
            this.btnAddX.UseVisualStyleBackColor = false;
            this.btnAddX.Click += new System.EventHandler(this.btnAddX_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(36, 153);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(91, 20);
            this.txtAdd.TabIndex = 8;
            // 
            // btnAddY
            // 
            this.btnAddY.BackColor = System.Drawing.Color.Yellow;
            this.btnAddY.Location = new System.Drawing.Point(314, 145);
            this.btnAddY.Name = "btnAddY";
            this.btnAddY.Size = new System.Drawing.Size(157, 34);
            this.btnAddY.TabIndex = 10;
            this.btnAddY.Text = "AddYPoint";
            this.btnAddY.UseVisualStyleBackColor = false;
            this.btnAddY.Click += new System.EventHandler(this.btnAddY_Click);
            // 
            // lstAddX
            // 
            this.lstAddX.BackColor = System.Drawing.Color.Lime;
            this.lstAddX.FormattingEnabled = true;
            this.lstAddX.Location = new System.Drawing.Point(36, 185);
            this.lstAddX.Name = "lstAddX";
            this.lstAddX.Size = new System.Drawing.Size(287, 134);
            this.lstAddX.TabIndex = 11;
            // 
            // lstAddY
            // 
            this.lstAddY.BackColor = System.Drawing.Color.Lime;
            this.lstAddY.FormattingEnabled = true;
            this.lstAddY.Location = new System.Drawing.Point(329, 185);
            this.lstAddY.Name = "lstAddY";
            this.lstAddY.Size = new System.Drawing.Size(287, 134);
            this.lstAddY.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Location = new System.Drawing.Point(36, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(157, 34);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "&ClearAll";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPlot
            // 
            this.btnPlot.BackColor = System.Drawing.Color.Yellow;
            this.btnPlot.Location = new System.Drawing.Point(36, 374);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(157, 34);
            this.btnPlot.TabIndex = 14;
            this.btnPlot.Text = "&Plot";
            this.btnPlot.UseVisualStyleBackColor = false;
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(651, 12);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(101, 73);
            this.btnQNext.TabIndex = 15;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.btnPlot);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstAddY);
            this.Controls.Add(this.lstAddX);
            this.Controls.Add(this.btnAddY);
            this.Controls.Add(this.btnAddX);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.btnEquation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPart3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPart2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPart1);
            this.Name = "Form1";
            this.Text = "GRADIE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPart3;
        private System.Windows.Forms.Button btnEquation;
        private System.Windows.Forms.Label lblEquation;
        private System.Windows.Forms.Button btnAddX;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAddY;
        private System.Windows.Forms.ListBox lstAddX;
        private System.Windows.Forms.ListBox lstAddY;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.Button btnQNext;
    }
}

