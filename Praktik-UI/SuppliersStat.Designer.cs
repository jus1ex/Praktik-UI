namespace Praktik_UI
{
    partial class SuppliersStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersStat));
            this.exit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DimGray;
            this.exit.ForeColor = System.Drawing.Color.AliceBlue;
            this.exit.Location = new System.Drawing.Point(235, 147);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(178, 68);
            this.exit.TabIndex = 14;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(460, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 68);
            this.button3.TabIndex = 12;
            this.button3.Text = "Vechicle-Tuning";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(235, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 68);
            this.button2.TabIndex = 11;
            this.button2.Text = "CarHelp";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 68);
            this.button1.TabIndex = 10;
            this.button1.Text = "AutoDoc";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SuppliersStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 227);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SuppliersStat";
            this.Text = "Статистика";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}