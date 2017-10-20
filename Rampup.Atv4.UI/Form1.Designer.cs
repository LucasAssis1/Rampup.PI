using System.Windows.Forms;

namespace Rampup.Atv4.UI
{
    partial class Form1
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPersonType = new System.Windows.Forms.ComboBox();
            this.comboBoxAccountType = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRegister = new System.Windows.Forms.TabPage();
            this.groupBoxAccount_Register = new System.Windows.Forms.GroupBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.labelAgency = new System.Windows.Forms.Label();
            this.groupBoxUser_Register = new System.Windows.Forms.GroupBox();
            this.tabPageOperations = new System.Windows.Forms.TabPage();
            this.btnConfirm_Operations = new System.Windows.Forms.Button();
            this.groupBox_Operations = new System.Windows.Forms.GroupBox();
            this.labelValue_Operations = new System.Windows.Forms.Label();
            this.txtValue_Operations = new System.Windows.Forms.TextBox();
            this.radioButtonDeposit_Operations = new System.Windows.Forms.RadioButton();
            this.radioButtonCashOut_Operations = new System.Windows.Forms.RadioButton();
            this.txtAccount_Operations = new System.Windows.Forms.TextBox();
            this.labelAgency_Operations = new System.Windows.Forms.Label();
            this.txtAgency_Operations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.ownerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.groupBoxAccount_Register.SuspendLayout();
            this.groupBoxUser_Register.SuspendLayout();
            this.tabPageOperations.SuspendLayout();
            this.groupBox_Operations.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(16, 42);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(216, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de pessoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo da Conta";
            // 
            // comboPersonType
            // 
            this.comboPersonType.FormattingEnabled = true;
            this.comboPersonType.Items.AddRange(new object[] {
            "Juridica",
            "Fisica"});
            this.comboPersonType.Location = new System.Drawing.Point(16, 95);
            this.comboPersonType.Name = "comboPersonType";
            this.comboPersonType.Size = new System.Drawing.Size(118, 21);
            this.comboPersonType.TabIndex = 1;
            // 
            // comboBoxAccountType
            // 
            this.comboBoxAccountType.FormattingEnabled = true;
            this.comboBoxAccountType.Items.AddRange(new object[] {
            "Poupanca",
            "Corrente"});
            this.comboBoxAccountType.Location = new System.Drawing.Point(17, 97);
            this.comboBoxAccountType.Name = "comboBoxAccountType";
            this.comboBoxAccountType.Size = new System.Drawing.Size(215, 21);
            this.comboBoxAccountType.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(144, 398);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 45);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Cadastrar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(17, 150);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(215, 20);
            this.txtBalance.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Saldo";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRegister);
            this.tabControl.Controls.Add(this.tabPageOperations);
            this.tabControl.Location = new System.Drawing.Point(517, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(383, 492);
            this.tabControl.TabIndex = 13;
            // 
            // tabPageRegister
            // 
            this.tabPageRegister.Controls.Add(this.groupBoxAccount_Register);
            this.tabPageRegister.Controls.Add(this.groupBoxUser_Register);
            this.tabPageRegister.Controls.Add(this.btnSend);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(375, 466);
            this.tabPageRegister.TabIndex = 0;
            this.tabPageRegister.Text = "Cadastrar";
            this.tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // groupBoxAccount_Register
            // 
            this.groupBoxAccount_Register.Controls.Add(this.txtBalance);
            this.groupBoxAccount_Register.Controls.Add(this.txtAccount);
            this.groupBoxAccount_Register.Controls.Add(this.label3);
            this.groupBoxAccount_Register.Controls.Add(this.labelAccount);
            this.groupBoxAccount_Register.Controls.Add(this.comboBoxAccountType);
            this.groupBoxAccount_Register.Controls.Add(this.txtAgency);
            this.groupBoxAccount_Register.Controls.Add(this.label4);
            this.groupBoxAccount_Register.Controls.Add(this.labelAgency);
            this.groupBoxAccount_Register.Location = new System.Drawing.Point(30, 176);
            this.groupBoxAccount_Register.Name = "groupBoxAccount_Register";
            this.groupBoxAccount_Register.Size = new System.Drawing.Size(313, 193);
            this.groupBoxAccount_Register.TabIndex = 15;
            this.groupBoxAccount_Register.TabStop = false;
            this.groupBoxAccount_Register.Text = "Conta";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(116, 43);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(116, 20);
            this.txtAccount.TabIndex = 3;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(116, 27);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(35, 13);
            this.labelAccount.TabIndex = 15;
            this.labelAccount.Text = "Conta";
            // 
            // txtAgency
            // 
            this.txtAgency.Location = new System.Drawing.Point(17, 43);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.Size = new System.Drawing.Size(77, 20);
            this.txtAgency.TabIndex = 2;
            // 
            // labelAgency
            // 
            this.labelAgency.AutoSize = true;
            this.labelAgency.Location = new System.Drawing.Point(17, 27);
            this.labelAgency.Name = "labelAgency";
            this.labelAgency.Size = new System.Drawing.Size(46, 13);
            this.labelAgency.TabIndex = 13;
            this.labelAgency.Text = "Agência";
            // 
            // groupBoxUser_Register
            // 
            this.groupBoxUser_Register.Controls.Add(this.txtUserName);
            this.groupBoxUser_Register.Controls.Add(this.comboPersonType);
            this.groupBoxUser_Register.Controls.Add(this.label2);
            this.groupBoxUser_Register.Controls.Add(this.label1);
            this.groupBoxUser_Register.Location = new System.Drawing.Point(30, 25);
            this.groupBoxUser_Register.Name = "groupBoxUser_Register";
            this.groupBoxUser_Register.Size = new System.Drawing.Size(313, 135);
            this.groupBoxUser_Register.TabIndex = 16;
            this.groupBoxUser_Register.TabStop = false;
            this.groupBoxUser_Register.Text = "Usuário";
            // 
            // tabPageOperations
            // 
            this.tabPageOperations.Controls.Add(this.btnConfirm_Operations);
            this.tabPageOperations.Controls.Add(this.groupBox_Operations);
            this.tabPageOperations.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperations.Name = "tabPageOperations";
            this.tabPageOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperations.Size = new System.Drawing.Size(375, 466);
            this.tabPageOperations.TabIndex = 1;
            this.tabPageOperations.Text = "Operações";
            this.tabPageOperations.UseVisualStyleBackColor = true;
            // 
            // btnConfirm_Operations
            // 
            this.btnConfirm_Operations.Location = new System.Drawing.Point(207, 223);
            this.btnConfirm_Operations.Name = "btnConfirm_Operations";
            this.btnConfirm_Operations.Size = new System.Drawing.Size(127, 42);
            this.btnConfirm_Operations.TabIndex = 6;
            this.btnConfirm_Operations.Text = "Confirmar";
            this.btnConfirm_Operations.UseVisualStyleBackColor = true;
            this.btnConfirm_Operations.Click += new System.EventHandler(this.btnConfirm_Operations_Click);
            // 
            // groupBox_Operations
            // 
            this.groupBox_Operations.Controls.Add(this.labelValue_Operations);
            this.groupBox_Operations.Controls.Add(this.txtValue_Operations);
            this.groupBox_Operations.Controls.Add(this.radioButtonDeposit_Operations);
            this.groupBox_Operations.Controls.Add(this.radioButtonCashOut_Operations);
            this.groupBox_Operations.Controls.Add(this.txtAccount_Operations);
            this.groupBox_Operations.Controls.Add(this.labelAgency_Operations);
            this.groupBox_Operations.Controls.Add(this.txtAgency_Operations);
            this.groupBox_Operations.Controls.Add(this.label5);
            this.groupBox_Operations.Location = new System.Drawing.Point(30, 25);
            this.groupBox_Operations.Name = "groupBox_Operations";
            this.groupBox_Operations.Size = new System.Drawing.Size(313, 179);
            this.groupBox_Operations.TabIndex = 5;
            this.groupBox_Operations.TabStop = false;
            this.groupBox_Operations.Text = "Operação";
            // 
            // labelValue_Operations
            // 
            this.labelValue_Operations.AutoSize = true;
            this.labelValue_Operations.Location = new System.Drawing.Point(17, 79);
            this.labelValue_Operations.Name = "labelValue_Operations";
            this.labelValue_Operations.Size = new System.Drawing.Size(31, 13);
            this.labelValue_Operations.TabIndex = 7;
            this.labelValue_Operations.Text = "Valor";
            // 
            // txtValue_Operations
            // 
            this.txtValue_Operations.Location = new System.Drawing.Point(17, 95);
            this.txtValue_Operations.Name = "txtValue_Operations";
            this.txtValue_Operations.Size = new System.Drawing.Size(108, 20);
            this.txtValue_Operations.TabIndex = 8;
            // 
            // radioButtonDeposit_Operations
            // 
            this.radioButtonDeposit_Operations.AutoSize = true;
            this.radioButtonDeposit_Operations.Location = new System.Drawing.Point(84, 139);
            this.radioButtonDeposit_Operations.Name = "radioButtonDeposit_Operations";
            this.radioButtonDeposit_Operations.Size = new System.Drawing.Size(70, 17);
            this.radioButtonDeposit_Operations.TabIndex = 6;
            this.radioButtonDeposit_Operations.TabStop = true;
            this.radioButtonDeposit_Operations.Text = "Depositar";
            this.radioButtonDeposit_Operations.UseVisualStyleBackColor = true;
            // 
            // radioButtonCashOut_Operations
            // 
            this.radioButtonCashOut_Operations.AutoSize = true;
            this.radioButtonCashOut_Operations.Location = new System.Drawing.Point(17, 139);
            this.radioButtonCashOut_Operations.Name = "radioButtonCashOut_Operations";
            this.radioButtonCashOut_Operations.Size = new System.Drawing.Size(53, 17);
            this.radioButtonCashOut_Operations.TabIndex = 5;
            this.radioButtonCashOut_Operations.TabStop = true;
            this.radioButtonCashOut_Operations.Text = "Sacar";
            this.radioButtonCashOut_Operations.UseVisualStyleBackColor = true;
            // 
            // txtAccount_Operations
            // 
            this.txtAccount_Operations.Location = new System.Drawing.Point(90, 39);
            this.txtAccount_Operations.Name = "txtAccount_Operations";
            this.txtAccount_Operations.Size = new System.Drawing.Size(82, 20);
            this.txtAccount_Operations.TabIndex = 3;
            // 
            // labelAgency_Operations
            // 
            this.labelAgency_Operations.AutoSize = true;
            this.labelAgency_Operations.Location = new System.Drawing.Point(17, 23);
            this.labelAgency_Operations.Name = "labelAgency_Operations";
            this.labelAgency_Operations.Size = new System.Drawing.Size(46, 13);
            this.labelAgency_Operations.TabIndex = 0;
            this.labelAgency_Operations.Text = "Agência";
            // 
            // txtAgency_Operations
            // 
            this.txtAgency_Operations.Location = new System.Drawing.Point(17, 39);
            this.txtAgency_Operations.Name = "txtAgency_Operations";
            this.txtAgency_Operations.Size = new System.Drawing.Size(46, 20);
            this.txtAgency_Operations.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Conta";
            // 
            // listViewAccounts
            // 
            this.listViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ownerName,
            this.accountType,
            this.personType,
            this.balance});
            this.listViewAccounts.Location = new System.Drawing.Point(47, 34);
            this.listViewAccounts.Name = "listViewAccounts";
            this.listViewAccounts.Size = new System.Drawing.Size(426, 466);
            this.listViewAccounts.TabIndex = 14;
            this.listViewAccounts.UseCompatibleStateImageBehavior = false;
            this.listViewAccounts.View = System.Windows.Forms.View.Details;
            // 
            // ownerName
            // 
            this.ownerName.Text = "Nome";
            this.ownerName.Width = 190;
            // 
            // accountType
            // 
            this.accountType.Text = "Tipo da conta";
            this.accountType.Width = 85;
            // 
            // personType
            // 
            this.personType.Text = "Tipo de Pessoa";
            this.personType.Width = 99;
            // 
            // balance
            // 
            this.balance.Text = "Saldo";
            this.balance.Width = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 535);
            this.Controls.Add(this.listViewAccounts);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageRegister.ResumeLayout(false);
            this.groupBoxAccount_Register.ResumeLayout(false);
            this.groupBoxAccount_Register.PerformLayout();
            this.groupBoxUser_Register.ResumeLayout(false);
            this.groupBoxUser_Register.PerformLayout();
            this.tabPageOperations.ResumeLayout(false);
            this.groupBox_Operations.ResumeLayout(false);
            this.groupBox_Operations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPersonType;
        private System.Windows.Forms.ComboBox comboBoxAccountType;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageRegister;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.TextBox txtAgency;
        private System.Windows.Forms.Label labelAgency;
        private System.Windows.Forms.TabPage tabPageOperations;
        private System.Windows.Forms.ListView listViewAccounts;
        private System.Windows.Forms.ColumnHeader ownerName;
        private System.Windows.Forms.ColumnHeader accountType;
        private System.Windows.Forms.ColumnHeader personType;
        private System.Windows.Forms.ColumnHeader balance;
        private TextBox txtAccount_Operations;
        private Label label5;
        private TextBox txtAgency_Operations;
        private Label labelAgency_Operations;
        private GroupBox groupBoxUser_Register;
        private GroupBox groupBoxAccount_Register;
        private GroupBox groupBox_Operations;
        private RadioButton radioButtonDeposit_Operations;
        private RadioButton radioButtonCashOut_Operations;
        private Label labelValue_Operations;
        private TextBox txtValue_Operations;
        private Button btnConfirm_Operations;
    }
}