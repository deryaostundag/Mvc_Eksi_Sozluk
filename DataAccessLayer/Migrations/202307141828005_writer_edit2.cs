namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class writer_edit2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterJob", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Writers", "WriterJob");
        }
    }
}
