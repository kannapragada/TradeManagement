using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TradeManagementAPI.Models;
using TradeManagementAPI.Context;

namespace TradeManagementAPI
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new TradeManagementDbContext())
            {
                User user = new User() { UserId=1, UserName="Ravi", Password="avkm759", DateOfBirth=DateTime.Now, CreateDate=DateTime.Now, LastModDate=DateTime.Now };

                ctx.Users.Add(user);
                ctx.SaveChanges();
            }
        }
    }
}