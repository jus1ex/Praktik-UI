
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
            this.numberbox.Location = new System.Drawing.Point(12, 31);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(27, 22);
            this.numberbox.TabIndex = 1;
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(46, 31);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(100, 22);
            this.amountbox.TabIndex = 2;
            // 
            // byubutton
            // 
            this.byubutton.Location = new System.Drawing.Point(35, 69);
            this.byubutton.Name = "byubutton";
            this.byubutton.Size = new System.Drawing.Size(82, 27);
            this.byubutton.TabIndex = 3;
            this.byubutton.Text = "Купить";
            this.byubutton.UseVisualStyleBackColor = true;
            // 
            // BuyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 108);
            this.Controls.Add(this.byubutton);
            this.Controls.Add(this.amountbox);
            this.Controls.Add(this.numberbox);
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