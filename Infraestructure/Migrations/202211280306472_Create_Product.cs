namespace Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Descripcion = c.String(),
                        PrecioVenta = c.Double(nullable: false),
                        CreatedON = c.DateTime(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                        FechaVen = c.String(),
                        Igv = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
