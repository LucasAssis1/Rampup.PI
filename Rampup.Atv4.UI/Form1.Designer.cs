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
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.labelAgency = new System.Windows.Forms.Label();
            this.tabPageOperations = new System.Windows.Forms.TabPage();
            this.listViewAccounts = new System.Windows.Forms.ListView();
            this.ownerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.personType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabPageRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(27, 37);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(218, 20);
            this.txtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de pessoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 180);
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
            this.comboPersonType.Location = new System.Drawing.Point(27, 96);
            this.comboPersonType.Name = "comboPersonType";
            this.comboPersonType.Size = new System.Drawing.Size(215, 21);
            this.comboPersonType.TabIndex = 8;
            // 
            // comboBoxAccountType
            // 
            this.comboBoxAccountType.FormattingEnabled = true;
            this.comboBoxAccountType.Items.AddRange(new object[] {
            "Poupanca",
            "Corrente"});
            this.comboBoxAccountType.Location = new System.Drawing.Point(27, 199);
            this.comboBoxAccountType.Name = "comboBoxAccountType";
            this.comboBoxAccountType.Size = new System.Drawing.Size(215, 21);
            this.comboBoxAccountType.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(143, 375);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(118, 45);
            this.btnSend.TabIndex = 10;
            this.btnSend.Text = "Cadastrar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(27, 255);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(218, 20);
            this.txtBalance.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 239);
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
            this.tabPageRegister.Controls.Add(this.txtAccount);
            this.tabPageRegister.Controls.Add(this.labelAccount);
            this.tabPageRegister.Controls.Add(this.txtAgency);
            this.tabPageRegister.Controls.Add(this.labelAgency);
            this.tabPageRegister.Controls.Add(this.txtBalance);
            this.tabPageRegister.Controls.Add(this.btnSend);
            this.tabPageRegister.Controls.Add(this.label4);
            this.tabPageRegister.Controls.Add(this.txtUserName);
            this.tabPageRegister.Controls.Add(this.label1);
            this.tabPageRegister.Controls.Add(this.label2);
            this.tabPageRegister.Controls.Add(this.comboBoxAccountType);
            this.tabPageRegister.Controls.Add(this.label3);
            this.tabPageRegister.Controls.Add(this.comboPersonType);
            this.tabPageRegister.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegister.Name = "tabPageRegister";
            this.tabPageRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegister.Size = new System.Drawing.Size(375, 466);
            this.tabPageRegister.TabIndex = 0;
            this.tabPageRegister.Text = "Cadastrar";
            this.tabPageRegister.UseVisualStyleBackColor = true;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(126, 148);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(119, 20);
            this.txtAccount.TabIndex = 16;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(126, 132);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(35, 13);
            this.labelAccount.TabIndex = 15;
            this.labelAccount.Text = "Conta";
            // 
            // txtAgency
            // 
            this.txtAgency.Location = new System.Drawing.Point(27, 148);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.Size = new System.Drawing.Size(77, 20);
            this.txtAgency.TabIndex = 14;
            // 
            // labelAgency
            // 
            this.labelAgency.AutoSize = true;
            this.labelAgency.Location = new System.Drawing.Point(27, 132);
            this.labelAgency.Name = "labelAgency";
            this.labelAgency.Size = new System.Drawing.Size(46, 13);
            this.labelAgency.TabIndex = 13;
            this.labelAgency.Text = "Agência";
            // 
            // tabPageOperations
            // 
            this.tabPageOperations.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperations.Name = "tabPageOperations";
            this.tabPageOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperations.Size = new System.Drawing.Size(375, 466);
            this.tabPageOperations.TabIndex = 1;
            this.tabPageOperations.Text = "Operações";
            this.tabPageOperations.UseVisualStyleBackColor = true;
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
            this.tabPageRegister.PerformLayout();
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
    }
}