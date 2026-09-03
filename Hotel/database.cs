using System;
using System.Data;
using System.Data.SqlClient;

public class DatabaseConnection
{
    // نص الاتصال الخاص بك
    private static string connectionString = @"Server=THEBest\SQLEXPRESS ; DataBase=hotel ; Integrated Security=true";

    // دالة للحصول على كائن الاتصال جاهزاً
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    // دالة لفتح الاتصال وتأكيده
    public static SqlConnection OpenConnection()
    {
        SqlConnection cn = new SqlConnection(connectionString);
        if (cn.State == ConnectionState.Closed)
        {
            cn.Open();
        }
        return cn;
    }
}