namespace TRAPWS
{
    partial class fVSub4
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
            this.btnQNext = new System.Windows.Forms.Button();
            this.fra1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.fra1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(587, 32);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(99, 88);
            this.btnQNext.TabIndex = 15;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // fra1
            // 
            this.fra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fra1.Controls.Add(this.btnSave);
            this.fra1.Controls.Add(this.txtEntry);
            this.fra1.Controls.Add(this.lst1);
            this.fra1.Location = new System.Drawing.Point(220, 32);
            this.fra1.Name = "fra1";
            this.fra1.Size = new System.Drawing.Size(335, 223);
            this.fra1.TabIndex = 14;
            this.fra1.TabStop = false;
            this.fra1.Text = "Border";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Location = new System.Drawing.Point(213, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(34, 183);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(161, 20);
            this.txtEntry.TabIndex = 1;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(34, 34);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(270, 134);
            this.lst1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.btn1);
            this.flowLayoutPanel1.Controls.Add(this.btn2);
            this.flowLayoutPanel1.Controls.Add(this.btn3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 329);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Lime;
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(125, 29);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "DMDE_LiftEffect";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn2.Location = new System.Drawing.Point(3, 38);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(125, 29);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "DMDE_ActualPulley";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn3.Location = new System.Drawing.Point(3, 73);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(125, 44);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Planet9";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // fVSub4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 390);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.fra1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "fVSub4";
            this.Text = "Planet9Possibilities";
            this.Load += new System.EventHandler(this.fVSub4_Load);
            this.fra1.ResumeLayout(false);
            this.fra1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.GroupBox fra1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}