using MySql.Data.MySqlClient;
using System;

namespace P10_7142200062
{
    internal class MySqlCommand
    {
        private string query;
        private MySqlConnection kon;

        public MySqlCommand(string query, MySqlConnection kon)
        {
            this.query = query;
            this.kon = kon;
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}