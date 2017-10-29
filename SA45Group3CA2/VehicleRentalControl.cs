using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45Group3CA2
{
    class VehicleRentalControl
    {
        public Vehicle RetrieveVehicle(String id)
        {

            VehicleDAO vehicleDAO = VehicleDAO.getInstance();
            try
            {
                vehicleDAO.openConnection();
                Vehicle v = vehicleDAO.RetrieveVehicle(id);
                return v;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                throw;           // preserve stack trace     
            }
            finally
            {
                vehicleDAO.CloseConnection();
            }
        }
    }
}
