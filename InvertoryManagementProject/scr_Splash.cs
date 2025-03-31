using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvertoryManagementProject
{
    public partial class scr_Splash : Form
    {
        public scr_Splash()
        {
            InitializeComponent();
        }

        private async void scr_Splash_Load(object sender, EventArgs e)
        {
            await ReadDB();
            this.DialogResult = DialogResult.OK;
        }

        private async Task ReadDB()
        {
            string query = "SELECT * FROM cargoTypes";

            GlobalVariables.cargoTypes.Add("Seçiniz..");
            using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        GlobalVariables.cargoTypes.Add(Convert.ToString(reader["cargoType"]));
                    }
                }
            }

            query = "SELECT * FROM paymentTypes";

            GlobalVariables.paymentTypes.Add("Seçiniz..");
            using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        GlobalVariables.paymentTypes.Add(Convert.ToString(reader["paymentType"]));
                    }
                }
            }

            query = "SELECT * FROM list_City ORDER BY name";
            GlobalVariables.Cities.Add(new City { ID = -1, Name = "Seçiniz..", PlateNumber = -1 });
            using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        GlobalVariables.Cities.Add(new City
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = Convert.ToString(reader["name"]),
                            PlateNumber = Convert.ToInt32(reader["plateNumber"])

                        });
                    }
                }
            }


            query = "SELECT * FROM list_District";
            GlobalVariables.Districts.Add(new District { ID = -1, Name = "Seçiniz..", CityPlateNumber = -1 });
            using (SqlConnection con = new SqlConnection(GlobalVariables.SQLPath))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        GlobalVariables.Districts.Add(new District
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = Convert.ToString(reader["name"]),
                            CityPlateNumber = Convert.ToInt32(reader["cityID"])
                        });
                    }
                }
            }


        }


    }
}
