namespace FashinHairDesk
{
    partial class FormFuncionario
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
            txtNome = new TextBox();
            txtRG = new TextBox();
            txtCpf = new TextBox();
            dtpDataNasc = new DateTimePicker();
            ckbAtivo = new CheckBox();
            cmbCargo = new ComboBox();
            lblNome = new Label();
            lblRg = new Label();
            lblCpf = new Label();
            lblDataNasc = new Label();
            lblCargo = new Label();
            btnInserir = new Button();
            dgvFuncionarios = new DataGridView();
            txtId = new TextBox();
            lblId = new Label();
            clnID = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnRG = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewTextBoxColumn();
            clnCargo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(226, 117);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(111, 23);
            txtNome.TabIndex = 0;
            // 
            // txtRG
            // 
            txtRG.Location = new Point(358, 117);
            txtRG.Name = "txtRG";
            txtRG.Size = new Size(111, 23);
            txtRG.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(490, 117);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(113, 23);
            txtCpf.TabIndex = 2;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(151, 176);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(111, 23);
            dtpDataNasc.TabIndex = 7;
            // 
            // ckbAtivo
            // 
            ckbAtivo.AutoSize = true;
            ckbAtivo.Location = new Point(547, 178);
            ckbAtivo.Name = "ckbAtivo";
            ckbAtivo.Size = new Size(54, 19);
            ckbAtivo.TabIndex = 8;
            ckbAtivo.Text = "Ativo";
            ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // cmbCargo
            // 
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(334, 176);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(90, 23);
            cmbCargo.TabIndex = 9;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(224, 99);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 10;
            lblNome.Text = "Nome";
            // 
            // lblRg
            // 
            lblRg.AutoSize = true;
            lblRg.Location = new Point(358, 99);
            lblRg.Name = "lblRg";
            lblRg.Size = new Size(22, 15);
            lblRg.TabIndex = 11;
            lblRg.Text = "RG";
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(493, 99);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(28, 15);
            lblCpf.TabIndex = 12;
            lblCpf.Text = "CPF";
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(148, 158);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(114, 15);
            lblDataNasc.TabIndex = 13;
            lblDataNasc.Text = "Data de Nascimento";
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(334, 155);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(39, 15);
            lblCargo.TabIndex = 14;
            lblCargo.Text = "Cargo";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(151, 220);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 17;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // dgvFuncionarios
            // 
            dgvFuncionarios.AllowUserToAddRows = false;
            dgvFuncionarios.AllowUserToDeleteRows = false;
            dgvFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuncionarios.Columns.AddRange(new DataGridViewColumn[] { clnID, clnNome, clnRG, clnCpf, clnDataNasc, clnAtivo, clnCargo });
            dgvFuncionarios.Location = new Point(151, 282);
            dgvFuncionarios.Name = "dgvFuncionarios";
            dgvFuncionarios.ReadOnly = true;
            dgvFuncionarios.Size = new Size(442, 150);
            dgvFuncionarios.TabIndex = 18;
            dgvFuncionarios.CellContentClick += dgvFuncionarios_CellContentClick;
            // 
            // txtId
            // 
            txtId.Location = new Point(151, 117);
            txtId.Name = "txtId";
            txtId.Size = new Size(54, 23);
            txtId.TabIndex = 20;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(151, 99);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 21;
            lblId.Text = "ID";
            // 
            // clnID
            // 
            clnID.HeaderText = "ID";
            clnID.Name = "clnID";
            clnID.ReadOnly = true;
            // 
            // clnNome
            // 
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            // 
            // clnRG
            // 
            clnRG.HeaderText = "RG";
            clnRG.Name = "clnRG";
            clnRG.ReadOnly = true;
            // 
            // clnCpf
            // 
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            // 
            // clnDataNasc
            // 
            clnDataNasc.HeaderText = "Data Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            // 
            // clnAtivo
            // 
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            // 
            // clnCargo
            // 
            clnCargo.HeaderText = "Cargo";
            clnCargo.Name = "clnCargo";
            clnCargo.ReadOnly = true;
            // 
            // FormTeste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 444);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(dgvFuncionarios);
            Controls.Add(btnInserir);
            Controls.Add(lblCargo);
            Controls.Add(lblDataNasc);
            Controls.Add(lblCpf);
            Controls.Add(lblRg);
            Controls.Add(lblNome);
            Controls.Add(cmbCargo);
            Controls.Add(ckbAtivo);
            Controls.Add(dtpDataNasc);
            Controls.Add(txtCpf);
            Controls.Add(txtRG);
            Controls.Add(txtNome);
            Name = "FormTeste";
            Text = "Form1";
            Load += FormTeste_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFuncionarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtRG;
        private TextBox txtCpf;
        private DateTimePicker dtpDataNasc;
        private CheckBox ckbAtivo;
        private ComboBox cmbCargo;
        private Label lblNome;
        private Label lblRg;
        private Label lblCpf;
        private Label lblDataNasc;
        private Label lblCargo;
        private Button btnInserir;
        private DataGridView dgvFuncionarios;
        private TextBox txtId;
        private Label lblId;
        private DataGridViewTextBoxColumn clnID;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnRG;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewTextBoxColumn clnAtivo;
        private DataGridViewTextBoxColumn clnCargo;
    }
}
