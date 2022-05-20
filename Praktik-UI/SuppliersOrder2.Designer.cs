namespace Praktik_UI
{
    partial class SuppliersOrder2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersOrder2));
            this.button7 = new System.Windows.Forms.Button();
            this.buy1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Suppliers2Grid = new System.Windows.Forms.DataGridView();
            this.number3Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers2Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button7.Location = new System.Drawing.Point(701, 372);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 52);
            this.button7.TabIndex = 20;
            this.button7.Text = "Подтвердить";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buy1
            // 
            this.buy1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buy1.Location = new System.Drawing.Point(701, 72);
            this.buy1.Name = "buy1";
            this.buy1.Size = new System.Drawing.Size(168, 52);
            this.buy1.TabIndex = 18;
            this.buy1.Text = "Купить";
            this.buy1.UseVisualStyleBackColor = false;
            this.buy1.Click += new System.EventHandler(this.buy1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.ForeColor = System.Drawing.Color.AliceBlue;
            this.button5.Location = new System.Drawing.Point(701, 492);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 52);
            this.button5.TabIndex = 17;
            this.button5.Text = "Выход";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(701, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 52);
            this.button4.TabIndex = 16;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.Suppliers2Grid.Location = new System.Drawing.Point(12, 12);
            this.Suppliers2Grid.Name = "Suppliers2Grid";
            this.Suppliers2Grid.ReadOnly = true;
            this.Suppliers2Grid.RowHeadersWidth = 51;
            this.Suppliers2Grid.RowTemplate.Height = 24;
            this.Suppliers2Grid.Size = new System.Drawing.Size(682, 532);
            this.Suppliers2Grid.TabIndex = 15;
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
            // SuppliersOrder2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 558);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buy1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Suppliers2Grid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SuppliersOrder2";
            this.Text = "CarHelp-Заказ";
            this.Load += new System.EventHandler(this.SuppliersOrder2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Suppliers2Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buy1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView Suppliers2Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn number3Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
    }
}