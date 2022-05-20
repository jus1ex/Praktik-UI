
namespace Praktik_UI
{
    partial class AddRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecord));
            this.textBoxArticle = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxArticle
            // 
            this.textBoxArticle.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxArticle.Location = new System.Drawing.Point(86, 15);
            this.textBoxArticle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxArticle.Name = "textBoxArticle";
            this.textBoxArticle.Size = new System.Drawing.Size(112, 26);
            this.textBoxArticle.TabIndex = 0;
            this.textBoxArticle.Tag = "";
            this.textBoxArticle.Text = "Артикул";
            this.textBoxArticle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxArticle.Enter += new System.EventHandler(this.textBoxArticle_Enter);
            this.textBoxArticle.Leave += new System.EventHandler(this.textBoxArticle_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxName.Location = new System.Drawing.Point(86, 50);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(112, 26);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Название";
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAmount.Location = new System.Drawing.Point(86, 85);
            this.textBoxAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(112, 26);
            this.textBoxAmount.TabIndex = 2;
            this.textBoxAmount.Text = "Количество";
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxAmount.Enter += new System.EventHandler(this.textBoxAmount_Enter);
            this.textBoxAmount.Leave += new System.EventHandler(this.textBoxAmount_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 174);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPrice.Location = new System.Drawing.Point(86, 120);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(112, 26);
            this.textBoxPrice.TabIndex = 4;
            this.textBoxPrice.Text = "Цена";
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPrice.Enter += new System.EventHandler(this.textBoxPrice_Enter);
            this.textBoxPrice.Leave += new System.EventHandler(this.textBoxPrice_Leave);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 218);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxArticle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AddRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRecord";
            this.Load += new System.EventHandler(this.AddRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxArticle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPrice;
    }
}