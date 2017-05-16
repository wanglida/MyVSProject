namespace HELLOWORLD
{
    partial class FormFile
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
            this.btnRead = new System.Windows.Forms.Button();
            this.textBoxShow = new System.Windows.Forms.TextBox();
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.labelRead = new System.Windows.Forms.Label();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.labelWrite = new System.Windows.Forms.Label();
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead.Location = new System.Drawing.Point(304, 23);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(104, 38);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "读文件";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(41, 112);
            this.textBoxShow.Multiline = true;
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(826, 457);
            this.textBoxShow.TabIndex = 3;
            // 
            // textBoxRead
            // 
            this.textBoxRead.Location = new System.Drawing.Point(170, 28);
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.Size = new System.Drawing.Size(113, 25);
            this.textBoxRead.TabIndex = 1;
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRead.Location = new System.Drawing.Point(45, 33);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(109, 20);
            this.labelRead.TabIndex = 5;
            this.labelRead.Text = "文件位置：";
            // 
            // buttonWrite
            // 
            this.buttonWrite.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonWrite.Location = new System.Drawing.Point(304, 69);
            this.buttonWrite.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(104, 38);
            this.buttonWrite.TabIndex = 6;
            this.buttonWrite.Text = "写文件";
            this.buttonWrite.UseVisualStyleBackColor = true;
            // 
            // labelWrite
            // 
            this.labelWrite.AutoSize = true;
            this.labelWrite.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWrite.Location = new System.Drawing.Point(45, 79);
            this.labelWrite.Name = "labelWrite";
            this.labelWrite.Size = new System.Drawing.Size(109, 20);
            this.labelWrite.TabIndex = 8;
            this.labelWrite.Text = "文件内容：";
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Location = new System.Drawing.Point(170, 74);
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.Size = new System.Drawing.Size(113, 25);
            this.textBoxWrite.TabIndex = 2;
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 620);
            this.Controls.Add(this.labelWrite);
            this.Controls.Add(this.textBoxWrite);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.labelRead);
            this.Controls.Add(this.textBoxRead);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.btnRead);
            this.Name = "FormFile";
            this.Text = "FormFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox textBoxShow;
        private System.Windows.Forms.TextBox textBoxRead;
        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label labelWrite;
        private System.Windows.Forms.TextBox textBoxWrite;
    }
}