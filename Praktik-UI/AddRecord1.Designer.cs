
namespace Praktik_UI
{
    partial class AddRecord1
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
            this.textBoxArticle1 = new System.Windows.Forms.TextBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.textBoxAmount1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPrice1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxArticle1
            // 
            this.textBoxArticle1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxArticle1.Location = new System.Drawing.Point(72, 12);
            this.textBoxArticle1.Name = "textBoxArticle1";
            this.textBoxArticle1.Size = new System.Drawing.Size(100, 22);
            this.textBoxArticle1.TabIndex = 0;
            this.textBoxArticle1.Text = "Артикул";
            this.textBoxArticle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxArticle1.Enter += new System.EventHandler(this.textBoxArticle1_Enter);
            this.textBoxArticle1.Leave += new System.EventHandler(this.textBoxArticle1_Leave);
            // 
            // textBoxName1
            // 
            this.textBoxName1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName1.Location = new System.Drawing.Point(72, 40);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(100, 22);
            this.textBoxName1.TabIndex = 1;
            this.textBoxName1.Text = "Название";
            this.textBoxName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBoxName1.Enter += new System.EventHandler(this.textBoxName1_Enter);
            this.textBoxName1.Leave += new System.EventHandler(this.textBoxName1_Leave);
            // 
            // textBoxAmount1
            // 
            this.textBoxAmount1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAmount1.Location = new System.Drawing.Point(72, 68);
            this.textBoxAmount1.Name = "textBoxAmount1";
            this.textBoxAmount1.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmount1.TabIndex = 2;
            this.textBoxAmount1.Text = "Количество";
            this.textBoxAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAmount1.Enter += new System.EventHandler(this.textBoxAmount1_Enter);
            this.textBoxAmount1.Leave += new System.EventHandler(this.textBoxAmount1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPrice1
            // 
            this.textBoxPrice1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPrice1.Location = new System.Drawing.Point(72, 96);
            this.textBoxPrice1.Name = "textBoxPrice1";
            this.textBoxPrice1.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice1.TabIndex = 4;
            this.textBoxPrice1.Text = "Цена";
            this.textBoxPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice1.Enter += new System.EventHandler(this.textBoxPrice1_Enter);
            this.textBoxPrice1.Leave += new System.EventHandler(this.textBoxPrice1_Leave);
            // 
            // AddRecord1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 174);
            this.Controls.Add(this.textBoxPrice1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAmount1);
            this.Controls.Add(this.textBoxName1);
            this.Controls.Add(this.textBoxArticle1);
            this.Name = "AddRecord1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecord1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArticle1;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.TextBox textBoxAmount1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrice1;
    }
}