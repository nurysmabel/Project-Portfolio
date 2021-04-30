namespace EntityF4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suplidores",
                c => new
                    {
                        EmpresaId = c.Int(nullable: false, identity: true),
                        NombreEmpresa = c.String(nullable: false, maxLength: 100, unicode: false),
                        PersonaRepresentante = c.String(nullable: false, maxLength: 100, unicode: false),
                        RNC = c.String(nullable: false, maxLength: 15, unicode: false),
                        Direccion = c.String(nullable: false, maxLength: 500, unicode: false),
                        Telefono = c.String(maxLength: 15, unicode: false),
                        ProveedorEstado = c.Boolean(nullable: false),
                        RegistroProveedor = c.String(maxLength: 50, unicode: false),
                        Estado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EmpresaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suplidores");
        }
    }
}
