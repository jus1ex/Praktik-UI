
namespace Praktik_UI
{
    partial class AddRecord2
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
            this.textBoxArticle2 = new System.Windows.Forms.TextBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxAmount2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPrice2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxArticle2
            // 
            this.textBoxArticle2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxArticle2.Location = new System.Drawing.Point(66, 12);
            this.textBoxArticle2.Name = "textBoxArticle2";
            this.textBoxArticle2.Size = new System.Drawing.Size(100, 22);
            this.textBoxArticle2.TabIndex = 0;
            this.textBoxArticle2.Text = "Артикул";
            this.textBoxArticle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxArticle2.Enter += new System.EventHandler(this.textBoxArticle2_Enter);
            this.textBoxArticle2.Leave += new System.EventHandler(this.textBoxArticle2_Leave);
            // 
            // textBoxName2
            // 
            this.textBoxName2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName2.Location = new System.Drawing.Point(66, 40);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(100, 22);
            this.textBoxName2.TabIndex = 1;
            this.textBoxName2.Text = "Название";
            this.textBoxName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName2.Enter += new System.EventHandler(this.textBoxName2_Enter);
            this.textBoxName2.Leave += new System.EventHandler(this.textBoxName2_Leave);
            // 
            // textBoxAmount2
            // 
            this.textBoxAmount2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAmount2.Location = new System.Drawing.Point(66, 68);
            this.textBoxAmount2.Name = "textBoxAmount2";
            this.textBoxAmount2.Size = new System.Drawing.Size(100, 22);
            this.textBoxAmount2.TabIndex = 2;
            this.textBoxAmount2.Text = "Количество";
            this.textBoxAmount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAmount2.Enter += new System.EventHandler(this.textBoxAmount2_Enter);
            this.textBoxAmount2.Leave += new System.EventHandler(this.textBoxAmount2_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPrice2
            // 
            this.textBoxPrice2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPrice2.Location = new System.Drawing.Point(66, 96);
            this.textBoxPrice2.Name = "textBoxPrice2";
            this.textBoxPrice2.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice2.TabIndex = 4;
            this.textBoxPrice2.Text = "Цена";
            this.textBoxPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice2.Enter += new System.EventHandler(this.textBoxPrice2_Enter);
            this.textBoxPrice2.Leave += new System.EventHandler(this.textBoxPrice2_Leave);
            // 
            // AddRecord2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 174);
            this.Controls.Add(this.textBoxPrice2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAmount2);
            this.Controls.Add(this.textBoxName2);
            this.Controls.Add(this.textBoxArticle2);
            this.Name = "AddRecord2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArticle2;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.TextBox textBoxAmount2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrice2;
    }
}