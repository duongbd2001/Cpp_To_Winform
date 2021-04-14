namespace WinformsBasicProgramming
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
            this.btnClick = new System.Windows.Forms.Button();
            this.txbValue = new System.Windows.Forms.TextBox();
            this.lbValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.AutoSize = true;
            this.btnClick.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnClick.FlatAppearance.BorderSize = 3;
            this.btnClick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btnClick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClick.Location = new System.Drawing.Point(479, 287);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 31);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Enter";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txbValue
            // 
            this.txbValue.Location = new System.Drawing.Point(454, 170);
            this.txbValue.Multiline = true;
            this.txbValue.Name = "txbValue";
            this.txbValue.Size = new System.Drawing.Size(100, 78);
            this.txbValue.TabIndex = 1;
            // 
            // lbValue
            // 
            this.lbValue.AutoSize = true;
            this.lbValue.Location = new System.Drawing.Point(262, 178);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(54, 15);
            this.lbValue.TabIndex = 2;
            this.lbValue.Text = "Nhập số ";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.txbValue);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Nhập chiều cao của bạn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txbValue;
        private System.Windows.Forms.Label lbValue;
    }
}

