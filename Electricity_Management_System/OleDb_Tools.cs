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

        // Checks if the item exists in the database using a query
        public static bool Exists(string theObj, string theQuery)
        {
            try
            {
                dt = ReadQueryOut(theQuery);
            }
            catch (Exception ex)
            {
                return false;
            }

            int i;
            for (i = 0; i <= dt.Rows.Count - 1; i++)
            {
                if (dt.Rows[i].ItemArray[0].ToString().Equals(theObj.ToString()))
                    return true;
            }
            return false;
        }


        // A Tool to add a building from scratch street and region
        public static int AddBuilding(ComboBox cbox_regions, ComboBox cbox_streets, ComboBox cbox_building)
        {
            // used in the loop
            int i;
            // Conserves Old values
            string theStreet = cbox_streets.Text;
            string theBuilding = cbox_building.Text;
            int theBuildingId = 1;
            // Conserves New Values
            if (cbox_regions.SelectedValue != null)
            {
                if (cbox_streets.SelectedValue != null)
                {
                    if (cbox_building.SelectedValue != null)
                    {
                        theBuildingId = int.Parse(cbox_building.SelectedValue.ToString());
                        goto End_Of_For;
                    }
                }
            }



            // Enters a checking loop that runs 3 times, each time for Region, Street, and Building respectively
            // Each time it checks of the item exists then jump to the next else add the item and continue
            // Until the last ittiration is reached
            for (i = 1; i <= 3; i++)
            {
                if (Exists(cbox_regions.Text, "SELECT region_name FROM region"))
                {
                    if (Exists(cbox_streets.Text, "SELECT street_name FROM street WHERE street_id = " + cbox_streets.SelectedValue + " AND region_id = " + cbox_regions.SelectedValue))
                    {
                        if (Exists(cbox_building.Text, "SELECT building_name FROM building b, street s WHERE b.street_id = " + cbox_streets.SelectedValue + " AND region_id = " + cbox_regions.SelectedValue))
                            goto End_Of_For;
                        else
                        {
                            theBuildingId = GenID("building", "building_id");
                            ExecuteQuery("INSERT INTO building VALUES(" + theBuildingId + ", '" + theBuilding + "', " + cbox_streets.SelectedValue + ")");
                            goto End_Of_For;
                        }
                    }
                    else
                    {
                        string streetId = GenID("street", "street_id").ToString();
                        ExecuteQuery("INSERT INTO street VALUES(" + streetId + ", '" + theStreet + "', " + cbox_regions.SelectedValue + ")");
                        FillCBox(cbox_streets, "SELECT street_id, street_name FROM street WHERE region_id = " + cbox_regions.SelectedValue, "street_id", "street_name");
                        cbox_streets.SelectedValue = streetId;
                    }
                }
                else
                {
                    string regionId = GenID("region", "region_id").ToString();
                    ExecuteQuery("INSERT INTO region VALUES(" + regionId + ", '" + cbox_regions.Text + "')");
                    FillCBox(cbox_regions, "SELECT region_id, region_name FROM region", "region_id", "region_name");
                    cbox_regions.SelectedValue = regionId;
                }
            }

            End_Of_For:
            return theBuildingId;
        }
        // A Tool to add a street from scratch region
        public static int AddStreet(ComboBox cbox_regions, ComboBox cbox_streets)
        {
            // used in the loop
            int i;
            // Conserves Old values
            string theStreet = cbox_streets.Text;
            int theStreetId = 1;
            // Conserves New Values
            if (cbox_regions.SelectedValue != null)
            {
                if (cbox_streets.SelectedValue != null)
                {
                    theStreetId = int.Parse(cbox_streets.SelectedValue.ToString());
                    goto End_Of_For;
                }
            }



            // Enters a checking loop that runs 2 times, each time for Region, and Street respectively
            // Each time it checks of the item exists then jump to the next else add the item and continue
            // Until the last ittiration is reached
            for (i = 1; i <= 2; i++)
            {
                if (Exists(cbox_regions.Text, "SELECT region_name FROM region"))
                {
                    if (Exists(cbox_streets.Text, "SELECT street_name FROM street WHERE street_id = " + cbox_streets.SelectedValue + " AND region_id = " + cbox_regions.SelectedValue))
                    {
                        goto End_Of_For;
                    }
                    else
                    {
                        string streetId = GenID("street", "street_id").ToString();
                        ExecuteQuery("INSERT INTO street VALUES(" + streetId + ", '" + theStreet + "', " + cbox_regions.SelectedValue + ")");
                        FillCBox(cbox_streets, "SELECT street_id, street_name FROM street WHERE region_id = " + cbox_regions.SelectedValue, "street_id", "street_name");
                        cbox_streets.SelectedValue = streetId;
                        theStreetId = int.Parse(streetId);
                    }
                }
                else
                {
                    string regionId = GenID("region", "region_id").ToString();
                    ExecuteQuery("INSERT INTO region VALUES(" + regionId + ", '" + cbox_regions.Text + "')");
                    FillCBox(cbox_regions, "SELECT region_id, region_name FROM region", "region_id", "region_name");
                    cbox_regions.SelectedValue = regionId;
                }
            }

            End_Of_For:
            return theStreetId;
        }
    }
}
