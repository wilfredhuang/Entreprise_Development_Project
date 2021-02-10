﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBService.Entity
{
    public class Caregiver
    {
        public string Id { get; set; }

        public string Carereceiver_id { get; set; }

        public int Certified_cg { get; set; }
        
        public Caregiver()
        {

        }

        public Caregiver(string id, string carereceiver_id, int certified_cg)
        {
            Id = id;
            Carereceiver_id = carereceiver_id;
            Certified_cg = certified_cg;
        }

        public Caregiver SelectById(string id)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["EDP_DB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from [Caregiver] WHERE Id = @paraId";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraId", id);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet.
            Caregiver caregiver = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                string ID = row["Id"].ToString();
                string carereceiver_id = row["carereceiver_id"].ToString();
                int certified_cg = Convert.ToInt32(row["certified_cg"]);

                caregiver = new Caregiver(ID, carereceiver_id, certified_cg);
            }
            return caregiver;
        }
    }
}