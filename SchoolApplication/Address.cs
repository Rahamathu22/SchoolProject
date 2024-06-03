﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolApplication
{
   public class Address
    {
        private string _DoorNo;

        public string DoorNo
        {
            get { return _DoorNo; }
            set { _DoorNo = value; }
        }
        private string _Street;

        public string Street
        {
            get { return _Street; }
            set { _Street = value; }
        }
        private string _Village;

        public string Village
        {
            get { return _Village; }
            set { _Village = value; }
        }
        private string _City;

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        private string _State;

        public string State
        {
            get { return _State; }
            set { _State = value; }
        }
        private string _Pin_Code;

        public string Pin_Code
        {
            get { return _Pin_Code; }
            set { _Pin_Code = value; }
        }
        private string _Mobile_Number;

        public string Mobile_Number
        {
            get { return _Mobile_Number; }
            set { _Mobile_Number = value; }
        }
        private string _Mail_Id;

        public string Mail_Id
        {
            get { return _Mail_Id; }
            set { _Mail_Id = value; }
        }
        public Address(string DoorNo, string Street, string Village, string City, string State, string Pin_Code, string Mobile_Number, string Mail_Id)
        {
            this._DoorNo=DoorNo;
            this._Street=Street;
            this._Village=Village;
            this._City=City;
            this._State=State;
            this._Pin_Code=Pin_Code;
            this._Mobile_Number=Mobile_Number;
            this._Mail_Id = Mail_Id;
        }
    }
}
