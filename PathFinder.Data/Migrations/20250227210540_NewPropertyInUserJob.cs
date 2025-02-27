using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PathFinder.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewPropertyInUserJob : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "d70c5b06-0e5e-454f-a506-1d082567069a", "AQAAAAIAAYagAAAAEGgaFHmaBpQisIfdJ3ikl7BoEqMpuhD5fImbh96hnu04Ka1FlaTB5PLgkKZYk6UlwQ==", "36764c0b-94bd-4d9e-8826-1225cc11c68d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17585a62-c173-4c68-9e4a-2ba93a419b21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44e86c3e-23e8-422e-aae7-77af545283be", "AQAAAAIAAYagAAAAELeSnqSM4vlRZC0LaFsor6nbbPgsxc7jArumdWqiGSVL7sspwUfJ3x24RVlb8qeUCA==", "762f9bed-3f60-4186-a6d7-b85e0eb45451" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa73ec91-1125-4407-942e-905cfaf569ec", "AQAAAAIAAYagAAAAEBHRL0CDb5X0TIUbys8zXT7he3idl0BDsI4sUYqJdEXi+NbWocn8FH9i22E8+2X3Pw==", "87193e30-7a89-41d1-920d-eaf36320c3e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ba4651d-2672-4a9c-9558-61a03f288b77", "AQAAAAIAAYagAAAAEJNEcaVeUFJ/iacKScYr9WZM+rZSp/b1Fz4Vl41X/GRt3RViCjd7+UjJjDTxK7403w==", "a00516d5-0fb8-4970-8cf4-f579499aa59e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cf3fb4a-235e-4c93-b66f-c1557006e067",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca570e40-c8d5-43f6-acff-33a70ecd9fd8", "AQAAAAIAAYagAAAAEJenyyLiyq3ffn4IovSWQOuSTw436vlOldQB2TeSr9ko8HFmmSBRusTU46pARlhqQw==", "4c2f9628-7bf4-470b-91fe-ba789db9a4f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "428bcf46-40f2-47b2-ac4a-a49f570178ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "312281c7-e852-4570-a83c-60089de30dc9", "AQAAAAIAAYagAAAAENZrN/gzsrUWyFOchIZx6d3YkhBW6keOPqWfhl992VGGH3KU1BI7RWa99zCdX8qcbQ==", "5273c725-c479-4e91-95d1-3235776a8365" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "596c6add-eaae-4890-8d4d-38aa5a0671bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1511f0a-5682-4f91-b9ed-e91a9797cbbe", "AQAAAAIAAYagAAAAENwsvAGSvljp3Y42DDrOolN+AePgiNdrAiby5fwo+ZLxXp5YZox6CzMSOuMzPzYT3w==", "cf95fb81-6830-4c8b-8f81-3f1db1bb8977" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a358b17-ffbe-4ac9-8d20-92544e3b739d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f136f77e-41b9-4c53-a4c2-cd7e992ade58", "AQAAAAIAAYagAAAAEDJ0Ie900GTE5GAJcqX+xE3lIZokfn+RHQIQ+T5pNXsRAFxDto3gw6hDiJiUKo74Hg==", "948f486d-035f-400e-b0dc-260b23f60693" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "723444b3-9434-4465-9044-f7e04fdcca2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4752e97-6c3f-453d-9668-7f64cc2c0073", "AQAAAAIAAYagAAAAEB1JOjr1cO+QMOMVYJnchDQ/DRwHFSGT3oi+x/GUw33nk+FHREbTJ89e46qdGZjF2Q==", "6c201cab-cc91-4fb6-b5a1-ed0837661ebc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d089603-dc80-415a-913b-f24b1a90b5f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25a24bb4-8374-4f45-8d6a-203e7874418e", "AQAAAAIAAYagAAAAEKs5Yqv8oTCgbYR6gqAFSUxN2Urn7HBqArSjXlj8+HSyPTlpMHTdjWd8jnaRBryRjQ==", "c336799c-9e4c-4fc7-9008-c3072b72307c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5de8f1a6-29a9-429a-824b-184ffbffe28a", "AQAAAAIAAYagAAAAEEIYQ8/e/d270PwltBrWX1xgg+7smEiQYrvc0zuW4gAmTXXCanEQTbvqgBuM2OcRfg==", "f48fb303-38b0-4440-95ee-a7aa629e9b2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d0c3b82-be4b-4fdf-834a-8e436176d9bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47e8cf6a-b4ab-465e-ab23-bd87de0530ef", "AQAAAAIAAYagAAAAEDBtb4tnmjYC67trP3Y/Uxpd8DSPKviMEr4Cx1hktWLsJ+O/8F9lYMc2nM+FxA0uGw==", "043fe43e-5a8e-4985-8485-ccc5357b0e44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e547484-9ea8-45e6-a488-d657f6f1c598",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9861a50-b3cf-418b-8e27-bea545d4a75a", "AQAAAAIAAYagAAAAEBulqnZIZhsQFB6kytLbmH3yMphm/f5JsiO+eAzTnjOlMxRSD4gGbXuVlFoXB1V5tA==", "b63bc871-80e2-4346-95ee-419c0743ce40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3693b0c-9c11-48ee-a3be-db37d5439ab0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd8f8eb4-654a-4dc7-a9a2-3a774571f625", "AQAAAAIAAYagAAAAEM4Xl2K52Xzn10INAEwDxwbEc5nJJtYCeDPKoDNCvtG5zz0U+WG72qd/IQsIHVx5RQ==", "0db2c237-6641-4498-918c-844846668ea9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "977f14f4-b7ae-4d70-9cbf-b4f9775f2a6b", "AQAAAAIAAYagAAAAEJQjgjEheZFvb5U9wnrMwcmsQrZtVnENB1zLBnbyth/R/8QOdMYrGVg9EHSScVQfPQ==", "6cb19c1a-b069-4bbd-b66d-092b1e38055c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca145762-b5db-4836-b963-85eff67fb124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fba2cf79-41e6-4cef-a5e7-c6a89330463e", "AQAAAAIAAYagAAAAEIFD7xDj3vKSYlH2SraZD8LyMV/ZgrWcxLLM1H1/Qt12Cu35Cs8uhcUDBljbK3SLjg==", "ea3649f2-4bbd-466e-a29c-0f2ff534b2bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d444522c-71c1-4cc9-b815-4ea25a49f17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4186c09-a49b-4c96-9077-163346912981", "AQAAAAIAAYagAAAAEIstddGGDX8WyE3sphtUsmZc6W6xZS68GG9/KtqDKpMBBN54hgPId9WawJ1eOTuYGA==", "3f8183ef-b37a-4d49-b261-fb3409c005f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0d6328d-f003-4bb1-8daa-21dcf49db469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad30c5ff-7a69-4a26-8fc2-a636d1cd842d", "AQAAAAIAAYagAAAAEEOqvB4KAPKhDcXDGhP4npKkSb1ur3VDs93YAq3JtXMe15eD3wRSCnN6O6KIbvvKjg==", "d3256719-9d52-4fe6-9cd1-4a1f505553ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2041514-c5ce-4e68-8956-f92298aa3b74",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce24fb49-973c-45fd-b6b8-fc030c43f78d", "AQAAAAIAAYagAAAAEBJVeYoh0ddgJObPPnIMLb5TiOp4u91BAZ2ashuHx8UWEktKKyOM8Ux17BpYoDCQQg==", "72fff40b-3a77-46d5-84f9-6c3ee2a4479a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01f18d53-ed1d-4f3d-93bb-ff5d859cfba4", "AQAAAAIAAYagAAAAEIjdjdNulvO8qAbh7j+qHEY/QoqXCNwAF97KP/L2TFfgGc9LDoQbdSuyQqlCnh1EXg==", "a883c97d-eaac-4a5b-ba42-8b04fb5f5065" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8d223af-7285-41c5-8c38-9e6989d4410d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aef39274-f2e5-4f6e-88f6-b35e9dd03a54", "AQAAAAIAAYagAAAAEBpXqM8JQt2o74dr/zcSWEzabGejwneT752qBpKugyScedV+kqMsltCiB8DIQE5Z8g==", "648fe05c-550f-4395-bcf8-7840474727f0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58612571-5941-4d44-9323-4751343a565a", "AQAAAAIAAYagAAAAEIdAUUp3l03+ISKoyxGAxHWKUsLeQOg7LPRJrGr4mukudq1ZVMv+hBzxxQFXeFkIzQ==", "bd5fb76f-b35b-46fb-8611-960932d66813" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa360a62-9355-474a-824d-aaa85d9fbd65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "374d884f-c332-4e3b-93a5-6d01ec591c2a", "AQAAAAIAAYagAAAAEGyqa08SVnd+Z6R1dfF/2vtvlTsXrpGLohD8jaSSx0xbhz5h+KaUOBXcaY7rlULHDA==", "8af0e150-f980-43c6-9597-ffec2f620e7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc7c5678-22b4-4650-af6e-4c5f90fa494d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "381b3a0f-2b02-486b-93c9-dcdb44a04906", "AQAAAAIAAYagAAAAEMqDCW563iqbIBNg9jUIrvwH9TazGaqwFovU1n2qyidS6NTKFriC9gD5GL9w5tzuXw==", "07266d14-7b20-448a-a6ef-29e0ea881ab7" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "UsersJobs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16226cef-b670-447e-99a9-b627cb16ae0b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "409f06bd-9769-4e9c-b24c-bf4e132e1d14", "AQAAAAIAAYagAAAAECVQs/McfBf7MC44ML3qSJ7bZjlT2DxZMH8vM2/xWYYiTY26jmpqbQp/4otQV+v52g==", "61567c35-d28c-4ba8-9afd-c4c5db550273" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17585a62-c173-4c68-9e4a-2ba93a419b21",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ec84404-99e4-411d-8812-5221c5db1735", "AQAAAAIAAYagAAAAEBte5k8kZV6pYGVaJgppUdDD3UT8oxMBqikCaNXBDIPTooI4sBIhX/vnP2TEq7r2fg==", "aad7444e-1bd4-40ee-a588-e5ba7e71bd10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21b4ac01-42ec-4df2-b48c-ebe1cf26adf0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f82d7ea-1b31-4c72-a5a2-663f57640963", "AQAAAAIAAYagAAAAELiF+e6SN760iWJXl74iMcz7kNJoHDqvFNLyvTFWEIH+jrv7zEtoGz6zfj7A9Lewew==", "b6e6175b-9ae0-4673-b1ef-8cc80a1a1f2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35e6291c-73f5-48ef-8f3e-5fda2c4ddee1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b8cb88d-518e-4b2a-adbb-d2474ea6675b", "AQAAAAIAAYagAAAAEP75E83lqn6wf475G6JfZBAnz+4I6j777YWzCuxmbz6yWs18Cv6cLg66FuHI36dWpA==", "5005f264-8323-4282-b165-e347c1b7b2e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cf3fb4a-235e-4c93-b66f-c1557006e067",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a749387-b118-49f8-a338-e1e68243a407", "AQAAAAIAAYagAAAAEPcRz5f06HIwhYYvK1vv8xQO069jKIPSlQvtoU8+HbMLEvGh+Lsk2z/yt4YIIJv1Ug==", "a5a87442-4b43-4c18-a4cf-a80dda85add2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "428bcf46-40f2-47b2-ac4a-a49f570178ad",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "194dd72b-7003-41c7-9756-940b2cecf11f", "AQAAAAIAAYagAAAAEF4OBbl3W4NBH9SVcArEZOsk/7HjzG/67Uv/AP2SaZl3AV/qelVZFhIb35/62VvIxQ==", "e3d8f20f-3464-4134-a75d-c58f6e167ba7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "596c6add-eaae-4890-8d4d-38aa5a0671bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a0c92d0-281a-48fb-8efb-ee80d85ae5fe", "AQAAAAIAAYagAAAAELINSVEAHy5E/f3JJjcRnUinfnpW3ekSXgqJe1+KDVL6FGuWLIvTK59hXaLmZl9nDw==", "48e27a99-3575-4384-b107-2a91d20fd794" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a358b17-ffbe-4ac9-8d20-92544e3b739d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04586020-ccc0-442a-bc29-9503f2009f11", "AQAAAAIAAYagAAAAEPOuHvVPD9nDUvrlX/nrn98n0hAHguWVptlpWnAz0LOnqskTzCNuTIG5x9qqhA9wdQ==", "737a28ca-bb82-44e6-bcf5-1faf01c54f83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "723444b3-9434-4465-9044-f7e04fdcca2f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6facd831-46d7-451b-a1dc-6362e849a54c", "AQAAAAIAAYagAAAAEAuXDJwaRDtNfqB5xHivs9u5tKuLo+TxIPCpEeo/XyMmfUZ9ybY8CStvjsfUPTDuew==", "f6a4f1dd-c7f8-43bc-b580-4434ed9d922a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d089603-dc80-415a-913b-f24b1a90b5f1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da7aef93-20a3-46ea-a9d3-f236f52f19e3", "AQAAAAIAAYagAAAAEIAfcE4rC4QW8iVtPCmlME7XIiIt+0kp8svC5gCTDvgu1nOWaZYX4ouSFYqINTxb8Q==", "8a50293a-bede-4fa6-be0e-5a0c485d1310" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dbc12c7-18ec-4af2-a5b7-877ff0df3faf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19616120-c48a-405b-b748-e5111764869d", "AQAAAAIAAYagAAAAEGey8sSjbBledjwDc+UIntHoR59SKOSRmRE4ZUnv3B3s+pcAy0fuNbbfGelWM/Xizg==", "bec7f8c3-1f8b-4f44-9f7f-5c9f7df055d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d0c3b82-be4b-4fdf-834a-8e436176d9bd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a0c3af3-4cae-4dab-af78-c4c47041a02c", "AQAAAAIAAYagAAAAENpnf/gkWeswG7XSxvpm3nMD9wI0qyrXQQmUXaO6CGDsK+SaPHpqFZsfPLrl4Imwgw==", "6f951af7-faf1-4472-843f-e926f91d1bfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e547484-9ea8-45e6-a488-d657f6f1c598",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3e26e6d-97a1-43d1-beac-e743912af271", "AQAAAAIAAYagAAAAEAuqxkqstkKuzClKG1F4+Vlgtgu2g50Erdwn+BSaXpac8cPKSkg8NDevD95OUae7Dw==", "c2d59c47-beb4-4f5b-8bb0-fbf07459eabc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3693b0c-9c11-48ee-a3be-db37d5439ab0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af8474bc-6a1a-45d1-ab66-df058aaebc06", "AQAAAAIAAYagAAAAEIld3qrvEOlpk77Sedi4PcspiCz4EpmpcfDo0Cpc9KZx6EnxzhS/AzJEHJZyJZIafg==", "0325b4f2-06db-48db-b75b-dca8b6dcdf51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b93fa043-cdea-4bd9-9d0b-7b16ee7c5355",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9839902d-80d6-4f43-9e2a-172f00259a1d", "AQAAAAIAAYagAAAAEPN+u0U/l6QHSmlYQ3s86v/O3CKnWeld7Ti2iFXud8fWG2wws7d89OHtzc3LfXZIjw==", "2a974208-6b57-43e9-9427-5e8477c98ebc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca145762-b5db-4836-b963-85eff67fb124",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "804f9c29-c688-463b-8ec3-90c442a82a45", "AQAAAAIAAYagAAAAEAtueyxeVMX/l1MSRRFNCY/VcxgqwF4VsTGblloJFN6gByDynwuYZxF3OUxFepErQQ==", "57bd3e5f-4cde-4547-a55b-b3c51ac771c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d444522c-71c1-4cc9-b815-4ea25a49f17b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c80cc725-ee85-41b3-96a8-c2693a2561e7", "AQAAAAIAAYagAAAAEFLWywcomcFRINqkpLIop3Sp/NKtyiD+hDYowuy2F/CLNX2zDtsjuR6Oe9ebLCmV7w==", "bdc185ae-2dd1-47c3-934f-bbef274d2ee1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0d6328d-f003-4bb1-8daa-21dcf49db469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e04028f-f3a2-43cb-ae6c-8ca62b1e3a6c", "AQAAAAIAAYagAAAAEHeJwosBpiG1i32BW9MgeScNi0ADKGP9Ck3GsWQQdUt6UU6/o2/fqfqZlG5xYnTPKg==", "290ebdd0-74a8-4b1e-8120-0f65b8914e8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2041514-c5ce-4e68-8956-f92298aa3b74",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "581b1c9a-58de-4f40-a624-0a406e21c735", "AQAAAAIAAYagAAAAENu7AYj7t675Bng0rA+pwvx1g5X7aNfZj3vBtgVVcr9E1RNiItziw3FD4y4lOtZxTA==", "0b6bf75c-96c2-490e-813b-d3887bbe4383" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47b8b58-2e3a-4f02-aee5-485d3e6db2b2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc0fb518-5e66-442a-94a3-9dd1513d9c9a", "AQAAAAIAAYagAAAAEAtJuOtaa5dF599yZDxPSUiAcIA1MEF+POFFBu0mybrau9jqNEh06EeYTglLrNdedQ==", "161ca169-eaac-414b-b433-7cd3127e80ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8d223af-7285-41c5-8c38-9e6989d4410d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f19b8b6a-e795-4960-8ca4-1d492332fabb", "AQAAAAIAAYagAAAAEI/y/HGT4iJE6kjD6hH38yyRZ+k9O5nx4iM/6Ij8iTq7OxqZ8kEb6ZzpGaSr4hKa0A==", "28191e23-1c43-4f44-bbff-ddcdf8574f7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb1f5c9f-186b-4a93-a9bd-64a6055c61cd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "967f7ae3-443b-437c-b074-1698aae9ca2a", "AQAAAAIAAYagAAAAEHly0kvOSEDhjgrWy2yMg9tlYJGXl1JdXoiR0naMtxBbLMyidfIASVOcdzuEBSrEzw==", "ed7e2d08-b7ee-4c31-8cfe-43a52083db12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa360a62-9355-474a-824d-aaa85d9fbd65",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da716826-f7dd-4f52-a42b-0ba947a39f06", "AQAAAAIAAYagAAAAEER+li6cPNsaURFtDi+GEoGxHJyzfdk8jfU1e62yQgMjFAXjagFyHVsIAVll6/EurA==", "3ae71ba6-54bf-4e3f-bade-67c4164fbbd1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc7c5678-22b4-4650-af6e-4c5f90fa494d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7213b05d-017e-436d-ad8f-ab038a034057", "AQAAAAIAAYagAAAAEF+/Ht0zbEAKhAq4dEm37RHqdlT4IuBq6Q0LcCgN1jxU23jKlejY9PelY5NTITtqXw==", "ca00318d-a2a3-45dd-b5ec-89b1075b36fd" });
        }
    }
}
