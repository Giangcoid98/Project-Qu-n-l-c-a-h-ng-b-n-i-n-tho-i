using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Quan_ly_cua_hang_ban_DT.DAO
{
    
        public class DataProvider
        {
            private static DataProvider instance;//Ctrl + R + E

        public static DataProvider Instance
            {
                get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
                private set { DataProvider.instance = value; }
            }

            private DataProvider() { }

            private string connectionSTR = "Data Source=DESKTOP-S75HL33\\SQLEXPRESS;Initial Catalog=QuanlycuahangbanDT;Integrated Security=True";

            public DataTable ExecuteQuery(string query, object[] parameter = null)//  trả ra dữ liệu datable
            {
                DataTable data = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(data);

                    connection.Close();
                }

                return data;
            }

            public int ExecuteNonQuery(string query, object[] parameter = null)//  trả ra xem update thành công hay k ? 
            {
                int data = 0;

                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string item in listPara)
                        {
                            if (item.Contains('@'))
                            {
                                command.Parameters.AddWithValue(item, parameter[i]);
                                i++;
                            }
                        }
                    }

                    data = command.ExecuteNonQuery();

                    connection.Close();
                }

                return data;
            }

            
        }
    }



