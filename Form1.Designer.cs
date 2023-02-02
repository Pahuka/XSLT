namespace XSLT
{
    partial class XSLT
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
            this.inputFile = new System.Windows.Forms.TextBox();
            this.resultFile = new System.Windows.Forms.TextBox();
            this.addElemCount = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.resultPath = new System.Windows.Forms.TextBox();
            this.inputPath = new System.Windows.Forms.TextBox();
            this.openXSL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xsltProcess
            // 
            this.xsltProcess.Location = new System.Drawing.Point(324, 250);
            this.xsltProcess.Name = "xsltProcess";
            this.xsltProcess.Size = new System.Drawing.Size(135, 40);
            this.xsltProcess.TabIndex = 0;
            this.xsltProcess.Text = "XSLT преобразование";
            this.xsltProcess.UseVisualStyleBackColor = true;
            this.xsltProcess.Click += new System.EventHandler(this.xsltProcess_Click_1);
            // 
            // inputFile
            // 
            this.inputFile.Location = new System.Drawing.Point(12, 39);
            this.inputFile.Multiline = true;
            this.inputFile.Name = "inputFile";
            this.inputFile.ReadOnly = true;
            this.inputFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputFile.Size = new System.Drawing.Size(300, 399);
            this.inputFile.TabIndex = 1;
            // 
            // resultFile
            // 
            this.resultFile.Location = new System.Drawing.Point(471, 39);
            this.resultFile.Multiline = true;
            this.resultFile.Name = "resultFile";
            this.resultFile.ReadOnly = true;
            this.resultFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultFile.Size = new System.Drawing.Size(300, 400);
            this.resultFile.TabIndex = 2;
            // 
            // addElemCount
            // 
            this.addElemCount.Location = new System.Drawing.Point(324, 346);
            this.addElemCount.Name = "addElemCount";
            this.addElemCount.Size = new System.Drawing.Size(135, 40);
            this.addElemCount.TabIndex = 3;
            this.addElemCount.Text = "Добавить атрибут в выбранный xml файл";
            this.addElemCount.UseVisualStyleBackColor = true;
            this.addElemCount.Click += new System.EventHandler(this.addElemCount_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(324, 58);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(135, 40);
            this.openFile.TabIndex = 4;
            this.openFile.Text = "Открыть xml файл";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // resultPath
            // 
            this.resultPath.Location = new System.Drawing.Point(471, 13);
            this.resultPath.Name = "resultPath";
            this.resultPath.Size = new System.Drawing.Size(300, 20);
            this.resultPath.TabIndex = 5;
            // 
            // inputPath
            // 
            this.inputPath.Enabled = false;
            this.inputPath.Location = new System.Drawing.Point(13, 13);
            this.inputPath.Name = "inputPath";
            this.inputPath.Size = new System.Drawing.Size(299, 20);
            this.inputPath.TabIndex = 6;
            // 
            // openXSL
            // 
            this.openXSL.Location = new System.Drawing.Point(324, 154);
            this.openXSL.Name = "openXSL";
            this.openXSL.Size = new System.Drawing.Size(135, 40);
            this.openXSL.TabIndex = 7;
            this.openXSL.Text = "Выбрать XSL схему";
            this.openXSL.UseVisualStyleBackColor = true;
            this.openXSL.Click += new System.EventHandler(this.openXSL_Click);
            // 
            // XSLT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 451);
            this.Controls.Add(this.openXSL);
            this.Controls.Add(this.inputPath);
            this.Controls.Add(this.resultPath);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.addElemCount);
            this.Controls.Add(this.resultFile);
            this.Controls.Add(this.inputFile);
            this.Controls.Add(this.xsltProcess);
            this.Name = "XSLT";
            this.Text = "XSLT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button xsltProcess;
        private System.Windows.Forms.TextBox inputFile;
        private System.Windows.Forms.TextBox resultFile;
        private System.Windows.Forms.Button addElemCount;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.TextBox resultPath;
        private System.Windows.Forms.TextBox inputPath;
        private System.Windows.Forms.Button openXSL;
    }
}

