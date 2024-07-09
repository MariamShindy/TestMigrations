using FluentMigrator;

namespace ConsoleApp1._4
{
	[Migration(3)]
	public class _0003_ProjectTable : Migration
	{
		public override void Down()
		{
			Delete.Table("Project");
		}

		public override void Up()
		{
			Create.Table("Project")
				.WithColumn("Id").AsInt32().PrimaryKey().NotNullable().Indexed()
				.WithColumn("Name").AsString().NotNullable()
				.WithColumn("StartDate").AsDateTime().NotNullable()
				.WithColumn("EndDate").AsDateTime().Nullable();
		}
	}
}
