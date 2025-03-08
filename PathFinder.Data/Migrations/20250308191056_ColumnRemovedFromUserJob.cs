using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class ColumnRemovedFromUserJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "UsersJobs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16226cef-b670-447e-99a9-b627cb16ae0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "692d454a-face-415b-a951-1b5fe6240928", "AQAAAAIAAYagAAAAEHzVWkrGv0fawkarWe5lTfobnYatpkpMKrF/a9RWpGXuRxv9By1MDuvEANK98hrzOw==", "ab4885cf-0bb4-4fd5-867c-99df1a961c14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17585a62-c173-4c68-9e4a-2ba93a419b21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aa02011-fb89-4e00-ac71-01377ebb3f6f", "AQAAAAIAAYagAAAAEC0jLtbsbnSZb8/a2NDAnz+hYFJ8g8yTd+z7p2noKSnDhCoqZEVqJfXKpyZCgbRc6w==", "b25a0589-9950-48fb-8803-4d78dd122c7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fb81921-d9d3-48dd-8b54-20a98ff358cd", "AQAAAAIAAYagAAAAEFuuG8kXf79UGmMV+vkBFJJdIGqFIddYT9atIbvDRGOoqxmsOuEteCW+jn8SI+9oxA==", "c8e9dfb0-1c04-4708-b922-5abdd49f4390" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36a7ace2-a055-4940-8e37-9f6592b80e66", "AQAAAAIAAYagAAAAEP2tFGbCYjZIg2gYmI12GcwPwSaGc0OG+mgnREhtxko4IuXKmr0jrPBc+ber26d+HQ==", "df5109a5-504b-4f40-a732-2de827827477" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cf3fb4a-235e-4c93-b66f-c1557006e067",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e60627f-b88c-4be5-84b4-83114742bd33", "AQAAAAIAAYagAAAAENh9Pcy15qXfy3neAWpR00NdpUXHTriQhSFsqZzo8c7rDBwv1B1TI0ZtYifKHAjvCA==", "88602962-15f6-4f88-830a-d7b9719226d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "428bcf46-40f2-47b2-ac4a-a49f570178ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5bed9d8-a346-41f1-825f-4cc2efbb07bd", "AQAAAAIAAYagAAAAEKnBm/hgRw7anywhp7MjCiYCjxEPE9gzNGZFPdnjT6nDmNfVUmAXaMKM3yZ8HotKeQ==", "bbfdc91b-a3ee-4465-9eba-6d16c7f173b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "596c6add-eaae-4890-8d4d-38aa5a0671bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf8a40b7-a6f7-4c64-b152-050001e840d6", "AQAAAAIAAYagAAAAENPvPMr7brnm3hKrmPjbGBOrEXVbBpiofHimk9SGDDt9TZPUm3MpXYq7iQAYFhFseA==", "4193ee72-a24b-42e0-83f5-288f58be579a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a358b17-ffbe-4ac9-8d20-92544e3b739d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4c603ba-e5a9-42b8-91a1-3b25eaca8c5c", "AQAAAAIAAYagAAAAEMqv85i3pLacgxJmO8TnP/AA+WaIy+BvtcozWClBBSAUt4wDYFariEWCmKDUpBuGjg==", "cf230457-1b88-4cf5-9c19-284a2fde1b33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "723444b3-9434-4465-9044-f7e04fdcca2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8141e0f-55af-4f85-aed8-8445eaa25bb4", "AQAAAAIAAYagAAAAEBFLqmSVU6kfhLZldYoRYCT0tgRCOJb0mtsAejjJxshGpsogEWPRD/10NS/y+mQYZQ==", "e200d58e-e155-43e2-85f4-d431d45e8cce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d089603-dc80-415a-913b-f24b1a90b5f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54ec28f3-92eb-408a-a572-200060acf6d7", "AQAAAAIAAYagAAAAEMTrTOQ2KyTo25/QmP8YFM/52F/Qa2We3J8/zpL6jIyDuZByKH3ClIrEqYEklGtpgg==", "9c96b9c9-3e23-4752-8d80-0fbb8e925958" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e312a43c-e4e1-49e3-9558-f5d68f00aa10", "AQAAAAIAAYagAAAAEBXPDHmJHdfwGf/3c8oYt5wkBvjUDGjvzStgbC/PPd1HLOSxGBksJksCNtBW5vyDYw==", "218845a9-8ef1-47bd-b656-76dd51845f6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d0c3b82-be4b-4fdf-834a-8e436176d9bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8936e09-8574-4ddd-81bc-ef6ffddfb756", "AQAAAAIAAYagAAAAEG8lMlHGYoxpPSdxmrEG15vHmAFWv2upZCVh/hcOVzl5kWRW0BB8RncJpR0FapnVSA==", "6cdec12d-7b39-4fd1-9e5d-887afd6e0b4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e547484-9ea8-45e6-a488-d657f6f1c598",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b00c02a-d7bb-4558-8e6a-9e184d82e189", "AQAAAAIAAYagAAAAEKMBfF7M19rWL0hTwziVlUhKdx9KHJMJubfKtM/O/MYfuMR852b9/0AfWe4on+GA0Q==", "7a5c9159-692e-4a0a-b4c0-7a7774812464" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3693b0c-9c11-48ee-a3be-db37d5439ab0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63e99c29-9a9b-4339-8390-9fac54fa1782", "AQAAAAIAAYagAAAAEFYZ5CsihNcNQIkQs5mdBh7nf+f4Hj5e49dw8utB3TFFt73l83i3kHHQ8vyYvBACHg==", "9f1c2a57-cc63-4ece-9b4a-b217f9b53fa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a91708f1-b5ff-4ae9-9acd-4edac144f86c", "AQAAAAIAAYagAAAAEPh7kzUmhCkqZC9XeuypSjlYCdRxILBE9RaOJcACtusIgQmnyj3SXayXOCSy+TsTbA==", "c43d4cd8-dd04-4eeb-abc8-a3d2893cad06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca145762-b5db-4836-b963-85eff67fb124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5d4c5d5-ff5f-4ed7-be0a-4378db902935", "AQAAAAIAAYagAAAAEDLzx8BXUZF1EcWaefzyUWZQP5FCCH6hQmsyx41yHOp8aRjg6PfJbEBN6ZtIl9ESLQ==", "93a74424-02d3-42a5-8b13-32d12a34e85b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d444522c-71c1-4cc9-b815-4ea25a49f17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab31ee15-324f-421d-a32a-4e76c9cd11e3", "AQAAAAIAAYagAAAAEPKECWlxm+ByhycoW6PzgKTCQCe86xRSqxgoNXnt8e85y70xwDXEmipOBllOWbnwHg==", "095db0d1-5a8d-48b2-b70e-2c10f2034301" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0d6328d-f003-4bb1-8daa-21dcf49db469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "233e6bbe-e6e8-42b9-8674-aade48cd7a6f", "AQAAAAIAAYagAAAAEJcA2vInYawI3sqkUHR7EEC9/7JbulNXlOCHfMdrQGQZeX/tSfPovPtlOEhOVuVd+w==", "6b7c3802-478d-4b51-ad31-bf10cface536" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2041514-c5ce-4e68-8956-f92298aa3b74",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b17d0ea9-9483-4c98-9be7-6abfcc3e0f1e", "AQAAAAIAAYagAAAAEKQFte2OtjYdsQekcgBFFU/WvwA7/RB3SYXKFcg9fphE+D0irshewzBchW5vfF8YDg==", "ddb4905a-e0b5-4499-958e-05aa3b283692" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0c9da92-1765-4e79-a01d-c828aff3d415", "AQAAAAIAAYagAAAAEJg58x23iD92Q+I3toVOknAVHWN7sIcB+7ql8LBOHjRWhynH9w+F3JdUvb822r7Blw==", "2da3fd23-46ec-40b4-a400-7fd31f1e005e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8d223af-7285-41c5-8c38-9e6989d4410d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "018aae38-1749-4453-aa73-7bca5c07f84b", "AQAAAAIAAYagAAAAEAnLUbFIF6NhrYkkhZ1bZQKjdml3dN5nkLinEZNhfesUaxniYU1JWvqC+AgmI2MobQ==", "c1c1669b-3874-483f-b52e-949a29e0e934" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "865c3f44-4072-430c-b970-b878eddbea92", "AQAAAAIAAYagAAAAEJ+seOvzYrOYAQVi9aUZrBPqO6UmYekyiAWErtpMhrUPQ8PllLhvfAvPPx5nPx/eHg==", "3ee10e14-94fd-4158-9a13-3c5e1044ef27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa360a62-9355-474a-824d-aaa85d9fbd65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0061fde3-6a69-456a-8d94-a8c6cb624d95", "AQAAAAIAAYagAAAAEEDxYktCnE0b6w8h3Ze23l7evxztNxsHEUk3Ig+LPh3uJ3thq40XM3AbHpEVWJ9VLQ==", "518fbfea-1835-44cd-9e72-4f6120f2218b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc7c5678-22b4-4650-af6e-4c5f90fa494d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd060dc2-748f-4834-a812-41001fdc29e7", "AQAAAAIAAYagAAAAEHEllhJ66vBMbtYs8yTMTSkxZxIyc5atT3grBPmRsg0hu6sE091XdQeyx30o55Zg8g==", "77813133-01a8-4d04-a1f1-28e5283fcffa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "UsersJobs",
                type: "nvarchar(max)",
                nullable: true,
                comment: "File name, uuid");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16226cef-b670-447e-99a9-b627cb16ae0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cbf9585-6d1d-43f9-99dd-702677fb17a1", "AQAAAAIAAYagAAAAEOtu6muG37NVdDCoA2rfbNZb/nfIHici0N2fvwk+RMhiim53Ka0ppaHh945l2xl0Kw==", "7304a03b-4aa1-48e8-8369-91c40b94a898" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17585a62-c173-4c68-9e4a-2ba93a419b21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5329781-43af-471f-ba9f-adbc7d46b03e", "AQAAAAIAAYagAAAAEIxbHK2jQGUSWxeTGbwosljzIrV61vp37WfFStiNvgBEIk7qPeLjSBqbqMNULdpQCQ==", "8dbda0e7-226a-47e5-af2b-1355977eb91d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f9f394e-5660-4fa4-b418-7122757a26f2", "AQAAAAIAAYagAAAAEHHL420Pq45cXZBK4wDLActXXPsNyyJLaHHVrKS06MBKsREopW+fy+5WiKaFsmuP4g==", "45aecb5a-1474-4ee0-96c8-9c581adc8873" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2048887-b709-4609-bba1-ff0d3e714605", "AQAAAAIAAYagAAAAEBg8kK9yZW+T3DahDHKerT/R9QuDpmuiyVSUNV94ldFGbeFkzE6CXhF81XB9oULt7w==", "38673ac2-ab66-4b98-bd6a-e9460024a533" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cf3fb4a-235e-4c93-b66f-c1557006e067",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "209c21fe-cb2e-4bed-904e-2aacbe920867", "AQAAAAIAAYagAAAAEJpdenhroFNT4UzwSWqzX6P+mBOeDO5yM2Xuxa0Wxz43VFoXfejz6tOhILIsSeojHw==", "3d0311a8-9738-490b-9ea5-8cea9cdd9107" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "428bcf46-40f2-47b2-ac4a-a49f570178ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b85318dc-3d94-4fae-968a-94f02e36071f", "AQAAAAIAAYagAAAAEFqLjRRo3Ezx4m9Z1v7evQjdfWiMqXS0TqDlIFvVP0i/3sp4PVNInSvcfj74tcrefQ==", "00d9e1c5-d9f8-41d7-adcc-bb67f56d46a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "596c6add-eaae-4890-8d4d-38aa5a0671bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b203040e-0106-4f63-a0dd-e8e34c976d80", "AQAAAAIAAYagAAAAEJSNzpddePgtQ+f1JAfSL9UTaAhs1m2jTZ8cQ8OeIYq0LwPr5InnFRTcvDe47mX3oQ==", "6b506259-a965-4610-b00b-32991d8ec8f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a358b17-ffbe-4ac9-8d20-92544e3b739d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f853982-0569-495e-a950-46b2c4f41bf2", "AQAAAAIAAYagAAAAELL6lpbqqC0k2EHcVYRO9tQFT0Rv4cwrGcKUi9IZ10PThVzkRZMCR227Y0FCsqcIXA==", "d4fbf1a7-9eaa-4a48-a845-f0c08ba7a348" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "723444b3-9434-4465-9044-f7e04fdcca2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9217a86-3d89-47a4-9ca3-d502118ee1a6", "AQAAAAIAAYagAAAAEFfvG9j1IJN7hzm64FdYnVlnlDEL3PoVsBfTTVFGA07RlsNlgnePUqHWj4BE6ZO1hQ==", "6f80f7b1-8f1e-441d-a698-45a572602acc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d089603-dc80-415a-913b-f24b1a90b5f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b99800e3-7d7c-450e-bad5-7334b400504d", "AQAAAAIAAYagAAAAEK3Qphg1ollS+FhpPKC53qOuXoYtuh+2f+9kgtMJXC36Tj/5RBHWWHzy7ue5R0dvVA==", "789f5de5-8d88-4cd8-9cd6-38fad70ae9d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7266d772-dc07-4c8a-bd05-f8544d54c347", "AQAAAAIAAYagAAAAECct8hqjLkM4rU023HEcmAoU5cuQvJvO53xOVEATo/147EbO63jbI9lTxaT8Qb4Z5A==", "9eb9dd8d-14b1-4eef-a155-004ce7b38b7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d0c3b82-be4b-4fdf-834a-8e436176d9bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "001d0f7d-9003-410d-81bd-7e714fa1f576", "AQAAAAIAAYagAAAAEBwOaGj09TNdF71NWuZmPIsdtAHpMr1/YAc3sBgjoW4M2cV/oI5b9iwygDwKHHOxKQ==", "cbe0f7d6-c653-4325-872b-e04e31e224d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e547484-9ea8-45e6-a488-d657f6f1c598",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a815716c-5965-4ac9-a5ba-abf18d891d16", "AQAAAAIAAYagAAAAEKlWckUa3z+zP4YIaT6vGb7R9rg6NkMDs223fWyw5umneAWKYMa/V9n7QxcFebceCA==", "efd30798-cf11-4ed6-a78d-ee7c80e09050" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3693b0c-9c11-48ee-a3be-db37d5439ab0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5914bd9f-3ac0-4c76-b6fc-66ad2fc38d22", "AQAAAAIAAYagAAAAEKQWtAb9raqm8nBKME5VJdGfu/cU4nM/1aQ+WGuECb0CLBqfbvZ1mWBxjtDWTJAf7Q==", "b7849272-28e6-48e9-a965-e57053d6119e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5255ad09-ca7e-4a05-a399-5a7b0254144e", "AQAAAAIAAYagAAAAEBi4BvJ+iFlgrbNFStshNpDGBKPGv3e2e6RI/HfyilG3KMnKxIr9GdyOOVwVUczkCg==", "9fa72657-e4b3-4d82-932f-379cdd6ab740" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca145762-b5db-4836-b963-85eff67fb124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc89cc61-0513-48e8-ba0e-e94152afde99", "AQAAAAIAAYagAAAAEKHIUZGHKgZpxvsdENnEocey6HwpDB+72x66HyLBMmkMD3YZ5F8iqUgauxvXP4BShQ==", "0a6927fd-8e4f-443a-b6ad-0f5f24bfca24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d444522c-71c1-4cc9-b815-4ea25a49f17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d66fa8-aef2-4e6b-88b8-39dbeb42cebf", "AQAAAAIAAYagAAAAEO59OHV2bPav8MYA+t3FvdONeIkUn88qOZzdod7XdXs8Z5GhiJMy68hWJFvp+ZuFQQ==", "df0b31bc-c579-405c-a297-a0d1af90b593" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0d6328d-f003-4bb1-8daa-21dcf49db469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90e18c8c-9be8-4c4c-bfa7-f08aec38098c", "AQAAAAIAAYagAAAAECje6y87sbpJL+jN2emcilqDH5PYmBfQ+66xia/Fk3TOPdS/OmJizC1xMn8XjQ0rEA==", "ed8f0273-07ed-4dd5-8e8a-468843509057" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2041514-c5ce-4e68-8956-f92298aa3b74",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b4a04c8-ab20-438a-b6a9-f0f6f4f21436", "AQAAAAIAAYagAAAAEFsPNYDPGMhTNCDoxdroJEgmMUQ6hR2ZrtpfF4hUz6iiUQrDXGVYMHE/uI9LcDZSIQ==", "483c8326-50ee-47cd-aad2-ad6ae34787c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c55a643a-ad72-4210-a2a6-84135304678a", "AQAAAAIAAYagAAAAEGhomnJEypWvIHIz+qw2fRZZfFDg3a9zdHiNjmv7I79X1FNqNkLIeNaXsnuptDBmAQ==", "ca763fd2-3f5f-4b74-a0a3-78c6b469ce40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8d223af-7285-41c5-8c38-9e6989d4410d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "512bf624-d5d6-4b8c-bdba-ada21dfb2a61", "AQAAAAIAAYagAAAAEDTBNf/z+18/y0yRV4YkBt2PpwgcE7CvKaORwKy2gapQMQvHIz6haagCy5v2mowCwg==", "b5636fb5-c575-4a7e-94ae-b4ddcb598dff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd6bc406-3a69-4afa-9f5a-3bd454fddcbf", "AQAAAAIAAYagAAAAEB6mEFvVELSOflY+m7a0ojBJNIEShLQV58eWE6TiN2yQpPBh7FIeOC1NZcMYZxN6xQ==", "15b056f6-7771-442e-913c-66cba99241bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa360a62-9355-474a-824d-aaa85d9fbd65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdac4de2-9ce9-4637-b675-7e4112094ed6", "AQAAAAIAAYagAAAAEOoSaa6y4ZYLlaB5ySbJa7oTmnZKMi/TEWXFWou+EeBwt7rBV2eQ5f6eDZYHowr7UQ==", "b2f88303-3f99-4b1a-be8d-a4341d8bc651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc7c5678-22b4-4650-af6e-4c5f90fa494d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1fe5966c-9b54-4cf3-b5fd-434b2436f5b1", "AQAAAAIAAYagAAAAEPa5HfB8XPiaQHBwRCZzoxBlycOcZxFEsdoJUA2VCRghPEeJHJuMdq3QGX5QoqXHXA==", "937a580a-7419-4f5d-8db5-6df80170ab95" });

            migrationBuilder.UpdateData(
                table: "UsersJobs",
                keyColumns: new[] { "JobId", "UserId" },
                keyValues: new object[] { 2, "d444522c-71c1-4cc9-b815-4ea25a49f17b" },
                column: "FileName",
                value: null);

            migrationBuilder.UpdateData(
                table: "UsersJobs",
                keyColumns: new[] { "JobId", "UserId" },
                keyValues: new object[] { 1, "e8d223af-7285-41c5-8c38-9e6989d4410d" },
                column: "FileName",
                value: null);
        }
    }
}
