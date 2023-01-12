namespace Login_forme.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TemaUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Temas", "Autor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Temas", "Autor");
        }
    }
}
