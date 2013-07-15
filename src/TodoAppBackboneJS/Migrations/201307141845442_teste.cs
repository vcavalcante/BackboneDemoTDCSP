namespace TodoAppBackboneJS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "statuss", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "statuss");
        }
    }
}
