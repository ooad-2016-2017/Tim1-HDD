using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Migrations.Operations;

namespace eBolnicav1Migrations
{
    public partial class trecimigration1 : Migration
    {
        public override void Up(MigrationBuilder migration)
        {
            migration.CreateTable(
                name: "Doktor",
                columns: table => new
                {
                    Id = table.Column(type: "INTEGER", nullable: false),
                       // .Annotation("Sqlite:Autoincrement", true),
                    AdresaStanovanja = table.Column(type: "TEXT", nullable: true),
                    BrojTelefona = table.Column(type: "TEXT", nullable: true),
                    DatumRodjenja = table.Column(type: "TEXT", nullable: false),
                    Email = table.Column(type: "TEXT", nullable: true),
                    Ime = table.Column(type: "TEXT", nullable: true),
                    Jmbg = table.Column(type: "TEXT", nullable: true),
                    Password = table.Column(type: "TEXT", nullable: true),
                    Plata = table.Column(type: "REAL", nullable: false),
                    Prezime = table.Column(type: "TEXT", nullable: true),
                    Username = table.Column(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktor", x => x.Id);
                });
            migration.AlterColumn(
                name: "id",
                table: "Pacijent",
                type: "INTEGER",
                nullable: false); 
               // .Annotation("Sqlite:Autoincrement", true);
        }

        public override void Down(MigrationBuilder migration)
        {
            migration.DropTable("Doktor");
            migration.AlterColumn(
                name: "id",
                table: "Pacijent",
                type: "INTEGER",
                nullable: false);
                //.Annotation("Sqlite:Autoincrement", true);
        }
    }
}
