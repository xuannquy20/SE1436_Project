using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SE1436_Group2_Project.DTL
{
    public class User
    {
        string username;
        int role;
        string name;
        string phone;
        int commented;

        public string Username { get => username; set => username = value; }
        public int Role { get => role; set => role = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Commented { get => commented; set => commented = value; }
    }
}