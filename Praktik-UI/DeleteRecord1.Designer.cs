
namespace Praktik_UI
{
    partial class DeleteRecord1
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
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите номер товара для удаления";
            // 
            // deleteBox1
            // 
            this.deleteBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.deleteBox1.Location = new System.Drawing.Point(99, 68);
            this.deleteBox1.Name = "deleteBox1";
            this.deleteBox1.Size = new System.Drawing.Size(100, 22);
            this.deleteBox1.TabIndex = 1;
            this.deleteBox1.Text = "Номер";
            this.deleteBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBox1.Enter += new System.EventHandler(this.deleteBox1_Enter);
            this.deleteBox1.Leave += new System.EventHandler(this.deleteBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeleteRecord1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 165);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteBox1);
            this.Controls.Add(this.label1);
            this.Name = "DeleteRecord1";
            this.Text = "Удаление товара";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteBox1;
        private System.Windows.Forms.Button button1;
    }
}