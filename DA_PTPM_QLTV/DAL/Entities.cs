using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Serializable]
    public partial class Entities
    {
        private Entities(DbConnection connectionString, bool contextOwnsConnection = true)
            : base(connectionString, contextOwnsConnection) { }
        public static Entities CreateEntities(bool contextOwnsConnection = true)
        {
            // Đọc file connectdb.dba
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Open("connect-db.dba", FileMode.Open, FileAccess.Read);
            Connect conn = (Connect)bf.Deserialize(fs);

            // Decrypt
            string serverName = Encryptor.Decrypt(conn.ServerName, "qwertyuiop", true);
            string userName = Encryptor.Decrypt(conn.UserName, "qwertyuiop", true);
            string password = Encryptor.Decrypt(conn.Password, "qwertyuiop", true);
            string database = Encryptor.Decrypt(conn.Database, "qwertyuiop", true);

            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            SqlConnectionStringBuilder sqlConnectBuiler = new SqlConnectionStringBuilder();
            sqlConnectBuiler.DataSource = serverName;
            sqlConnectBuiler.InitialCatalog = database;
            sqlConnectBuiler.UserID = userName;
            sqlConnectBuiler.Password = password;

            string sqlConnectionString = sqlConnectBuiler.ConnectionString;

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.Provider = "System.Data.SqlClient";
            entityBuilder.ProviderConnectionString = sqlConnectionString;

            entityBuilder.Metadata = @"res://*/DA_PTPM_QLTV.csdl|res://*/DA_PTPM_QLTV.ssdl|res://*/DA_PTPM_QLTV.msl";

            EntityConnection connection = new EntityConnection(entityBuilder.ConnectionString);

            fs.Close();
            return new Entities(connection);
        }

        public static bool TestConnectionEF()
        {
            using (Entities db = Entities.CreateEntities())
            {
                try
                {
                    return db.Database.Connection.Database.Equals("DB_PTPM_QLTV") ? true : false;
                }
                catch (Exception)
                {
                    return false;
                    // throw;
                }
            }
        }
    }
}
