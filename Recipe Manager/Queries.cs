
using System.Data;


using Microsoft.Data.SqlClient;

class Queries
{
    private string connString;

    public Queries(string server, string database)
    {
        connString = $"Data Source={server};Initial Catalog={database};Integrated Security=True;Trust Server Certificate=True";
    }

    public DataTable ExecuteQuery(string query)
    {
        try
        {
            using var conn = new SqlConnection(connString);
            conn.Open();
            var cmd = new SqlCommand(query, conn);
            var reader = cmd.ExecuteReader();
            var table = new DataTable();
            table.Load(reader);
            conn.Close();
            return table;
        } catch (SqlException ex)
        {
            throw ex;
        }
    }

    public void ExecuteNonQuery(string query) 
    {
        try
        {
            using var conn = new SqlConnection(connString);
            conn.Open();
            var cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (SqlException ex)
        {
            throw ex;
        }
    
    }


}
