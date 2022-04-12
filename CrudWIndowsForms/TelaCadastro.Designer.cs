
namespace CrudWIndowsForms
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.Novo = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textCEP = new System.Windows.Forms.MaskedTextBox();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textUF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Novo
            // 
            this.Novo.BackColor = System.Drawing.Color.White;
            this.Novo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Novo.BackgroundImage")));
            this.Novo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Novo.Location = new System.Drawing.Point(12, 12);
            this.Novo.Name = "Novo";
            this.Novo.Size = new System.Drawing.Size(47, 38);
            this.Novo.TabIndex = 0;
            this.Novo.UseVisualStyleBackColor = false;
            this.Novo.Click += new System.EventHandler(this.Novo_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelar.BackgroundImage")));
            this.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cancelar.Location = new System.Drawing.Point(118, 12);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(47, 38);
            this.Cancelar.TabIndex = 1;
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Salvar
            // 
            this.Salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Salvar.BackgroundImage")));
            this.Salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Salvar.Cursor = System.Windows.Forms.Cursors.No;
            this.Salvar.Location = new System.Drawing.Point(65, 12);
            this.Salvar.Name = "Salvar";
            this.Salvar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Salvar.Size = new System.Drawing.Size(47, 38);
            this.Salvar.TabIndex = 2;
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.Gainsboro;
            this.Excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Excluir.BackgroundImage")));
            this.Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Excluir.Location = new System.Drawing.Point(171, 12);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(47, 38);
            this.Excluir.TabIndex = 3;
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(224, 18);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(72, 13);
            this.ID.TabIndex = 4;
            this.ID.Text = "Busca por ID:";
            // 
            // txtID
            // 
            this.txtID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtID.Location = new System.Drawing.Point(293, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 20);
            this.txtID.TabIndex = 5;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pesquisar.BackgroundImage")));
            this.Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pesquisar.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Pesquisar.Location = new System.Drawing.Point(437, 9);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(45, 27);
            this.Pesquisar.TabIndex = 6;
            this.Pesquisar.UseVisualStyleBackColor = false;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "CEP";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bairro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "UF";
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(12, 300);
            this.textTelefone.Mask = "(999) 000-0000";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(100, 20);
            this.textTelefone.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Telefone";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(12, 92);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(65, 20);
            this.textID.TabIndex = 16;
            this.textID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(153, 92);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(329, 20);
            this.textNome.TabIndex = 17;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(12, 164);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(470, 20);
            this.textEndereco.TabIndex = 18;
            // 
            // textCEP
            // 
            this.textCEP.Location = new System.Drawing.Point(12, 231);
            this.textCEP.Mask = "00000-999";
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(100, 20);
            this.textCEP.TabIndex = 19;
            this.textCEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // textBairro
            // 
            this.textBairro.Location = new System.Drawing.Point(133, 231);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(102, 20);
            this.textBairro.TabIndex = 20;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(265, 231);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(139, 20);
            this.textCidade.TabIndex = 21;
            // 
            // textUF
            // 
            this.textUF.Location = new System.Drawing.Point(417, 231);
            this.textUF.Name = "textUF";
            this.textUF.Size = new System.Drawing.Size(65, 20);
            this.textUF.TabIndex = 22;
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 348);
            this.Controls.Add(this.textUF);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.textCEP);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Salvar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Novo);
            this.Name = "TelaCadastro";
            this.Text = "TelaCadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Novo;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.MaskedTextBox textCEP;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textUF;
    }
}