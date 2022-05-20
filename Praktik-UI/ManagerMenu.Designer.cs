
namespace Praktik_UI
{
    partial class ManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMenu));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(224, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Список поставщиков";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(224, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 74);
            this.button2.TabIndex = 1;
            this.button2.Text = "Статистика по артикулу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(224, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 74);
            this.button3.TabIndex = 2;
            this.button3.Text = "Статистика прибыли поставщика";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DimGray;
            this.exit.ForeColor = System.Drawing.Color.AliceBlue;
            this.exit.Location = new System.Drawing.Point(224, 317);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(184, 74);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 432);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню менеджера";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button exit;
    }
}