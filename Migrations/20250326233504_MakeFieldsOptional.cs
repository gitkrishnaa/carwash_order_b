using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderService.Migrations
{
    /// <inheritdoc />
    public partial class MakeFieldsOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "payment_id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "review_text",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "service_amount",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "workStatus",
                table: "Orders",
                newName: "WorkStatus");

            migrationBuilder.RenameColumn(
                name: "serviceId",
                table: "Orders",
                newName: "ServiceId");

            migrationBuilder.RenameColumn(
                name: "selectedWasherId",
                table: "Orders",
                newName: "SelectedWasherId");

            migrationBuilder.RenameColumn(
                name: "rating",
                table: "Orders",
                newName: "Rating");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "service_name",
                table: "Orders",
                newName: "PaymentId");

            migrationBuilder.RenameColumn(
                name: "is_washer_accepted",
                table: "Orders",
                newName: "IsWasherAccepted");

            migrationBuilder.AlterColumn<string>(
                name: "WorkStatus",
                table: "Orders",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ServiceId",
                table: "Orders",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SelectedWasherId",
                table: "Orders",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Rating",
                table: "Orders",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Orders",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ReviewText",
                table: "Orders",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ServiceAmount",
                table: "Orders",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "ServiceName",
                table: "Orders",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewText",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ServiceAmount",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ServiceName",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "WorkStatus",
                table: "Orders",
                newName: "workStatus");

            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Orders",
                newName: "serviceId");

            migrationBuilder.RenameColumn(
                name: "SelectedWasherId",
                table: "Orders",
                newName: "selectedWasherId");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "Orders",
                newName: "rating");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "customerId");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Orders",
                newName: "service_name");

            migrationBuilder.RenameColumn(
                name: "IsWasherAccepted",
                table: "Orders",
                newName: "is_washer_accepted");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "workStatus",
                keyValue: null,
                column: "workStatus",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "workStatus",
                table: "Orders",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "serviceId",
                keyValue: null,
                column: "serviceId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "serviceId",
                table: "Orders",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "selectedWasherId",
                keyValue: null,
                column: "selectedWasherId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "selectedWasherId",
                table: "Orders",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "rating",
                keyValue: null,
                column: "rating",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "rating",
                table: "Orders",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "customerId",
                keyValue: null,
                column: "customerId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "customerId",
                table: "Orders",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "payment_id",
                table: "Orders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "review_text",
                table: "Orders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "service_amount",
                table: "Orders",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
