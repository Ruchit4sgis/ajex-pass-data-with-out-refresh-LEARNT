namespace async_learn
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class test : DbContext
    {
        // Your context has been configured to use a 'test' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'async_learn.test' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'test' 
        // connection string in the application configuration file.
        public test()
            : base("name=test")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<async_learn.Models.Student_detail> Student_detail { get; set; }
        public virtual DbSet<async_learn.Models.employee_details> employee_detils{ get; set; }
        
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}