using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace eBolnicav1Migrations
{
    public partial class trecimigration2 : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.AlterColumn(
                name: "id",
                table: "Pacijent",
                type: "INTEGER",
                nullable: false);
            //  .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Doktor",
                type: "INTEGER",
                nullable: false);
                //.Annotation("Sqlite:Autoincrement", true);
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.AlterColumn(
                name: "id",
                table: "Pacijent",
                type: "INTEGER",
                nullable: false);
            // .Annotation("Sqlite:Autoincrement", true);
            migration.AlterColumn(
                name: "Id",
                table: "Doktor",
                type: "INTEGER",
                nullable: false);
               // .Annotation("Sqlite:Autoincrement", true);
        }
    }
}
