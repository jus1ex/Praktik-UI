
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyMenu));
            this.numberbox = new System.Windows.Forms.TextBox();
            this.amountbox = new System.Windows.Forms.TextBox();
            this.byubutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(12, 38);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(118, 26);
            this.numberbox.TabIndex = 1;
            this.numberbox.Enter += new System.EventHandler(this.numberbox_Enter);
            this.numberbox.Leave += new System.EventHandler(this.numberbox_Leave);
            // 
            // amountbox
            // 
            this.amountbox.Location = new System.Drawing.Point(140, 38);
            this.amountbox.Name = "amountbox";
            this.amountbox.Size = new System.Drawing.Size(112, 26);
            this.amountbox.TabIndex = 2;
            this.amountbox.Enter += new System.EventHandler(this.amountbox_Enter);
            this.amountbox.Leave += new System.EventHandler(this.amountbox_Leave);
            // 
            // byubutton
            // 
            this.byubutton.Location = new System.Drawing.Point(81, 70);
            this.byubutton.Name = "byubutton";
            this.byubutton.Size = new System.Drawing.Size(93, 34);
            this.byubutton.TabIndex = 3;
            this.byubutton.Text = "Купить";
            this.byubutton.UseVisualStyleBackColor = true;
            this.byubutton.Click += new System.EventHandler(this.byubutton_Click);
            // 
            // BuyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 135);
            this.Controls.Add(this.byubutton);
            this.Controls.Add(this.amountbox);
            this.Controls.Add(this.numberbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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