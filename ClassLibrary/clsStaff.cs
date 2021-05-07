using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffNumber;
        private DateTime mStaffDate;
        private Boolean mStaffStatus;
        private Int32 mStaffCredit;
        private double mStaffSalary;
        private string mStaffName;
        public Int32 StaffNumber
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffNumber;
            }
            set
            {
                //this line of code allows data into the property
                mStaffNumber = value;
            }
        }
        public string StaffName
        {
            get
            {
                return mStaffName;
            }
            set
            {
                mStaffName = value;
            }

        }
        public bool StaffStatus
        {
            get
            {
                return mStaffStatus;
            }
            set
            {
                mStaffStatus = value;
            }

        }
        public DateTime StaffDate
        {
            get
            {             
                return mStaffDate;
            }
            set
            {
                mStaffDate = value;
            }
        }
        public int StaffCredit
        {
            get
            {
                return mStaffCredit;
            }
            set
            {
                mStaffCredit = value;
            }

        }
        public double StaffSalary
        {
            get
            {
                return mStaffSalary;
            }
            set
            {
                mStaffSalary = value;
            }

        }

        public bool Find(int StaffNumber)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parrameter for the staffnumber to search for
            DB.AddParameter("@StaffNumber", StaffNumber);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffNumber");
            //if one record is found(there should be either one or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffNumber = Convert.ToInt32(DB.DataTable.Rows[0]["StaffNumber"]);
                mStaffDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffDate"]);
                mStaffStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["StaffStatus"]);
                mStaffSalary = Convert.ToDouble(DB.DataTable.Rows[0]["StaffSalary"]);
                mStaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mStaffCredit = Convert.ToInt32(DB.DataTable.Rows[0]["StaffCredit"]);
                //return that everything worked ok
                return true;
            }
            //set the private data members to the test data value
            //mStaffNumber = 2;
            //mStaffDate = Convert.ToDateTime("16/09/2015");
            //mStaffStatus = true;
            //mStaffSalary = 1000.0;
            //mStaffName = "jacky";
            //mStaffCredit = 100;
            //always return true
            //return true;

            //if no record was found
            else
            {
                //retrun false indicating a problem
                return false;
            }
        }

        public string Valid(string staffName, string staffDate, string staffSalary,string staffCredit,string staffStatus, string staffNumber)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the StaffNumber is blank
            if(staffName.Length == 0)
            {
                //record the error
                Error = Error + "the staff name may bot be blank: ";
            }
            //of the StaffNumberis greater than 8 characters
            if(staffName.Length > 8)
            {
                //record the error
                Error = Error + "the staff name must be less than 8 characters: ";
            }
          

            try
            {
                //copy the date value to the DateTemp variable
                DateTemp = Convert.ToDateTime(staffDate);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "the date cannot be in the past: ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "the date cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "the date was not a valid date: ";
            }
            return Error;
        }
    }
}
