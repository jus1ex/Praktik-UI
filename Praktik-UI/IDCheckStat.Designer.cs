namespace Praktik_UI
{
    partial class IDCheckStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDCheckStat));
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.Load_Button = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.Location = new System.Drawing.Point(12, 12);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(202, 26);
            this.textBoxArticle.TabIndex = 0;
            this.textBoxArticle.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBoxArticle.Leave += new System.EventHandler(this.textBoxArticle_Leave);
            // 
            // Load_Button
            // 
            this.Load_Button.Location = new System.Drawing.Point(12, 44);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(98, 36);
            this.Load_Button.TabIndex = 1;
            this.Load_Button.Text = "Загрузка";
            this.Load_Button.UseVisualStyleBackColor = true;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(116, 44);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(98, 36);
            this.ApplyButton.TabIndex = 2;
            this.ApplyButton.Text = "Вывод";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // IDCheckStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 98);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.Load_Button);
            this.Controls.Add(this.textBoxArticle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "IDCheckStat";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.IDCheckStat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.Button Load_Button;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}