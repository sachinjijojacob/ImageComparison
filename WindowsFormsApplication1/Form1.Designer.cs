namespace WindowsFormsApplication1
{
    partial class Cmpimg
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tUrl1 = new System.Windows.Forms.TextBox();
            this.tURL2 = new System.Windows.Forms.TextBox();
            this.bComp = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.p2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(401, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL 2";
            // 
            // tUrl1
            // 
            this.tUrl1.Location = new System.Drawing.Point(90, 22);
            this.tUrl1.Name = "tUrl1";
            this.tUrl1.Size = new System.Drawing.Size(243, 20);
            this.tUrl1.TabIndex = 2;
            // 
            // tURL2
            // 
            this.tURL2.Location = new System.Drawing.Point(479, 22);
            this.tURL2.Name = "tURL2";
            this.tURL2.Size = new System.Drawing.Size(243, 20);
            this.tURL2.TabIndex = 3;
            // 
            // bComp
            // 
            this.bComp.Location = new System.Drawing.Point(340, 424);
            this.bComp.Name = "bComp";
            this.bComp.Size = new System.Drawing.Size(75, 23);
            this.bComp.TabIndex = 4;
            this.bComp.Text = "Compare";
            this.bComp.UseVisualStyleBackColor = true;
            this.bComp.Click += new System.EventHandler(this.bComp_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(217, 363);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(340, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(90, 80);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(243, 204);
            this.p1.TabIndex = 6;
            this.p1.TabStop = false;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(479, 80);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(243, 204);
            this.p2.TabIndex = 7;
            this.p2.TabStop = false;
            // 
            // Cmpimg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 483);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bComp);
            this.Controls.Add(this.tURL2);
            this.Controls.Add(this.tUrl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cmpimg";
            this.Text = "COMPARE IMAGE";
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tUrl1;
        private System.Windows.Forms.TextBox tURL2;
        private System.Windows.Forms.Button bComp;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p2;
    }
}

