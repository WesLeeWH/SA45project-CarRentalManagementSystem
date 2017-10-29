using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Group3CA2
{
    class VehicleDAO
    {
        SqlConnection cn;       // Declaring Connection object
        SqlCommand cmSelbyPK;


        private static VehicleDAO dbInstance;

        private VehicleDAO()
        {
            string strCN = @"Data Source=(Localdb)\MSSQLLocalDB;" +
                           @"AttachDbFilename =|DataDirectory|SA45Team03ADLC3CA.mdf;" +
                           @"Integrated Security = true";

            cn = new SqlConnection(strCN);

            initializeSQLCmd();
        }

        private void initializeSQLCmd()
        {
            cmSelbyPK = new SqlCommand();

            cmSelbyPK.CommandText =
               "Select VehiclePlateNumber,Model, Color, EngineSerialNo,RentalStatus from Car WHERE VehiclePlateNumber =@vehiclePlateNumber";
            cmSelbyPK.Connection = cn;
        }

        public static VehicleDAO getInstance()
        {

            if (dbInstance == null)
                dbInstance = new VehicleDAO();

            return dbInstance;
        }

        public void openConnection()
        {
            cn.Open();
        }
        public void CloseConnection()
        {
            if (cn != null)
                cn.Close();
        }


        public Vehicle RetrieveVehicle(String id)
        {
            SqlParameter pVehiclePlateNumber =
                 new SqlParameter("@VehiclePlateNumber", SqlDbType.NVarChar, 20);
            pVehiclePlateNumber.Value = id;

            // clear any previous parameters set before adding new parameters
            cmSelbyPK.Parameters.Clear();
            cmSelbyPK.Parameters.Add(pVehiclePlateNumber);


            Vehicle v = new Vehicle();

            // execute reader
            SqlDataReader rd = cmSelbyPK.ExecuteReader();
            if (rd.HasRows == false)
            {
                cmSelbyPK.CommandText =
             "Select  VehiclePlateNumber,Model, Color, EngineSerialNo,RentalStatus from Bus WHERE vehiclePlateNumber =@vehiclePlateNumber";
                cmSelbyPK.Connection = cn;
                rd.Close();
                rd = cmSelbyPK.ExecuteReader();
                if (rd.HasRows==false)
                {
                    cmSelbyPK.CommandText =
                "Select  VehiclePlateNumber,Model, Color, EngineSerialNo,RentalStatus from Truck WHERE vehiclePlateNumber =@vehiclePlateNumber";
                    cmSelbyPK.Connection = cn;
                    rd.Close();
                    rd = cmSelbyPK.ExecuteReader();
                }
            }
            if (rd.Read())
            {
                v.VehiclePlateNumber = rd["VehiclePlateNumber"].ToString();
                v.Model = rd["Model"].ToString();
                v.Colour = rd["Color"].ToString();
                v.EngineSeriaNo = rd["EngineSerialNo"].ToString();
                v.RetialStatus = rd["RentalStatus"].ToString();
            }
            else
            {
                throw new RVMException(RVMMessage.VehicleRecordNotFound);
            }
            // close reader
            rd.Close();
            return v;
        }
    }
}
