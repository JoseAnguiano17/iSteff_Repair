using iS_Repair.Clases.Utils;
using System;

namespace iS_Repair.Clases.DataBase
{
    [Serializable]
    public class DataHost : IEquatable<DataHost>
    {
        private string _strServer;

        public string Server {
            get { return _strServer; }
            set {
                if (value == "")
                    throw new Exception("The server is required.");
                else
                    _strServer = value; }
        }

        private string _strDatabase;

        public string Database {
            get { return _strDatabase; }
            set {
                if (value == "")
                    throw new Exception("Specify the database.");
                else
                    _strDatabase = value; }
        }

        private string _strUID;

        public string UID {
            get { return _strUID; }
            set {
                if (value == "")
                    throw new Exception("Indicate which user signs in.");
                else
                    _strUID = value; }
        }

        private string _strPassword;

        public string Password {
            set {
                if (value == "")
                    throw new Exception("The password field is empty.");
                else
                    _strPassword = TextManager.Encriptar(value); }
        }

        public DataHost(string strServer, string strDatabase, string strUID, string strPassword)
        {
            Server = strServer;
            Database = strDatabase;
            UID = strUID;
            Password = strPassword;
        }

        public DB getDataBase()
        {
            return new DB(this,TextManager.DesEncriptar(_strPassword));
        }

        public bool Equals(DataHost other)
        {
            return Database.Equals(other.Database) && Server.Equals(other.Server);
        }
    }
}
