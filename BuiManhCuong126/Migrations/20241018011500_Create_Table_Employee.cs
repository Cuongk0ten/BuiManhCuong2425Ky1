﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuiManhCuong126.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Employee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Hoten = table.Column<string>(type: "TEXT", nullable: false),
                    MaSinhVien = table.Column<int>(type: "INTEGER", nullable: false),
                    Ngaysinh = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Hoten);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
