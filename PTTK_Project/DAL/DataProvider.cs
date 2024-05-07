using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DAL
{
    public class DataProvider
    {
        private static string connection_string="Data Source=LAPTOP-TAKTPLNA;Initial Catalog=QUANLY_HOSO_UNGTUYEN;Integrated Security=True";
        private SqlConnection conn = new SqlConnection(connection_string);


        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {   
                    instance = new DataProvider();
                }

                return instance;
            }
            set { instance = value; }
        }

        public void OpenConnect()
        {
            conn.Open();
        }

        public void CloseConnect()
        {
            conn.Close();
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            SqlCommand cmd = new SqlCommand(query, conn);


            OpenConnect();

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);

            CloseConnect();
            

            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            int rows;
            SqlCommand cmd = new SqlCommand(query, conn);

            OpenConnect();
            rows = cmd.ExecuteNonQuery();
            CloseConnect();

            return rows;
        }

        //Procedure tra ve kieu int
        public int ExecuteStoreProcedure(string query, object[] parameters = null)
        {
            object result;
            SqlCommand cmd = new SqlCommand(query, conn);

            if(parameters != null)
            {
                string[] listParams = query.Split(' ');
                int paramIndex = 0;

                foreach(string item in listParams)
                {
                    if (item.Contains('@'))
                    {
                        cmd.Parameters.AddWithValue(item, parameters[paramIndex]);
                        paramIndex++;
                    }
                }

            }

            OpenConnect();
            result = cmd.ExecuteScalar();
            CloseConnect();

            return Convert.ToInt32(result);
        } 
    }
}
