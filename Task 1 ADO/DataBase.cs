using DocumentFormat.OpenXml.Office.Word;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Data.SqlClient;

namespace Task_1_ADO;

public static class DataBase
{
    public static List<User> Users { get; set; } = new();
    static SqlConnection connection = null;
    static SqlCommand command = null;
    static SqlDataReader reader = null;
    static string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=DBUsers;Integrated Security=SSPI;";

    public static void WrittentoDB() 
    {
        using (connection=new(connectionString))
        {
            connection.Open();
            foreach (var user in Users)
            {
                command = new SqlCommand($@"INSERT INTO Users(Name,Surname,Age,Login,Password)
                           VALUES('{user.Name}','{user.Surname}','{user.Age}','{user.Login}','{user.Password}')", connection);

            command.ExecuteNonQuery();
            }
        }
    
    }

    public static void ReadToDBuser() 
    {
        using (connection = new(connectionString))
        {
            connection.Open();
            command= new("SELECT * FROM [Users]", connection);
            reader = command.ExecuteReader();
            if (reader == null) return;

            while (reader.Read())
            {
                User user = new User();
                user.Name = reader["Name"].ToString();
                user.Surname = reader["Surname"].ToString();
                user.Age = int.Parse(reader["Age"].ToString());
                user.Login = reader["Login"].ToString();
                user.Password = reader["Password"].ToString();


                Users.Add(user);
            }

        }

    }

    public static bool Checklogpas(string pas,string log) 
    {
        foreach (var user in Users)
        {
            if (log == user.Login && pas == user.Password) return true;
        }
        return false;
    }
}
