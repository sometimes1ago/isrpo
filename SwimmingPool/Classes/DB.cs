using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SwimmingPool
{
    class DB
    {
        private readonly static string ConnStr = @"Data Source = DESKTOP-Q8AEUVR\SQLEXPRESS; Initial Catalog = SwimmingPool; Integrated Security = true";
        private static SqlDataAdapter adapter;
        private static SqlCommand comnd;
        public static DataSet ds;

        public static object Select(string Query, List<string> Params = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(Query))
                {
                    using (SqlConnection sqlconn = new SqlConnection(ConnStr))
                    {
                        sqlconn.Open();
                        adapter = new SqlDataAdapter(Query, ConnStr);
                        comnd = new SqlCommand(Query, sqlconn);
                        ds = new DataSet();

                        if (Params != null)
                        {
                            for (int i = 0; i < Params.Count; i++)
                            {
                                comnd.Parameters.AddWithValue($@"@{i}", Params[i]);
                            }

                            adapter.SelectCommand = comnd;
                            adapter.SelectCommand.ExecuteNonQuery();
                        }

                        adapter.SelectCommand = comnd;
                        adapter.SelectCommand.ExecuteNonQuery();
                        adapter.Fill(ds);
                        sqlconn.Close();
                        return ds.Tables[0];
                    }
                }
                else
                {
                    throw new ArgumentNullException(Query, "Query string cannot be empty!");
                }
            }
            catch (Exception ex)
            {
                return ex;
            }
        }
    }
}
