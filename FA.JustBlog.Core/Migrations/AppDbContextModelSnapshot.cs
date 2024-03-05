﻿// <auto-generated />
using System;
using FA.JustBlog.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FA.JustBlog.Core.Models.Categories", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("37b2a62e-b9b8-456c-bcce-6c30c696575f"),
                            Description = "Written by individuals about their lives, experiences, and thoughts. They can be about anything from daily life to travel to personal growth. Personal blogs are a great way to connect with other people and share your story.",
                            Name = "Personal",
                            UrlSlug = "personal"
                        },
                        new
                        {
                            Id = new Guid("59918479-bfae-4794-8477-b5c0f4ad05e2"),
                            Description = "Written by businesses to promote their products or services. They can also be used to share industry news, educate customers, or build relationships with potential clients. Business blogs are a great way to connect with your target audience and grow your business.",
                            Name = "Business",
                            UrlSlug = "business"
                        },
                        new
                        {
                            Id = new Guid("0549b13b-668a-4556-8176-e3d9abbbbefe"),
                            Description = "Written about a specific topic in great depth. They can be about anything from cooking to fashion to travel. Niche blogs are a great way to become an expert in your field and attract a loyal following of readers.",
                            Name = "Niche",
                            UrlSlug = "Niche"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comments", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CommentHeader")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CommentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("018adb98-88d7-46b8-8e80-d5ce572331d2"),
                            CommentHeader = "Header",
                            CommentText = "A Comment Body",
                            CommentTime = new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8571),
                            Email = "cuongcop@gmail.com",
                            Name = "A Demo Comment 1",
                            PostId = new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede")
                        },
                        new
                        {
                            Id = new Guid("75748d1f-e48e-407e-84bc-1600569d11f5"),
                            CommentHeader = "Header",
                            CommentText = "A Comment Body",
                            CommentTime = new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8575),
                            Email = "bachkhi@gmail.com",
                            Name = "A Demo Comment 2",
                            PostId = new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede")
                        },
                        new
                        {
                            Id = new Guid("6c13902e-8842-4cf6-8f03-194f8218294c"),
                            CommentHeader = "Header",
                            CommentText = "A Comment Body",
                            CommentTime = new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8580),
                            Email = "theanhk2@gmail.com",
                            Name = "A Demo Comment 3",
                            PostId = new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede")
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Posts", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Meta")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PostContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PostedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("UrlSlug")
                        .IsUnique();

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede"),
                            CategoriesId = new Guid("37b2a62e-b9b8-456c-bcce-6c30c696575f"),
                            Meta = "Test",
                            PostContent = "I've always been fascinated by computers. I remember when I was a kid, I would spend hours taking apart and putting together my family's computer. I was always curious about how it worked and how I could make it do different things.\n\nWhen I got to college, I decided to major in computer science. I wanted to learn how to build my own software and create new things. I also wanted to learn how to use computers to solve real-world problems.\n\nLearning to code was challenging at first, but it was also incredibly rewarding. I loved the feeling of accomplishment when I finally figured out how to solve a problem. I also loved the creativity that coding allows. There are so many different ways to solve a problem, and it's always fun to experiment and find new solutions.\n\nCoding has also taught me a lot about problem-solving, critical thinking, and creativity. These are all skills that are valuable in any career, and I'm grateful that I had the opportunity to learn them through coding.\n\nI'm still learning to code, but I've come a long way since I first started. I'm now able to build my own websites and software applications. I'm also able to use coding to solve real-world problems.",
                            PostedOn = new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8403),
                            Published = true,
                            ShortDescription = "If you're thinking about learning to code, I encourage you to go for it! It's a challenging but rewarding experience that will teach you valuable skills that you can use in any career.",
                            Title = "Learning to Code: A Personal Journey",
                            UrlSlug = "post-1"
                        },
                        new
                        {
                            Id = new Guid("8c61ae9e-6ea9-4bfe-bc59-9e75293c3026"),
                            CategoriesId = new Guid("37b2a62e-b9b8-456c-bcce-6c30c696575f"),
                            Meta = "Test",
                            PostContent = "There are a number of things you can do to increase blog traffic in 2023. Here are a few tips:\r\n\r\nWrite high-quality content that is relevant to your target audience. This is the most important thing you can do to attract readers to your blog. Make sure your content is well-written, informative, and engaging.\r\nOptimize your blog posts for search engines. This means using keywords and phrases that your target audience is likely to search for. You can use a tool like Google Keyword Planner to help you find the right keywords.\r\nPromote your blog posts on social media. Share your posts on Facebook, Twitter, LinkedIn, and other social media platforms. You can also use social media to engage with your readers and answer their questions.\r\nGuest blog on other relevant blogs. This is a great way to get your content in front of a new audience. When you guest blog, make sure to include a link back to your own blog in your bio.\r\nRun contests and giveaways. This is a great way to generate excitement for your blog and attract new readers. When you run a contest or giveaway, make sure to promote it on social media and your email list.\r\nUse social media influencers. If you have a budget, you can partner with social media influencers to promote your blog posts. This is a great way to reach a large audience of potential customers.",
                            PostedOn = new DateTime(2023, 8, 14, 8, 7, 57, 922, DateTimeKind.Local).AddTicks(8417),
                            Published = true,
                            ShortDescription = "Blog traffic is essential for any business that wants to grow its online presence. More traffic means more potential customers, and more customers means more sales.",
                            Title = "How to Increase Blog Traffic in 2023",
                            UrlSlug = "post-2"
                        },
                        new
                        {
                            Id = new Guid("45cf481f-d98c-471e-b235-d0a9f3b0cfcb"),
                            CategoriesId = new Guid("59918479-bfae-4794-8477-b5c0f4ad05e2"),
                            Meta = "Test",
                            PostContent = "Here are some additional tips for cooking a perfect steak:\r\n\r\nUse a meat thermometer to check the doneness of the steak. This is the most accurate way to ensure that your steak is cooked to your desired doneness.\r\nDon't overcook the steak! An overcooked steak will be tough and dry.\r\nLet the steak come to room temperature before cooking. This will help to prevent the steak from shrinking and toughening.\r\nDon't crowd the pan or grill. If you cook too many steaks at once, the temperature will drop and the steaks will not cook evenly.\r\nUse a cast iron skillet or grill pan for the best results. These pans retain heat well, which helps to sear the steak and lock in the juices.\r\nServe the steak with your favorite sides. Steak is delicious with mashed potatoes, grilled vegetables, or a salad.\r\nWith these tips, you'll be able to cook a perfect steak every time!\r\n\r\nHere is a bonus tip for cooking a perfect steak:\r\n\r\nUse a cooking spray with avocado oil. Avocado oil has a high smoke point, which means it can withstand high heat without burning. This will help to prevent the steak from sticking to the pan or grill.\r\nI hope these tips help you cook a perfect steak!",
                            PostedOn = new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Published = false,
                            ShortDescription = "Steak is a delicious and versatile dish that can be enjoyed by people of all ages. However, cooking a perfect steak can be tricky. Here are a few tips to help you cook a perfect steak every time",
                            Title = "How to Cook a Perfect Steak",
                            UrlSlug = "post-3"
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTag", b =>
                {
                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTags");

                    b.HasData(
                        new
                        {
                            PostId = new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede"),
                            TagId = new Guid("80fa9998-ca7b-4971-bce1-15f0688034c0")
                        },
                        new
                        {
                            PostId = new Guid("18d6c8da-6d80-4b5c-a94f-66e32835aede"),
                            TagId = new Guid("b32db558-8e83-47f7-94dd-b27678cf98ba")
                        },
                        new
                        {
                            PostId = new Guid("8c61ae9e-6ea9-4bfe-bc59-9e75293c3026"),
                            TagId = new Guid("80fa9998-ca7b-4971-bce1-15f0688034c0")
                        });
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tags", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlSlug")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UrlSlug")
                        .IsUnique();

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80fa9998-ca7b-4971-bce1-15f0688034c0"),
                            Count = 0,
                            Description = "A Demo tag",
                            Name = "Code",
                            UrlSlug = "tag-1"
                        },
                        new
                        {
                            Id = new Guid("ab0cbc9d-14e3-4c3b-a0d7-a28bd2ad471b"),
                            Count = 0,
                            Description = "A Demo tag",
                            Name = "Computer",
                            UrlSlug = "tag-2"
                        },
                        new
                        {
                            Id = new Guid("b32db558-8e83-47f7-94dd-b27678cf98ba"),
                            Count = 0,
                            Description = "A Demo tag",
                            Name = "Traffic",
                            UrlSlug = "tag-3"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Comments", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Posts", "Posts")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Posts", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Categories", "Categories")
                        .WithMany("Posts")
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.PostTag", b =>
                {
                    b.HasOne("FA.JustBlog.Core.Models.Posts", "Posts")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FA.JustBlog.Core.Models.Tags", "Tags")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Posts");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Categories", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Posts", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("FA.JustBlog.Core.Models.Tags", b =>
                {
                    b.Navigation("PostTags");
                });
#pragma warning restore 612, 618
        }
    }
}
