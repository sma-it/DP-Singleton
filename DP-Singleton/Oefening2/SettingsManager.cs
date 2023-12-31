﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class SettingsManager
    {
        private Dictionary<string, string> _settings = new Dictionary<string,string>();

        public void SaveSetting(string key, string value)
        {
            _settings.Add(key, value);
        }

        public string? GetSetting(string key)
        {
            if (_settings.ContainsKey(key))
            {
                return _settings[key];
            }

            return null;
        }
    }
}
