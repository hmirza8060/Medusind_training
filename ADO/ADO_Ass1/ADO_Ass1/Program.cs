using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_Ass1
{
    internal class Program
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            // CallProcedure();
            DisplayRecords();
            Console.ReadLine();
        }
        static SqlConnection GetConnection()
        {
            conn = new SqlConnection("data source=DESKTOP-DOUQUL8\\SQLEXPRESS;Initial Catalog=Medusind;Integrated Security=true;");
            conn.Open();
            return conn;
        }
        //static void CallProcedure()
        //{
        //    conn=GetConnection();
        //    Console.WriteLine("Insert Employee Details");
        //    Console.Write("Employee Number:");
        //    int empno=int.Parse(Console.ReadLine());
        //    Console.WriteLine("Employee Name");
        //    string empname=Console.ReadLine();
        //    Console.Write("Enter Employee Salary : ");
        //    float empsal = float.Parse(Console.ReadLine());
        //    Console.Write("Enter Employee Type F for Fulltime / P for Parttime: ");
        //    char emptype = char.Parse(Console.ReadLine());
        //    cmd = new SqlCommand("insertEmp", conn);
        //    cmd.CommandType=CommandType.StoredProcedure;
        //    SqlParameter sqleno, sqlename, sqlesal, sqletype;
        //    sqleno = new SqlParameter("@eno", empno);
        //    sqleno.SqlDbType = SqlDbType.Int;
        //    cmd.Parameters.Add(sqleno);
        //    sqlename = new SqlParameter("@ename", empname);
        //    sqlename.SqlDbType = SqlDbType.VarChar;
        //    cmd.Parameters.Add(sqlename);
        //    sqlesal = new SqlParameter("@esal", empsal);
        //    sqlesal.SqlDbType = SqlDbType.Decimal;
        //    cmd.Parameters.Add(sqlesal);
        //    sqletype = new SqlParameter("@etype", emptype);
        //    sqletype.SqlDbType = SqlDbType.Char;
        //    cmd.Parameters.Add(sqletype);
        //    try
        //    {
        //        cmd.ExecuteNonQuery();
        //        Console.WriteLine("Inserted Successfully");
        //    }
        //    catch (SqlException)
        //    {
        //        Console.WriteLine("Unsuccess");
        //    }
        //}
        static void DisplayRecords()
        {
            Console.WriteLine("\nEmployee Information\n");
            try
            {
                conn = GetConnection();
                string query = "Select * from Code_Employee";
                cmd = new SqlCommand(query, conn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["empno"] + "  " + dr["empname"] + "  " + dr["empsal"] + "  " + dr["emptype"]);
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
