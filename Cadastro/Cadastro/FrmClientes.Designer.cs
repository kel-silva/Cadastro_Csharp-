namespace Cadastro
{
    partial class FrmMenuClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuClientes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgLista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_civil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PesqCancelado = new System.Windows.Forms.RadioButton();
            this.PesqTodos = new System.Windows.Forms.RadioButton();
            this.PesqAtivo = new System.Windows.Forms.RadioButton();
            this.PesqEstCivil = new System.Windows.Forms.ComboBox();
            this.PesqGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PesqNasc = new System.Windows.Forms.TextBox();
            this.PesqEnderecos = new System.Windows.Forms.TextBox();
            this.PesqNome = new System.Windows.Forms.TextBox();
            this.PesqCod = new System.Windows.Forms.TextBox();
            this.lblTotalCancelados = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbltotalAtivos = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.btFicha = new System.Windows.Forms.Button();
            this.btRelatorio = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btFicha);
            this.groupBox1.Controls.Add(this.btRelatorio);
            this.groupBox1.Controls.Add(this.btEditar);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acoes";
            // 
            // dgLista
            // 
            this.dgLista.AllowUserToAddRows = false;
            this.dgLista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.AliceBlue;
            this.dgLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgLista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgLista.ColumnHeadersHeight = 30;
            this.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.foto,
            this.nome,
            this.documento,
            this.genero,
            this.rg,
            this.endereco,
            this.estado_civil,
            this.cidade,
            this.nasc,
            this.numero,
            this.bairro,
            this.celular,
            this.estado,
            this.email,
            this.obs,
            this.situacao});
            this.dgLista.EnableHeadersVisualStyles = false;
            this.dgLista.Location = new System.Drawing.Point(8, 114);
            this.dgLista.Name = "dgLista";
            this.dgLista.ReadOnly = true;
            this.dgLista.RowHeadersWidth = 4;
            this.dgLista.RowTemplate.Height = 30;
            this.dgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgLista.Size = new System.Drawing.Size(1572, 487);
            this.dgLista.TabIndex = 1;
            this.dgLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellClick);
            this.dgLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgLista.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellMouseEnter);
            this.dgLista.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLista_CellMouseLeave);
            this.dgLista.Sorted += new System.EventHandler(this.dgLista_Sorted);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "N";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 20;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.foto.MinimumWidth = 6;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome do Cliente";
            this.nome.MinimumWidth = 6;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 125;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "CPF / CNPJ";
            this.documento.MinimumWidth = 6;
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 125;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.MinimumWidth = 6;
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 125;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg";
            this.rg.HeaderText = "RG";
            this.rg.MinimumWidth = 6;
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            this.rg.Width = 125;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.MinimumWidth = 6;
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Width = 125;
            // 
            // estado_civil
            // 
            this.estado_civil.DataPropertyName = "estado_civil";
            this.estado_civil.HeaderText = "Estado Civil";
            this.estado_civil.MinimumWidth = 6;
            this.estado_civil.Name = "estado_civil";
            this.estado_civil.ReadOnly = true;
            this.estado_civil.Width = 125;
            // 
            // cidade
            // 
            this.cidade.DataPropertyName = "cidade";
            this.cidade.HeaderText = "Cidade";
            this.cidade.MinimumWidth = 6;
            this.cidade.Name = "cidade";
            this.cidade.ReadOnly = true;
            this.cidade.Width = 125;
            // 
            // nasc
            // 
            this.nasc.DataPropertyName = "nasc";
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.nasc.DefaultCellStyle = dataGridViewCellStyle9;
            this.nasc.HeaderText = "Data nascimento";
            this.nasc.MinimumWidth = 6;
            this.nasc.Name = "nasc";
            this.nasc.ReadOnly = true;
            this.nasc.Width = 125;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "n";
            this.numero.HeaderText = "Numero";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "Bairro";
            this.bairro.MinimumWidth = 6;
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Width = 125;
            // 
            // celular
            // 
            this.celular.DataPropertyName = "celular";
            this.celular.HeaderText = "Celular";
            this.celular.MinimumWidth = 6;
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 125;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "Observacao";
            this.obs.MinimumWidth = 6;
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Width = 125;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "Situacao";
            this.situacao.MinimumWidth = 6;
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PesqCancelado);
            this.groupBox2.Controls.Add(this.PesqTodos);
            this.groupBox2.Controls.Add(this.PesqAtivo);
            this.groupBox2.Controls.Add(this.PesqEstCivil);
            this.groupBox2.Controls.Add(this.PesqGenero);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.PesqNasc);
            this.groupBox2.Controls.Add(this.PesqEnderecos);
            this.groupBox2.Controls.Add(this.PesqNome);
            this.groupBox2.Controls.Add(this.PesqCod);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(311, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1139, 96);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opçoes de Pesquisa";
            this.groupBox2.TextChanged += new System.EventHandler(this.groupBox2_TextChanged);
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PesqCancelado
            // 
            this.PesqCancelado.AutoSize = true;
            this.PesqCancelado.ForeColor = System.Drawing.Color.Red;
            this.PesqCancelado.Location = new System.Drawing.Point(1038, 67);
            this.PesqCancelado.Name = "PesqCancelado";
            this.PesqCancelado.Size = new System.Drawing.Size(94, 20);
            this.PesqCancelado.TabIndex = 10;
            this.PesqCancelado.Text = "Cancelado";
            this.PesqCancelado.UseVisualStyleBackColor = true;
            this.PesqCancelado.CheckedChanged += new System.EventHandler(this.PesqCancelado_CheckedChanged);
            // 
            // PesqTodos
            // 
            this.PesqTodos.AutoSize = true;
            this.PesqTodos.Checked = true;
            this.PesqTodos.Location = new System.Drawing.Point(1038, 15);
            this.PesqTodos.Name = "PesqTodos";
            this.PesqTodos.Size = new System.Drawing.Size(68, 20);
            this.PesqTodos.TabIndex = 9;
            this.PesqTodos.TabStop = true;
            this.PesqTodos.Text = "Todos";
            this.PesqTodos.UseVisualStyleBackColor = true;
            this.PesqTodos.CheckedChanged += new System.EventHandler(this.PesqTodos_CheckedChanged);
            // 
            // PesqAtivo
            // 
            this.PesqAtivo.AutoSize = true;
            this.PesqAtivo.ForeColor = System.Drawing.Color.Green;
            this.PesqAtivo.Location = new System.Drawing.Point(1038, 41);
            this.PesqAtivo.Name = "PesqAtivo";
            this.PesqAtivo.Size = new System.Drawing.Size(58, 20);
            this.PesqAtivo.TabIndex = 8;
            this.PesqAtivo.Text = "Ativo";
            this.PesqAtivo.UseVisualStyleBackColor = true;
            this.PesqAtivo.CheckedChanged += new System.EventHandler(this.PesqAtivo_CheckedChanged);
            // 
            // PesqEstCivil
            // 
            this.PesqEstCivil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PesqEstCivil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PesqEstCivil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PesqEstCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesqEstCivil.ForeColor = System.Drawing.Color.CadetBlue;
            this.PesqEstCivil.FormattingEnabled = true;
            this.PesqEstCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)",
            "Viuvo(a)",
            "Divorciado(a)",
            "Separado(a)"});
            this.PesqEstCivil.Location = new System.Drawing.Point(493, 40);
            this.PesqEstCivil.Name = "PesqEstCivil";
            this.PesqEstCivil.Size = new System.Drawing.Size(166, 28);
            this.PesqEstCivil.TabIndex = 7;
            this.PesqEstCivil.TextChanged += new System.EventHandler(this.PesqCod_TextChanged);
            // 
            // PesqGenero
            // 
            this.PesqGenero.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PesqGenero.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PesqGenero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PesqGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesqGenero.ForeColor = System.Drawing.Color.CadetBlue;
            this.PesqGenero.FormattingEnabled = true;
            this.PesqGenero.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.PesqGenero.Location = new System.Drawing.Point(232, 41);
            this.PesqGenero.Name = "PesqGenero";
            this.PesqGenero.Size = new System.Drawing.Size(255, 28);
            this.PesqGenero.TabIndex = 6;
            this.PesqGenero.TextChanged += new System.EventHandler(this.PesqCod_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(826, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Data Nasc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(661, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereco Gerais";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(489, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Estado civil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(228, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Genero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(63, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome CPF/CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(13, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Id";
            // 
            // PesqNasc
            // 
            this.PesqNasc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PesqNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesqNasc.ForeColor = System.Drawing.Color.CadetBlue;
            this.PesqNasc.Location = new System.Drawing.Point(830, 40);
            this.PesqNasc.Name = "PesqNasc";
            this.PesqNasc.Size = new System.Drawing.Size(159, 26);
            this.PesqNasc.TabIndex = 2;
            this.PesqNasc.TextChanged += new System.EventHandler(this.PesqCod_TextChanged);
            // 
            // PesqEnderecos
            // 
            this.PesqEnderecos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PesqEnderecos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesqEnderecos.ForeColor = System.Drawing.Color.CadetBlue;
            this.PesqEnderecos.Location = new System.Drawing.Point(665, 40);
            this.PesqEnderecos.Name = "PesqEnderecos";
            this.PesqEnderecos.Size = new System.Drawing.Size(159, 26);
            this.PesqEnderecos.TabIndex = 2;
            this.PesqEnderecos.TextChanged += new System.EventHandler(this.PesqCod_TextChanged);
            // 
            // PesqNome
            // 
            this.PesqNome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PesqNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesqNome.ForeColor = System.Drawing.Color.CadetBlue;
            this.PesqNome.Location = new System.Drawing.Point(67, 43);
            this.PesqNome.Name = "PesqNome";
            this.PesqNome.Size = new System.Drawing.Size(159, 26);
            this.PesqNome.TabIndex = 2;
            this.PesqNome.TextChanged += new System.EventHandler(this.PesqCod_TextChanged);
            // 
            // PesqCod
            // 
            this.PesqCod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PesqCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PesqCod.ForeColor = System.Drawing.Color.CadetBlue;
            this.PesqCod.Location = new System.Drawing.Point(17, 43);
            this.PesqCod.Name = "PesqCod";
            this.PesqCod.Size = new System.Drawing.Size(44, 26);
            this.PesqCod.TabIndex = 2;
            this.PesqCod.TextChanged += new System.EventHandler(this.PesqCod_TextChanged);
            // 
            // lblTotalCancelados
            // 
            this.lblTotalCancelados.AutoSize = true;
            this.lblTotalCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCancelados.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTotalCancelados.Location = new System.Drawing.Point(728, 642);
            this.lblTotalCancelados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCancelados.Name = "lblTotalCancelados";
            this.lblTotalCancelados.Size = new System.Drawing.Size(70, 22);
            this.lblTotalCancelados.TabIndex = 1;
            this.lblTotalCancelados.Text = "Genero";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbltotal.Location = new System.Drawing.Point(4, 642);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(70, 22);
            this.lbltotal.TabIndex = 1;
            this.lbltotal.Text = "Genero";
            // 
            // lbltotalAtivos
            // 
            this.lbltotalAtivos.AutoSize = true;
            this.lbltotalAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalAtivos.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbltotalAtivos.Location = new System.Drawing.Point(324, 642);
            this.lbltotalAtivos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalAtivos.Name = "lbltotalAtivos";
            this.lbltotalAtivos.Size = new System.Drawing.Size(70, 22);
            this.lbltotalAtivos.TabIndex = 1;
            this.lbltotalAtivos.Text = "Genero";
            // 
            // lblAviso
            // 
            this.lblAviso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAviso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAviso.Location = new System.Drawing.Point(-4, 144);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(1409, 400);
            this.lblAviso.TabIndex = 2;
            this.lblAviso.Text = "Nada Econtrado...";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAviso.Visible = false;
            // 
            // btFicha
            // 
            this.btFicha.BackColor = System.Drawing.Color.Transparent;
            this.btFicha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFicha.Enabled = false;
            this.btFicha.FlatAppearance.BorderSize = 0;
            this.btFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFicha.Image = ((System.Drawing.Image)(resources.GetObject("btFicha.Image")));
            this.btFicha.Location = new System.Drawing.Point(245, 30);
            this.btFicha.Name = "btFicha";
            this.btFicha.Size = new System.Drawing.Size(48, 48);
            this.btFicha.TabIndex = 1;
            this.btFicha.UseVisualStyleBackColor = false;
            // 
            // btRelatorio
            // 
            this.btRelatorio.BackColor = System.Drawing.Color.Transparent;
            this.btRelatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRelatorio.FlatAppearance.BorderSize = 0;
            this.btRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btRelatorio.Image")));
            this.btRelatorio.Location = new System.Drawing.Point(169, 30);
            this.btRelatorio.Name = "btRelatorio";
            this.btRelatorio.Size = new System.Drawing.Size(48, 48);
            this.btRelatorio.TabIndex = 1;
            this.btRelatorio.UseVisualStyleBackColor = false;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.Transparent;
            this.btEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEditar.Enabled = false;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.Location = new System.Drawing.Point(93, 30);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(48, 48);
            this.btEditar.TabIndex = 1;
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.FlatAppearance.BorderSize = 0;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(6, 30);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(59, 48);
            this.btAdd.TabIndex = 1;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // FrmMenuClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1456, 673);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.dgLista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbltotalAtivos);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblTotalCancelados);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMenuClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Clientes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMenuClientes_FormClosed);
            this.Load += new System.EventHandler(this.FrmMenuClientes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btFicha;
        private System.Windows.Forms.Button btRelatorio;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DataGridView dgLista;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PesqCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PesqNome;
        private System.Windows.Forms.ComboBox PesqEstCivil;
        private System.Windows.Forms.ComboBox PesqGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PesqEnderecos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PesqNasc;
        private System.Windows.Forms.RadioButton PesqCancelado;
        private System.Windows.Forms.RadioButton PesqTodos;
        private System.Windows.Forms.RadioButton PesqAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_civil;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.Label lblTotalCancelados;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbltotalAtivos;
        private System.Windows.Forms.Label lblAviso;
    }
}