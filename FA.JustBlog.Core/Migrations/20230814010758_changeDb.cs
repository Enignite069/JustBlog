using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class changeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f685516-1abd-4315-8831-a5a03c58e76f", "017888d8-e46a-4a2f-b207-7df331fe49e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7786d32d-f3eb-444c-bb70-6e8172ab019c", "149d42c3-9385-467c-934b-1d4d18b415b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7786d32d-f3eb-444c-bb70-6e8172ab019c", "3c97c3a6-5626-445c-a7cc-df5da48b7df7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7786d32d-f3eb-444c-bb70-6e8172ab019c", "5d8610ce-c87e-44de-b63d-db947edc8a16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f685516-1abd-4315-8831-a5a03c58e76f", "7ee8dfab-7cf9-4f1b-b9ea-5f92e11af797" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95a1cdb8-09ca-4a78-8e97-23d111568fa8", "c3cb4a1a-eaf3-4f18-9626-2e72301b8bd1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95a1cdb8-09ca-4a78-8e97-23d111568fa8", "d77e4bf3-a0a1-4eb5-9e61-901b51dfcd4d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "95a1cdb8-09ca-4a78-8e97-23d111568fa8", "e52e436f-03f8-4d09-911e-60c7b41e58ab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3f685516-1abd-4315-8831-a5a03c58e76f", "f91b9d5b-cb78-4410-9eda-a085f3219e7b" });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6435e4f7-c437-4b1c-9494-5a6c408d3263"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("863627da-e97c-491e-9d27-0d3165806c5c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("cd5520ac-0ade-430f-920e-f6ac148d8d0c"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f685516-1abd-4315-8831-a5a03c58e76f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7786d32d-f3eb-444c-bb70-6e8172ab019c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95a1cdb8-09ca-4a78-8e97-23d111568fa8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "017888d8-e46a-4a2f-b207-7df331fe49e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "149d42c3-9385-467c-934b-1d4d18b415b5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c97c3a6-5626-445c-a7cc-df5da48b7df7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d8610ce-c87e-44de-b63d-db947edc8a16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ee8dfab-7cf9-4f1b-b9ea-5f92e11af797");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3cb4a1a-eaf3-4f18-9626-2e72301b8bd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d77e4bf3-a0a1-4eb5-9e61-901b51dfcd4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e52e436f-03f8-4d09-911e-60c7b41e58ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f91b9d5b-cb78-4410-9eda-a085f3219e7b");

            migrationBuilder.DropColumn(
                name: "RateCount",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TotalRate",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0549b13b-668a-4556-8176-e3d9abbbbefe"),
                columns: new[] { "Description", "Name", "UrlSlug" },
                values: new object[] { "Written about a specific topic in great depth. They can be about anything from cooking to fashion to travel. Niche blogs are a great way to become an expert in your field and attract a loyal following of readers.", "Niche", "Niche" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37b2a62e-b9b8-456c-bcce-6c30c696575f"),
                columns: new[] { "Description", "Name", "UrlSlug" },
                values: new object[] { "Written by individuals about their lives, experiences, and thoughts. They can be about anything from daily life to travel to personal growth. Personal blogs are a great way to connect with other people and share your story.", "Personal", "personal" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59918479-bfae-4794-8477-b5c0f4ad05e2"),
                columns: new[] { "Description", "Name", "UrlSlug" },
                values: new object[] { "Written by businesses to promote their products or services. They can also be used to share industry news, educate customers, or build relationships with potential clients. Business blogs are a great way to connect with your target audience and grow your business.", "Business", "business" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentHeader", "CommentText", "CommentTime", "Email", "Name", "PostId" },
                values: new object[,]
                {
                    { new Guid("018adb98-88d7-46b8-8e80-d5ce572331d2"), "Header", "A Comment Body", new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8571), "cuongcop@gmail.com", "A Demo Comment 1", new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede") },
                    { new Guid("6c13902e-8842-4cf6-8f03-194f8218294c"), "Header", "A Comment Body", new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8580), "theanhk2@gmail.com", "A Demo Comment 3", new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede") },
                    { new Guid("75748d1f-e48e-407e-84bc-1600569d11f5"), "Header", "A Comment Body", new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8575), "bachkhi@gmail.com", "A Demo Comment 2", new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede") }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede"),
                columns: new[] { "PostContent", "PostedOn", "ShortDescription", "Title" },
                values: new object[] { "I've always been fascinated by computers. I remember when I was a kid, I would spend hours taking apart and putting together my family's computer. I was always curious about how it worked and how I could make it do different things.\n\nWhen I got to college, I decided to major in computer science. I wanted to learn how to build my own software and create new things. I also wanted to learn how to use computers to solve real-world problems.\n\nLearning to code was challenging at first, but it was also incredibly rewarding. I loved the feeling of accomplishment when I finally figured out how to solve a problem. I also loved the creativity that coding allows. There are so many different ways to solve a problem, and it's always fun to experiment and find new solutions.\n\nCoding has also taught me a lot about problem-solving, critical thinking, and creativity. These are all skills that are valuable in any career, and I'm grateful that I had the opportunity to learn them through coding.\n\nI'm still learning to code, but I've come a long way since I first started. I'm now able to build my own websites and software applications. I'm also able to use coding to solve real-world problems.", new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8403), "If you're thinking about learning to code, I encourage you to go for it! It's a challenging but rewarding experience that will teach you valuable skills that you can use in any career.", "Learning to Code: A Personal Journey" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("45cf481f-d98c-471e-b235-d0a9f3b0cfcb"),
                columns: new[] { "PostContent", "ShortDescription", "Title" },
                values: new object[] { "Here are some additional tips for cooking a perfect steak:\r\n\r\nUse a meat thermometer to check the doneness of the steak. This is the most accurate way to ensure that your steak is cooked to your desired doneness.\r\nDon't overcook the steak! An overcooked steak will be tough and dry.\r\nLet the steak come to room temperature before cooking. This will help to prevent the steak from shrinking and toughening.\r\nDon't crowd the pan or grill. If you cook too many steaks at once, the temperature will drop and the steaks will not cook evenly.\r\nUse a cast iron skillet or grill pan for the best results. These pans retain heat well, which helps to sear the steak and lock in the juices.\r\nServe the steak with your favorite sides. Steak is delicious with mashed potatoes, grilled vegetables, or a salad.\r\nWith these tips, you'll be able to cook a perfect steak every time!\r\n\r\nHere is a bonus tip for cooking a perfect steak:\r\n\r\nUse a cooking spray with avocado oil. Avocado oil has a high smoke point, which means it can withstand high heat without burning. This will help to prevent the steak from sticking to the pan or grill.\r\nI hope these tips help you cook a perfect steak!", "Steak is a delicious and versatile dish that can be enjoyed by people of all ages. However, cooking a perfect steak can be tricky. Here are a few tips to help you cook a perfect steak every time", "How to Cook a Perfect Steak" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8c61ae9e-6ea9-4bfe-bc59-9e75293c3026"),
                columns: new[] { "PostContent", "PostedOn", "ShortDescription", "Title" },
                values: new object[] { "There are a number of things you can do to increase blog traffic in 2023. Here are a few tips:\r\n\r\nWrite high-quality content that is relevant to your target audience. This is the most important thing you can do to attract readers to your blog. Make sure your content is well-written, informative, and engaging.\r\nOptimize your blog posts for search engines. This means using keywords and phrases that your target audience is likely to search for. You can use a tool like Google Keyword Planner to help you find the right keywords.\r\nPromote your blog posts on social media. Share your posts on Facebook, Twitter, LinkedIn, and other social media platforms. You can also use social media to engage with your readers and answer their questions.\r\nGuest blog on other relevant blogs. This is a great way to get your content in front of a new audience. When you guest blog, make sure to include a link back to your own blog in your bio.\r\nRun contests and giveaways. This is a great way to generate excitement for your blog and attract new readers. When you run a contest or giveaway, make sure to promote it on social media and your email list.\r\nUse social media influencers. If you have a budget, you can partner with social media influencers to promote your blog posts. This is a great way to reach a large audience of potential customers.", new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8417), "Blog traffic is essential for any business that wants to grow its online presence. More traffic means more potential customers, and more customers means more sales.", "How to Increase Blog Traffic in 2023" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("80fa9998-ca7b-4971-bce1-15f0688034c0"),
                column: "Name",
                value: "Code");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ab0cbc9d-14e3-4c3b-a0d7-a28bd2ad471b"),
                column: "Name",
                value: "Computer");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b32db558-8e83-47f7-94dd-b27678cf98ba"),
                column: "Name",
                value: "Traffic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("018adb98-88d7-46b8-8e80-d5ce572331d2"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("6c13902e-8842-4cf6-8f03-194f8218294c"));

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: new Guid("75748d1f-e48e-407e-84bc-1600569d11f5"));

            migrationBuilder.AddColumn<double>(
                name: "RateCount",
                table: "Posts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalRate",
                table: "Posts",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3f685516-1abd-4315-8831-a5a03c58e76f", "c0e14bba-55cf-4905-a7f9-97a7e996e2ab", "Contributor", "CONTRIBUTOR" },
                    { "7786d32d-f3eb-444c-bb70-6e8172ab019c", "0ddae8d1-8569-4442-a108-0f60b0061978", "Blog Owner", "BLOG OWNER" },
                    { "95a1cdb8-09ca-4a78-8e97-23d111568fa8", "c4156964-e88c-44c4-b866-96445fc5bbcc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "017888d8-e46a-4a2f-b207-7df331fe49e4", 0, "307e1b30-71f5-4e34-a77c-36b26b9a6a80", "BlogUsers", "contributor2@localhost.com", false, "System", "Contributor 2", false, null, "CONTRIBUTOR2@LOCALHOST.COM", "CONTRIBUTOR2@LOCALHOST.COM", "AQAAAAEAACcQAAAAEH35EXlmVHzUXmheu/ZzH4xPneVKtivIYHJ3ssWjfKGisj2VhZIVBjJIUHTqyaDtxQ==", null, false, "26aa2b77-4d7b-46a7-b21d-c329bc2a3077", false, "contributor2@localhost.com" },
                    { "149d42c3-9385-467c-934b-1d4d18b415b5", 0, "2a737093-bf1a-4410-848b-237c15127739", "BlogUsers", "mod2@localhost.com", false, "System", "Administrator 3", false, null, "MOD2@LOCALHOST.COM", "MOD2@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFeB4mAKFp0S/Apn1EQwgsKEjVu5Ll3ff1I3DtFM02nYO2+RhBRyT/5icZRxPsy1Pg==", null, false, "3c86a064-372c-4129-8c42-b078d51294af", false, "mod2@localhost.com" },
                    { "3c97c3a6-5626-445c-a7cc-df5da48b7df7", 0, "4dbfad5b-828f-49f7-8685-cc967abe38d3", "BlogUsers", "mod1@localhost.com", false, "System", "Administrator 2", false, null, "MOD1@LOCALHOST.COM", "MOD1@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOjmt91aYepOfX8vQ4IpcRvpO0+YncpXSxN0Uw7z/yBv0W8nQ4b888Qn5YATFiu3PA==", null, false, "7740a616-3fd1-4491-9a98-d82c6f09a7a1", false, "mod1@localhost.com" },
                    { "5d8610ce-c87e-44de-b63d-db947edc8a16", 0, "a6020c1a-826d-407d-a5c0-80f27f24ab95", "BlogUsers", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEBr8sA8tqxl6WqJV14opWs/0QCWrF1O4vly0Q+ZqXnSMWSut0NHA+6vUPY+fYq/Zgw==", null, false, "0646b46b-f61b-4d14-94c6-006e9a731f62", false, "admin@localhost.com" },
                    { "7ee8dfab-7cf9-4f1b-b9ea-5f92e11af797", 0, "c923fb17-fb12-418c-a3b0-9775b471abbc", "BlogUsers", "contributor3@localhost.com", false, "System", "Contributor 3", false, null, "CONTRIBUTOR3@LOCALHOST.COM", "CONTRIBUTOR3@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDuuwL9ui5DnaVXdZGdVNns47VSXiNl5XaUvJB/uc0G4Lx7EmAsShV2qdpxXjoEgGw==", null, false, "b074a947-5f19-4ddb-928a-f34c97fdbb92", false, "contributor3@localhost.com" },
                    { "c3cb4a1a-eaf3-4f18-9626-2e72301b8bd1", 0, "a13dd5c1-7b8b-4c55-9e21-632dcfa87904", "BlogUsers", "user3@localhost.com", false, "System", "User 3", false, null, "USER3@LOCALHOST.COM", "USER3@LOCALHOST.COM", "AQAAAAEAACcQAAAAEHLDklm685LD658LfYr83iQ35tailTo2ADCroTsfFaMl9uJTJXcZtOVjSjZ0tYAT9Q==", null, false, "015115de-e54b-44ed-9680-851d85d2b0f5", false, "user3@localhost.com" },
                    { "d77e4bf3-a0a1-4eb5-9e61-901b51dfcd4d", 0, "7f8c3f34-15a3-4a67-95a2-43648f55a2ab", "BlogUsers", "user2@localhost.com", false, "System", "User 2", false, null, "USER2@LOCALHOST.COM", "USER2@LOCALHOST.COM", "AQAAAAEAACcQAAAAEJB9DHOv4gwT6641cfUTF8u5bFiktX0MIMzUtIl7jaPj/xFvq28TdTTv9ObOKfztNg==", null, false, "1ce046ad-86b2-448b-aea6-2afc2efb8a1e", false, "user2@localhost.com" },
                    { "e52e436f-03f8-4d09-911e-60c7b41e58ab", 0, "83a63ce4-b776-4d1b-880e-4be7e553ffff", "BlogUsers", "user1@localhost.com", false, "System", "User 1", false, null, "USER1@LOCALHOST.COM", "USER1@LOCALHOST.COM", "AQAAAAEAACcQAAAAEOmjcaGVV2uAoQKpFL7iP5i89XAYhqdZ5pPS6ssUKI8nnXev0mRF8YLRWfpsQRcHww==", null, false, "cff39f41-a66e-4a64-9a5d-71e9e66f10fe", false, "user1@localhost.com" },
                    { "f91b9d5b-cb78-4410-9eda-a085f3219e7b", 0, "a97dc22a-767d-40f1-b1ad-e590ef538431", "BlogUsers", "contributor@localhost.com", false, "System", "Contrubutor 1", false, null, "CONTRIBUTOR@LOCALHOST.COM", "CONTRIBUTOR@LOCALHOST.COM", "AQAAAAEAACcQAAAAEMfmjKM4fxdYLD+h6CIfSKLUEwMpu2OSjKq2+/xRLzKYqm2XcV40NCEo1gV44SAwnw==", null, false, "a9cc2618-8580-4076-b1ed-1227907b43c0", false, "contributor@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0549b13b-668a-4556-8176-e3d9abbbbefe"),
                columns: new[] { "Description", "Name", "UrlSlug" },
                values: new object[] { "Demo category", "Category 3", "cat-3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37b2a62e-b9b8-456c-bcce-6c30c696575f"),
                columns: new[] { "Description", "Name", "UrlSlug" },
                values: new object[] { "Demo category", "Category 1", "cat-1" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59918479-bfae-4794-8477-b5c0f4ad05e2"),
                columns: new[] { "Description", "Name", "UrlSlug" },
                values: new object[] { "Demo category", "Category 2", "cat-2" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CommentHeader", "CommentText", "CommentTime", "Email", "Name", "PostId" },
                values: new object[,]
                {
                    { new Guid("6435e4f7-c437-4b1c-9494-5a6c408d3263"), "Header", "A Comment Body", new DateTime(2022, 10, 4, 22, 24, 31, 911, DateTimeKind.Local).AddTicks(6114), "binhtruong@gmail.com", "A Demo Comment 1", new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede") },
                    { new Guid("863627da-e97c-491e-9d27-0d3165806c5c"), "Header", "A Comment Body", new DateTime(2022, 10, 4, 22, 24, 31, 911, DateTimeKind.Local).AddTicks(6120), "binhtruong@gmail.com", "A Demo Comment 2", new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede") },
                    { new Guid("cd5520ac-0ade-430f-920e-f6ac148d8d0c"), "Header", "A Comment Body", new DateTime(2022, 10, 4, 22, 24, 31, 911, DateTimeKind.Local).AddTicks(6122), "binhtruong@gmail.com", "A Demo Comment 3", new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede") }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede"),
                columns: new[] { "PostContent", "PostedOn", "RateCount", "ShortDescription", "Title", "TotalRate", "ViewCount" },
                values: new object[] { "A whatever text here", new DateTime(2022, 10, 4, 22, 24, 31, 911, DateTimeKind.Local).AddTicks(5867), 4.5, "A Short Desc", "A Post number 1", 50.0, 100 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("45cf481f-d98c-471e-b235-d0a9f3b0cfcb"),
                columns: new[] { "PostContent", "ShortDescription", "Title" },
                values: new object[] { "A whatever text here", "A Short Desc", "A Post number 3" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8c61ae9e-6ea9-4bfe-bc59-9e75293c3026"),
                columns: new[] { "PostContent", "PostedOn", "RateCount", "ShortDescription", "Title", "TotalRate", "ViewCount" },
                values: new object[] { "A whatever text here", new DateTime(2022, 10, 4, 22, 24, 31, 911, DateTimeKind.Local).AddTicks(5883), 4.5, "A Short Desc", "A Post number 2", 50.0, 100 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("80fa9998-ca7b-4971-bce1-15f0688034c0"),
                column: "Name",
                value: "Tag1");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ab0cbc9d-14e3-4c3b-a0d7-a28bd2ad471b"),
                column: "Name",
                value: "Tag2");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b32db558-8e83-47f7-94dd-b27678cf98ba"),
                column: "Name",
                value: "Tag3");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3f685516-1abd-4315-8831-a5a03c58e76f", "017888d8-e46a-4a2f-b207-7df331fe49e4" },
                    { "7786d32d-f3eb-444c-bb70-6e8172ab019c", "149d42c3-9385-467c-934b-1d4d18b415b5" },
                    { "7786d32d-f3eb-444c-bb70-6e8172ab019c", "3c97c3a6-5626-445c-a7cc-df5da48b7df7" },
                    { "7786d32d-f3eb-444c-bb70-6e8172ab019c", "5d8610ce-c87e-44de-b63d-db947edc8a16" },
                    { "3f685516-1abd-4315-8831-a5a03c58e76f", "7ee8dfab-7cf9-4f1b-b9ea-5f92e11af797" },
                    { "95a1cdb8-09ca-4a78-8e97-23d111568fa8", "c3cb4a1a-eaf3-4f18-9626-2e72301b8bd1" },
                    { "95a1cdb8-09ca-4a78-8e97-23d111568fa8", "d77e4bf3-a0a1-4eb5-9e61-901b51dfcd4d" },
                    { "95a1cdb8-09ca-4a78-8e97-23d111568fa8", "e52e436f-03f8-4d09-911e-60c7b41e58ab" },
                    { "3f685516-1abd-4315-8831-a5a03c58e76f", "f91b9d5b-cb78-4410-9eda-a085f3219e7b" }
                });
        }
    }
}
