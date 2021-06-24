
namespace _2_tb_funcionarios
{
    partial class clientes
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnalt = new System.Windows.Forms.Button();
            this.DgvListaCliente = new System.Windows.Forms.DataGridView();
            this.btncadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(38, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(38, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(38, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(141, 215);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(607, 20);
            this.txtemail.TabIndex = 12;
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(141, 161);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(240, 20);
            this.txttelefone.TabIndex = 11;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(141, 103);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(607, 20);
            this.txtnome.TabIndex = 10;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(141, 50);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(240, 20);
            this.txtcodigo.TabIndex = 9;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnexcluir.Location = new System.Drawing.Point(548, 256);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(138, 40);
            this.btnexcluir.TabIndex = 16;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click_1);
            // 
            // btnalt
            // 
            this.btnalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnalt.Location = new System.Drawing.Point(342, 256);
            this.btnalt.Name = "btnalt";
            this.btnalt.Size = new System.Drawing.Size(138, 40);
            this.btnalt.TabIndex = 15;
            this.btnalt.Text = "Alterar";
            this.btnalt.UseVisualStyleBackColor = true;
            this.btnalt.Click += new System.EventHandler(this.btnalt_Click_1);
            // 
            // DgvListaCliente
            // 
            this.DgvListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCliente.Location = new System.Drawing.Point(26, 302);
            this.DgvListaCliente.Name = "DgvListaCliente";
            this.DgvListaCliente.Size = new System.Drawing.Size(722, 146);
            this.DgvListaCliente.TabIndex = 14;
            this.DgvListaCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaCliente_CellClick_1);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btncadastrar.Location = new System.Drawing.Point(141, 256);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(138, 40);
            this.btncadastrar.TabIndex = 13;
            this.btncadastrar.Text = "Cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click_1);
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalt);
            this.Controls.Add(this.DgvListaCliente);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnalt;
        private System.Windows.Forms.DataGridView DgvListaCliente;
        private System.Windows.Forms.Button btncadastrar;
    }
}