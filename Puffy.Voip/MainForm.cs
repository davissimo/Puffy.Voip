﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Puffy.Voip
{
    public partial class MainForm : Form
    {
        private readonly ContactManager _contactManager;
        private readonly VoipManager _voipManager;

        public MainForm()
        {
            _contactManager = new ContactManager();
            _voipManager = new VoipManager();

            InitializeComponent();
            RetrieveContacts();
            RetrieveUserSettings();
        }

        private void RetrieveContacts()
        {
            List<ContactNumber> contacts =_contactManager.GetAllContacts();
            SetContacts(contacts);
        }

        private void RetrieveUserSettings()
        {
            var settings = UserSettings.Instance;

            providerTextBox.Text = settings.Provider;
            usernameTextBox.Text = settings.Username;
            passwordTextBox.Text = settings.Password;
            callBackTextBox.Text = settings.CallBackNumber;
        }

        private void SetContacts(IEnumerable<ContactNumber> contacts)
        {
            contactsListBox.DataSource = contacts;
            contactsListBox.DisplayMember = "Name";
            contactsListBox.ValueMember = "Number";
        }

        private void searchContactTextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = searchContactTextBox.Text;
            List<ContactNumber> contacts = _contactManager.GetFilteredContacts(filter);
            SetContacts(contacts);
        }

        private void makeCallButton_Click(object sender, EventArgs e)
        {
            var destination = (string) contactsListBox.SelectedValue;

            try
            {
                _voipManager.CallTo(destination);
                ShowNotificationBy(CallResult.Success, destination);
            }
            catch (VoipException ex)
            {
                ShowNotificationBy(CallResult.Failure, ex.Message);
            }
        }

        private void ShowNotificationBy(string callResult, string details)
        {
            string caption = null;
            string text = null;

            switch (callResult)
            {
                case CallResult.Success:
                    caption = "Bellen naar " + details;
                    text = "Uw telefoon zal zo rinkelen.";
                    break;
                case CallResult.Failure:
                    caption = "Oproep gefaald";
                    text = details;
                    break;
            }

            ShowNotification(caption, text);
        }

        private void ShowNotification(string caption, string text)
        {
            callNotification.Caption = caption;
            callNotification.Text = text;
            callNotification.Visible = true;
        }

        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            var settings = UserSettings.Instance;

            settings.Provider = providerTextBox.Text;
            settings.Username = usernameTextBox.Text;
            settings.Password = passwordTextBox.Text;
            settings.CallBackNumber = callBackTextBox.Text;
        }
    }
}