
namespace Praktik_UI
{
    partial class BuyMenu
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
            this.numberbox = new System.Windows.Forms.TextBox();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.byubutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(9, 25);
            this.numberbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(21, 20);
            this.numberbox.TabIndex = 1;
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(34, 25);
            this.amountbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(76, 20);
            this.amountbox.TabIndex = 2;
            // 
            // byubutton
            // 
            this.byubutton.Location = new System.Drawing.Point(26, 56);
            this.byubutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.byubutton.Name = "byubutton";
            this.byubutton.Size = new System.Drawing.Size(62, 22);
            this.byubutton.TabIndex = 3;
            this.byubutton.Text = "Купить";
            this.byubutton.UseVisualStyleBackColor = true;
            this.byubutton.Click += new System.EventHandler(this.byubutton_Click);
            // 
            // BuyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 88);
            this.Controls.Add(this.byubutton);
            this.Controls.Add(this.amountbox);
            this.Controls.Add(this.numberbox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuyMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Купить";
            this.Load += new System.EventHandler(this.BuyMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.TextBox amountbox;
        private System.Windows.Forms.Button byubutton;
    }
}