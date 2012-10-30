using System;
using Microsoft.Win32;

namespace Puffy.Voip
{
    public class UserSettings
    {
        private string _provider;
        private string _username;
        private string _password;
        private string _callBackNumber;

        private const string _providerKey = "Provider";
        private const string _usernameKey = "Username";
        private const string _passwordKey = "Password";
        private const string _callBackNumberKey = "CallBackNumber";

        private const string _keyName = @"HKEY_CURRENT_USER\Software\PuffyVoip\";
        
        private static readonly UserSettings _instance = new UserSettings();

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

        private UserSettings()
        {
            _provider = GetSetting(_providerKey);
            _username = GetSetting(_usernameKey);
            _password = GetSetting(_passwordKey);
            _callBackNumber = GetSetting(_callBackNumberKey);
        }

        private string GetSetting(string valueName)
        {
            return (string) Registry.GetValue(_keyName, valueName, null); 
        }

        private void SetSetting(string valueName, string value)
        {
            Registry.SetValue(_keyName, valueName, value);
        }
    }
}
