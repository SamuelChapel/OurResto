﻿
namespace OurResto
{
    partial class FormSalarie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalarie));
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.dGVSalarie = new System.Windows.Forms.DataGridView();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estActifDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idGradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cda68_bd1DataSet = new OurResto.cda68_bd1DataSet();
            this.tLPSalaries = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tBPrenom = new System.Windows.Forms.TextBox();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.tBNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.fLPTransactionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btCredit = new System.Windows.Forms.Button();
            this.btSellOff = new System.Windows.Forms.Button();
            this.dGVTransaction = new System.Windows.Forms.DataGridView();
            this.matriculeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypePaiementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horodateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tLPTransactions = new System.Windows.Forms.TableLayoutPanel();
            this.lblSoldeFinal = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblSolde = new System.Windows.Forms.Label();
            this.tBMontant = new System.Windows.Forms.TextBox();
            this.tBSolde = new System.Windows.Forms.TextBox();
            this.vsoldesalarieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cBTypePaiement = new System.Windows.Forms.ComboBox();
            this.typePaiementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBSoldeFinal = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRechercheSalarie = new System.Windows.Forms.Label();
            this.tBRechercheSalarie = new System.Windows.Forms.TextBox();
            this.tLPButtons = new System.Windows.Forms.TableLayoutPanel();
            this.fLPSalarieButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.salarieTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.SalarieTableAdapter();
            this.transactionTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.TransactionTableAdapter();
            this.v_soldesalarieTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.v_soldesalarieTableAdapter();
            this.typePaiementTableAdapter = new OurResto.cda68_bd1DataSetTableAdapters.TypePaiementTableAdapter();
            this.timerRechercheSalarie = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tLPMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSalarie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).BeginInit();
            this.tLPSalaries.SuspendLayout();
            this.fLPTransactionButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.tLPTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsoldesalarieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePaiementBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tLPButtons.SuspendLayout();
            this.fLPSalarieButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPMain
            // 
            this.tLPMain.ColumnCount = 2;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.59387F));
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.40613F));
            this.tLPMain.Controls.Add(this.dGVSalarie, 0, 1);
            this.tLPMain.Controls.Add(this.tLPSalaries, 0, 2);
            this.tLPMain.Controls.Add(this.fLPTransactionButtons, 1, 3);
            this.tLPMain.Controls.Add(this.dGVTransaction, 1, 1);
            this.tLPMain.Controls.Add(this.tLPTransactions, 1, 2);
            this.tLPMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tLPMain.Controls.Add(this.tLPButtons, 0, 3);
            this.tLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMain.Location = new System.Drawing.Point(0, 0);
            this.tLPMain.Margin = new System.Windows.Forms.Padding(4);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 4;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tLPMain.Size = new System.Drawing.Size(1182, 603);
            this.tLPMain.TabIndex = 0;
            // 
            // dGVSalarie
            // 
            this.dGVSalarie.AllowUserToAddRows = false;
            this.dGVSalarie.AllowUserToDeleteRows = false;
            this.dGVSalarie.AllowUserToResizeColumns = false;
            this.dGVSalarie.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dGVSalarie.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVSalarie.AutoGenerateColumns = false;
            this.dGVSalarie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSalarie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVSalarie.BackgroundColor = System.Drawing.Color.White;
            this.dGVSalarie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSalarie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.estActifDataGridViewCheckBoxColumn,
            this.idGradeDataGridViewTextBoxColumn});
            this.dGVSalarie.DataSource = this.salarieBindingSource;
            this.dGVSalarie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVSalarie.Location = new System.Drawing.Point(4, 42);
            this.dGVSalarie.Margin = new System.Windows.Forms.Padding(4);
            this.dGVSalarie.Name = "dGVSalarie";
            this.dGVSalarie.ReadOnly = true;
            this.dGVSalarie.RowHeadersVisible = false;
            this.dGVSalarie.RowHeadersWidth = 51;
            this.dGVSalarie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVSalarie.Size = new System.Drawing.Size(826, 341);
            this.dGVSalarie.TabIndex = 100;
            this.dGVSalarie.TabStop = false;
            this.dGVSalarie.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVSalarie_ColumnHeaderMouseClick);
            this.dGVSalarie.SelectionChanged += new System.EventHandler(this.DGVSalarie_SelectionChanged);
            this.dGVSalarie.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGVSalarie_MouseClick);
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            this.matriculeDataGridViewTextBoxColumn.ReadOnly = true;
            this.matriculeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            this.prenomDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // estActifDataGridViewCheckBoxColumn
            // 
            this.estActifDataGridViewCheckBoxColumn.DataPropertyName = "EstActif";
            this.estActifDataGridViewCheckBoxColumn.HeaderText = "EstActif";
            this.estActifDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.estActifDataGridViewCheckBoxColumn.Name = "estActifDataGridViewCheckBoxColumn";
            this.estActifDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estActifDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idGradeDataGridViewTextBoxColumn
            // 
            this.idGradeDataGridViewTextBoxColumn.DataPropertyName = "Id_Grade";
            this.idGradeDataGridViewTextBoxColumn.HeaderText = "Id_Grade";
            this.idGradeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idGradeDataGridViewTextBoxColumn.Name = "idGradeDataGridViewTextBoxColumn";
            this.idGradeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGradeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idGradeDataGridViewTextBoxColumn.Visible = false;
            // 
            // salarieBindingSource
            // 
            this.salarieBindingSource.DataMember = "Salarie";
            this.salarieBindingSource.DataSource = this.cda68_bd1DataSet;
            // 
            // cda68_bd1DataSet
            // 
            this.cda68_bd1DataSet.DataSetName = "cda68_bd1DataSet";
            this.cda68_bd1DataSet.Namespace = "http://tempuri.org/cda68_bd1DataSet.xsd";
            this.cda68_bd1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tLPSalaries
            // 
            this.tLPSalaries.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tLPSalaries.ColumnCount = 2;
            this.tLPSalaries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLPSalaries.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPSalaries.Controls.Add(this.lblEmail, 0, 2);
            this.tLPSalaries.Controls.Add(this.tBPrenom, 1, 1);
            this.tLPSalaries.Controls.Add(this.tBEmail, 1, 2);
            this.tLPSalaries.Controls.Add(this.tBNom, 1, 0);
            this.tLPSalaries.Controls.Add(this.lblNom, 0, 0);
            this.tLPSalaries.Controls.Add(this.lblPrenom, 0, 1);
            this.tLPSalaries.Controls.Add(this.lblInfo, 1, 3);
            this.tLPSalaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPSalaries.Location = new System.Drawing.Point(4, 391);
            this.tLPSalaries.Margin = new System.Windows.Forms.Padding(4);
            this.tLPSalaries.Name = "tLPSalaries";
            this.tLPSalaries.RowCount = 4;
            this.tLPSalaries.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPSalaries.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPSalaries.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPSalaries.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLPSalaries.Size = new System.Drawing.Size(826, 132);
            this.tLPSalaries.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Location = new System.Drawing.Point(4, 68);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 34);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBPrenom
            // 
            this.tBPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Prenom", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.tBPrenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBPrenom.Location = new System.Drawing.Point(77, 38);
            this.tBPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.tBPrenom.Name = "tBPrenom";
            this.tBPrenom.Size = new System.Drawing.Size(745, 26);
            this.tBPrenom.TabIndex = 3;
            this.tBPrenom.TextChanged += new System.EventHandler(this.TBPrenom_TextChanged);
            this.tBPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNom_Prenom_KeyPress);
            // 
            // tBEmail
            // 
            this.tBEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.tBEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBEmail.Location = new System.Drawing.Point(77, 72);
            this.tBEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(745, 26);
            this.tBEmail.TabIndex = 4;
            this.tBEmail.TextChanged += new System.EventHandler(this.TBEmail_TextChanged);
            // 
            // tBNom
            // 
            this.tBNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.salarieBindingSource, "Nom", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.tBNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBNom.Location = new System.Drawing.Point(77, 4);
            this.tBNom.Margin = new System.Windows.Forms.Padding(4);
            this.tBNom.Name = "tBNom";
            this.tBNom.Size = new System.Drawing.Size(745, 26);
            this.tBNom.TabIndex = 2;
            this.tBNom.TextChanged += new System.EventHandler(this.TBNom_TextChanged);
            this.tBNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNom_Prenom_KeyPress);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNom.Location = new System.Drawing.Point(4, 0);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(65, 34);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrenom.Location = new System.Drawing.Point(3, 34);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(67, 34);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prénom";
            this.lblPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(76, 102);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(747, 20);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Info";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fLPTransactionButtons
            // 
            this.fLPTransactionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fLPTransactionButtons.AutoSize = true;
            this.fLPTransactionButtons.Controls.Add(this.btCredit);
            this.fLPTransactionButtons.Controls.Add(this.btSellOff);
            this.fLPTransactionButtons.Location = new System.Drawing.Point(864, 530);
            this.fLPTransactionButtons.Name = "fLPTransactionButtons";
            this.fLPTransactionButtons.Size = new System.Drawing.Size(288, 70);
            this.fLPTransactionButtons.TabIndex = 4;
            // 
            // btCredit
            // 
            this.btCredit.Enabled = false;
            this.btCredit.Location = new System.Drawing.Point(3, 3);
            this.btCredit.Name = "btCredit";
            this.btCredit.Size = new System.Drawing.Size(138, 61);
            this.btCredit.TabIndex = 11;
            this.btCredit.Text = "&Crediter";
            this.btCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCredit.UseVisualStyleBackColor = true;
            this.btCredit.Click += new System.EventHandler(this.BtCredit_Click);
            // 
            // btSellOff
            // 
            this.btSellOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSellOff.Location = new System.Drawing.Point(147, 3);
            this.btSellOff.Name = "btSellOff";
            this.btSellOff.Size = new System.Drawing.Size(138, 61);
            this.btSellOff.TabIndex = 12;
            this.btSellOff.Text = "&Solder";
            this.btSellOff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSellOff.UseVisualStyleBackColor = true;
            this.btSellOff.Click += new System.EventHandler(this.BtSellOff_Click);
            // 
            // dGVTransaction
            // 
            this.dGVTransaction.AllowUserToAddRows = false;
            this.dGVTransaction.AllowUserToDeleteRows = false;
            this.dGVTransaction.AllowUserToResizeColumns = false;
            this.dGVTransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dGVTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVTransaction.AutoGenerateColumns = false;
            this.dGVTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dGVTransaction.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dGVTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculeDataGridViewTextBoxColumn1,
            this.idTypePaiementDataGridViewTextBoxColumn,
            this.horodateDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn});
            this.dGVTransaction.DataSource = this.transactionBindingSource;
            this.dGVTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVTransaction.Location = new System.Drawing.Point(837, 41);
            this.dGVTransaction.MultiSelect = false;
            this.dGVTransaction.Name = "dGVTransaction";
            this.dGVTransaction.ReadOnly = true;
            this.dGVTransaction.RowHeadersVisible = false;
            this.dGVTransaction.RowHeadersWidth = 51;
            this.dGVTransaction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dGVTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVTransaction.Size = new System.Drawing.Size(342, 343);
            this.dGVTransaction.TabIndex = 100;
            this.dGVTransaction.TabStop = false;
            // 
            // matriculeDataGridViewTextBoxColumn1
            // 
            this.matriculeDataGridViewTextBoxColumn1.DataPropertyName = "Matricule";
            this.matriculeDataGridViewTextBoxColumn1.HeaderText = "Matricule";
            this.matriculeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.matriculeDataGridViewTextBoxColumn1.Name = "matriculeDataGridViewTextBoxColumn1";
            this.matriculeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.matriculeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idTypePaiementDataGridViewTextBoxColumn
            // 
            this.idTypePaiementDataGridViewTextBoxColumn.DataPropertyName = "Id_TypePaiement";
            this.idTypePaiementDataGridViewTextBoxColumn.HeaderText = "Id_TypePaiement";
            this.idTypePaiementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idTypePaiementDataGridViewTextBoxColumn.Name = "idTypePaiementDataGridViewTextBoxColumn";
            this.idTypePaiementDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTypePaiementDataGridViewTextBoxColumn.Visible = false;
            // 
            // horodateDataGridViewTextBoxColumn
            // 
            this.horodateDataGridViewTextBoxColumn.DataPropertyName = "Horodate";
            this.horodateDataGridViewTextBoxColumn.HeaderText = "Horodate";
            this.horodateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horodateDataGridViewTextBoxColumn.Name = "horodateDataGridViewTextBoxColumn";
            this.horodateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            this.montantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "Transaction";
            this.transactionBindingSource.DataSource = this.cda68_bd1DataSet;
            // 
            // tLPTransactions
            // 
            this.tLPTransactions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tLPTransactions.ColumnCount = 2;
            this.tLPTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLPTransactions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPTransactions.Controls.Add(this.lblSoldeFinal, 0, 3);
            this.tLPTransactions.Controls.Add(this.lblType, 0, 2);
            this.tLPTransactions.Controls.Add(this.lblMontant, 0, 1);
            this.tLPTransactions.Controls.Add(this.lblSolde, 0, 0);
            this.tLPTransactions.Controls.Add(this.tBMontant, 1, 1);
            this.tLPTransactions.Controls.Add(this.tBSolde, 1, 0);
            this.tLPTransactions.Controls.Add(this.cBTypePaiement, 1, 2);
            this.tLPTransactions.Controls.Add(this.tBSoldeFinal, 1, 3);
            this.tLPTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPTransactions.Location = new System.Drawing.Point(837, 390);
            this.tLPTransactions.Name = "tLPTransactions";
            this.tLPTransactions.RowCount = 4;
            this.tLPTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tLPTransactions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tLPTransactions.Size = new System.Drawing.Size(342, 134);
            this.tLPTransactions.TabIndex = 2;
            // 
            // lblSoldeFinal
            // 
            this.lblSoldeFinal.AutoSize = true;
            this.lblSoldeFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoldeFinal.Location = new System.Drawing.Point(3, 98);
            this.lblSoldeFinal.Name = "lblSoldeFinal";
            this.lblSoldeFinal.Size = new System.Drawing.Size(145, 40);
            this.lblSoldeFinal.TabIndex = 8;
            this.lblSoldeFinal.Text = "Solde Final";
            this.lblSoldeFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Location = new System.Drawing.Point(3, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(145, 34);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type de paiement";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontant.Location = new System.Drawing.Point(3, 32);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(145, 32);
            this.lblMontant.TabIndex = 1;
            this.lblMontant.Text = "Montant à créditer";
            this.lblMontant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSolde
            // 
            this.lblSolde.AutoSize = true;
            this.lblSolde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSolde.Location = new System.Drawing.Point(3, 0);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(145, 32);
            this.lblSolde.TabIndex = 0;
            this.lblSolde.Text = "Solde";
            this.lblSolde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBMontant
            // 
            this.tBMontant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBMontant.Location = new System.Drawing.Point(154, 35);
            this.tBMontant.Name = "tBMontant";
            this.tBMontant.Size = new System.Drawing.Size(185, 26);
            this.tBMontant.TabIndex = 6;
            this.tBMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBMontant.TextChanged += new System.EventHandler(this.TBMontant_TextChanged);
            this.tBMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBMontant_KeyPress);
            // 
            // tBSolde
            // 
            this.tBSolde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSolde.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vsoldesalarieBindingSource, "Solde", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.tBSolde.Location = new System.Drawing.Point(154, 3);
            this.tBSolde.Name = "tBSolde";
            this.tBSolde.ReadOnly = true;
            this.tBSolde.Size = new System.Drawing.Size(185, 26);
            this.tBSolde.TabIndex = 5;
            this.tBSolde.TabStop = false;
            this.tBSolde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsoldesalarieBindingSource
            // 
            this.vsoldesalarieBindingSource.DataMember = "v_soldesalarie";
            this.vsoldesalarieBindingSource.DataSource = this.cda68_bd1DataSet;
            // 
            // cBTypePaiement
            // 
            this.cBTypePaiement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cBTypePaiement.DataSource = this.typePaiementBindingSource;
            this.cBTypePaiement.DisplayMember = "Nom";
            this.cBTypePaiement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTypePaiement.FormattingEnabled = true;
            this.cBTypePaiement.Location = new System.Drawing.Point(154, 67);
            this.cBTypePaiement.Name = "cBTypePaiement";
            this.cBTypePaiement.Size = new System.Drawing.Size(185, 28);
            this.cBTypePaiement.TabIndex = 7;
            this.cBTypePaiement.ValueMember = "Nom";
            // 
            // typePaiementBindingSource
            // 
            this.typePaiementBindingSource.DataMember = "TypePaiement";
            this.typePaiementBindingSource.DataSource = this.cda68_bd1DataSet;
            // 
            // tBSoldeFinal
            // 
            this.tBSoldeFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSoldeFinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vsoldesalarieBindingSource, "Solde", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.tBSoldeFinal.Location = new System.Drawing.Point(154, 105);
            this.tBSoldeFinal.Name = "tBSoldeFinal";
            this.tBSoldeFinal.ReadOnly = true;
            this.tBSoldeFinal.Size = new System.Drawing.Size(185, 26);
            this.tBSoldeFinal.TabIndex = 9;
            this.tBSoldeFinal.TabStop = false;
            this.tBSoldeFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblRechercheSalarie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tBRechercheSalarie, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(828, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRechercheSalarie
            // 
            this.lblRechercheSalarie.AutoSize = true;
            this.lblRechercheSalarie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRechercheSalarie.Location = new System.Drawing.Point(3, 0);
            this.lblRechercheSalarie.Name = "lblRechercheSalarie";
            this.lblRechercheSalarie.Size = new System.Drawing.Size(90, 32);
            this.lblRechercheSalarie.TabIndex = 0;
            this.lblRechercheSalarie.Text = "Recherche";
            this.lblRechercheSalarie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBRechercheSalarie
            // 
            this.tBRechercheSalarie.Location = new System.Drawing.Point(99, 3);
            this.tBRechercheSalarie.Name = "tBRechercheSalarie";
            this.tBRechercheSalarie.Size = new System.Drawing.Size(306, 26);
            this.tBRechercheSalarie.TabIndex = 0;
            this.tBRechercheSalarie.TextChanged += new System.EventHandler(this.TBRechercheSalarie_TextChanged);
            // 
            // tLPButtons
            // 
            this.tLPButtons.ColumnCount = 2;
            this.tLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLPButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPButtons.Controls.Add(this.fLPSalarieButtons, 1, 0);
            this.tLPButtons.Controls.Add(this.btQuitter, 0, 0);
            this.tLPButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPButtons.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tLPButtons.Location = new System.Drawing.Point(3, 530);
            this.tLPButtons.Name = "tLPButtons";
            this.tLPButtons.RowCount = 1;
            this.tLPButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPButtons.Size = new System.Drawing.Size(828, 70);
            this.tLPButtons.TabIndex = 3;
            // 
            // fLPSalarieButtons
            // 
            this.fLPSalarieButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.fLPSalarieButtons.AutoSize = true;
            this.fLPSalarieButtons.Controls.Add(this.btRefresh);
            this.fLPSalarieButtons.Controls.Add(this.btEdit);
            this.fLPSalarieButtons.Location = new System.Drawing.Point(342, 3);
            this.fLPSalarieButtons.Name = "fLPSalarieButtons";
            this.fLPSalarieButtons.Size = new System.Drawing.Size(288, 64);
            this.fLPSalarieButtons.TabIndex = 1;
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(3, 3);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(138, 61);
            this.btRefresh.TabIndex = 9;
            this.btRefresh.Text = "&Actualiser";
            this.btRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.BtRefresh_Click);
            // 
            // btEdit
            // 
            this.btEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btEdit.Location = new System.Drawing.Point(147, 3);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(138, 61);
            this.btEdit.TabIndex = 10;
            this.btEdit.Text = "&Modifier";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.BtEdit_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btQuitter.BackColor = System.Drawing.Color.Transparent;
            this.btQuitter.Location = new System.Drawing.Point(3, 3);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(138, 64);
            this.btQuitter.TabIndex = 0;
            this.btQuitter.Text = "&Quitter";
            this.btQuitter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btQuitter.UseVisualStyleBackColor = false;
            this.btQuitter.Click += new System.EventHandler(this.BtQuitter_Click);
            // 
            // salarieTableAdapter
            // 
            this.salarieTableAdapter.ClearBeforeFill = true;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // v_soldesalarieTableAdapter
            // 
            this.v_soldesalarieTableAdapter.ClearBeforeFill = true;
            // 
            // typePaiementTableAdapter
            // 
            this.typePaiementTableAdapter.ClearBeforeFill = true;
            // 
            // timerRechercheSalarie
            // 
            this.timerRechercheSalarie.Interval = 400;
            this.timerRechercheSalarie.Tick += new System.EventHandler(this.TimerRechercheSalarie_Tick);
            // 
            // cMS
            // 
            this.cMS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cMS.Name = "cMS";
            this.cMS.Size = new System.Drawing.Size(61, 4);
            this.cMS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.CMS_ItemClicked);
            // 
            // FormSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.tLPMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1069, 579);
            this.Name = "FormSalarie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comptes repas des salariés";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSalarie_FormClosing);
            this.Load += new System.EventHandler(this.FormSalarie_Load);
            this.tLPMain.ResumeLayout(false);
            this.tLPMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSalarie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salarieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cda68_bd1DataSet)).EndInit();
            this.tLPSalaries.ResumeLayout(false);
            this.tLPSalaries.PerformLayout();
            this.fLPTransactionButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.tLPTransactions.ResumeLayout(false);
            this.tLPTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsoldesalarieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typePaiementBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tLPButtons.ResumeLayout(false);
            this.tLPButtons.PerformLayout();
            this.fLPSalarieButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPMain;
        private System.Windows.Forms.DataGridView dGVSalarie;
        private cda68_bd1DataSet cda68_bd1DataSet;
        private System.Windows.Forms.BindingSource salarieBindingSource;
        private cda68_bd1DataSetTableAdapters.SalarieTableAdapter salarieTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tLPSalaries;
        private System.Windows.Forms.TextBox tBPrenom;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.TextBox tBNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.FlowLayoutPanel fLPTransactionButtons;
        private System.Windows.Forms.Button btCredit;
        private System.Windows.Forms.Button btSellOff;
        private System.Windows.Forms.DataGridView dGVTransaction;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private cda68_bd1DataSetTableAdapters.TransactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTypePaiementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horodateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tLPTransactions;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.TextBox tBMontant;
        private System.Windows.Forms.TextBox tBSolde;
        private System.Windows.Forms.BindingSource vsoldesalarieBindingSource;
        private cda68_bd1DataSetTableAdapters.v_soldesalarieTableAdapter v_soldesalarieTableAdapter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cBTypePaiement;
        private System.Windows.Forms.BindingSource typePaiementBindingSource;
        private cda68_bd1DataSetTableAdapters.TypePaiementTableAdapter typePaiementTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRechercheSalarie;
        private System.Windows.Forms.TextBox tBRechercheSalarie;
        private System.Windows.Forms.Timer timerRechercheSalarie;
        private System.Windows.Forms.TableLayoutPanel tLPButtons;
        private System.Windows.Forms.FlowLayoutPanel fLPSalarieButtons;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ContextMenuStrip cMS;
        private System.Windows.Forms.Label lblSoldeFinal;
        private System.Windows.Forms.TextBox tBSoldeFinal;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estActifDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGradeDataGridViewTextBoxColumn;
    }
}