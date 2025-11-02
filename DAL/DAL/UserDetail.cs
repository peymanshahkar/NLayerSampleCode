using System;
using System.Data;

namespace DAL
{
    public class UserDetail
    {

        public UserDetail(Int32 userid, string username, string password, string name, string family, DateTime? lastlogin)
        {
			UserID = userid;
			Username = username;
			Password = password;
			Name = name;
			Family = family;
			LastLogin = lastlogin;
        }

        public UserDetail(IDataReader reader)
        {
			UserID = (Int32)reader["UserID"];
			Username = (string)reader["Username"];
			Password = (string)reader["Password"];
			Name = (string)reader["Name"];
			Family = (string)reader["Family"];
			if (reader["LastLogin"]!= DBNull.Value)
				LastLogin = (DateTime)reader["LastLogin"];
        }

        public UserDetail()
        {
        }


        public virtual Int32 UserID { get; set; } 

        public virtual string Username { get; set; } 

        public virtual string Password { get; set; } 

        public virtual string Name { get; set; } 

        public virtual string Family { get; set; } 

        public virtual DateTime? LastLogin { get; set; } 

    }
}
