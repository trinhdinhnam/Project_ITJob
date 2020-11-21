using System;
using ITJobProject.Data.Entities;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITJobProject.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: new Guid("2cc0137f-6d98-4119-9824-e7441e69e283"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("04f75755-70f9-4ca7-bea7-c3be358de030"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("a6ef356c-783f-4c1c-b85b-38fc236fa194"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("fc37cb1f-11ef-4c89-b80f-8292d3a28d1f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: new Guid("09caa418-6f56-49eb-8c4f-41751b5c54dd"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: new Guid("18f7c143-d7f7-44c9-9210-942fb21f1015"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: new Guid("66fa5982-9438-4c2a-8af1-734f8af35788"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: new Guid("68f9282e-9ecb-4121-a6cf-d64b58923e2b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("155e240e-5891-4f4f-99a7-f664a5fd9d74"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8c39d631-1e7f-42a2-bef7-3ebc114d1279"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("97c60fc7-3351-4bc4-91ae-b2a4b6127ae6"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("9a40ac15-7aba-429f-9069-b9d0951339cc"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c44854d6-ec9e-4f98-b2a0-325d62439472"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("cb758f32-ae84-4c54-8046-fefa7d93be6b"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f31f1d32-fd47-4fbc-8c11-5d647d030bbc"));

            migrationBuilder.DeleteData(
                table: "RecruiterLevels",
                keyColumn: "RecruiterLevelId",
                keyValue: new Guid("08ed4b1f-f703-4f89-a827-6f216ec9fa52"));

            migrationBuilder.DeleteData(
                table: "RecruiterLevels",
                keyColumn: "RecruiterLevelId",
                keyValue: new Guid("36921dc0-973e-46b6-920a-57ebca02980f"));

            migrationBuilder.DeleteData(
                table: "RecruiterLevels",
                keyColumn: "RecruiterLevelId",
                keyValue: new Guid("379ba608-629f-423d-8b58-9ebce0b02e55"));

            migrationBuilder.DeleteData(
                table: "RecruiterLevels",
                keyColumn: "RecruiterLevelId",
                keyValue: new Guid("f332798a-7ef1-4244-8e29-931d3fe90646"));

            migrationBuilder.DeleteData(
                table: "Recruiters",
                keyColumn: "RecruiterId",
                keyValue: new Guid("487f8b97-c025-4df8-af3e-44e040c20ed9"));

            migrationBuilder.DeleteData(
                table: "Recruiters",
                keyColumn: "RecruiterId",
                keyValue: new Guid("9712376b-5ebf-4748-bcd3-e4d5bcc07c12"));

            migrationBuilder.DeleteData(
                table: "Recruiters",
                keyColumn: "RecruiterId",
                keyValue: new Guid("c424b608-77d6-410a-ac70-ca722655b13b"));

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("2038a645-0889-4043-9f53-330789566ae6"), new Guid("ccafc600-2681-46ce-a648-7c0944879d7b") });

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("62994642-6507-4500-ba6a-b7d45108cdf0"), new Guid("f41d8a9d-a1a0-4a68-a585-8c26f0c6e064") });

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("6b6b9b17-358c-4722-8269-d0b8c02612ec"), new Guid("b5bc2994-5b3a-4a19-8e9b-5ebe0ef574d1") });

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("ce3b493d-d246-48f9-a73e-3fd6d436eba9"), new Guid("30b64d54-813d-44c6-bb2b-42b99f20214c") });

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("cf9e3c57-6333-4b79-bf18-b5db98c7a013"), new Guid("6a23227d-ed51-4abf-9fc6-9e7bd5922381") });

            migrationBuilder.DeleteData(
                table: "Seekers",
                keyColumn: "SeekerId",
                keyValue: new Guid("43fcec85-cded-43c1-a08f-7625bae60df5"));

            migrationBuilder.DeleteData(
                table: "Seekers",
                keyColumn: "SeekerId",
                keyValue: new Guid("7ca4012c-ae12-42bc-b35d-8dd21bc4c65f"));

            migrationBuilder.DeleteData(
                table: "Seekers",
                keyColumn: "SeekerId",
                keyValue: new Guid("f407eb30-1607-49d1-8b81-4166fbe4c59c"));
            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "AdminName", "CreatedBy", "CreatedDate", "Email", "ModifiedBy", "ModifiedDate", "Password", "Phone" },
                values: new object[] { new Guid("03f0df99-4d97-4f67-ab65-2a110ba127fc"), "Trịnh Đình Nam", "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 551, DateTimeKind.Local).AddTicks(5681), "trinhdinhnam16898@gmail.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEPQW1RQ3Z10wfUgue0ZvVrF7VHv07Kqdsh/Omt8RRdXiSSExUs/PKIUsndV87pnugg==", "03095699933" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "CompanyName", "CompanySize", "CreatedBy", "CreatedDate", "Image", "Introduction", "ModifiedBy", "ModifiedDate", "TypeBusiness", "WorkingDay" },
                values: new object[,]
                {
                    { new Guid("851789b8-d0d4-477f-a9ee-1285524c6c46"), "15 Phố Duy Tân, Cầu Giấy, Hà Nội", "Công ty cổ phần MISA", 3000, "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 557, DateTimeKind.Local).AddTicks(4231), "", "Công ty cổ phần MISA là công ty phần mềm Product tạo ra những phần mềm có ứng dụng cao cho các ngành nghề", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Thứ 2 - Thứ 6" },
                    { new Guid("79841e3f-b663-413c-ae9e-96998fe07351"), "Tòa Landmark 72, đường Phạm Hùng, Hà Nội", "Tập toàn viễn thông quân đội Viettel", 25000, "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 557, DateTimeKind.Local).AddTicks(5773), "", "Tập đoàn lớn nhất khu vực về mạng viễn thông", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Thứ 2 - Thứ 6" },
                    { new Guid("909beffe-385e-4c9d-a162-3e42e4b0f11b"), "Số 1, Phạm Văn Bạch, Cầu Giấy, Hà Nội", "Công ty SamSung", 3000, "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 557, DateTimeKind.Local).AddTicks(5810), "", "Công ty SamSung là công ty hàng đầu trong lĩnh vực mạng 4G", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thứ 2 - Thứ 6" }
                });


            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedDate", "Description", "LanguageName", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("8ec487c3-a472-4053-a447-21769efce82f"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(3330), "Ngôn ngữ lập trình Python", "Python", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d8faf22-ddeb-4225-9a07-d1a16703dc43"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(3326), "Ngôn ngữ lập trình Adroid", "Android", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f04dcda0-6877-47d7-8032-0620a09c7c9d"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(3309), "Ngôn ngữ lập trình C/C++", "C/C++", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0415b5e7-99c2-4e39-b245-869ad07cccc7"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(3334), "Ngôn ngữ lập trình front-end Angular", "Angular", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30983d40-6137-4230-8f54-dad02a3faa94"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(3270), "Ngôn ngữ lập trình Java web", "JAVA", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c09cd8e1-2fd5-45e3-90b8-539bdc580f96"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(1626), "Ngôn ngữ lập trình .NET core", "C#/.NET", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c6cd1d7-784b-4d5e-ac8a-a2a10914d501"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(3304), "Ngôn ngữ lập trình Php", "PHP", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RecruiterLevels",
                columns: new[] { "RecruiterLevelId", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "PostNumber", "Price", "RecruiterLevelName" },
                values: new object[,]
                {
                    { new Guid("f2af217b-6676-40e0-8947-34b5fbef5444"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(9074), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 1200000m, "Normal" },
                    { new Guid("41d07fa3-31d3-4d9a-b207-e184758b48d1"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(9015), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 3600000m, "Vip 2" },
                    { new Guid("ab156ed6-ee57-4f67-aa4f-0123493a3856"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(7480), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 4500000m, "Vip 1" },
                    { new Guid("ac4cc259-e36f-46c8-8717-fbf371119849"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 555, DateTimeKind.Local).AddTicks(9068), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 2700000m, "Vip 3" }
                });

            migrationBuilder.InsertData(
                table: "Recruiters",
                columns: new[] { "RecruiterId", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "Gender", "ModifiedBy", "ModifiedDate", "Password", "Phone", "RecruiterLevelId", "RecruiterName" },
                values: new object[,]
                {
                    { new Guid("f7c0bf76-cdfa-4929-ba17-adca7fe45d30"), "ngõ 67, Yên Hòa, Cầu Giấy", "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 558, DateTimeKind.Local).AddTicks(5012), new DateTime(1998, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoang123@gmail.com", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEIgfNKqiKGlMDlT3Fu1/UrzkmsvYRWhu0Pl8CeKc8IpZR+2tGDuIvGhkKlqP+tjNQA==", "03828484844", new Guid("41d07fa3-31d3-4d9a-b207-e184758b48d1"), "Lưu Văn Hoàng" },
                    { new Guid("80270ca1-2383-4863-ab75-e5adea08a004"), "Số 3 Nguyễn Khang, Cầu Giấy", "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 558, DateTimeKind.Local).AddTicks(3268), new DateTime(1997, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuan123@gmail.com", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEC2FbTUz4dMOfsxzDizgPCnl63+hYO6IB4+kv1r6UE0C6upYTszUNgsqEGOhjL2HXA==", "04984842444", new Guid("ab156ed6-ee57-4f67-aa4f-0123493a3856"), "Hoàng Văn Tuấn" },
                    { new Guid("9316f1d8-b533-4299-9b30-6b992e09d5d2"), "số 37, Trương Định, Hai Bà Trưng, Hà Nội", "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 558, DateTimeKind.Local).AddTicks(5048), new DateTime(1996, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "trang3323@gmail.com", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAENc5wiyX+gD9F3IQHSI0w1xHLeQeC2kd41sC16AzaNewSKnJaJA/XqalkqFthuIoXg==", "094838848353", new Guid("ac4cc259-e36f-46c8-8717-fbf371119849"), "Lê Thị Trang" }
                });

           
            migrationBuilder.InsertData(
               table: "Jobs",
               columns: new[] { "JobId", "Address", "AdminId", "CompanyId", "CreatedBy", "CreatedDate", "Description", "EndDateApply", "JobName", "LanguageId", "ModifiedBy", "ModifiedDate", "Possition", "RecruiterId", "Require", "Salary", "StartDateApply" },
               values: new object[,]
               {
                    { new Guid("8aecaa76-f155-4a15-aa2b-2865c1abaf7a"), "Hà Nội", new Guid("03f0df99-4d97-4f67-ab65-2a110ba127fc"), new Guid("851789b8-d0d4-477f-a9ee-1285524c6c46"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 559, DateTimeKind.Local).AddTicks(2577), "Bạn sẽ được đào tạo trong 3 tháng và đánh giá để lên nhân viên chính thức, join vào các dự án thực tế", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thực tập sinh PHP/Laravel", new Guid("8ec487c3-a472-4053-a447-21769efce82f"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thực tập sinh", new Guid("f7c0bf76-cdfa-4929-ba17-adca7fe45d30"), "Yêu cầu thí sinh nắm chắc kiến thức về HTML/CSS, và biết một số framework như Laravel, Magnento càng tốt", 5000000m, new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f471a6b7-3423-4b34-ba04-474e5a8b3c63"), "Hà Nội", new Guid("03f0df99-4d97-4f67-ab65-2a110ba127fc"), new Guid("79841e3f-b663-413c-ae9e-96998fe07351"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 559, DateTimeKind.Local).AddTicks(3706), "Bạn sẽ được thử việc vào dự án trong 2 tháng và được đánh giá lên nhân viên chính thức", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhân viên lập trình front-end Angular", new Guid("2d8faf22-ddeb-4225-9a07-d1a16703dc43"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhân viên", new Guid("80270ca1-2383-4863-ab75-e5adea08a004"), "Yêu cầu chắc kiến thức về HTML/CSS, nắm rõ kiến thức cơ bản về Angular", 12000000m, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90943b5a-9b3b-4906-a6c7-2ddfdd1d4542"), "Đà Nẵng", new Guid("03f0df99-4d97-4f67-ab65-2a110ba127fc"), new Guid("909beffe-385e-4c9d-a162-3e42e4b0f11b"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 559, DateTimeKind.Local).AddTicks(3735), "Bạn sẽ giao làm việc trong dự án quản trị doanh nghiệp với một đội nhân viên theo sự chỉ đạo của bạn", new DateTime(2020, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senior Manager dự án quản trị doanh nghiệp", new Guid("0415b5e7-99c2-4e39-b245-869ad07cccc7"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senior Manager", new Guid("80270ca1-2383-4863-ab75-e5adea08a004"), "Yêu cầu có kinh nghiệm làm việc 2 năm, có khả năng lãnh đạo và tổ chức làm việc teamwork, nhanh nhẹn không ngại vất vả", 27500000m, new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bff35643-ffaf-4104-a0ff-f00214379c84"), "TP Hồ Chí Minh", new Guid("03f0df99-4d97-4f67-ab65-2a110ba127fc"), new Guid("909beffe-385e-4c9d-a162-3e42e4b0f11b"), "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 559, DateTimeKind.Local).AddTicks(3746), "Bạn sẽ làm việc trong một nhóm Java nhỏ, nhanh nhẹn cùng với các chuyên gia Java khác và cùng chúng tôi xây dựng kiến ​​trúc microservices. Phát triển và phát triển tài năng thông qua các chiến lược cố vấn, huấn luyện và giữ chân nhân tài quan trọng trong môi trường kinh tế tăng trưởng nhanh,cạnh tranh cao.", new DateTime(2020, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Junior Software Engineer ", new Guid("c09cd8e1-2fd5-45e3-90b8-539bdc580f96"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Junior", new Guid("80270ca1-2383-4863-ab75-e5adea08a004"), "Yêu cầu đã làm qua các dự án về Java, và có khả năng làm việc nhóm", 25000000m, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
               });
            migrationBuilder.InsertData(
         table: "Seekers",
         columns: new[] { "SeekerId", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "Gender", "ModifiedBy", "ModifiedDate", "Password", "Phone", "SeekerName" },
         values: new object[,]
         {
                    { new Guid("166d3d22-c2b5-4ec1-b2aa-d5f1aa0ad49f"), "Thường Tín, Hà Nội", "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 556, DateTimeKind.Local).AddTicks(5869), new DateTime(1998, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "sang123@gmail.com", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEMTl0ls+Q83SFvgYUVkPcLrm8asIVCcSVY2TxJRe8X3lRvGNSXbr+cUAEQrH62pOfg==", "03949394932", "Phạm Minh Sang" },
                    { new Guid("3b92438b-3f6e-47e6-b599-6739c62a208c"), "Yên Hòa, Cầu Giấy, Hà Nội", "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 556, DateTimeKind.Local).AddTicks(7663), new DateTime(1998, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "hunghp@gmail.com", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEH7PSLXQQj/jAB/x1jRGE18zKjTewhkOeOS1BKZOxMOLAG01G1fQXe0IKkspn9ykIA==", "09493848844", "Hoàng Phi Hùng" },
                    { new Guid("6a3d0283-9cc4-460b-a0a3-f20c1ed3afbb"), "Tạ Quang Bửu, Hai Bà Trưng, Hà Nội", "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 556, DateTimeKind.Local).AddTicks(7701), new DateTime(1997, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "trang123@gmail.com", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAELHFoDDB9Y6Ob43gwS+hYd5zNurvMrBf4kNJ4ahHhz/LFZhli213xChzC3qp0wkZlA==", "07483884835", "Lê Thị Thùy Trang" }
         });
            migrationBuilder.InsertData(
                table: "SeekerJobs",
                columns: new[] { "SeekerId", "JobId", "ApplyDate", "CVLink", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Status" },
                values: new object[] { new Guid("166d3d22-c2b5-4ec1-b2aa-d5f1aa0ad49f"), new Guid("f471a6b7-3423-4b34-ba04-474e5a8b3c63"), new DateTime(2020, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 559, DateTimeKind.Local).AddTicks(7582), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "SeekerJobs",
                columns: new[] { "SeekerId", "JobId", "ApplyDate", "CVLink", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("3b92438b-3f6e-47e6-b599-6739c62a208c"), new Guid("90943b5a-9b3b-4906-a6c7-2ddfdd1d4542"), new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 559, DateTimeKind.Local).AddTicks(7604), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b92438b-3f6e-47e6-b599-6739c62a208c"), new Guid("bff35643-ffaf-4104-a0ff-f00214379c84"), new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 559, DateTimeKind.Local).AddTicks(7617), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
            migrationBuilder.InsertData(
               table: "SeekerJobs",
               columns: new[] { "SeekerId", "JobId", "ApplyDate", "CVLink", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
               values: new object[,]
               {
                    { new Guid("6a3d0283-9cc4-460b-a0a3-f20c1ed3afbb"), new Guid("bff35643-ffaf-4104-a0ff-f00214379c84"), new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 559, DateTimeKind.Local).AddTicks(7608), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a3d0283-9cc4-460b-a0a3-f20c1ed3afbb"), new Guid("90943b5a-9b3b-4906-a6c7-2ddfdd1d4542"), new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 38, 1, 559, DateTimeKind.Local).AddTicks(6588), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
               });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "AdminId",
                keyValue: new Guid("03f0df99-4d97-4f67-ab65-2a110ba127fc"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("79841e3f-b663-413c-ae9e-96998fe07351"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("851789b8-d0d4-477f-a9ee-1285524c6c46"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("909beffe-385e-4c9d-a162-3e42e4b0f11b"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: new Guid("8aecaa76-f155-4a15-aa2b-2865c1abaf7a"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: new Guid("90943b5a-9b3b-4906-a6c7-2ddfdd1d4542"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: new Guid("bff35643-ffaf-4104-a0ff-f00214379c84"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: new Guid("f471a6b7-3423-4b34-ba04-474e5a8b3c63"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("0415b5e7-99c2-4e39-b245-869ad07cccc7"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2d8faf22-ddeb-4225-9a07-d1a16703dc43"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("30983d40-6137-4230-8f54-dad02a3faa94"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("5c6cd1d7-784b-4d5e-ac8a-a2a10914d501"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("8ec487c3-a472-4053-a447-21769efce82f"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c09cd8e1-2fd5-45e3-90b8-539bdc580f96"));

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("f04dcda0-6877-47d7-8032-0620a09c7c9d"));

            migrationBuilder.DeleteData(
                table: "RecruiterLevels",
                keyColumn: "RecruiterLevelId",
                keyValue: new Guid("41d07fa3-31d3-4d9a-b207-e184758b48d1"));

            migrationBuilder.DeleteData(
                table: "RecruiterLevels",
                keyColumn: "RecruiterLevelId",
                keyValue: new Guid("ab156ed6-ee57-4f67-aa4f-0123493a3856"));

            migrationBuilder.DeleteData(
                table: "RecruiterLevels",
                keyColumn: "RecruiterLevelId",
                keyValue: new Guid("ac4cc259-e36f-46c8-8717-fbf371119849"));

            migrationBuilder.DeleteData(
                table: "RecruiterLevels",
                keyColumn: "RecruiterLevelId",
                keyValue: new Guid("f2af217b-6676-40e0-8947-34b5fbef5444"));

            migrationBuilder.DeleteData(
                table: "Recruiters",
                keyColumn: "RecruiterId",
                keyValue: new Guid("80270ca1-2383-4863-ab75-e5adea08a004"));

            migrationBuilder.DeleteData(
                table: "Recruiters",
                keyColumn: "RecruiterId",
                keyValue: new Guid("9316f1d8-b533-4299-9b30-6b992e09d5d2"));

            migrationBuilder.DeleteData(
                table: "Recruiters",
                keyColumn: "RecruiterId",
                keyValue: new Guid("f7c0bf76-cdfa-4929-ba17-adca7fe45d30"));

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("15485aec-dfde-4399-98fc-052e25145662"), new Guid("b074a111-2b3a-472d-837a-fbf4e135c929") });

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("3bdd468a-71aa-417c-a8c0-3550b6b16563"), new Guid("8b6cb7ed-8d21-4409-89e9-32ac5e738196") });

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("b5a62d5c-f51f-4f06-a7ee-0d9d75864a80"), new Guid("9c5516a5-1aa6-4e7a-a5ee-f19de9092809") });

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("b72cbfc1-04d1-4328-afa1-f3a4792276ed"), new Guid("bade0d2d-a8ac-467e-abf3-0ef0efa53356") });

            migrationBuilder.DeleteData(
                table: "SeekerJobs",
                keyColumns: new[] { "SeekerId", "JobId" },
                keyValues: new object[] { new Guid("cfd55f4e-9039-4f5e-abe3-5b118c19c38e"), new Guid("2d5b68f7-8a8f-427a-b736-ed8945f5a33f") });

            migrationBuilder.DeleteData(
                table: "Seekers",
                keyColumn: "SeekerId",
                keyValue: new Guid("166d3d22-c2b5-4ec1-b2aa-d5f1aa0ad49f"));

            migrationBuilder.DeleteData(
                table: "Seekers",
                keyColumn: "SeekerId",
                keyValue: new Guid("3b92438b-3f6e-47e6-b599-6739c62a208c"));

            migrationBuilder.DeleteData(
                table: "Seekers",
                keyColumn: "SeekerId",
                keyValue: new Guid("6a3d0283-9cc4-460b-a0a3-f20c1ed3afbb"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "AdminName", "CreatedBy", "CreatedDate", "Email", "ModifiedBy", "ModifiedDate", "Password", "Phone" },
                values: new object[] { new Guid("2cc0137f-6d98-4119-9824-e7441e69e283"), "Trịnh Đình Nam", "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 72, DateTimeKind.Local).AddTicks(9600), "trinhdinhnam16898@gmail.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123456", "03095699933" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "CompanyName", "CompanySize", "CreatedBy", "CreatedDate", "Image", "Introduction", "ModifiedBy", "ModifiedDate", "TypeBusiness", "WorkingDay" },
                values: new object[,]
                {
                    { new Guid("a6ef356c-783f-4c1c-b85b-38fc236fa194"), "15 Phố Duy Tân, Cầu Giấy, Hà Nội", "Công ty cổ phần MISA", 3000, "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 77, DateTimeKind.Local).AddTicks(2250), "", "Công ty cổ phần MISA là công ty phần mềm Product tạo ra những phần mềm có ứng dụng cao cho các ngành nghề", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Thứ 2 - Thứ 6" },
                    { new Guid("04f75755-70f9-4ca7-bea7-c3be358de030"), "Tòa Landmark 72, đường Phạm Hùng, Hà Nội", "Tập toàn viễn thông quân đội Viettel", 25000, "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 77, DateTimeKind.Local).AddTicks(3265), "", "Tập đoàn lớn nhất khu vực về mạng viễn thông", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Thứ 2 - Thứ 6" },
                    { new Guid("fc37cb1f-11ef-4c89-b80f-8292d3a28d1f"), "Số 1, Phạm Văn Bạch, Cầu Giấy, Hà Nội", "Công ty SamSung", 3000, "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 77, DateTimeKind.Local).AddTicks(3289), "", "Công ty SamSung là công ty hàng đầu trong lĩnh vực mạng 4G", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Thứ 2 - Thứ 6" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "JobId", "Address", "AdminId", "CompanyId", "CreatedBy", "CreatedDate", "Description", "EndDateApply", "JobName", "LanguageId", "ModifiedBy", "ModifiedDate", "Possition", "RecruiterId", "Require", "Salary", "StartDateApply" },
                values: new object[,]
                {
                    { new Guid("68f9282e-9ecb-4121-a6cf-d64b58923e2b"), "Hà Nội", new Guid("e4a7bbc7-b7c0-4d82-b8ce-197155f0dc8d"), new Guid("36b19704-0dfb-402b-bd14-e2edb9e66247"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 78, DateTimeKind.Local).AddTicks(7085), "Bạn sẽ được đào tạo trong 3 tháng và đánh giá để lên nhân viên chính thức, join vào các dự án thực tế", new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thực tập sinh PHP/Laravel", new Guid("0d570ed3-68ea-4266-a0c4-889914c47ee3"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thực tập sinh", new Guid("5d36e7c2-edf9-4cde-96bc-5aff1b7c7b39"), "Yêu cầu thí sinh nắm chắc kiến thức về HTML/CSS, và biết một số framework như Laravel, Magnento càng tốt", 5000000m, new DateTime(2020, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66fa5982-9438-4c2a-8af1-734f8af35788"), "Hà Nội", new Guid("81289ab3-e456-4316-b42c-2db37c5472d2"), new Guid("0ce397b0-e9a9-4593-91d5-5d48645e24df"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 78, DateTimeKind.Local).AddTicks(8168), "Bạn sẽ được thử việc vào dự án trong 2 tháng và được đánh giá lên nhân viên chính thức", new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhân viên lập trình front-end Angular", new Guid("f8e9f376-f90d-4b0d-a1c2-544c768a7d5c"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nhân viên", new Guid("013afe97-7c7e-45f8-b354-563853afd62c"), "Yêu cầu chắc kiến thức về HTML/CSS, nắm rõ kiến thức cơ bản về Angular", 12000000m, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18f7c143-d7f7-44c9-9210-942fb21f1015"), "Đà Nẵng", new Guid("c2f769d1-0758-40c5-bc5c-5a9cbfd99786"), new Guid("f78f9072-c283-430f-9cb4-f62a86442218"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 78, DateTimeKind.Local).AddTicks(8197), "Bạn sẽ giao làm việc trong dự án quản trị doanh nghiệp với một đội nhân viên theo sự chỉ đạo của bạn", new DateTime(2020, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senior Manager dự án quản trị doanh nghiệp", new Guid("308bd5e1-580b-4edf-b884-417b2d1b12e6"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Senior Manager", new Guid("b7e85f58-fbb1-4f44-9e99-a017b83e983d"), "Yêu cầu có kinh nghiệm làm việc 2 năm, có khả năng lãnh đạo và tổ chức làm việc teamwork, nhanh nhẹn không ngại vất vả", 27500000m, new DateTime(2020, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09caa418-6f56-49eb-8c4f-41751b5c54dd"), "TP Hồ Chí Minh", new Guid("da2eaf79-924c-4492-87bd-a4fd67c14374"), new Guid("84ad08f6-14be-4135-92c3-a7ed82eb9b60"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 78, DateTimeKind.Local).AddTicks(8209), "Bạn sẽ làm việc trong một nhóm Java nhỏ, nhanh nhẹn cùng với các chuyên gia Java khác và cùng chúng tôi xây dựng kiến ​​trúc microservices. Phát triển và phát triển tài năng thông qua các chiến lược cố vấn, huấn luyện và giữ chân nhân tài quan trọng trong môi trường kinh tế tăng trưởng nhanh,cạnh tranh cao.", new DateTime(2020, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Junior Software Engineer ", new Guid("63696103-c07b-48c3-a76a-b3ce098978a5"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Junior", new Guid("2ec58fa3-1d57-46ba-a9f3-13a52eab98d0"), "Yêu cầu đã làm qua các dự án về Java, và có khả năng làm việc nhóm", 25000000m, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedDate", "Description", "LanguageName", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("c44854d6-ec9e-4f98-b2a0-325d62439472"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 75, DateTimeKind.Local).AddTicks(7959), "Ngôn ngữ lập trình Python", "Python", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("155e240e-5891-4f4f-99a7-f664a5fd9d74"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 75, DateTimeKind.Local).AddTicks(7944), "Ngôn ngữ lập trình Adroid", "Android", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb758f32-ae84-4c54-8046-fefa7d93be6b"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 75, DateTimeKind.Local).AddTicks(7941), "Ngôn ngữ lập trình C/C++", "C/C++", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97c60fc7-3351-4bc4-91ae-b2a4b6127ae6"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 75, DateTimeKind.Local).AddTicks(7962), "Ngôn ngữ lập trình front-end Angular", "Angular", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f31f1d32-fd47-4fbc-8c11-5d647d030bbc"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 75, DateTimeKind.Local).AddTicks(7912), "Ngôn ngữ lập trình Java web", "JAVA", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c39d631-1e7f-42a2-bef7-3ebc114d1279"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 75, DateTimeKind.Local).AddTicks(6771), "Ngôn ngữ lập trình .NET core", "C#/.NET", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a40ac15-7aba-429f-9069-b9d0951339cc"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 75, DateTimeKind.Local).AddTicks(7938), "Ngôn ngữ lập trình Php", "PHP", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RecruiterLevels",
                columns: new[] { "RecruiterLevelId", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "PostNumber", "Price", "RecruiterLevelName" },
                values: new object[,]
                {
                    { new Guid("379ba608-629f-423d-8b58-9ebce0b02e55"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 76, DateTimeKind.Local).AddTicks(2018), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 1200000m, "Normal" },
                    { new Guid("08ed4b1f-f703-4f89-a827-6f216ec9fa52"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 76, DateTimeKind.Local).AddTicks(1973), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 80, 3600000m, "Vip 2" },
                    { new Guid("36921dc0-973e-46b6-920a-57ebca02980f"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 76, DateTimeKind.Local).AddTicks(937), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, 4500000m, "Vip 1" },
                    { new Guid("f332798a-7ef1-4244-8e29-931d3fe90646"), "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 76, DateTimeKind.Local).AddTicks(2014), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60, 2700000m, "Vip 3" }
                });

            migrationBuilder.InsertData(
                table: "Recruiters",
                columns: new[] { "RecruiterId", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "Gender", "ModifiedBy", "ModifiedDate", "Password", "Phone", "RecruiterLevelId", "RecruiterName" },
                values: new object[,]
                {
                    { new Guid("487f8b97-c025-4df8-af3e-44e040c20ed9"), "ngõ 67, Yên Hòa, Cầu Giấy", "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 78, DateTimeKind.Local).AddTicks(111), new DateTime(1998, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoang123@gmail.com", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123123", "03828484844", new Guid("00000000-0000-0000-0000-000000000000"), "Lưu Văn Hoàng" },
                    { new Guid("c424b608-77d6-410a-ac70-ca722655b13b"), "Số 3 Nguyễn Khang, Cầu Giấy", "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 77, DateTimeKind.Local).AddTicks(9001), new DateTime(1997, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuan123@gmail.com", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "123445", "04984842444", new Guid("00000000-0000-0000-0000-000000000000"), "Hoàng Văn Tuấn" },
                    { new Guid("9712376b-5ebf-4748-bcd3-e4d5bcc07c12"), "số 37, Trương Định, Hai Bà Trưng, Hà Nội", "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 78, DateTimeKind.Local).AddTicks(137), new DateTime(1996, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "trang3323@gmail.com", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "323442", "094838848353", new Guid("00000000-0000-0000-0000-000000000000"), "Lê Thị Trang" }
                });

            migrationBuilder.InsertData(
                table: "SeekerJobs",
                columns: new[] { "SeekerId", "JobId", "ApplyDate", "CVLink", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("cf9e3c57-6333-4b79-bf18-b5db98c7a013"), new Guid("6a23227d-ed51-4abf-9fc6-9e7bd5922381"), new DateTime(2020, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 79, DateTimeKind.Local).AddTicks(2062), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62994642-6507-4500-ba6a-b7d45108cdf0"), new Guid("f41d8a9d-a1a0-4a68-a585-8c26f0c6e064"), new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 79, DateTimeKind.Local).AddTicks(1038), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "SeekerJobs",
                columns: new[] { "SeekerId", "JobId", "ApplyDate", "CVLink", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Status" },
                values: new object[] { new Guid("2038a645-0889-4043-9f53-330789566ae6"), new Guid("ccafc600-2681-46ce-a648-7c0944879d7b"), new DateTime(2020, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 79, DateTimeKind.Local).AddTicks(2030), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "SeekerJobs",
                columns: new[] { "SeekerId", "JobId", "ApplyDate", "CVLink", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("6b6b9b17-358c-4722-8269-d0b8c02612ec"), new Guid("b5bc2994-5b3a-4a19-8e9b-5ebe0ef574d1"), new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 79, DateTimeKind.Local).AddTicks(2058), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce3b493d-d246-48f9-a73e-3fd6d436eba9"), new Guid("30b64d54-813d-44c6-bb2b-42b99f20214c"), new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 79, DateTimeKind.Local).AddTicks(2068), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Seekers",
                columns: new[] { "SeekerId", "Address", "CreatedBy", "CreatedDate", "DateOfBirth", "Email", "Gender", "ModifiedBy", "ModifiedDate", "Password", "Phone", "SeekerName" },
                values: new object[,]
                {
                    { new Guid("43fcec85-cded-43c1-a08f-7625bae60df5"), "Thường Tín, Hà Nội", "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 76, DateTimeKind.Local).AddTicks(6709), new DateTime(1998, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "sang123@gmail.com", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "162661", "03949394932", "Phạm Minh Sang" },
                    { new Guid("7ca4012c-ae12-42bc-b35d-8dd21bc4c65f"), "Yên Hòa, Cầu Giấy, Hà Nội", "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 76, DateTimeKind.Local).AddTicks(7783), new DateTime(1998, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "hunghp@gmail.com", 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "174777", "09493848844", "Hoàng Phi Hùng" },
                    { new Guid("f407eb30-1607-49d1-8b81-4166fbe4c59c"), "Tạ Quang Bửu, Hai Bà Trưng, Hà Nội", "TDNAM", new DateTime(2020, 11, 20, 14, 25, 30, 76, DateTimeKind.Local).AddTicks(7816), new DateTime(1997, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "trang123@gmail.com", 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "838834", "07483884835", "Lê Thị Thùy Trang" }
                });
        }
    }
}
