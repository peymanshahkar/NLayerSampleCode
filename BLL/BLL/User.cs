using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BLL
{
    public class User : BLL.UserBase
    {

        public User (Int32 userid, string username, string password, string name, string family, DateTime? lastlogin) : base(userid, username, password, name, family, lastlogin)
        {
			//UserID = userid;
			//Username = username;
			//Password = password;
			//Name = name;
			//Family = family;
			//LastLogin = lastlogin;
        }
        public User(Int32 userid, string username,  string name, string family, DateTime? lastlogin) 
        {
            UserID = userid;
            Username = username;
            Name = name;
            Family = family;
            LastLogin = lastlogin;
        }


        public User() : base()
        {
        }

        public static UserS GetUserSById(Int32 Id )
        {
             SqlDataReader reader;
             UserS userS = new UserS();

             bool CanCloseConnection = DBHelper.DbHelper.OpenConnection();
             reader = DBHelper.DbHelper.ExecuteReader("exec User_Search 'UserID="+ Id +"'");
             User user;
             while (reader.Read())
             {
                 user = new User(
                        (Int32)reader["UserID"],
                        reader["Username"].ToString(),
                        reader["Password"].ToString(),
                        reader["Name"].ToString(),
                        reader["Family"].ToString(),
                        reader["LastLogin"] == DBNull.Value ? null : (DateTime?)reader["LastLogin"]);

                userS.AddObject(user);
             }
              reader.Close();
              if (CanCloseConnection)
                  DBHelper.DbHelper.CloseConnection();
              return userS;
        }


        public static UserS GetUserS()
        {
            string selectCommad = @"select 
                UserID,
                UserName,
                [Name],
                [Family],
                [LastLogin]
                From dbo.[User]
                ";
                
            SqlDataReader reader;
            UserS userS = new UserS();

            bool CanCloseConnection = DBHelper.DbHelper.OpenConnection();
            reader = DBHelper.DbHelper.ExecuteReader(selectCommad);
            User user;
            while (reader.Read())
            {
                user = new User(
                       (Int32)reader["UserID"],
                       reader["Username"].ToString(),
                       reader["Name"].ToString(),
                       reader["Family"].ToString(),
                       reader["LastLogin"] == DBNull.Value ? null : (DateTime?)reader["LastLogin"]);

                userS.AddObject(user);
            }
            reader.Close();
            if (CanCloseConnection)
                DBHelper.DbHelper.CloseConnection();
            return userS;
        }

        public void UpdateObject() {throw new NotImplementedException();}

        public bool DeleteObject(){throw new NotImplementedException();}

    }
}
