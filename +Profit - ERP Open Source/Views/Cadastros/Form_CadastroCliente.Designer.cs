namespace _Profit___ERP_Open_Source.Views.Cadastros
{
    partial class Form_CadastroCliente
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
            panel1 = new Panel();
            textBox_Cnpj = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox_NomeFantasia = new TextBox();
            textBox_RazaoSocial = new TextBox();
            textBox_CodigoCliente = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button_Cancelar = new Button();
            button_Processar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(textBox_Cnpj);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_NomeFantasia);
            panel1.Controls.Add(textBox_RazaoSocial);
            panel1.Controls.Add(textBox_CodigoCliente);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 477);
            panel1.TabIndex = 1;
            // 
            // textBox_Cnpj
            // 
            textBox_Cnpj.Location = new Point(91, 389);
            textBox_Cnpj.Name = "textBox_Cnpj";
            textBox_Cnpj.Size = new Size(206, 23);
            textBox_Cnpj.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(91, 365);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 8;
            label5.Text = "CNPJ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(55, 54);
            label4.Name = "label4";
            label4.Size = new Size(263, 32);
            label4.TabIndex = 7;
            label4.Text = "CADASTRO DE CLIENTE";
            // 
            // textBox_NomeFantasia
            // 
            textBox_NomeFantasia.Location = new Point(91, 316);
            textBox_NomeFantasia.Name = "textBox_NomeFantasia";
            textBox_NomeFantasia.Size = new Size(206, 23);
            textBox_NomeFantasia.TabIndex = 6;
            // 
            // textBox_RazaoSocial
            // 
            textBox_RazaoSocial.Location = new Point(91, 235);
            textBox_RazaoSocial.Name = "textBox_RazaoSocial";
            textBox_RazaoSocial.Size = new Size(206, 23);
            textBox_RazaoSocial.TabIndex = 5;
            // 
            // textBox_CodigoCliente
            // 
            textBox_CodigoCliente.Location = new Point(91, 163);
            textBox_CodigoCliente.Name = "textBox_CodigoCliente";
            textBox_CodigoCliente.Size = new Size(206, 23);
            textBox_CodigoCliente.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(91, 292);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 3;
            label3.Text = "Nome Fantasia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(91, 211);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 2;
            label2.Text = "Razão Social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(91, 139);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 1;
            label1.Text = "Código do Cliente:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumPurple;
            panel2.Controls.Add(button_Cancelar);
            panel2.Controls.Add(button_Processar);
            panel2.Location = new Point(660, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 477);
            panel2.TabIndex = 0;
            // 
            // button_Cancelar
            // 
            button_Cancelar.BackColor = Color.Purple;
            button_Cancelar.FlatStyle = FlatStyle.Popup;
            button_Cancelar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cancelar.ForeColor = Color.WhiteSmoke;
            button_Cancelar.Location = new Point(12, 389);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(173, 45);
            button_Cancelar.TabIndex = 1;
            button_Cancelar.Text = "CANCELAR";
            button_Cancelar.UseVisualStyleBackColor = false;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // button_Processar
            // 
            button_Processar.BackColor = Color.Purple;
            button_Processar.FlatStyle = FlatStyle.Popup;
            button_Processar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_Processar.ForeColor = Color.WhiteSmoke;
            button_Processar.Location = new Point(12, 50);
            button_Processar.Name = "button_Processar";
            button_Processar.Size = new Size(173, 45);
            button_Processar.TabIndex = 0;
            button_Processar.Text = "PROCESSAR";
            button_Processar.UseVisualStyleBackColor = false;
            button_Processar.Click += button_Processar_Click;
            // 
            // Form_CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(884, 501);
            Controls.Add(panel1);
            Name = "Form_CadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox textBox_NomeFantasia;
        private TextBox textBox_RazaoSocial;
        private TextBox textBox_CodigoCliente;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button button_Cancelar;
        private Button button_Processar;
        private TextBox textBox_Cnpj;
        private Label label5;
    }
}