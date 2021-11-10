
namespace SuMueble.Views
{
    partial class ClientesView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.n_monto_max = new System.Windows.Forms.NumericUpDown();
            this.txt_buscar_nombre = new System.Windows.Forms.TextBox();
            this.n_monto_min = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_buscar_por_monto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_monto_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_monto_min)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(101, 181);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.RowHeadersWidth = 51;
            this.dgv_clientes.RowTemplate.Height = 29;
            this.dgv_clientes.Size = new System.Drawing.Size(1319, 516);
            this.dgv_clientes.TabIndex = 0;
            // 
            // n_monto_max
            // 
            this.n_monto_max.Location = new System.Drawing.Point(1076, 127);
            this.n_monto_max.Name = "n_monto_max";
            this.n_monto_max.Size = new System.Drawing.Size(150, 27);
            this.n_monto_max.TabIndex = 1;
            // 
            // txt_buscar_nombre
            // 
            this.txt_buscar_nombre.Location = new System.Drawing.Point(101, 125);
            this.txt_buscar_nombre.Name = "txt_buscar_nombre";
            this.txt_buscar_nombre.PlaceholderText = "Buscar por nombre";
            this.txt_buscar_nombre.Size = new System.Drawing.Size(178, 27);
            this.txt_buscar_nombre.TabIndex = 2;
            this.txt_buscar_nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_nombre_KeyUp);
            // 
            // n_monto_min
            // 
            this.n_monto_min.Location = new System.Drawing.Point(889, 127);
            this.n_monto_min.Name = "n_monto_min";
            this.n_monto_min.Size = new System.Drawing.Size(150, 27);
            this.n_monto_min.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Monto Minima";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1076, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto Maxima";
            // 
            // btn_buscar_por_monto
            // 
            this.btn_buscar_por_monto.Location = new System.Drawing.Point(1259, 123);
            this.btn_buscar_por_monto.Name = "btn_buscar_por_monto";
            this.btn_buscar_por_monto.Size = new System.Drawing.Size(161, 29);
            this.btn_buscar_por_monto.TabIndex = 4;
            this.btn_buscar_por_monto.Text = "Buscar por Monto ";
            this.btn_buscar_por_monto.UseVisualStyleBackColor = true;
            this.btn_buscar_por_monto.Click += new System.EventHandler(this.btn_buscar_por_monto_Click);
            // 
            // ClientesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_buscar_por_monto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_buscar_nombre);
            this.Controls.Add(this.n_monto_min);
            this.Controls.Add(this.n_monto_max);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "ClientesView";
            this.Size = new System.Drawing.Size(1517, 760);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_monto_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_monto_min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.NumericUpDown n_monto_max;
        private System.Windows.Forms.TextBox txt_buscar_nombre;
        private System.Windows.Forms.NumericUpDown n_monto_min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar_por_monto;
    }
}
