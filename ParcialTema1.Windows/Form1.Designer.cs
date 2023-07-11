namespace ParcialTema1.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtRadio = new TextBox();
            txtAltura = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            dgvMedidas = new DataGridView();
            colAltura = new DataGridViewTextBoxColumn();
            colRadio = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colBase = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            btnOK = new Button();
            btnCancelar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedidas).BeginInit();
            SuspendLayout();
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(139, 86);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 27);
            txtRadio.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(139, 34);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 87);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 0;
            label2.Text = "Radio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 35);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Altura:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dgvMedidas
            // 
            dgvMedidas.AllowUserToAddRows = false;
            dgvMedidas.AllowUserToDeleteRows = false;
            dgvMedidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedidas.Columns.AddRange(new DataGridViewColumn[] { colAltura, colRadio, colArea, colBase, colVolumen });
            dgvMedidas.Location = new Point(0, 244);
            dgvMedidas.Name = "dgvMedidas";
            dgvMedidas.ReadOnly = true;
            dgvMedidas.RowHeadersWidth = 51;
            dgvMedidas.RowTemplate.Height = 29;
            dgvMedidas.Size = new Size(900, 296);
            dgvMedidas.TabIndex = 2;
            // 
            // colAltura
            // 
            colAltura.HeaderText = "Altura";
            colAltura.MinimumWidth = 6;
            colAltura.Name = "colAltura";
            colAltura.ReadOnly = true;
            colAltura.Width = 125;
            // 
            // colRadio
            // 
            colRadio.HeaderText = "Radio";
            colRadio.MinimumWidth = 6;
            colRadio.Name = "colRadio";
            colRadio.ReadOnly = true;
            colRadio.Width = 125;
            // 
            // colArea
            // 
            colArea.HeaderText = "Area";
            colArea.MinimumWidth = 6;
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            colArea.Width = 125;
            // 
            // colBase
            // 
            colBase.HeaderText = "Base";
            colBase.MinimumWidth = 6;
            colBase.Name = "colBase";
            colBase.ReadOnly = true;
            colBase.Width = 125;
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.MinimumWidth = 6;
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            colVolumen.Width = 125;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(65, 149);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(103, 60);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(222, 149);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 60);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(400, 69);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 60);
            btnBorrar.TabIndex = 5;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 540);
            Controls.Add(btnBorrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(dgvMedidas);
            Controls.Add(txtRadio);
            Controls.Add(label2);
            Controls.Add(txtAltura);
            Controls.Add(label1);
            Name = "Form1";
            Text = "2";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRadio;
        private TextBox txtAltura;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnOK;
        private DataGridView dgvMedidas;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colRadio;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colBase;
        private DataGridViewTextBoxColumn colVolumen;
        private Button btnBorrar;
    }
}