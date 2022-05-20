
namespace Praktik_UI
{
    partial class Suppliers2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers2));
            this.Suppliers2Grid = new System.Windows.Forms.DataGridView();
            this.number3Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers2Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Suppliers2Grid
            // 
            this.Suppliers2Grid.AllowUserToAddRows = false;
            this.Suppliers2Grid.AllowUserToDeleteRows = false;
            this.Suppliers2Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Suppliers2Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number3Col,
            this.idCol,
            this.nameCol,
            this.amountCol,
            this.priceCol});
            this.Suppliers2Grid.Location = new System.Drawing.Point(14, 15);
            this.Suppliers2Grid.Name = "Suppliers2Grid";
            this.Suppliers2Grid.ReadOnly = true;
            this.Suppliers2Grid.RowHeadersWidth = 51;
            this.Suppliers2Grid.RowTemplate.Height = 24;
            this.Suppliers2Grid.Size = new System.Drawing.Size(682, 532);
            this.Suppliers2Grid.TabIndex = 0;
            this.Suppliers2Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Suppliers2Grid_CellContentClick);
            // 
            // number3Col
            // 
            this.number3Col.HeaderText = "№";
            this.number3Col.MinimumWidth = 6;
            this.number3Col.Name = "number3Col";
            this.number3Col.ReadOnly = true;
            this.number3Col.Width = 30;
            // 
            // idCol
            // 
            this.idCol.HeaderText = "Артикул";
            this.idCol.MinimumWidth = 6;
            this.idCol.Name = "idCol";
            this.idCol.ReadOnly = true;
            this.idCol.Width = 125;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Название";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Width = 125;
            // 
            // amountCol
            // 
            this.amountCol.HeaderText = "Количество";
            this.amountCol.MinimumWidth = 6;
            this.amountCol.Name = "amountCol";
            this.amountCol.ReadOnly = true;
            this.amountCol.Width = 125;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Цена";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
            this.priceCol.ReadOnly = true;
            this.priceCol.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(718, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "Загрузка из файла";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(718, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Сохранение в файл";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(718, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавление запчасти";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(718, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 52);
            this.button4.TabIndex = 4;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.ForeColor = System.Drawing.Color.AliceBlue;
            this.button5.Location = new System.Drawing.Point(718, 495);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 52);
            this.button5.TabIndex = 5;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button6.Location = new System.Drawing.Point(720, 253);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 52);
            this.button6.TabIndex = 8;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Suppliers2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 563);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Suppliers2Grid);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Suppliers2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vechicle-Tuning";
            this.Load += new System.EventHandler(this.Suppliers2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers2Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Suppliers2Grid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn number3Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.Button button6;
    }
}