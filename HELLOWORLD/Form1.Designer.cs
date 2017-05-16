namespace HELLOWORLD
{
    partial class Form1
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
            this.btnhw = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tbxHello = new System.Windows.Forms.TextBox();
            this.btnShowWindow = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhw
            // 
            this.btnhw.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnhw.Location = new System.Drawing.Point(40, 33);
            this.btnhw.Margin = new System.Windows.Forms.Padding(4);
            this.btnhw.Name = "btnhw";
            this.btnhw.Size = new System.Drawing.Size(161, 50);
            this.btnhw.TabIndex = 0;
            this.btnhw.Text = "Hello World!";
            this.btnhw.UseVisualStyleBackColor = true;
            this.btnhw.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.Location = new System.Drawing.Point(16, 379);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(161, 50);
            this.btnexit.TabIndex = 1;
            this.btnexit.Text = "Exit.";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.Location = new System.Drawing.Point(239, 18);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(278, 39);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Lable - Hello World!";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(13, 443);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(188, 18);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LinkLable - About me";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tbxHello
            // 
            this.tbxHello.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbxHello.Location = new System.Drawing.Point(245, 84);
            this.tbxHello.Name = "tbxHello";
            this.tbxHello.Size = new System.Drawing.Size(272, 34);
            this.tbxHello.TabIndex = 4;
            this.tbxHello.Text = "Textbox - Hello World!";
            // 
            // btnShowWindow
            // 
            this.btnShowWindow.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShowWindow.Location = new System.Drawing.Point(40, 124);
            this.btnShowWindow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowWindow.Name = "btnShowWindow";
            this.btnShowWindow.Size = new System.Drawing.Size(161, 50);
            this.btnShowWindow.TabIndex = 5;
            this.btnShowWindow.Text = "显示随机数窗口";
            this.btnShowWindow.UseVisualStyleBackColor = true;
            this.btnShowWindow.Click += new System.EventHandler(this.btnShowWindow_Click);
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFile.Location = new System.Drawing.Point(40, 208);
            this.btnFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(161, 50);
            this.btnFile.TabIndex = 6;
            this.btnFile.Text = "文件读写";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 480);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnShowWindow);
            this.Controls.Add(this.tbxHello);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnhw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Click);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhw;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tbxHello;
        private System.Windows.Forms.Button btnShowWindow;
        private System.Windows.Forms.Button btnFile;
    }
}

