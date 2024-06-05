using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication
{
    public class StaffDetails
    {
        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
       
        private string _Qualification;

        public string Qualification
        {
            get { return _Qualification; }
            set { _Qualification = value; }
        }
        private string _JoiningYear;

        public string JoiningYear
        {
            get { return _JoiningYear; }
            set { _JoiningYear = value; }
        }
        private string _PreviousExperience;

        public string PreviousExperience
        {
            get { return _PreviousExperience; }
            set { _PreviousExperience = value; }
        }
        public StaffDetails(string Name, string Qualification, string JoiningYear, string PreviousExperience)
        {
            this._Name=Name;
            
            this._Qualification=Qualification;
            this._JoiningYear=JoiningYear;
            this._PreviousExperience = PreviousExperience;
        }
    }
}
