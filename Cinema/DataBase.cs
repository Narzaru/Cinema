using System.Data;
using System.Data.SqlClient;

namespace Cinema {
    public class DataBase {
        public static void TryConnect(string connection_string) {
            m_connection = new SqlConnection(connection_string);
            m_connection.Open();
        }

        public static DataTable GetData(string query) {
            m_command = new SqlCommand(query, m_connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, m_connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public static int SetData(string query) {
            m_command = new SqlCommand(query, m_connection);
            return m_command.ExecuteNonQuery();
        }

        private DataBase() { }

        private static SqlConnection m_connection;
        private static SqlCommand m_command;
    }
}
