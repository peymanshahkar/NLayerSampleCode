using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UserAccessRole : UserAccessRoleProvider
    {

///////UserAccessRole درج رکورد جدید در جدول 

      public override Int32 InsertUserAccessRole(UserAccessRoleDetail useraccessrole)
      {
            using (SqlCommand command = new SqlCommand("UserAccessRole_Insert", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@UserID", SqlDbType.Int).Value = useraccessrole.UserID;
				 command.Parameters.Add("@AccessRoleID", SqlDbType.Int).Value = useraccessrole.AccessRoleID;
				 command.Parameters.Add("@IsAccess", SqlDbType.Bit).Value = useraccessrole.IsAccess;

                 Int32 result = (Int32)DBHelper.DbHelper.ExecuteScalar(command);
                 return result;
            }
      }

///////UserAccessRole به روز رسانی یک رکورد در جدول 

      public override Int32 UpdateUserAccessRole(UserAccessRoleDetail useraccessrole)
      {
            using (SqlCommand command = new SqlCommand("UserAccessRole_Update", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@UserAccessRoleID", SqlDbType.Int).Value = useraccessrole.UserAccessRoleID;
				 command.Parameters.Add("@UserID", SqlDbType.Int).Value = useraccessrole.UserID;
				 command.Parameters.Add("@AccessRoleID", SqlDbType.Int).Value = useraccessrole.AccessRoleID;
				 command.Parameters.Add("@IsAccess", SqlDbType.Bit).Value = useraccessrole.IsAccess;

                 Int32 result = DBHelper.DbHelper.Execute(command);
                 return result;
            }
      }

///////UserAccessRole حذف رکورد از جدول 

      public override Int32 DeleteUserAccessRole(Int32 useraccessroleid)
      {
            using (SqlCommand command = new SqlCommand("UserAccessRole_DeleteRow", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@UserAccessRoleID", SqlDbType.Int).Value = useraccessroleid;

                 Int32 result = DBHelper.DbHelper.Execute(command);
                 return result;
            }
      }

///////UserAccessRole جستجو رکورد از جدول 

      public override List<UserAccessRoleDetail> Search(string filter)
      {
	            using (SqlCommand command = new SqlCommand("UserAccessRole_Search", DBHelper.DbHelper.Connection))
	            {
					 command.CommandType = CommandType.StoredProcedure;

					 command.Parameters.Add("@FilterString", SqlDbType.NVarChar).Value = filter;

	                 return GetUserAccessRoleCollectionFromReader(DBHelper.DbHelper.ExecuteReader(command));
	            }
      }

///////UserAccessRole بدست آوردن بیشترین مقدار فیلد کلید از جدول

      public override Int32 UserAccessRole_GetMaxId()
      {
            using (SqlCommand command = new SqlCommand("UserAccessRole_GetMaxId", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

                 Object result = DBHelper.DbHelper.ExecuteScalar(command);
                 return (Int32)result;
            }
      }

///////UserAccessRole انتخاب همه رکوردهای جدول 

      public override List<UserAccessRoleDetail> GetAllUserAccessRole()
      {
            try
            {
	            using (SqlCommand command = new SqlCommand("UserAccessRole_GetAll", DBHelper.DbHelper.Connection))
	            {
					 command.CommandType = CommandType.StoredProcedure;

	                 return GetUserAccessRoleCollectionFromReader(DBHelper.DbHelper.ExecuteReader(command));
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

///////UserAccessRole انتخاب یک رکورد براساس شناسه از جدول 

      public override UserAccessRoleDetail GetUserAccessRoleById(Int32  useraccessroleid)
      {
	            using (SqlCommand command = new SqlCommand("UserAccessRole_GetById", DBHelper.DbHelper.Connection))
	            {
					 UserAccessRoleDetail useraccessroleDetail = null;
					 command.CommandType = CommandType.StoredProcedure;

					 command.Parameters.Add("@UserAccessRoleID", SqlDbType.Int).Value = useraccessroleid;

	                 SqlDataReader reader = DBHelper.DbHelper.ExecuteReader(command);
	                 if (reader.Read())
	                 useraccessroleDetail =  GetUserAccessRoleFromReader(reader);
	                 reader.Close();
	                 return useraccessroleDetail;
	            }
      }

    }
}
