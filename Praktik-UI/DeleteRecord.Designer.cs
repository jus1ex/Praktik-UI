
namespace Praktik_UI
{
    partial class DeleteRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRecord));
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteBox
            // 
            this.deleteBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.deleteBox.Location = new System.Drawing.Point(111, 13);
            this.deleteBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(112, 26);
            this.deleteBox.TabIndex = 0;
            this.deleteBox.Text = "Номер";
            this.deleteBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBox.Enter += new System.EventHandler(this.deleteBox_Enter);
            this.deleteBox.Leave += new System.EventHandler(this.deleteBox_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 47);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 96);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DeleteRecord";
            this.Text = "Удаление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.Button button1;
    }
}