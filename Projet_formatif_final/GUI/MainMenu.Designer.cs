namespace Projet_formatif_final.GUI;

partial class MainMenu
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
        userListBox = new ListBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        buttonsPanel = new Panel();
        buttonQuit = new Button();
        buttonDelete = new Button();
        buttonChange = new Button();
        buttonDetails = new Button();
        buttonCreate = new Button();
        tableLayoutPanel1.SuspendLayout();
        buttonsPanel.SuspendLayout();
        SuspendLayout();
        // 
        // userListBox
        // 
        userListBox.FormattingEnabled = true;
        userListBox.ItemHeight = 15;
        userListBox.Location = new Point(3, 3);
        userListBox.Name = "userListBox";
        userListBox.Size = new Size(286, 349);
        userListBox.TabIndex = 0;
        userListBox.SelectedIndexChanged += userListBox_SelectedIndexChanged;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(userListBox, 0, 0);
        tableLayoutPanel1.Controls.Add(buttonsPanel, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(584, 361);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // buttonsPanel
        // 
        buttonsPanel.Controls.Add(buttonQuit);
        buttonsPanel.Controls.Add(buttonDelete);
        buttonsPanel.Controls.Add(buttonChange);
        buttonsPanel.Controls.Add(buttonDetails);
        buttonsPanel.Controls.Add(buttonCreate);
        buttonsPanel.Dock = DockStyle.Fill;
        buttonsPanel.Location = new Point(295, 3);
        buttonsPanel.Name = "buttonsPanel";
        buttonsPanel.Size = new Size(286, 355);
        buttonsPanel.TabIndex = 1;
        // 
        // buttonQuit
        // 
        buttonQuit.Location = new Point(3, 306);
        buttonQuit.Name = "buttonQuit";
        buttonQuit.Size = new Size(280, 30);
        buttonQuit.TabIndex = 4;
        buttonQuit.Text = "Quitter";
        buttonQuit.UseVisualStyleBackColor = true;
        buttonQuit.Click += buttonQuit_Click;
        // 
        // buttonDelete
        // 
        buttonDelete.Location = new Point(3, 111);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(280, 30);
        buttonDelete.TabIndex = 3;
        buttonDelete.Text = "Delete User";
        buttonDelete.UseVisualStyleBackColor = true;
        buttonDelete.Click += buttonDelete_Click;
        // 
        // buttonChange
        // 
        buttonChange.Location = new Point(3, 75);
        buttonChange.Name = "buttonChange";
        buttonChange.Size = new Size(280, 30);
        buttonChange.TabIndex = 2;
        buttonChange.Text = "Change User";
        buttonChange.UseVisualStyleBackColor = true;
        buttonChange.Click += buttonChange_Click;
        // 
        // buttonDetails
        // 
        buttonDetails.Location = new Point(3, 39);
        buttonDetails.Name = "buttonDetails";
        buttonDetails.Size = new Size(280, 30);
        buttonDetails.TabIndex = 1;
        buttonDetails.Text = "Details User";
        buttonDetails.UseVisualStyleBackColor = true;
        buttonDetails.Click += buttonDetails_Click;
        // 
        // buttonCreate
        // 
        buttonCreate.Location = new Point(3, 3);
        buttonCreate.Name = "buttonCreate";
        buttonCreate.Size = new Size(280, 30);
        buttonCreate.TabIndex = 0;
        buttonCreate.Text = "Create User";
        buttonCreate.UseVisualStyleBackColor = true;
        buttonCreate.Click += buttonCreate_Click;
        // 
        // MainMenu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(584, 361);
        Controls.Add(tableLayoutPanel1);
        Name = "MainMenu";
        Text = "Form1";
        tableLayoutPanel1.ResumeLayout(false);
        buttonsPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ListBox userListBox;
    private TableLayoutPanel tableLayoutPanel1;
    private Panel buttonsPanel;
    private Button buttonChange;
    private Button buttonDetails;
    private Button buttonCreate;
    private Button buttonQuit;
    private Button buttonDelete;
}