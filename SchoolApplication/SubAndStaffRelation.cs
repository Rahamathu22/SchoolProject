﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication
{
   public class SubAndStaffRelation
    {
        private int _SubjectId;

        public int SubjectId
        {
            get { return _SubjectId; }
            set { _SubjectId = value; }
        }
        private int _Class;

        public int Class
        {
            get { return _Class; }
            set { _Class = value; }
        }
        private string _Section;

        public string Section
        {
            get { return _Section; }
            set { _Section = value; }
        }
        private string _Year;

        public string Year
        {
            get { return _Year; }
            set { _Year = value; }
        }
        private int _StaffId;

        public int StaffId
        {
            get { return _StaffId; }
            set { _StaffId = value; }
        }

        public SubAndStaffRelation(int SubjectId, int Class, string Section, string Year, int StaffId)
        {
            this._SubjectId=SubjectId;
            this._Class=Class;
            this._Section=Section;
            this._Year=Year;
            this._StaffId = StaffId;
        }
    }
}
