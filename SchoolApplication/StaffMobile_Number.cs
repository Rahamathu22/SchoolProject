using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication
{
   public class StaffMobile_Number
    {
        private int _StaffId;

        public int StaffId
        {
            get { return _StaffId; }
            set { _StaffId = value; }
        }
        private string _Mobile_Number;

        public string Mobile_Number
        {
            get { return _Mobile_Number; }
            set { _Mobile_Number = value; }
        }
        public StaffMobile_Number(int SatffId,string Mobile_Number)
        {
            this._StaffId=StaffId;
            this._Mobile_Number = Mobile_Number;
        }
    }
}
