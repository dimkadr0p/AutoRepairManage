using System.Configuration;

namespace AdminAPP
{
    class AppSettings
    {
        private static AppSettings _instance = new AppSettings();
        private Configuration _configuration;
        public static AppSettings Instance
        {
            get
            {
                return _instance;
            }
        }

        private AppSettings()
        {
            _configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            setConnectionString(1, this.getConnectionString(1).Replace("{0}", System.Net.Dns.GetHostName()));
        }

        public string getConnectionString(int key)
        {
            return _configuration.ConnectionStrings.ConnectionStrings[key].ConnectionString;
        }

        public string setConnectionString(int key, string value)
        {
            _configuration.ConnectionStrings.ConnectionStrings[key].ConnectionString = value;
            _configuration.ConnectionStrings.ConnectionStrings[key].ProviderName = "System.Data.SqlClient";
            _configuration.ConnectionStrings.ConnectionStrings[key].Name = "AdminAPP.Properties.Settings.AutoRepairShopConnectionString";
            _configuration.Save(ConfigurationSaveMode.Modified);
            return getConnectionString(key);
        }
    }
}
