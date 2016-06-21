using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Migrations
{
    public partial class initial5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Patient_PatientIdUniqueFK",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_PatientIdUniqueFK",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "PatientIdUniqueFK",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Contact",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PatientId",
                table: "Contact",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Patient_PatientId",
                table: "Contact",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Patient_PatientId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_PatientId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Contact");

            migrationBuilder.AddColumn<int>(
                name: "PatientIdUniqueFK",
                table: "Contact",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_PatientIdUniqueFK",
                table: "Contact",
                column: "PatientIdUniqueFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Patient_PatientIdUniqueFK",
                table: "Contact",
                column: "PatientIdUniqueFK",
                principalTable: "Patient",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
