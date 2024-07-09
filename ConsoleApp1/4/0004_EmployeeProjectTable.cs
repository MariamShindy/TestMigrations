using FluentMigrator;

namespace ConsoleApp1._4
{
	[Migration(4)]
	public class _0004_EmployeeProjectTable: Migration
	{
		public override void Down()
		{
			Delete.Table("EmployeeProject");
		}

		public override void Up()
		{
			Create.Table("EmployeeProject")
				.WithColumn("EmployeeId").AsInt32().NotNullable()
				.WithColumn("ProjectId").AsInt32().NotNullable();

			Create.PrimaryKey("PK_EmployeeProject")
				.OnTable("EmployeeProject")
				.Columns("EmployeeId", "ProjectId");

			Create.ForeignKey("FK_EmployeeProject_Employee")
				.FromTable("EmployeeProject").ForeignColumn("EmployeeId")
				.ToTable("Employee").PrimaryColumn("Id"); 

			Create.ForeignKey("FK_EmployeeProject_Project")
				.FromTable("EmployeeProject").ForeignColumn("ProjectId")
				.ToTable("Project").PrimaryColumn("Id");
		}

	}
}
