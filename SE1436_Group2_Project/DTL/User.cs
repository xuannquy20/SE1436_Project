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

        public string Username { get => username; set => username = value; }
        public int Role { get => role; set => role = value; }
    }
}