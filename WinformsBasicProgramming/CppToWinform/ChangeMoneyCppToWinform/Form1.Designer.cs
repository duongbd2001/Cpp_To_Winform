namespace ChangeMoneyCppToWinform
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
            this.txbValue1 = new System.Windows.Forms.TextBox();
            this.lb1Text = new System.Windows.Forms.Label();
            this.lb2Text = new System.Windows.Forms.Label();
            this.txbValueMoney2 = new System.Windows.Forms.TextBox();
            this.lbText3 = new System.Windows.Forms.Label();
            this.txbValue3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(113, 240);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Đổi tiền";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txbValue1
            // 
            this.txbValue1.Location = new System.Drawing.Point(291, 96);
            this.txbValue1.Name = "txbValue1";
            this.txbValue1.Size = new System.Drawing.Size(192, 23);
            this.txbValue1.TabIndex = 1;
            // 
            // lb1Text
            // 
            this.lb1Text.AutoSize = true;
            this.lb1Text.Location = new System.Drawing.Point(113, 104);
            this.lb1Text.Name = "lb1Text";
            this.lb1Text.Size = new System.Drawing.Size(85, 15);
            this.lb1Text.TabIndex = 2;
            this.lb1Text.Text = "Tờ tiền cần đổi";
            // 
            // lb2Text
            // 
            this.lb2Text.AutoSize = true;
            this.lb2Text.Location = new System.Drawing.Point(113, 166);
            this.lb2Text.Name = "lb2Text";
            this.lb2Text.Size = new System.Drawing.Size(94, 15);
            this.lb2Text.TabIndex = 3;
            this.lb2Text.Text = "Mệnh giá sẵn có";
            // 
            // txbValueMoney2
            // 
            this.txbValueMoney2.Location = new System.Drawing.Point(291, 163);
            this.txbValueMoney2.Name = "txbValueMoney2";
            this.txbValueMoney2.Size = new System.Drawing.Size(192, 23);
            this.txbValueMoney2.TabIndex = 4;
            this.txbValueMoney2.Text = " 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1";
            // 
            // lbText3
            // 
            this.lbText3.AutoSize = true;
            this.lbText3.Location = new System.Drawing.Point(113, 333);
            this.lbText3.Name = "lbText3";
            this.lbText3.Size = new System.Drawing.Size(113, 15);
            this.lbText3.TabIndex = 5;
            this.lbText3.Text = "Mệnh giá đổi được :";
            // 
            // txbValue3
            // 
            this.txbValue3.Location = new System.Drawing.Point(291, 324);
            this.txbValue3.Name = "txbValue3";
            this.txbValue3.Size = new System.Drawing.Size(100, 23);
            this.txbValue3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbValue3);
            this.Controls.Add(this.lbText3);
            this.Controls.Add(this.txbValueMoney2);
            this.Controls.Add(this.lb2Text);
            this.Controls.Add(this.lb1Text);
            this.Controls.Add(this.txbValue1);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txbValue1;
        private System.Windows.Forms.Label lb1Text;
        private System.Windows.Forms.Label lb2Text;
        private System.Windows.Forms.TextBox txbValueMoney2;
        private System.Windows.Forms.Label lbText3;
        public System.Windows.Forms.TextBox txbValue3;
    }
}

