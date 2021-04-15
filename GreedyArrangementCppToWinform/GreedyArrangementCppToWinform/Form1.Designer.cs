namespace GreedyArrangementCppToWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb1Text = new System.Windows.Forms.Label();
            this.txbValueArray1 = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.lb2Text = new System.Windows.Forms.Label();
            this.lb3Text = new System.Windows.Forms.Label();
            this.txbValueArray2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb1Text
            // 
            this.lb1Text.AutoSize = true;
            this.lb1Text.Location = new System.Drawing.Point(12, 116);
            this.lb1Text.Name = "lb1Text";
            this.lb1Text.Size = new System.Drawing.Size(135, 15);
            this.lb1Text.TabIndex = 0;
            this.lb1Text.Text = "Nhập mảng cần sắp xếp";
            // 
            // txbValueArray1
            // 
            this.txbValueArray1.Location = new System.Drawing.Point(193, 177);
            this.txbValueArray1.Name = "txbValueArray1";
            this.txbValueArray1.Size = new System.Drawing.Size(100, 23);
            this.txbValueArray1.TabIndex = 1;
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClick.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnClick.FlatAppearance.BorderSize = 3;
            this.btnClick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnClick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Location = new System.Drawing.Point(39, 313);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 34);
            this.btnClick.TabIndex = 2;
            this.btnClick.Text = "Sắp xếp";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb2Text
            // 
            this.lb2Text.AutoSize = true;
            this.lb2Text.Location = new System.Drawing.Point(221, 116);
            this.lb2Text.Name = "lb2Text";
            this.lb2Text.Size = new System.Drawing.Size(47, 15);
            this.lb2Text.TabIndex = 3;
            this.lb2Text.Text = "Mảng 1";
            // 
            // lb3Text
            // 
            this.lb3Text.AutoSize = true;
            this.lb3Text.Location = new System.Drawing.Point(394, 116);
            this.lb3Text.Name = "lb3Text";
            this.lb3Text.Size = new System.Drawing.Size(47, 15);
            this.lb3Text.TabIndex = 4;
            this.lb3Text.Text = "Mảng 2";
            // 
            // txbValueArray2
            // 
            this.txbValueArray2.Location = new System.Drawing.Point(371, 177);
            this.txbValueArray2.Name = "txbValueArray2";
            this.txbValueArray2.Size = new System.Drawing.Size(100, 23);
            this.txbValueArray2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbValueArray2);
            this.Controls.Add(this.lb3Text);
            this.Controls.Add(this.lb2Text);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txbValueArray1);
            this.Controls.Add(this.lb1Text);
            this.Name = "Form1";
            this.Text = "Sắp xếp mảng bằng Greedy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1Text;
        private System.Windows.Forms.TextBox txbValueArray1;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lb2Text;
        private System.Windows.Forms.Label lb3Text;
        private System.Windows.Forms.TextBox txbValueArray2;
    }
}

