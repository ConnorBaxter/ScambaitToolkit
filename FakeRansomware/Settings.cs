using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FakeRansomware
{
    public class Settings
    {
        public Color BackgroundColourPrimary = Color.Black;
        public Color BackgroundColourSecondary = Color.Black;
        public Color BackgroundColourTertiary = Color.DimGray;

        public Color ForegroundColourPrimary = Color.LimeGreen;
        public Color ForegroundColourSecondary = Color.Red;
        public Color ForegroundColourTertiary = Color.Orange;

        public Color CountdownColour = Color.Red;

        public void LoadFromJSON()
        {
            if (File.Exists("settings.json"))
            {
                String settingsStr;
                using (StreamReader sr = new StreamReader("settings.json"))
                {
                    settingsStr = sr.ReadToEnd();
                }

                Settings newSettings = (Settings) JsonConvert.DeserializeObject(settingsStr);
                changeSettings(newSettings);    
            }
        }

        public void changeSettings(Settings newSettings)
        {
            BackgroundColourPrimary = newSettings.BackgroundColourPrimary;
            BackgroundColourSecondary = newSettings.BackgroundColourSecondary;
            BackgroundColourTertiary = newSettings.BackgroundColourTertiary;
            ForegroundColourPrimary = newSettings.ForegroundColourPrimary;
            ForegroundColourSecondary = newSettings.ForegroundColourSecondary;
            ForegroundColourTertiary = newSettings.ForegroundColourTertiary;
            CountdownColour = newSettings.CountdownColour;
        }

        public void debugCreateSettingsFile()
        {
            Settings settings_template = new Settings();
            using (StreamWriter sw = new StreamWriter("settings_template.json"))
            {
                sw.Write(JsonConvert.SerializeObject(settings_template, Formatting.Indented));
            }
        }
    }
}
