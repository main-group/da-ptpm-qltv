using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Serializable]
    public class Connect
    {
        public string ServerName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Database { get; set; }

        public Connect(string serverName, string userName, string password, string database)
        {
            this.ServerName = serverName;
            this.UserName = userName;
            this.Password = password;
            this.Database = database;
        }

        /// <summary>
        /// Lưu file config kết nối cơ sở dữ liệu dba vào thẳng trong Debug folder
        /// Trường hợp nếu file đã tồn tại:
        /// - Xóa file xong tạo file lại
        /// - Trước khi xóa tránh trường hợp "The file is apparently being used by another process" -> dùng Garbage Collection (dòng code 2 và 3)
        /// </summary>
        public void SaveFile()
        {
            if (File.Exists("connect-db.dba"))
            {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers(); 
                File.Delete("connect-db.dba");
            }

            FileStream fs = File.Open("connect-db.dba", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }
    }
}
