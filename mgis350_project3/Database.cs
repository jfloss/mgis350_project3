using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc; // Database Libraries
using System.Diagnostics; // Debugging Libraries

namespace mgis350_project3
{
    class Database
    {
        OdbcConnection dbConn;
        OdbcCommand dbCmd;
        OdbcDataReader dbReader;
        public Database()
        {
            dbConn = new OdbcConnection("Driver={SQL Server};"
            + "Server=scb­sv­mgis­4.main.ad.rit.edu\\mgismssql;"
            + "DataBase=MGIS350_2181_Group7;"
            + "Uid=Group7;"
            + "Pwd=qzmvarfg$$6278OXRT");
        }

        private void ExecuteQuery(string Query)
        {
            try
            {
                Debug.WriteLine("");
                Debug.WriteLine("SQL Query: " + Query);
                Debug.WriteLine("");
                // Building command to database and executing the query string
                dbCmd = new OdbcCommand(Query, dbConn);
                // Opening the connection
                dbConn.Open();
                // Executing the query and closing the connection
                dbReader = dbCmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                // Determine if database is open. If so close it.
                if (dbConn.State.ToString() == "Open")
                {
                    this.CloseDatabase();
                }
                // Display Error
                System.Windows.Forms.MessageBox.Show("Error:\n\n" +
                ex.ToString() + "\n");
            }
        }

        private void CloseDatabase()
        {
            // Determine if database is open. If so close it.
            if (dbConn.State.ToString() == "Open")
            {
                // Closing connection
                dbConn.Close();
            }
        }

        public bool CheckInv()
        {

            return false;
        }

        public void UpdateInv(string ingredient, decimal amt)
        {
            string query = "UPDATE p3Inventory SET " + ingredient + " = " +
                amt + ";";

            ExecuteQuery(query);
            CloseDatabase();
        }

        public void UpdateExpenses(decimal amt)
        {
            string query = "UPDATE p3Profits SET expenses = " + amt + ";";
            ExecuteQuery(query);
            CloseDatabase();
        }

        public void UpdateSales(decimal amt)
        {
            string query = "UPDATE p3Profits SET sales = " + amt + ";";
            ExecuteQuery(query);
            CloseDatabase();
        }
    }
}
