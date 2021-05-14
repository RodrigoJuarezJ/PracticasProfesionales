namespace PracticasProfesionales.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segunda : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Advisers", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Advisers", "LastName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Advisers", "PhoneNumer", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Advisers", "CellPhone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Advisers", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Advisers", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Advisers", "Departament", c => c.String(maxLength: 50));
            AlterColumn("dbo.Coaches", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Coaches", "LastName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Coaches", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Coaches", "Cellphone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Coaches", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Companies", "Name", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Companies", "Address", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Companies", "PostalCode", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Companies", "Website", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Companies", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Companies", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Contacts", "Firstname", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Contacts", "CellPhone", c => c.String(maxLength: 15));
            AlterColumn("dbo.Contacts", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "Departament", c => c.String(maxLength: 50));
            AlterColumn("dbo.Coordinators", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Coordinators", "LastName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Coordinators", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Coordinators", "CellPhone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Coordinators", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Majors", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Majors", "PhoneNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Majors", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Majors", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Majors", "Description", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Students", "PhoneNumber", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Students", "CellPhone", c => c.String(maxLength: 15));
            AlterColumn("dbo.Students", "Photo", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Photo", c => c.String());
            AlterColumn("dbo.Students", "CellPhone", c => c.String());
            AlterColumn("dbo.Students", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            AlterColumn("dbo.Majors", "Description", c => c.String());
            AlterColumn("dbo.Majors", "Email", c => c.String());
            AlterColumn("dbo.Majors", "Photo", c => c.String());
            AlterColumn("dbo.Majors", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Majors", "FirstName", c => c.String());
            AlterColumn("dbo.Coordinators", "Photo", c => c.String());
            AlterColumn("dbo.Coordinators", "CellPhone", c => c.String());
            AlterColumn("dbo.Coordinators", "Email", c => c.String());
            AlterColumn("dbo.Coordinators", "LastName", c => c.String());
            AlterColumn("dbo.Coordinators", "FirstName", c => c.String());
            AlterColumn("dbo.Contacts", "Departament", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Photo", c => c.String());
            AlterColumn("dbo.Contacts", "CellPhone", c => c.String());
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "Firstname", c => c.String());
            AlterColumn("dbo.Companies", "Photo", c => c.String());
            AlterColumn("dbo.Companies", "Email", c => c.String());
            AlterColumn("dbo.Companies", "Website", c => c.String());
            AlterColumn("dbo.Companies", "PostalCode", c => c.String());
            AlterColumn("dbo.Companies", "Address", c => c.String());
            AlterColumn("dbo.Companies", "Name", c => c.String());
            AlterColumn("dbo.Coaches", "Photo", c => c.String());
            AlterColumn("dbo.Coaches", "Cellphone", c => c.String());
            AlterColumn("dbo.Coaches", "Email", c => c.String());
            AlterColumn("dbo.Coaches", "LastName", c => c.String());
            AlterColumn("dbo.Coaches", "FirstName", c => c.String());
            AlterColumn("dbo.Advisers", "Departament", c => c.String());
            AlterColumn("dbo.Advisers", "Email", c => c.String());
            AlterColumn("dbo.Advisers", "Photo", c => c.String());
            AlterColumn("dbo.Advisers", "CellPhone", c => c.String());
            AlterColumn("dbo.Advisers", "PhoneNumer", c => c.String());
            AlterColumn("dbo.Advisers", "LastName", c => c.String());
            AlterColumn("dbo.Advisers", "FirstName", c => c.String());
        }
    }
}
