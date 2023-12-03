namespace Projet_formatif_final.GUI
{
    partial class UserManagementForm
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
            panelButton = new Panel();
            buttonCancel = new Button();
            buttonAction = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ControlPanel = new Panel();
            userRolesListBox = new ListBox();
            labelRole = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            numericUpDownId = new NumericUpDown();
            labelId = new Label();
            panelButton.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            SuspendLayout();
            // 
            // panelButton
            // 
            panelButton.Controls.Add(buttonCancel);
            panelButton.Controls.Add(buttonAction);
            panelButton.Dock = DockStyle.Bottom;
            panelButton.Location = new Point(0, 365);
            panelButton.Name = "panelButton";
            panelButton.Size = new Size(484, 96);
            panelButton.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(361, 51);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(111, 33);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonAction
            // 
            buttonAction.Location = new Point(12, 51);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(111, 33);
            buttonAction.TabIndex = 0;
            buttonAction.Text = "Action";
            buttonAction.UseVisualStyleBackColor = true;
            buttonAction.Click += buttonAction_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1642F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.7794342F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0563679F));
            tableLayoutPanel1.Controls.Add(ControlPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(484, 365);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ControlPanel
            // 
            ControlPanel.Controls.Add(userRolesListBox);
            ControlPanel.Controls.Add(labelRole);
            ControlPanel.Controls.Add(textBoxPassword);
            ControlPanel.Controls.Add(labelPassword);
            ControlPanel.Controls.Add(textBoxUsername);
            ControlPanel.Controls.Add(labelUsername);
            ControlPanel.Controls.Add(numericUpDownId);
            ControlPanel.Controls.Add(labelId);
            ControlPanel.Location = new Point(124, 3);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(234, 359);
            ControlPanel.TabIndex = 0;
            // 
            // userRolesListBox
            // 
            userRolesListBox.FormattingEnabled = true;
            userRolesListBox.ItemHeight = 15;
            userRolesListBox.Location = new Point(12, 184);
            userRolesListBox.Name = "userRolesListBox";
            userRolesListBox.Size = new Size(207, 169);
            userRolesListBox.TabIndex = 7;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(11, 166);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(64, 15);
            labelRole.TabIndex = 6;
            labelRole.Text = "User Roles:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(11, 131);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(207, 23);
            textBoxPassword.TabIndex = 5;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(10, 115);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(12, 86);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(207, 23);
            textBoxUsername.TabIndex = 3;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(11, 70);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(63, 15);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username:";
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(11, 32);
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(208, 23);
            numericUpDownId.TabIndex = 1;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(11, 14);
            labelId.Name = "labelId";
            labelId.Size = new Size(21, 15);
            labelId.TabIndex = 0;
            labelId.Text = "ID:";
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelButton);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            panelButton.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ControlPanel.ResumeLayout(false);
            ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel ControlPanel;
        private Label labelUsername;
        private NumericUpDown numericUpDownId;
        private Label labelId;
        private TextBox textBoxUsername;
        private ListBox userRolesListBox;
        private Label labelRole;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button buttonCancel;
        private Button buttonAction;
    }
}