namespace Puffy.Voip
{
    partial class CallForm
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
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.contactsTabPage = new System.Windows.Forms.TabPage();
            this.makeCallButton = new System.Windows.Forms.Button();
            this.searchContactTextBox = new System.Windows.Forms.TextBox();
            this.contactSearchLabel = new System.Windows.Forms.Label();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.phoneTabPage = new System.Windows.Forms.TabPage();
            this.settingsTabPage = new System.Windows.Forms.TabPage();
            this.providerTextBox = new System.Windows.Forms.TextBox();
            this.providerLabel = new System.Windows.Forms.Label();
            this.saveSettingsButton = new System.Windows.Forms.Button();
            this.callBackTextBox = new System.Windows.Forms.TextBox();
            this.callBackLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.callNotification = new Microsoft.WindowsCE.Forms.Notification();
            this.menuTabControl.SuspendLayout();
            this.contactsTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.contactsTabPage);
            this.menuTabControl.Controls.Add(this.phoneTabPage);
            this.menuTabControl.Controls.Add(this.settingsTabPage);
            this.menuTabControl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
            this.menuTabControl.Location = new System.Drawing.Point(0, 0);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(240, 294);
            this.menuTabControl.TabIndex = 0;
            // 
            // contactsTabPage
            // 
            this.contactsTabPage.Controls.Add(this.makeCallButton);
            this.contactsTabPage.Controls.Add(this.searchContactTextBox);
            this.contactsTabPage.Controls.Add(this.contactSearchLabel);
            this.contactsTabPage.Controls.Add(this.contactsListBox);
            this.contactsTabPage.Location = new System.Drawing.Point(0, 0);
            this.contactsTabPage.Name = "contactsTabPage";
            this.contactsTabPage.Size = new System.Drawing.Size(240, 265);
            this.contactsTabPage.Text = "Contacten";
            // 
            // makeCallButton
            // 
            this.makeCallButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.makeCallButton.Location = new System.Drawing.Point(3, 232);
            this.makeCallButton.Name = "makeCallButton";
            this.makeCallButton.Size = new System.Drawing.Size(234, 30);
            this.makeCallButton.TabIndex = 3;
            this.makeCallButton.Text = "Bellen";
            this.makeCallButton.Click += new System.EventHandler(this.makeCallButton_Click);
            // 
            // searchContactTextBox
            // 
            this.searchContactTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.searchContactTextBox.Location = new System.Drawing.Point(3, 27);
            this.searchContactTextBox.Name = "searchContactTextBox";
            this.searchContactTextBox.Size = new System.Drawing.Size(234, 31);
            this.searchContactTextBox.TabIndex = 2;
            this.searchContactTextBox.TextChanged += new System.EventHandler(this.searchContactTextBox_TextChanged);
            // 
            // contactSearchLabel
            // 
            this.contactSearchLabel.Location = new System.Drawing.Point(3, 4);
            this.contactSearchLabel.Name = "contactSearchLabel";
            this.contactSearchLabel.Size = new System.Drawing.Size(100, 20);
            this.contactSearchLabel.Text = "Zoeken:";
            // 
            // contactsListBox
            // 
            this.contactsListBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.contactsListBox.Location = new System.Drawing.Point(3, 64);
            this.contactsListBox.Name = "contactsListBox";
            this.contactsListBox.Size = new System.Drawing.Size(234, 146);
            this.contactsListBox.TabIndex = 0;
            // 
            // phoneTabPage
            // 
            this.phoneTabPage.Location = new System.Drawing.Point(0, 0);
            this.phoneTabPage.Name = "phoneTabPage";
            this.phoneTabPage.Size = new System.Drawing.Size(232, 263);
            this.phoneTabPage.Text = "Telefoon";
            // 
            // settingsTabPage
            // 
            this.settingsTabPage.Controls.Add(this.providerTextBox);
            this.settingsTabPage.Controls.Add(this.providerLabel);
            this.settingsTabPage.Controls.Add(this.saveSettingsButton);
            this.settingsTabPage.Controls.Add(this.callBackTextBox);
            this.settingsTabPage.Controls.Add(this.callBackLabel);
            this.settingsTabPage.Controls.Add(this.passwordTextBox);
            this.settingsTabPage.Controls.Add(this.passwordLabel);
            this.settingsTabPage.Controls.Add(this.usernameTextBox);
            this.settingsTabPage.Controls.Add(this.usernameLabel);
            this.settingsTabPage.Location = new System.Drawing.Point(0, 0);
            this.settingsTabPage.Name = "settingsTabPage";
            this.settingsTabPage.Size = new System.Drawing.Size(232, 263);
            this.settingsTabPage.Text = "Instellingen";
            // 
            // providerTextBox
            // 
            this.providerTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.providerTextBox.Location = new System.Drawing.Point(3, 27);
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.Size = new System.Drawing.Size(234, 31);
            this.providerTextBox.TabIndex = 20;
            // 
            // providerLabel
            // 
            this.providerLabel.Location = new System.Drawing.Point(3, 4);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(234, 20);
            this.providerLabel.Text = "Aanbieder:";
            // 
            // saveSettingsButton
            // 
            this.saveSettingsButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.saveSettingsButton.Location = new System.Drawing.Point(3, 232);
            this.saveSettingsButton.Name = "saveSettingsButton";
            this.saveSettingsButton.Size = new System.Drawing.Size(234, 30);
            this.saveSettingsButton.TabIndex = 15;
            this.saveSettingsButton.Text = "Opslaan";
            this.saveSettingsButton.Click += new System.EventHandler(this.saveSettingsButton_Click);
            // 
            // callBackTextBox
            // 
            this.callBackTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.callBackTextBox.Location = new System.Drawing.Point(3, 198);
            this.callBackTextBox.Name = "callBackTextBox";
            this.callBackTextBox.Size = new System.Drawing.Size(234, 31);
            this.callBackTextBox.TabIndex = 13;
            // 
            // callBackLabel
            // 
            this.callBackLabel.Location = new System.Drawing.Point(3, 175);
            this.callBackLabel.Name = "callBackLabel";
            this.callBackLabel.Size = new System.Drawing.Size(234, 20);
            this.callBackLabel.Text = "Uw telefoonnummer:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.passwordTextBox.Location = new System.Drawing.Point(3, 141);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(234, 31);
            this.passwordTextBox.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(3, 118);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(234, 20);
            this.passwordLabel.Text = "Wachtwoord:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.usernameTextBox.Location = new System.Drawing.Point(3, 84);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(234, 31);
            this.usernameTextBox.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Location = new System.Drawing.Point(3, 61);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(234, 20);
            this.usernameLabel.Text = "Gebruikersnaam:";
            // 
            // callNotification
            // 
            this.callNotification.InitialDuration = 7;
            this.callNotification.Text = "";
            // 
            // CallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.menuTabControl);
            this.KeyPreview = true;
            this.Name = "CallForm";
            this.Text = "VOIP";
            this.menuTabControl.ResumeLayout(false);
            this.contactsTabPage.ResumeLayout(false);
            this.settingsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage contactsTabPage;
        private System.Windows.Forms.TabPage phoneTabPage;
        private System.Windows.Forms.ListBox contactsListBox;
        private System.Windows.Forms.Label contactSearchLabel;
        private System.Windows.Forms.TextBox searchContactTextBox;
        private System.Windows.Forms.Button makeCallButton;
        private System.Windows.Forms.TabPage settingsTabPage;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox callBackTextBox;
        private System.Windows.Forms.Label callBackLabel;
        private System.Windows.Forms.Button saveSettingsButton;
        private System.Windows.Forms.TextBox providerTextBox;
        private System.Windows.Forms.Label providerLabel;
        private Microsoft.WindowsCE.Forms.Notification callNotification;
    }
}

