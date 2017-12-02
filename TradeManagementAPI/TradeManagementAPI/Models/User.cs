using System;
using System.ComponentModel.DataAnnotations;

namespace TradeManagementAPI.Models
{
    public class User
    {
        [Key]
        public int UserId
        {
            get => default(int);
            set
            {
            }
        }

        public string UserName
        {
            get => default(string);
            set
            {
            }
        }

        public string Password
        {
            get => default(string);
            set
            {
            }
        }

        public DateTime DateOfBirth
        {
            get => default(DateTime);
            set
            {
            }
        }

        public DateTime CreateDate
        {
            get => default(DateTime);
            set
            {
            }
        }

        public DateTime LastModDate
        {
            get => default(DateTime);
            set
            {
            }
        }

        public bool CreateUser()
        {
            throw new System.NotImplementedException();
        }

        public bool ModifyUser()
        {
            throw new System.NotImplementedException();
        }

        public bool DeleteUser()
        {
            throw new System.NotImplementedException();
        }

        public User GetUserDetail()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckUser()
        {
            throw new System.NotImplementedException();
        }
    }
}