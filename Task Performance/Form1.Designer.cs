namespace Task_Performance
{
    partial class FrmBasicCalculator
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(247)))));
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(62, 93);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(254, 18);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "    0";
            // 
            // txt2
            // 
            this.txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(247)))));
            this.txt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(62, 166);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(254, 18);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "    0";
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(247)))));
            this.cb.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.cb.Location = new System.Drawing.Point(161, 134);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(59, 26);
            this.cb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Basic Calculator";
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(247)))));
            this.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompute.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCompute.Location = new System.Drawing.Point(130, 332);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(114, 30);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pnl.Controls.Add(this.label3);
            this.pnl.Controls.Add(this.label2);
            this.pnl.Location = new System.Drawing.Point(65, 212);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(254, 100);
            this.pnl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(92, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 1;
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(166)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(377, 405);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "FrmBasicCalculator";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

