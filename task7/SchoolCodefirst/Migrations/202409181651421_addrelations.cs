namespace SchoolCodefirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addrelations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TeacherID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teachers", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.TeacherID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Assignments = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.StudentDetails",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FullName = c.String(),
                        Email = c.String(),
                        Phonenumber = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentDetails", "Id", "dbo.Students");
            DropForeignKey("dbo.Courses", "TeacherID", "dbo.Teachers");
            DropIndex("dbo.StudentDetails", new[] { "Id" });
            DropIndex("dbo.Courses", new[] { "TeacherID" });
            DropTable("dbo.StudentDetails");
            DropTable("dbo.Students");
            DropTable("dbo.Teachers");
            DropTable("dbo.Courses");
            DropTable("dbo.Assignments");
        }
    }
}
