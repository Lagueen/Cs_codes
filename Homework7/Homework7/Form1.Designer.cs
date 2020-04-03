using System;

namespace Homework7
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.draw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pens_value = new System.Windows.Forms.ComboBox();
            this.th2_value = new System.Windows.Forms.TextBox();
            this.th_2 = new System.Windows.Forms.Label();
            this.th1_value = new System.Windows.Forms.TextBox();
            this.th_1 = new System.Windows.Forms.Label();
            this.per2_value = new System.Windows.Forms.TextBox();
            this.per_2 = new System.Windows.Forms.Label();
            this.per1_value = new System.Windows.Forms.TextBox();
            this.per_1 = new System.Windows.Forms.Label();
            this.leng_value = new System.Windows.Forms.TextBox();
            this.leng_ = new System.Windows.Forms.Label();
            this.n_ = new System.Windows.Forms.Label();
            this.n_value = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // draw
            // 
            this.draw.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw.Location = new System.Drawing.Point(88, 394);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(99, 42);
            this.draw.TabIndex = 0;
            this.draw.Text = "draw";
            this.draw.UseVisualStyleBackColor = true;
            this.draw.Click += new System.EventHandler(this.draw_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.draw);
            this.panel1.Controls.Add(this.pens_value);
            this.panel1.Controls.Add(this.th2_value);
            this.panel1.Controls.Add(this.th_2);
            this.panel1.Controls.Add(this.th1_value);
            this.panel1.Controls.Add(this.th_1);
            this.panel1.Controls.Add(this.per2_value);
            this.panel1.Controls.Add(this.per_2);
            this.panel1.Controls.Add(this.per1_value);
            this.panel1.Controls.Add(this.per_1);
            this.panel1.Controls.Add(this.leng_value);
            this.panel1.Controls.Add(this.leng_);
            this.panel1.Controls.Add(this.n_);
            this.panel1.Controls.Add(this.n_value);
            this.panel1.Location = new System.Drawing.Point(559, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 475);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "画笔颜色：";
            // 
            // pens_value
            // 
            this.pens_value.FormattingEnabled = true;
            this.pens_value.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "Yellow"});
            this.pens_value.Location = new System.Drawing.Point(113, 309);
            this.pens_value.Name = "pens_value";
            this.pens_value.Size = new System.Drawing.Size(121, 23);
            this.pens_value.TabIndex = 12;
            // 
            // th2_value
            // 
            this.th2_value.Location = new System.Drawing.Point(128, 273);
            this.th2_value.Name = "th2_value";
            this.th2_value.Size = new System.Drawing.Size(100, 25);
            this.th2_value.TabIndex = 11;
            // 
            // th_2
            // 
            this.th_2.AutoSize = true;
            this.th_2.Location = new System.Drawing.Point(25, 276);
            this.th_2.Name = "th_2";
            this.th_2.Size = new System.Drawing.Size(97, 15);
            this.th_2.TabIndex = 10;
            this.th_2.Text = "左分支角度：";
            // 
            // th1_value
            // 
            this.th1_value.Location = new System.Drawing.Point(128, 235);
            this.th1_value.Name = "th1_value";
            this.th1_value.Size = new System.Drawing.Size(100, 25);
            this.th1_value.TabIndex = 9;
            // 
            // th_1
            // 
            this.th_1.AutoSize = true;
            this.th_1.Location = new System.Drawing.Point(25, 238);
            this.th_1.Name = "th_1";
            this.th_1.Size = new System.Drawing.Size(97, 15);
            this.th_1.TabIndex = 8;
            this.th_1.Text = "右分支角度：";
            // 
            // per2_value
            // 
            this.per2_value.Location = new System.Drawing.Point(143, 197);
            this.per2_value.Name = "per2_value";
            this.per2_value.Size = new System.Drawing.Size(100, 25);
            this.per2_value.TabIndex = 7;
            // 
            // per_2
            // 
            this.per_2.AutoSize = true;
            this.per_2.Location = new System.Drawing.Point(25, 200);
            this.per_2.Name = "per_2";
            this.per_2.Size = new System.Drawing.Size(112, 15);
            this.per_2.TabIndex = 6;
            this.per_2.Text = "左分支长度比：";
            // 
            // per1_value
            // 
            this.per1_value.Location = new System.Drawing.Point(143, 162);
            this.per1_value.Name = "per1_value";
            this.per1_value.Size = new System.Drawing.Size(100, 25);
            this.per1_value.TabIndex = 5;
            // 
            // per_1
            // 
            this.per_1.AutoSize = true;
            this.per_1.Location = new System.Drawing.Point(25, 165);
            this.per_1.Name = "per_1";
            this.per_1.Size = new System.Drawing.Size(112, 15);
            this.per_1.TabIndex = 4;
            this.per_1.Text = "右分支长度比：";
            // 
            // leng_value
            // 
            this.leng_value.Location = new System.Drawing.Point(113, 129);
            this.leng_value.Name = "leng_value";
            this.leng_value.Size = new System.Drawing.Size(100, 25);
            this.leng_value.TabIndex = 3;
            // 
            // leng_
            // 
            this.leng_.AutoSize = true;
            this.leng_.Location = new System.Drawing.Point(25, 132);
            this.leng_.Name = "leng_";
            this.leng_.Size = new System.Drawing.Size(82, 15);
            this.leng_.TabIndex = 2;
            this.leng_.Text = "主干长度：";
            // 
            // n_
            // 
            this.n_.AutoSize = true;
            this.n_.Location = new System.Drawing.Point(25, 99);
            this.n_.Name = "n_";
            this.n_.Size = new System.Drawing.Size(82, 15);
            this.n_.TabIndex = 1;
            this.n_.Text = "递归深度：";
            // 
            // n_value
            // 
            this.n_value.Location = new System.Drawing.Point(113, 98);
            this.n_value.Name = "n_value";
            this.n_value.Size = new System.Drawing.Size(100, 25);
            this.n_value.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 589);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void draw_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button draw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox n_value;
        private System.Windows.Forms.TextBox leng_value;
        private System.Windows.Forms.Label leng_;
        private System.Windows.Forms.Label n_;
        private System.Windows.Forms.Label per_1;
        private System.Windows.Forms.TextBox per1_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox pens_value;
        private System.Windows.Forms.TextBox th2_value;
        private System.Windows.Forms.Label th_2;
        private System.Windows.Forms.TextBox th1_value;
        private System.Windows.Forms.Label th_1;
        private System.Windows.Forms.TextBox per2_value;
        private System.Windows.Forms.Label per_2;
    }
}

