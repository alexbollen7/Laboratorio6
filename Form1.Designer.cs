
namespace Laboratorio6
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewVehiculos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGISTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLQUILERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECARGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewAlquileres = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMayorRecorrido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "PREDIO RAYO McQueen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vehículos Registrados";
            // 
            // dataGridViewVehiculos
            // 
            this.dataGridViewVehiculos.AllowUserToAddRows = false;
            this.dataGridViewVehiculos.AllowUserToDeleteRows = false;
            this.dataGridViewVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehiculos.Location = new System.Drawing.Point(12, 141);
            this.dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            this.dataGridViewVehiculos.ReadOnly = true;
            this.dataGridViewVehiculos.Size = new System.Drawing.Size(515, 242);
            this.dataGridViewVehiculos.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTROToolStripMenuItem,
            this.aLQUILERToolStripMenuItem,
            this.rECARGARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(966, 31);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGISTROToolStripMenuItem
            // 
            this.rEGISTROToolStripMenuItem.Name = "rEGISTROToolStripMenuItem";
            this.rEGISTROToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.rEGISTROToolStripMenuItem.Text = "REGISTRO";
            this.rEGISTROToolStripMenuItem.Click += new System.EventHandler(this.rEGISTROToolStripMenuItem_Click);
            // 
            // aLQUILERToolStripMenuItem
            // 
            this.aLQUILERToolStripMenuItem.Name = "aLQUILERToolStripMenuItem";
            this.aLQUILERToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.aLQUILERToolStripMenuItem.Text = "ALQUILER";
            this.aLQUILERToolStripMenuItem.Click += new System.EventHandler(this.aLQUILERToolStripMenuItem_Click);
            // 
            // rECARGARToolStripMenuItem
            // 
            this.rECARGARToolStripMenuItem.Name = "rECARGARToolStripMenuItem";
            this.rECARGARToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.rECARGARToolStripMenuItem.Text = "RECARGAR";
            this.rECARGARToolStripMenuItem.Click += new System.EventHandler(this.rECARGARToolStripMenuItem_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(562, 141);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(391, 242);
            this.dataGridViewClientes.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Clientes Registrados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vehículos Alquilados";
            // 
            // dataGridViewAlquileres
            // 
            this.dataGridViewAlquileres.AllowUserToAddRows = false;
            this.dataGridViewAlquileres.AllowUserToDeleteRows = false;
            this.dataGridViewAlquileres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlquileres.Location = new System.Drawing.Point(12, 438);
            this.dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            this.dataGridViewAlquileres.ReadOnly = true;
            this.dataGridViewAlquileres.Size = new System.Drawing.Size(941, 238);
            this.dataGridViewAlquileres.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 693);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alquiler con mayor Km recorridos:";
            // 
            // labelMayorRecorrido
            // 
            this.labelMayorRecorrido.AutoSize = true;
            this.labelMayorRecorrido.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMayorRecorrido.Location = new System.Drawing.Point(328, 693);
            this.labelMayorRecorrido.Name = "labelMayorRecorrido";
            this.labelMayorRecorrido.Size = new System.Drawing.Size(24, 26);
            this.labelMayorRecorrido.TabIndex = 11;
            this.labelMayorRecorrido.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(850, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Gm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 739);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelMayorRecorrido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewAlquileres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewVehiculos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehiculos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlquileres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewVehiculos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLQUILERToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem rECARGARToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewAlquileres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMayorRecorrido;
        private System.Windows.Forms.Button button1;
    }
}

