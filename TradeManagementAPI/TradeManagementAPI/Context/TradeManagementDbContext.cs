namespace TradeManagementAPI.Context
{
    using System.Data.Entity;
    using TradeManagementAPI.Models;

    public class TradeManagementDbContext : DbContext
    {
        // Your context has been configured to use a 'TradeManagementDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TradeManagementAPI.Context.TradeManagementDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TradeManagementDbContext' 
        // connection string in the application configuration file.
        public TradeManagementDbContext()
            : base("name=TradeManagementDbContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        //TradeManagementDbContext
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
         public virtual DbSet<User> Users { get; set; }
         public virtual DbSet<Stock> Stocks { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}