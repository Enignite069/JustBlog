using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Data
{
	public static class AppDataInitialiser
	{
		public static void SeedData(this ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Categories>().HasData(
				new Categories
				{
					Id = Guid.Parse("37b2a62e-b9b8-456c-bcce-6c30c696575f"),
					Name = "Personal",
					Description = "Written by individuals about their lives, experiences, and thoughts. They can be about anything from daily life to travel to personal growth. Personal blogs are a great way to connect with other people and share your story.",
					UrlSlug = "personal"
				},
				new Categories
				{
					Id = Guid.Parse("59918479-bfae-4794-8477-b5c0f4ad05e2"),
					Name = "Business",
					Description = "Written by businesses to promote their products or services. They can also be used to share industry news, educate customers, or build relationships with potential clients. Business blogs are a great way to connect with your target audience and grow your business.",
					UrlSlug = "business"
				},
				new Categories
				{
					Id = Guid.Parse("0549b13b-668a-4556-8176-e3d9abbbbefe"),
					Name = "Niche",
					Description = "Written about a specific topic in great depth. They can be about anything from cooking to fashion to travel. Niche blogs are a great way to become an expert in your field and attract a loyal following of readers.",
					UrlSlug = "Niche"
				}
			);

			modelBuilder.Entity<Posts>().HasData(
			new Posts
			{
				Id = Guid.Parse("18d6c8da-6d80-4b5c-a94f-66e32835aede"),
				Title = "Learning to Code: A Personal Journey",
				Meta = "Test",
				UrlSlug = "post-1",
				Published = true,
				PostedOn = DateTime.Now,
				ShortDescription = "If you're thinking about learning to code, I encourage you to go for it! It's a challenging but rewarding experience that will teach you valuable skills that you can use in any career.",
				CategoriesId = Guid.Parse("37b2a62e-b9b8-456c-bcce-6c30c696575f"),
				PostContent = "I've always been fascinated by computers. I remember when I was a kid, I would spend hours taking apart and putting together my family's computer. I was always curious about how it worked and how I could make it do different things.\n\nWhen I got to college, I decided to major in computer science. I wanted to learn how to build my own software and create new things. I also wanted to learn how to use computers to solve real-world problems.\n\nLearning to code was challenging at first, but it was also incredibly rewarding. I loved the feeling of accomplishment when I finally figured out how to solve a problem. I also loved the creativity that coding allows. There are so many different ways to solve a problem, and it's always fun to experiment and find new solutions.\n\nCoding has also taught me a lot about problem-solving, critical thinking, and creativity. These are all skills that are valuable in any career, and I'm grateful that I had the opportunity to learn them through coding.\n\nI'm still learning to code, but I've come a long way since I first started. I'm now able to build my own websites and software applications. I'm also able to use coding to solve real-world problems."
            },
			new Posts
			{
				Id = Guid.Parse("8c61ae9e-6ea9-4bfe-bc59-9e75293c3026"),
				Title = "How to Increase Blog Traffic in 2023",
				Meta = "Test",
				UrlSlug = "post-2",
				Published = true,
				PostedOn = DateTime.Now,
				ShortDescription = "Blog traffic is essential for any business that wants to grow its online presence. More traffic means more potential customers, and more customers means more sales.",
				CategoriesId = Guid.Parse("37b2a62e-b9b8-456c-bcce-6c30c696575f"),
				PostContent = "There are a number of things you can do to increase blog traffic in 2023. Here are a few tips:\r\n\r\nWrite high-quality content that is relevant to your target audience. This is the most important thing you can do to attract readers to your blog. Make sure your content is well-written, informative, and engaging.\r\nOptimize your blog posts for search engines. This means using keywords and phrases that your target audience is likely to search for. You can use a tool like Google Keyword Planner to help you find the right keywords.\r\nPromote your blog posts on social media. Share your posts on Facebook, Twitter, LinkedIn, and other social media platforms. You can also use social media to engage with your readers and answer their questions.\r\nGuest blog on other relevant blogs. This is a great way to get your content in front of a new audience. When you guest blog, make sure to include a link back to your own blog in your bio.\r\nRun contests and giveaways. This is a great way to generate excitement for your blog and attract new readers. When you run a contest or giveaway, make sure to promote it on social media and your email list.\r\nUse social media influencers. If you have a budget, you can partner with social media influencers to promote your blog posts. This is a great way to reach a large audience of potential customers."
            },
			new Posts
			{
				Id = Guid.Parse("45cf481f-d98c-471e-b235-d0a9f3b0cfcb"),
				Title = "How to Cook a Perfect Steak",
				Meta = "Test",
				UrlSlug = "post-3",
				Published = false,
				ShortDescription = "Steak is a delicious and versatile dish that can be enjoyed by people of all ages. However, cooking a perfect steak can be tricky. Here are a few tips to help you cook a perfect steak every time",
				PostedOn = Convert.ToDateTime("2022/04/05"),
				CategoriesId = Guid.Parse("59918479-bfae-4794-8477-b5c0f4ad05e2"),
				PostContent = "Here are some additional tips for cooking a perfect steak:\r\n\r\nUse a meat thermometer to check the doneness of the steak. This is the most accurate way to ensure that your steak is cooked to your desired doneness.\r\nDon't overcook the steak! An overcooked steak will be tough and dry.\r\nLet the steak come to room temperature before cooking. This will help to prevent the steak from shrinking and toughening.\r\nDon't crowd the pan or grill. If you cook too many steaks at once, the temperature will drop and the steaks will not cook evenly.\r\nUse a cast iron skillet or grill pan for the best results. These pans retain heat well, which helps to sear the steak and lock in the juices.\r\nServe the steak with your favorite sides. Steak is delicious with mashed potatoes, grilled vegetables, or a salad.\r\nWith these tips, you'll be able to cook a perfect steak every time!\r\n\r\nHere is a bonus tip for cooking a perfect steak:\r\n\r\nUse a cooking spray with avocado oil. Avocado oil has a high smoke point, which means it can withstand high heat without burning. This will help to prevent the steak from sticking to the pan or grill.\r\nI hope these tips help you cook a perfect steak!"
            }
			);

			modelBuilder.Entity<Tags>().HasData(
			new Tags
			{
				Id = Guid.Parse("80fa9998-ca7b-4971-bce1-15f0688034c0"),
				Name = "Code",
				UrlSlug = "tag-1",
				Description = "A Demo tag"
			},
			new Tags
			{
				Id = Guid.Parse("ab0cbc9d-14e3-4c3b-a0d7-a28bd2ad471b"),
				Name = "Computer",
				UrlSlug = "tag-2",
				Description = "A Demo tag"
			},
			new Tags
			{
				Id = Guid.Parse("b32db558-8e83-47f7-94dd-b27678cf98ba"),
				Name = "Traffic",
				UrlSlug = "tag-3",
				Description = "A Demo tag"
			}
			);

			modelBuilder.Entity<Comments>().HasData(
				new Comments
				{
					Name = "A Demo Comment 1",
					Email = "cuongcop@gmail.com",
					CommentHeader = "Header",
					CommentText = "A Comment Body",
					PostId = Guid.Parse("18d6c8da-6d80-4b5c-a94f-66e32835aede")
				},
				new Comments
				{
					Name = "A Demo Comment 2",
					Email = "bachkhi@gmail.com",
					CommentHeader = "Header",
					CommentText = "A Comment Body",
					PostId = Guid.Parse("18d6c8da-6d80-4b5c-a94f-66e32835aede")
				},
				new Comments
				{
					Name = "A Demo Comment 3",
					Email = "theanhk2@gmail.com",
					CommentHeader = "Header",
					CommentText = "A Comment Body",
					PostId = Guid.Parse("18d6c8da-6d80-4b5c-a94f-66e32835aede")
				}
			);

			modelBuilder.Entity<PostTag>().HasData(
				new PostTag
				{
					PostId = Guid.Parse("18d6c8da-6d80-4b5c-a94f-66e32835aede"),
					TagId = Guid.Parse("80fa9998-ca7b-4971-bce1-15f0688034c0")
				},
				new PostTag
				{
					PostId = Guid.Parse("18d6c8da-6d80-4b5c-a94f-66e32835aede"),
					TagId = Guid.Parse("b32db558-8e83-47f7-94dd-b27678cf98ba")
				},
				new PostTag
				{
					PostId = Guid.Parse("8c61ae9e-6ea9-4bfe-bc59-9e75293c3026"),
					TagId = Guid.Parse("80fa9998-ca7b-4971-bce1-15f0688034c0")
				}
			);
		}
	}
}