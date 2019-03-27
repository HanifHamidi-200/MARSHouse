namespace SIMPL
{
    partial class START
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(START));
            this.picRoll1 = new System.Windows.Forms.PictureBox();
            this.picRoll2 = new System.Windows.Forms.PictureBox();
            this.btnRoll1 = new System.Windows.Forms.Button();
            this.btnRoll2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picRoll1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoll2)).BeginInit();
            this.SuspendLayout();
            // 
            // picRoll1
            // 
            this.picRoll1.Image = ((System.Drawing.Image)(resources.GetObject("picRoll1.Image")));
            this.picRoll1.Location = new System.Drawing.Point(45, 53);
            this.picRoll1.Name = "picRoll1";
            this.picRoll1.Size = new System.Drawing.Size(107, 90);
            this.picRoll1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoll1.TabIndex = 0;
            this.picRoll1.TabStop = false;
            this.picRoll1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picRoll2
            // 
            this.picRoll2.Image = ((System.Drawing.Image)(resources.GetObject("picRoll2.Image")));
            this.picRoll2.Location = new System.Drawing.Point(45, 165);
            this.picRoll2.Name = "picRoll2";
            this.picRoll2.Size = new System.Drawing.Size(107, 90);
            this.picRoll2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRoll2.TabIndex = 1;
            this.picRoll2.TabStop = false;
            // 
            // btnRoll1
            // 
            this.btnRoll1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRoll1.Location = new System.Drawing.Point(188, 87);
            this.btnRoll1.Name = "btnRoll1";
            this.btnRoll1.Size = new System.Drawing.Size(195, 37);
            this.btnRoll1.TabIndex = 2;
            this.btnRoll1.Text = "Roll Player1";
            this.btnRoll1.UseVisualStyleBackColor = false;
            // 
            // btnRoll2
            // 
            this.btnRoll2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRoll2.Location = new System.Drawing.Point(188, 191);
            this.btnRoll2.Name = "btnRoll2";
            this.btnRoll2.Size = new System.Drawing.Size(195, 37);
            this.btnRoll2.TabIndex = 3;
            this.btnRoll2.Text = "Roll Player2";
            this.btnRoll2.UseVisualStyleBackColor = false;
            // 
            // START
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRoll2);
            this.Controls.Add(this.btnRoll1);
            this.Controls.Add(this.picRoll2);
            this.Controls.Add(this.picRoll1);
            this.Name = "START";
            this.Text = "fStart1";
            this.Load += new System.EventHandler(this.fStart1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picRoll1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRoll2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRoll1;
        private System.Windows.Forms.PictureBox picRoll2;
        private System.Windows.Forms.Button btnRoll1;
        private System.Windows.Forms.Button btnRoll2;
    }
}