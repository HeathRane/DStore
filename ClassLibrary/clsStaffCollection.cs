using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{


    public class clsStaffCollection
    {
        
        clsStaff mThisStaff = new clsStaff();
        //public property for the staff list
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
                mThisStaff = value;
            }
        }
        public clsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("dbo.sproc_tblStaff_SelectAll");

            PopulateArray(DB);
        }

        List<clsStaff> mStaffList = new List<clsStaff>();
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStaffList = new List<clsStaff>();
            while (Index < RecordCount)
            {
                clsStaff AStaff = new clsStaff();
                //read in the fields from the current record
                AStaff.StaffStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["StaffStatus"]);
                AStaff.StaffNumber = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffNumber"]);
                AStaff.StaffName = Convert.ToString(DB.DataTable.Rows[Index]["StaffName"]);
                AStaff.StaffSalary = Convert.ToDouble(DB.DataTable.Rows[Index]["StaffSalary"]);
                AStaff.StaffCredit = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffCredit"]);
                AStaff.StaffDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StaffDate"]);
                //add the record to the private data mamber
                mStaffList.Add(AStaff);
                Index++;
            }
        }


         

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }

            set
            {

            }
        }

        //constructor for the class
        

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNumber", mThisStaff.StaffNumber);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffStatus", mThisStaff.StaffStatus);
            DB.AddParameter("@StaffCredit", mThisStaff.StaffCredit);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@StaffDate", mThisStaff.StaffDate);

            return DB.Execute("dbo.sproc_tblStaff_Insert");
        }
        

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNumber", mThisStaff.StaffNumber);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@StaffStatus", mThisStaff.StaffStatus);
            DB.AddParameter("@StaffCredit", mThisStaff.StaffCredit);
            DB.AddParameter("@StaffSalary", mThisStaff.StaffSalary);
            DB.AddParameter("@StaffDate", mThisStaff.StaffDate);

            DB.Execute("dbo.sproc_tblStaff_Update");

        }

        public void Delete ()
        {   
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffNumber", mThisStaff.StaffNumber);
          
            DB.Execute("dbo.sproc_tblStaff_Delete");

        }

        public void Filter(string StaffName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffName", StaffName);
            DB.Execute("sproc_tblStaff_Filter");
            PopulateArray(DB);



        }
        
        
    }
}