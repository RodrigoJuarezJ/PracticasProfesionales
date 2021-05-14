namespace PracticasProfesionales.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advisers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumer = c.String(),
                        CellPhone = c.String(),
                        Photo = c.String(),
                        Email = c.String(),
                        Departament = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Cellphone = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        PostalCode = c.String(),
                        Website = c.String(),
                        Email = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        CellPhone = c.String(),
                        Photo = c.String(),
                        Email = c.String(),
                        Departament = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Coordinators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        CellPhone = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        PhoneNumber = c.String(),
                        Photo = c.String(),
                        Email = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        CellPhone = c.String(),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Majors");
            DropTable("dbo.Coordinators");
            DropTable("dbo.Contacts");
            DropTable("dbo.Companies");
            DropTable("dbo.Coaches");
            DropTable("dbo.Advisers");
        }
    }
}
