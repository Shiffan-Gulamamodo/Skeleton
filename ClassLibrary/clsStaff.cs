using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public bool isActive { get; set; }
        public DateTime lastUpdated { get; set; }
        public int StaffId { get; set; }
        public string StaffFullName { get; set; }
        public string StaffPassword { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}