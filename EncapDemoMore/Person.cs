using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapDemoMore {
    class Person {
        #region Private Variables
        private String _FirstName;
        private String _MiddleName;
        private String _LastName;
        private DateTime _DateOfBirth;
        private Colors _EyeColor;
        private double _Height;
        #endregion

        #region Enums

        public enum Colors {
            Black,
            Brown,
            Green,
            Blue = 77,
            Gray = 56,
            Hazel,
            BlueAndGreen
        }
        #endregion

        #region Properties
        public string FirstName {
            get {
                string value = _FirstName;
                return value;
            }
            set {
                if (value == "") {
                    _FirstName = "Bob";
                } else {
                    _FirstName = value;
                }
            }
        }
        public string MiddleName {
            get {
                string value = _MiddleName;
                return value;
            }
            set {
                if (value == "") {
                    _MiddleName = "Bob";
                } else {
                    _MiddleName = value;
                }
            }
        }

        public string LastName {
            get {
                string value = _LastName;
                return value;
            }
            set {
                if (value == "") {
                    _LastName = "Smith";
                } else {
                    _LastName = value;
                }
            }
        }

        public DateTime DateOfBirth {
            get {
                return _DateOfBirth;
            }
            set {
                _DateOfBirth = value;
            }
        }

        f

        #endregion


    }
}
