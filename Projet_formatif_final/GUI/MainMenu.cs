using Projet_formatif_final.Business;
using Projet_formatif_final.DataAcess.DTOs;
using System.Windows.Forms.VisualStyles;

namespace Projet_formatif_final.GUI;

internal partial class MainMenu : Form
{
    private FinalFormatifApp parentApp;
    private Utilisateur? selectedUser;
    public MainMenu(FinalFormatifApp parentApp)
    {
        this.parentApp = parentApp;
        this.InitializeComponent();
        this.ReloadUserListBox();
    }

    public void ReloadUserListBox()
    {
        this.userListBox.SelectedItem = null;
        this.userListBox.DataSource = parentApp.GetAllUtilisateur();
    }

    private void buttonCreate_Click(object sender, EventArgs e)
    {
        Utilisateur? newUser = this.parentApp.CreateNewUser();
        this.ReloadUserListBox();
    }

    private void buttonQuit_Click(object sender, EventArgs e)
    {
        this.parentApp.Terminate();
    }

    private void userListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.selectedUser = this.userListBox.SelectedItem as Utilisateur;
        this.ActivateUserSelectedButtons();
    }
    private void ActivateUserSelectedButtons()
    {
        this.buttonDetails.Enabled = true;
        this.buttonChange.Enabled = true;
        this.buttonDelete.Enabled = true;
    }

    private void DeactivateUserSelectedButtons()
    {
        this.buttonDetails.Enabled = false;
        this.buttonChange.Enabled = false;
        this.buttonDelete.Enabled = false;
    }

    private void buttonChange_Click(object sender, EventArgs e)
    {
        if (this.selectedUser is not null)
        {
            _ = this.parentApp.EditUser(this.selectedUser);
            this.ReloadUserListBox();
        }
    }

    private void buttonDetails_Click(object sender, EventArgs e)
    {
        if (this.selectedUser is not null)
        {
            _ = this.parentApp.ViewUserDetails(this.selectedUser);
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (this.selectedUser is not null)
        {
            Utilisateur? deletedUser = this.parentApp.DeleteUser(this.selectedUser);
            if (deletedUser is not null) {
                this.ReloadUserListBox();
                this.selectedUser = null;
                this.DeactivateUserSelectedButtons();
            }
        }
    }
}