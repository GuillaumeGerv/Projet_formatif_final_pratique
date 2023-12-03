using Projet_formatif_final.Business;
using Projet_formatif_final.DataAcess.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_formatif_final.GUI;

internal partial class UserManagementForm : Form
{
    private enum ViewIntentEnum
    {
        VIEW,
        CREATE,
        EDIT,
        DELETE
    }

    private FinalFormatifApp parentApp;
    private ViewIntentEnum currentIntent;
    private Utilisateur currentUser = null!;
    public UserManagementForm(FinalFormatifApp parentApp)
    {
        this.parentApp = parentApp;
        InitializeComponent();
        this.currentUser = new Utilisateur();
        this.ReloadRoleList();
    }
    private void ReloadRoleList()
    {
        this.userRolesListBox.Items.Clear();
        this.userRolesListBox.DataSource = parentApp.GetAllRoles();
    }
    public DialogResult OpenForView(Utilisateur user)
    {
        this.currentIntent = ViewIntentEnum.VIEW;
        this.buttonAction.Text = "Close";
        this.currentUser = user;
        this.DeactivatesControls();
        this.LoadUsersDataInControls(user);
        return this.ShowDialog();
    }
    private void LoadUsersDataInControls(Utilisateur user)
    {
        if (user != null)
        {
            this.numericUpDownId.Value = user.Id;
            this.textBoxUsername.Text = user.NomUtilisateur;
            this.textBoxPassword.Text = user.MotDePasse;

            // Check if Roles is not null before trying to make change
            if (user.Roles != null)
            {
                this.userRolesListBox.SelectedItems.Clear();

                foreach (Role role in user.Roles)
                {
                    // Check if role is not null before adding it
                    if (role != null)
                    {
                        this.userRolesListBox.SelectedItems.Add(role);
                    }
                }
            }
        }
    }


    public DialogResult OpenForCreate(Utilisateur user)
    {
        this.currentIntent = ViewIntentEnum.CREATE;
        this.buttonAction.Text = "Create";
        this.ActivateControls();
        this.LoadUsersDataInControls(user);
        return this.ShowDialog();
    }
    public DialogResult OpenForEdit(Utilisateur user)
    {
        this.currentIntent = ViewIntentEnum.EDIT;
        this.buttonAction.Text = "Save";
        this.ActivateControls();
        this.LoadUsersDataInControls(user);
        return this.ShowDialog();
    }
    public DialogResult OpenForDelete(Utilisateur user)
    {
        this.currentIntent = ViewIntentEnum.DELETE;
        this.buttonAction.Text = "Deleted";
        this.DeactivatesControls();
        this.LoadUsersDataInControls(user);
        return this.ShowDialog();
    }

    private void ActivateControls()
    {
        this.numericUpDownId.Enabled = false;
        this.textBoxUsername.Enabled = true;
        this.textBoxPassword.Enabled = true;
        this.userRolesListBox.Enabled = true;
    }
    private void DeactivatesControls()
    {
        this.numericUpDownId.Enabled = true;
        this.textBoxUsername.Enabled = false;
        this.textBoxPassword.Enabled = false;
        this.userRolesListBox.Enabled = false;
    }
    

    private void buttonAction_Click(object sender, EventArgs e)
    {
        try
        {
            switch (this.currentIntent)
            {
                case ViewIntentEnum.CREATE:
                case ViewIntentEnum.EDIT:
                    this.UpdateInstanceWithData();
                    break;
                case ViewIntentEnum.VIEW:
                case ViewIntentEnum.DELETE:
                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            _ = MessageBox.Show(ex.Message);
        }
    }
    private void UpdateInstanceWithData()
    {
        if (this.currentUser == null)
        {
            throw new Exception("Current user is not properly initialized.");
        }
        if (this.textBoxUsername.Text.Length > Utilisateur.MAX_USERNAME_LENGTH)
        {
            throw new Exception($"Username too long, {this.textBoxUsername.Text.Length} enter caracters. The maximum is {Utilisateur.MAX_USERNAME_LENGTH}.");
        }
        if (this.textBoxPassword.Text.Length > Utilisateur.MAX_PASSWORD_LENGTH)
        {
            throw new Exception($"Password too long, {this.textBoxPassword.Text.Length} enter caracters. The maximum is {Utilisateur.MAX_PASSWORD_LENGTH}.");
        }
        this.currentUser.NomUtilisateur = this.textBoxUsername.Text;
        this.currentUser.MotDePasse = this.textBoxPassword.Text;
        List<Role> selectedRoles = new List<Role>();
        foreach (object? selectedRole in this.userRolesListBox.SelectedItems)
        {
            selectedRoles.Add((Role)selectedRole);
        }
        this.currentUser.Roles = selectedRoles;
    }

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
    }
}
