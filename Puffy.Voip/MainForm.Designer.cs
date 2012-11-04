namespace Puffy.Voip
{
    partial class MainForm
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
            this.callContactButton = new System.Windows.Forms.Button();
            this.searchContactTextBox = new System.Windows.Forms.TextBox();
            this.contactSearchLabel = new System.Windows.Forms.Label();
            this.contactsListBox = new System.Windows.Forms.ListBox();
            this.phoneTabPage = new System.Windows.Forms.TabPage();
            this.clearButton = new System.Windows.Forms.Button();
            this.backspaceButton = new System.Windows.Forms.Button();
            this.callNumberButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.oneButton = new System.Windows.Forms.Button();
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
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuTabControl.SuspendLayout();
            this.contactsTabPage.SuspendLayout();
            this.phoneTabPage.SuspendLayout();
            this.settingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.contactsTabPage);
            this.menuTabControl.Controls.Add(this.phoneTabPage);
            this.menuTabControl.Controls.Add(this.settingsTabPage);
            this.menuTabControl.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
            this.menuTabControl.Location = new System.Drawing.Point(0, 0);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(240, 348);
            this.menuTabControl.TabIndex = 0;
            // 
            // contactsTabPage
            // 
            this.contactsTabPage.Controls.Add(this.callContactButton);
            this.contactsTabPage.Controls.Add(this.searchContactTextBox);
            this.contactsTabPage.Controls.Add(this.contactSearchLabel);
            this.contactsTabPage.Controls.Add(this.contactsListBox);
            this.contactsTabPage.Location = new System.Drawing.Point(0, 0);
            this.contactsTabPage.Name = "contactsTabPage";
            this.contactsTabPage.Size = new System.Drawing.Size(240, 317);
            this.contactsTabPage.Text = "Contacten";
            // 
            // callContactButton
            // 
            this.callContactButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.callContactButton.Location = new System.Drawing.Point(3, 286);
            this.callContactButton.Name = "callContactButton";
            this.callContactButton.Size = new System.Drawing.Size(234, 30);
            this.callContactButton.TabIndex = 3;
            this.callContactButton.Text = "Bellen";
            this.callContactButton.Click += new System.EventHandler(this.callContactButton_Click);
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
            this.contactsListBox.Size = new System.Drawing.Size(234, 194);
            this.contactsListBox.TabIndex = 0;
            // 
            // phoneTabPage
            // 
            this.phoneTabPage.Controls.Add(this.clearButton);
            this.phoneTabPage.Controls.Add(this.backspaceButton);
            this.phoneTabPage.Controls.Add(this.callNumberButton);
            this.phoneTabPage.Controls.Add(this.zeroButton);
            this.phoneTabPage.Controls.Add(this.nineButton);
            this.phoneTabPage.Controls.Add(this.eightButton);
            this.phoneTabPage.Controls.Add(this.sevenButton);
            this.phoneTabPage.Controls.Add(this.sixButton);
            this.phoneTabPage.Controls.Add(this.fiveButton);
            this.phoneTabPage.Controls.Add(this.fourButton);
            this.phoneTabPage.Controls.Add(this.threeButton);
            this.phoneTabPage.Controls.Add(this.twoButton);
            this.phoneTabPage.Controls.Add(this.phoneNumberTextBox);
            this.phoneTabPage.Controls.Add(this.oneButton);
            this.phoneTabPage.Location = new System.Drawing.Point(0, 0);
            this.phoneTabPage.Name = "phoneTabPage";
            this.phoneTabPage.Size = new System.Drawing.Size(240, 315);
            this.phoneTabPage.Text = "Telefoon";
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.clearButton.Location = new System.Drawing.Point(3, 286);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(47, 30);
            this.clearButton.TabIndex = 17;
            this.clearButton.Tag = "0";
            this.clearButton.Text = "C";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // backspaceButton
            // 
            this.backspaceButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.backspaceButton.Location = new System.Drawing.Point(190, 286);
            this.backspaceButton.Name = "backspaceButton";
            this.backspaceButton.Size = new System.Drawing.Size(47, 30);
            this.backspaceButton.TabIndex = 16;
            this.backspaceButton.Tag = "0";
            this.backspaceButton.Text = "<";
            this.backspaceButton.Click += new System.EventHandler(this.backspaceButton_Click);
            // 
            // callNumberButton
            // 
            this.callNumberButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.callNumberButton.Location = new System.Drawing.Point(56, 286);
            this.callNumberButton.Name = "callNumberButton";
            this.callNumberButton.Size = new System.Drawing.Size(128, 30);
            this.callNumberButton.TabIndex = 15;
            this.callNumberButton.Text = "Bellen";
            this.callNumberButton.Click += new System.EventHandler(this.callNumberButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.zeroButton.Location = new System.Drawing.Point(83, 182);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(74, 40);
            this.zeroButton.TabIndex = 13;
            this.zeroButton.Tag = "0";
            this.zeroButton.Text = "0";
            this.zeroButton.Click += new System.EventHandler(this.keypadButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.nineButton.Location = new System.Drawing.Point(163, 136);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(74, 40);
            this.nineButton.TabIndex = 12;
            this.nineButton.Tag = "9";
            this.nineButton.Text = "9";
            this.nineButton.Click += new System.EventHandler(this.keypadButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.eightButton.Location = new System.Drawing.Point(83, 136);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(74, 40);
            this.eightButton.TabIndex = 11;
            this.eightButton.Tag = "8";
            this.eightButton.Text = "8";
            this.eightButton.Click += new System.EventHandler(this.keypadButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.sevenButton.Location = new System.Drawing.Point(3, 136);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(74, 40);
            this.sevenButton.TabIndex = 10;
            this.sevenButton.Tag = "7";
            this.sevenButton.Text = "7";
            this.sevenButton.Click += new System.EventHandler(this.keypadButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.sixButton.Location = new System.Drawing.Point(163, 90);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(74, 40);
            this.sixButton.TabIndex = 9;
            this.sixButton.Tag = "6";
            this.sixButton.Text = "6";
            this.sixButton.Click += new System.EventHandler(this.keypadButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.fiveButton.Location = new System.Drawing.Point(83, 90);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(74, 40);
            this.fiveButton.TabIndex = 8;
            this.fiveButton.Tag = "5";
            this.fiveButton.Text = "5";
            this.fiveButton.Click += new System.EventHandler(this.keypadButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.fourButton.Location = new System.Drawing.Point(3, 90);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(74, 40);
            this.fourButton.TabIndex = 7;
            this.fourButton.Tag = "4";
            this.fourButton.Text = "4";
            this.fourButton.Click += new System.EventHandler(this.keypadButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.threeButton.Location = new System.Drawing.Point(163, 44);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(74, 40);
            this.threeButton.TabIndex = 6;
            this.threeButton.Tag = "3";
            this.threeButton.Text = "3";
            this.threeButton.Click += new System.EventHandler(this.keypadButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.twoButton.Location = new System.Drawing.Point(83, 44);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(74, 40);
            this.twoButton.TabIndex = 5;
            this.twoButton.Tag = "2";
            this.twoButton.Text = "2";
            this.twoButton.Click += new System.EventHandler(this.keypadButton_Click);
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(3, 7);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(234, 31);
            this.phoneNumberTextBox.TabIndex = 4;
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
            this.oneButton.Location = new System.Drawing.Point(3, 44);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(74, 40);
            this.oneButton.TabIndex = 0;
            this.oneButton.Tag = "1";
            this.oneButton.Text = "1";
            this.oneButton.Click += new System.EventHandler(this.keypadButton_Click);
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
            this.settingsTabPage.Size = new System.Drawing.Size(240, 319);
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
            this.saveSettingsButton.Location = new System.Drawing.Point(3, 286);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 348);
            this.Controls.Add(this.menuTabControl);
            this.KeyPreview = true;
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "VOIP";
            this.menuTabControl.ResumeLayout(false);
            this.contactsTabPage.ResumeLayout(false);
            this.phoneTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.Button callContactButton;
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
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button callNumberButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backspaceButton;
        private System.Windows.Forms.MainMenu mainMenu;
    }
}

