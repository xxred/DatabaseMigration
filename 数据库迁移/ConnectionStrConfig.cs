using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.Extensions.Configuration;
using XCode.DataAccessLayer;

namespace 数据库迁移
{
    public static class ConnectionStrConfig
    {
        public static void AddConnectionStr()
        {
            var configurationBuilder = new ConfigurationBuilder();
            //configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
            configurationBuilder.AddJsonFile("appsettings.json", 
                optional: false, reloadOnChange: false);

            var configuration = configurationBuilder.Build();

            var connectionStrings = configuration.GetSection("connectionStrings");
            var connections = connectionStrings.GetChildren();
            foreach (var conn in connections)
            {
                var connStr = conn.GetSection("connectionString").Value;
                var provider = conn.GetSection("providerName").Value;
                DAL.AddConnStr(conn.Key, connStr, null, provider);
            }
        }
    }
}
