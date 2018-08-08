using System;
using System.Data.OleDb;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace Electricity_Management_System
{
    public static class OleDb_Tools
    {

        static readonly String conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=elect_db.accdb;";
        static OleDbConnection theCon = new OleDbConnection(conString);
        static OleDbCommand theCmd = new OleDbCommand();
        static OleDbDataAdapter da = new OleDbDataAdapter();
        static DataTable dt = new DataTable();
        static DataTable theDataTable = new DataTable();

        public static String loggedUserName;
        public static int loggedUserId;
        public static int customerId;
        public static String loggedUserType;
        public static DateTime theDate = DateTime.Today;

        public static void OpenConnection()
        {
            theCon.Open();
        }
        public static void ExecuteQuery(String theQuery)
        {
            theCmd.CommandText = theQuery;
            theCmd.Connection = theCon;
            theCmd.ExecuteNonQuery();
        }

        public static int GenID(String theTable, String theColumn)
        {
            theDataTable = ReadQueryOut("SELECT MAX(" + theColumn + ") FROM " + theTable);
            if (!(theDataTable.Rows[0].ItemArray[0].GetType().ToString().ToLower().Equals("system.dbnull")))
            {
                return (int)theDataTable.Rows[0].ItemArray[0] + 1;
            }
            else
            {
                return 1;
            }
        }

        public static DataTable ReadQueryOut(String theQuery)
        {
            dt.Reset();
            theCmd.CommandText = theQuery;
            theCmd.Connection = theCon;
            da.SelectCommand = theCmd;
            da.Fill(dt);
            da.Dispose();
            return dt;
        }

        public static void FillDGV(DataGridView theDGV, String theQuery)
        {
            theDataTable.Reset();
            theDataTable = ReadQueryOut(theQuery).Copy();
            theDGV.DataSource = theDataTable;
        }

        public static void FillData(DataGridView theDGV)
        {
            theDataTable.Reset();
            theDataTable = ReadQueryOut("SELECT c.CId, CName, CPhone, ConnectedYN FROM Customers AS c, Connects AS Con WHERE c.CId = Con.CId AND c.EmpId = " + loggedUserId + " AND ConnDate = #" + theDate.ToString("yyyy/MM/dd") + "# ORDER BY c.CId").Copy();
            theDGV.DataSource = theDataTable;
        }

        public static void FillData(DataGridView theDGV, String theQuery)
        {
            theDataTable.Reset();
            theDataTable = ReadQueryOut(theQuery).Copy();
            theDGV.DataSource = theDataTable;
        }

        public static Boolean Exists(String theObject, String theColumn, String theTable)
        {
            DataTable dtt = new DataTable();
            try
            {
                dtt = OleDb_Tools.ReadQueryOut("SELECT " + theColumn + " FROM " + theTable + " WHERE " + theColumn + " = '" + theObject + "'").Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return false;
            }
            if (dtt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void FillCBox(ComboBox theCBox, String theQuery, String valueMember, String displayMember)
        {
            DataTable cBoxDataTable = new DataTable();
            theCBox.Text = "";
            cBoxDataTable = ReadQueryOut(theQuery).Copy();
            theCBox.DataSource = cBoxDataTable;
            theCBox.ValueMember = valueMember;
            theCBox.DisplayMember = displayMember;
        }
    }
}
