using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors.NavigatorButtons;
namespace Salse_System_2
{
    //                        _______________       " THIS IS THE DATABASE CLASS "       _______________
    internal class Data_Base_Class
    {
        //This is the conection
        SqlConnection conn = new SqlConnection(@"Server=PCDEV\MSSQLSERVER01;Database=Salse System_DB;User Id=hazem;Password=hazem;");
        SqlCommand cmd = new SqlCommand();

        //This is the the reading function it bring data for me from the DataBase 
        public DataTable ReedData(string CommandText , string Message)
        {
            DataTable TBL = new DataTable();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = CommandText;
                conn.Open();

                TBL.Load(cmd.ExecuteReader());

                conn.Close();
                if (Message != "")
                {
                    MessageBox.Show(Message,"تأكيد",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }
            return TBL;
        }

        public bool ExecuteData (string CommandText , string Message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = CommandText;
                conn.Open();
                cmd.ExecuteNonQuery();

                conn.Close();
                if (Message != "")
                {
                    MessageBox.Show(Message, "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
            

        }
    }
}
