using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class User : UserProvider
    {

///////User درج رکورد جدید در جدول 

      public override Int32 InsertUser(UserDetail user)
      {
            using (SqlCommand command = new SqlCommand("User_Insert", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user.Username;
				 command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
				 command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
				 command.Parameters.Add("@Family", SqlDbType.NVarChar).Value = user.Family;
				 command.Parameters.Add("@LastLogin", SqlDbType.DateTime).Value = user.LastLogin;

                 Int32 result = (Int32)DBHelper.DbHelper.ExecuteScalar(command);
                 return result;
            }
      }

///////User به روز رسانی یک رکورد در جدول 

      public override Int32 UpdateUser(UserDetail user)
      {
            using (SqlCommand command = new SqlCommand("User_Update", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@UserID", SqlDbType.Int).Value = user.UserID;
				 command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = user.Username;
				 command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = user.Password;
				 command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = user.Name;
				 command.Parameters.Add("@Family", SqlDbType.NVarChar).Value = user.Family;
				 command.Parameters.Add("@LastLogin", SqlDbType.DateTime).Value = user.LastLogin;

                 Int32 result = DBHelper.DbHelper.Execute(command);
                 return result;
            }
      }

///////User حذف رکورد از جدول 

      public override Int32 DeleteUser(Int32 userid)
      {
            using (SqlCommand command = new SqlCommand("User_DeleteRow", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@UserID", SqlDbType.Int).Value = userid;

                 Int32 result = DBHelper.DbHelper.Execute(command);
                 return result;
            }
      }

///////User جستجو رکورد از جدول 

      public override List<UserDetail> Search(string filter)
      {
	            using (SqlCommand command = new SqlCommand("User_Search", DBHelper.DbHelper.Connection))
	            {
					 command.CommandType = CommandType.StoredProcedure;

					 command.Parameters.Add("@FilterString", SqlDbType.NVarChar).Value = filter;

	                 return GetUserCollectionFromReader(DBHelper.DbHelper.ExecuteReader(command));
	            }
      }

///////User بدست آوردن بیشترین مقدار فیلد کلید از جدول

      public override Int32 User_GetMaxId()
      {
            using (SqlCommand command = new SqlCommand("User_GetMaxId", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

                 Object result = DBHelper.DbHelper.ExecuteScalar(command);
                 return (Int32)result;
            }
      }

///////User انتخاب همه رکوردهای جدول 

      public override List<UserDetail> GetAllUser()
      {
            try
            {
	            using (SqlCommand command = new SqlCommand("User_GetAll", DBHelper.DbHelper.Connection))
	            {
					 command.CommandType = CommandType.StoredProcedure;

	                 return GetUserCollectionFromReader(DBHelper.DbHelper.ExecuteReader(command));
	            }
            }
            catch (Exception ex)
            {
	            throw new Exception(ex.Message);
            }
            finally
            {
	            DBHelper.DbHelper.CloseConnection();
            }
      }

///////User انتخاب یک رکورد براساس شناسه از جدول 

      public override UserDetail GetUserById(Int32  userid)
      {
	            using (SqlCommand command = new SqlCommand("User_GetById", DBHelper.DbHelper.Connection))
	            {
					 UserDetail userDetail = null;
					 command.CommandType = CommandType.StoredProcedure;

					 command.Parameters.Add("@UserID", SqlDbType.Int).Value = userid;

	                 SqlDataReader reader = DBHelper.DbHelper.ExecuteReader(command);
	                 if (reader.Read())
	                 userDetail =  GetUserFromReader(reader);
	                 reader.Close();
	                 return userDetail;
	            }
      }

    }
}
