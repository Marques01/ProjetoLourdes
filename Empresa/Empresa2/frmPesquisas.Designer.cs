
namespace Empresa2
{
    partial class frmPesquisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisas));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.avariastexto = new System.Windows.Forms.TextBox();
            this.vnslourdesDataSet = new Empresa2.vnslourdesDataSet();
            this.gravar_avariaTableAdapter = new Empresa2.vnslourdesDataSetTableAdapters.gravar_avariaTableAdapter();
            this.gravar_avariaDataGridView = new System.Windows.Forms.DataGridView();
            this.gravar_avariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Empresa2.vnslourdesDataSetTableAdapters.TableAdapterManager();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.nordemTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vnslourdesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravar_avariaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravar_avariaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(1, 32);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(90, 32);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Visible = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // avariastexto
            // 
            this.avariastexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avariastexto.Location = new System.Drawing.Point(630, 32);
            this.avariastexto.Multiline = true;
            this.avariastexto.Name = "avariastexto";
            this.avariastexto.ReadOnly = true;
            this.avariastexto.Size = new System.Drawing.Size(100, 34);
            this.avariastexto.TabIndex = 1;
            this.avariastexto.Visible = false;
            // 
            // vnslourdesDataSet
            // 
            this.vnslourdesDataSet.DataSetName = "vnslourdesDataSet";
            this.vnslourdesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gravar_avariaTableAdapter
            // 
            this.gravar_avariaTableAdapter.ClearBeforeFill = true;
            // 
            // gravar_avariaDataGridView
            // 
            this.gravar_avariaDataGridView.AllowUserToAddRows = false;
            this.gravar_avariaDataGridView.AllowUserToDeleteRows = false;
            this.gravar_avariaDataGridView.AllowUserToOrderColumns = true;
            this.gravar_avariaDataGridView.AutoGenerateColumns = false;
            this.gravar_avariaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gravar_avariaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gravar_avariaDataGridView.DataSource = this.gravar_avariaBindingSource;
            this.gravar_avariaDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gravar_avariaDataGridView.Location = new System.Drawing.Point(0, 342);
            this.gravar_avariaDataGridView.Name = "gravar_avariaDataGridView";
            this.gravar_avariaDataGridView.ReadOnly = true;
            this.gravar_avariaDataGridView.RowHeadersVisible = false;
            this.gravar_avariaDataGridView.Size = new System.Drawing.Size(742, 220);
            this.gravar_avariaDataGridView.TabIndex = 3;
            // 
            // gravar_avariaBindingSource
            // 
            this.gravar_avariaBindingSource.DataMember = "gravar_avaria";
            this.gravar_avariaBindingSource.DataSource = this.vnslourdesDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.gravar_avariaTableAdapter = null;
            this.tableAdapterManager.produtosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Empresa2.vnslourdesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(4, 153);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Modelo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(4, 104);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nº Ordem";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "dia";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nordem";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nº Ordem";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "modelo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "avaria";
            this.dataGridViewTextBoxColumn5.HeaderText = "Avaria";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 3000;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gravar_avariaBindingSource, "modelo", true));
            this.modeloTextBox.Location = new System.Drawing.Point(95, 150);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(100, 20);
            this.modeloTextBox.TabIndex = 9;
            this.modeloTextBox.Visible = false;
            // 
            // nordemTextBox
            // 
            this.nordemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gravar_avariaBindingSource, "nordem", true));
            this.nordemTextBox.Location = new System.Drawing.Point(95, 104);
            this.nordemTextBox.Name = "nordemTextBox";
            this.nordemTextBox.Size = new System.Drawing.Size(100, 20);
            this.nordemTextBox.TabIndex = 10;
            this.nordemTextBox.Visible = false;
            // 
            // frmPesquisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 562);
            this.Controls.Add(this.nordemTextBox);
            this.Controls.Add(this.modeloTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.gravar_avariaDataGridView);
            this.Controls.Add(this.avariastexto);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.frmPesquisas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vnslourdesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravar_avariaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravar_avariaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox avariastexto;
        private vnslourdesDataSet vnslourdesDataSet;
        private System.Windows.Forms.BindingSource gravar_avariaBindingSource;
        private vnslourdesDataSetTableAdapters.gravar_avariaTableAdapter gravar_avariaTableAdapter;
        private vnslourdesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gravar_avariaDataGridView;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.TextBox nordemTextBox;
    }
}