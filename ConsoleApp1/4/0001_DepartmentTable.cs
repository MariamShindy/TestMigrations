using FluentMigrator;

namespace ConsoleApp1._4
{
	[Migration(1)]
	public class Class1 : Migration
	{
		public override void Down()
		{
			Delete.Table("Department");
		}

		public override void Up()
		{
			Create.Table("Department").WithColumn("id").AsInt32().PrimaryKey().NotNullable().Indexed()
				.WithColumn("Name").AsString().WithDefaultValue("Dept").NotNullable();

		}
	}
}
