using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class AccessRole : AccessRoleProvider
    {

///////AccessRole درج رکورد جدید در جدول 

      public override Int32 InsertAccessRole(AccessRoleDetail accessrole)
      {
            using (SqlCommand command = new SqlCommand("AccessRole_Insert", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@AccessKey", SqlDbType.NVarChar).Value = accessrole.AccessKey;
				 command.Parameters.Add("@AccessCaption", SqlDbType.NVarChar).Value = accessrole.AccessCaption;

                 Int32 result = (Int32)DBHelper.DbHelper.ExecuteScalar(command);
                 return result;
            }
      }

///////AccessRole به روز رسانی یک رکورد در جدول 

      public override Int32 UpdateAccessRole(AccessRoleDetail accessrole)
      {
            using (SqlCommand command = new SqlCommand("AccessRole_Update", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@AccessRoleID", SqlDbType.Int).Value = accessrole.AccessRoleID;
				 command.Parameters.Add("@AccessKey", SqlDbType.NVarChar).Value = accessrole.AccessKey;
				 command.Parameters.Add("@AccessCaption", SqlDbType.NVarChar).Value = accessrole.AccessCaption;

                 Int32 result = DBHelper.DbHelper.Execute(command);
                 return result;
            }
      }

///////AccessRole حذف رکورد از جدول 

      public override Int32 DeleteAccessRole(Int32 accessroleid)
      {
            using (SqlCommand command = new SqlCommand("AccessRole_DeleteRow", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

				 command.Parameters.Add("@AccessRoleID", SqlDbType.Int).Value = accessroleid;

                 Int32 result = DBHelper.DbHelper.Execute(command);
                 return result;
            }
      }

///////AccessRole جستجو رکورد از جدول 

      public override List<AccessRoleDetail> Search(string filter)
      {
	            using (SqlCommand command = new SqlCommand("AccessRole_Search", DBHelper.DbHelper.Connection))
	            {
					 command.CommandType = CommandType.StoredProcedure;

					 command.Parameters.Add("@FilterString", SqlDbType.NVarChar).Value = filter;

	                 return GetAccessRoleCollectionFromReader(DBHelper.DbHelper.ExecuteReader(command));
	            }
      }

///////AccessRole بدست آوردن بیشترین مقدار فیلد کلید از جدول

      public override Int32 AccessRole_GetMaxId()
      {
            using (SqlCommand command = new SqlCommand("AccessRole_GetMaxId", DBHelper.DbHelper.Connection))
            {
				 command.CommandType = CommandType.StoredProcedure;

                 Object result = DBHelper.DbHelper.ExecuteScalar(command);
                 return (Int32)result;
            }
      }

///////AccessRole انتخاب همه رکوردهای جدول 

      public override List<AccessRoleDetail> GetAllAccessRole()
      {
            try
            {
	            using (SqlCommand command = new SqlCommand("AccessRole_GetAll", DBHelper.DbHelper.Connection))
	            {
					 command.CommandType = CommandType.StoredProcedure;

	                 return GetAccessRoleCollectionFromReader(DBHelper.DbHelper.ExecuteReader(command));
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

///////AccessRole انتخاب یک رکورد براساس شناسه از جدول 

      public override AccessRoleDetail GetAccessRoleById(Int32  accessroleid)
      {
	            using (SqlCommand command = new SqlCommand("AccessRole_GetById", DBHelper.DbHelper.Connection))
	            {
					 AccessRoleDetail accessroleDetail = null;
					 command.CommandType = CommandType.StoredProcedure;

					 command.Parameters.Add("@AccessRoleID", SqlDbType.Int).Value = accessroleid;

	                 SqlDataReader reader = DBHelper.DbHelper.ExecuteReader(command);
	                 if (reader.Read())
	                 accessroleDetail =  GetAccessRoleFromReader(reader);
	                 reader.Close();
	                 return accessroleDetail;
	            }
      }

    }
}
