using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA45Group3CA2
{
    class RVMMessage
    {
        public const String GeneralErrorMsg
           = "RVM001E Services not available. Please contact helpdesk.";

        public const String VehicleRecordFound
            = "RVM011E Vehicle Record exist.  Please enter another id.";
        public const String VehicleRecordNotFound
            = "RVM012E Vehicle record not found.  Please enter another id.";

        public const String EmptyVehiclePlateNumber
            = "RVM013E Vehicle Plate Number cannot be empty.  Please enter a Vehicle Plate Number.";
        public const String InvalidEmaildAddress
            = "RVM014E Invalid email address.  Please enter a valid email address.";

        public const String VehicleRecordSuccessful
            = "RVM099I Vehicle record successfully created!";
    }
}
