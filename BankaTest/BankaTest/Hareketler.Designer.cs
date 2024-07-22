namespace BankaTest
{
    partial class Hareketler
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bANKADataSet1 = new BankaTest.BANKADataSet1();
            this.hareketDüzeniBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hareketDüzeniTableAdapter = new BankaTest.BANKADataSet1TableAdapters.HareketDüzeniTableAdapter();
            this.gönderenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alıcıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketDüzeniBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gönderenDataGridViewTextBoxColumn,
            this.alıcıDataGridViewTextBoxColumn,
            this.tutarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hareketDüzeniBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1123, 493);
            this.dataGridView1.TabIndex = 0;
            // 
            // bANKADataSet1
            // 
            this.bANKADataSet1.DataSetName = "BANKADataSet1";
            this.bANKADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hareketDüzeniBindingSource
            // 
            this.hareketDüzeniBindingSource.DataMember = "HareketDüzeni";
            this.hareketDüzeniBindingSource.DataSource = this.bANKADataSet1;
            // 
            // hareketDüzeniTableAdapter
            // 
            this.hareketDüzeniTableAdapter.ClearBeforeFill = true;
            // 
            // gönderenDataGridViewTextBoxColumn
            // 
            this.gönderenDataGridViewTextBoxColumn.DataPropertyName = "Gönderen";
            this.gönderenDataGridViewTextBoxColumn.HeaderText = "Gönderen";
            this.gönderenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gönderenDataGridViewTextBoxColumn.Name = "gönderenDataGridViewTextBoxColumn";
            this.gönderenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alıcıDataGridViewTextBoxColumn
            // 
            this.alıcıDataGridViewTextBoxColumn.DataPropertyName = "Alıcı";
            this.alıcıDataGridViewTextBoxColumn.HeaderText = "Alıcı";
            this.alıcıDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alıcıDataGridViewTextBoxColumn.Name = "alıcıDataGridViewTextBoxColumn";
            this.alıcıDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutarDataGridViewTextBoxColumn
            // 
            this.tutarDataGridViewTextBoxColumn.DataPropertyName = "Tutar";
            this.tutarDataGridViewTextBoxColumn.HeaderText = "Tutar";
            this.tutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tutarDataGridViewTextBoxColumn.Name = "tutarDataGridViewTextBoxColumn";
            // 
            // Hareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(1163, 553);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Hareketler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hareketler";
            this.Load += new System.EventHandler(this.Hareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANKADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketDüzeniBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BANKADataSet1 bANKADataSet1;
        private System.Windows.Forms.BindingSource hareketDüzeniBindingSource;
        private BANKADataSet1TableAdapters.HareketDüzeniTableAdapter hareketDüzeniTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gönderenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alıcıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutarDataGridViewTextBoxColumn;
    }
}