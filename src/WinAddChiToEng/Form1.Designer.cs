namespace WinAddChiToEng
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.EngText = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.city = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lane = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.alley = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num_hyphen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hyphen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.suite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cityarea = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EngText
            // 
            this.EngText.Location = new System.Drawing.Point(19, 16);
            this.EngText.Multiline = true;
            this.EngText.Name = "EngText";
            this.EngText.Size = new System.Drawing.Size(451, 48);
            this.EngText.TabIndex = 0;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button.Location = new System.Drawing.Point(166, 191);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 3;
            this.button.Text = "轉 換";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "清 空";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(52, 30);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 22);
            this.city.TabIndex = 12;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(236, 69);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(121, 22);
            this.street.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(416, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "室";
            // 
            // lane
            // 
            this.lane.Location = new System.Drawing.Point(52, 107);
            this.lane.Name = "lane";
            this.lane.Size = new System.Drawing.Size(28, 22);
            this.lane.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "樓之";
            // 
            // alley
            // 
            this.alley.Location = new System.Drawing.Point(109, 107);
            this.alley.Name = "alley";
            this.alley.Size = new System.Drawing.Size(28, 22);
            this.alley.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "號之";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(166, 107);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(28, 22);
            this.num.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "弄";
            // 
            // num_hyphen
            // 
            this.num_hyphen.Location = new System.Drawing.Point(232, 107);
            this.num_hyphen.Name = "num_hyphen";
            this.num_hyphen.Size = new System.Drawing.Size(28, 22);
            this.num_hyphen.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "巷";
            // 
            // fl
            // 
            this.fl.Location = new System.Drawing.Point(286, 107);
            this.fl.Name = "fl";
            this.fl.Size = new System.Drawing.Size(28, 22);
            this.fl.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "道路或街名";
            // 
            // hyphen
            // 
            this.hyphen.Location = new System.Drawing.Point(348, 107);
            this.hyphen.Name = "hyphen";
            this.hyphen.Size = new System.Drawing.Size(28, 22);
            this.hyphen.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "市區";
            // 
            // suite
            // 
            this.suite.Location = new System.Drawing.Point(382, 107);
            this.suite.Name = "suite";
            this.suite.Size = new System.Drawing.Size(28, 22);
            this.suite.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "縣市";
            // 
            // cityarea
            // 
            this.cityarea.Location = new System.Drawing.Point(52, 69);
            this.cityarea.Name = "cityarea";
            this.cityarea.Size = new System.Drawing.Size(100, 22);
            this.cityarea.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cityarea);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.suite);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.hyphen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.fl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.num_hyphen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.num);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.alley);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lane);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.street);
            this.panel1.Controls.Add(this.city);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 151);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.EngText);
            this.panel2.Location = new System.Drawing.Point(12, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 81);
            this.panel2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(513, 331);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "AddressTrans";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox EngText;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox lane;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox alley;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num_hyphen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hyphen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox suite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityarea;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

