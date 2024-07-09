using FluentMigrator;

namespace ConsoleApp1._4
{
	[Migration(2)]
	public class _0002_EmployeeTable : Migration
	{
		public override void Down()
		{
			Delete.Table("Employee");
		}

		public override void Up()
		{
			Create.Table("Employee").WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Indexed()
							.WithColumn("FirstName").AsString().NotNullable()
							.WithColumn("LastName").AsString().NotNullable()
							.WithColumn("Salary").AsDecimal().WithDefaultValue("2400").NotNullable()
							.WithColumn("Address").AsString().WithDefaultValue("Cairo, Egypt").NotNullable()
		                   .WithColumn("DepartmentId").AsInt32(); 
			                Create.ForeignKey("FK_Employee_Department")
				           .FromTable("Employee").ForeignColumn("DepartmentId")
				           .ToTable("Department").PrimaryColumn("id");
		}
	}
}
