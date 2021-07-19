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
        int isBooked;
        string name;
        string phone;
        int canComment;
        int commented;

        public string Username { get => username; set => username = value; }
        public int Role { get => role; set => role = value; }
        public int IsBooked { get => isBooked; set => isBooked = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int CanComment { get => canComment; set => canComment = value; }
        public int Commented { get => commented; set => commented = value; }
    }
}