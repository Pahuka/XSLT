namespace XSLT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.xsltProcess = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addElemCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xsltProcess
            // 
            this.xsltProcess.Location = new System.Drawing.Point(331, 73);
            this.xsltProcess.Name = "xsltProcess";
            this.xsltProcess.Size = new System.Drawing.Size(135, 40);
            this.xsltProcess.TabIndex = 0;
            this.xsltProcess.Text = "XSLT преобразование";
            this.xsltProcess.UseVisualStyleBackColor = true;
            this.xsltProcess.Click += new System.EventHandler(this.xsltProcess_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(300, 426);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(488, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(300, 426);
            this.textBox2.TabIndex = 2;
            // 
            // addElemCount
            // 
            this.addElemCount.Location = new System.Drawing.Point(331, 136);
            this.addElemCount.Name = "addElemCount";
            this.addElemCount.Size = new System.Drawing.Size(135, 40);
            this.addElemCount.TabIndex = 3;
            this.addElemCount.Text = "Добавить атрибут count в list.xml";
            this.addElemCount.UseVisualStyleBackColor = true;
            this.addElemCount.Click += new System.EventHandler(this.addElemCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addElemCount);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.xsltProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xsltProcess;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addElemCount;
    }
}

