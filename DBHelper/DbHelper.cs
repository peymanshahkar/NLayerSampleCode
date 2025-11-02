using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Reflection;

namespace DBHelper
{
    public class DbHelper
    {
        private static bool transactionInRun = false;
        private static string _ConStr;

        public static string ConStr
        {
            get { return DbHelper._ConStr; }
            set
            {
                DbHelper._ConStr = value;
                sqlCon = new SqlConnection(_ConStr);
            }
        }

        public static SqlConnection Connection
        {
            get
            {
                return sqlCon;
            }
        }


        private static SqlConnection sqlCon;
        public static bool OpenConnection()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {

                sqlCon.Open();
                return true;
            }
            return false;
        }
        public static bool CloseConnection()
        {
            if (sqlCon.State == ConnectionState.Open && transactionInRun == false)
            {
                sqlCon.Close();
                return true;
            }
            return false;
        }
        private static SqlTransaction Transaction = null;
        public static bool BeginTransaction()
        {
            OpenConnection();
            if (Transaction == null)
            {

                Transaction = sqlCon.BeginTransaction();
                transactionInRun = true;
                return true;
            }
            //else
            //{
            //    throw new Exception("یک تراکنش در  حال اجرا هم اکنون وجود دارد نمی توان تراکنش جدیدی اجرا کرد");
            //}

            return false;
        }

        public static void RollBackTransaction()
        {
            if (Transaction != null)
            {
                Transaction.Rollback();
                Transaction = null;

                transactionInRun = false;

                CloseConnection();
            }
        }

        public static void CommitTransaction()
        {
            if (Transaction != null)
            {
                Transaction.Commit();
                Transaction = null;

                transactionInRun = false;
                CloseConnection();
            }
        }

        public static void Execute(string sqlQuery)
        {
            bool CanCloseConnection = false;
            try
            {

                SqlCommand sqlcommand = new SqlCommand(sqlQuery.ToEnglishNumbers(), sqlCon);
                if (Transaction != null)
                    sqlcommand.Transaction = Transaction;

                CanCloseConnection = OpenConnection();
                sqlcommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("بروز خطا در اجرای دستورالعمل در دیتابیس" + '\n' + ex.Message);
            }
            finally
            {
                if (CanCloseConnection)
                    CanCloseConnection = CloseConnection();
            }

        }


        public static int Execute(SqlCommand sqlcommand)
        {
            bool CanCloseConnection = false;
            int result;
            try
            {

                //SqlCommand sqlcommand = new SqlCommand(sqlQuery, sqlCon);
                if (Transaction != null)
                    sqlcommand.Transaction = Transaction;

                CanCloseConnection = OpenConnection();
                result = sqlcommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("بروز خطا در اجرای دستورالعمل در دیتابیس" + '\n' + ex.Message);
            }
            finally
            {
                if (CanCloseConnection)
                    CanCloseConnection = CloseConnection();
            }
            return result;
        }

        public static object ExecuteScalar(string sqlQuery)
        {
            object Result = null;
            bool CanCloseConnection = false;
            try
            {

                SqlCommand sqlcommand = new SqlCommand(sqlQuery.ToEnglishNumbers(), sqlCon);
                if (Transaction != null)
                    sqlcommand.Transaction = Transaction;

                CanCloseConnection = OpenConnection();
                Result = sqlcommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("بروز خطا در اجرای دستورالعمل در دیتابیس" + '\n' + ex.Message);
            }
            finally
            {
                if (CanCloseConnection)
                    CanCloseConnection = CloseConnection();

            }
            return Result;
        }
        public static object ExecuteScalar(SqlCommand sqlcommand)
        {
            object Result = null;
            bool CanCloseConnection = false;
            try
            {

                // sqlcommand //= new SqlCommand(sqlQuery, sqlCon);
                if (Transaction != null)
                    sqlcommand.Transaction = Transaction;

                CanCloseConnection = OpenConnection();
                Result = sqlcommand.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("بروز خطا در اجرای دستورالعمل در دیتابیس" + '\n' + ex.Message);
            }
            finally
            {
                if (CanCloseConnection)
                    CanCloseConnection = CloseConnection();

            }
            return Result;
        }
        public static SqlDataReader ExecuteReader(string sqlQuery)
        {
            SqlDataReader reader = null;
            bool CanCloseConnection = false;
            try
            {

                SqlCommand sqlcommand = new SqlCommand(sqlQuery.ToEnglishNumbers(), sqlCon);
                if (Transaction != null)
                    sqlcommand.Transaction = Transaction;

                CanCloseConnection = OpenConnection();
                reader = sqlcommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("بروز خطا در اجرای دستورالعمل در دیتابیس" + '\n' + ex.Message);
            }
            finally
            {
                if (CanCloseConnection)
                    CanCloseConnection = CloseConnection();
            }

            return reader;
        }

        public static SqlDataReader ExecuteReader(SqlCommand sqlcommand)
        {
            SqlDataReader reader = null;
            bool CanCloseConnection = false;
            try
            {

                //   SqlCommand sqlcommand = new SqlCommand(sqlQuery, sqlCon);
                if (Transaction != null)
                    sqlcommand.Transaction = Transaction;

                CanCloseConnection = OpenConnection();
                reader = sqlcommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw new Exception("بروز خطا در اجرای دستورالعمل در دیتابیس" + '\n' + ex.Message);
            }
            finally
            {
                if (CanCloseConnection)
                    CanCloseConnection = CloseConnection();
            }

            return reader;
        }


        public static DataTable ReadDataTable(string SQLCommand)
        {
            SqlCommand command = new SqlCommand(SQLCommand.ToEnglishNumbers());
            return ReadDataTable(command);
        }
        public static DataTable ReadDataTable(SqlCommand command)
        {
            bool CanCloseConnection = false;
            DataTable datatable = new DataTable();
            try
            {
                command.Connection = new SqlConnection(ConStr);
                if (Transaction != null)
                    command.Transaction = Transaction;

                //  CanCloseConnection = OpenConnection();


                SqlDataAdapter Adapter = new SqlDataAdapter();
                Adapter.SelectCommand = command;
                Adapter.SelectCommand.Transaction = Transaction;
                //Adapter.SelectCommand.CommandTimeout = 0;
                Adapter.Fill(datatable);



            }
            catch (Exception ex)
            {

                throw new Exception("بروز خطا در اجرای دستورالعمل در دیتابیس" + '\n' + ex.Message);

            }
            finally
            {
                if (CanCloseConnection) CloseConnection();
            }

            return datatable;
        }




    }
}
