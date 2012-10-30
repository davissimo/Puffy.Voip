using System;
using Microsoft.Win32;

namespace Puffy.Voip
{
    public class UserSettings
    {
        private static readonly UserSettings _instance = new UserSettings();

        private UserSettings()
        {
            _provider = GetSetting(_providerKey);
            _username = GetSetting(_usernameKey);
            _password = GetSetting(_passwordKey);
            _callBackNumber = GetSetting(_callBackNumberKey);
        }

        private string _provider;
        private string _username;
        private string _password;
        private string _callBackNumber;

        private const string _providerKey = "Provider";
        private const string _usernameKey = "Username";
        private const string _passwordKey = "Password";
        private const string _callBackNumberKey = "CallBackNumber";

        private const string _rootKey = @"HKEY_CURRENT_USER\Software\PuffyVoip\";

        public string Provider
        {
            get { return _provider; }
            set
            {
                _provider = value;
                SetSetting(_providerKey, value);
            }
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                SetSetting(_usernameKey, value);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                SetSetting(_passwordKey, value);
            }
        }

        public string CallBackNumber
        {
            get { return _callBackNumber; }
            set
            {
                _callBackNumber = value;
                SetSetting(_callBackNumberKey, value);
            }
        }

        public static UserSettings Instance
        {
            get
            {
                return _instance;
            }
        }

        private string GetSetting(string valueKey)
        {
            return (string) Registry.GetValue(_rootKey, valueKey, null); 
        }

        private void SetSetting(string valueKey, string value)
        {
            Registry.SetValue(_rootKey, valueKey, value);
        }
    }
}