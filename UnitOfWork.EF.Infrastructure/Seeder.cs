using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.EF.Domain;

namespace UnitOfWork.EF.Infrastructure
{
	public class Seeder
	{
		public static void Seed(DatabaseContext context)
		{
			var laptop = new Product("Laptop");
			context.Products.Add(laptop);
			var laptop_review1 = new ProductReview("Good", laptop.Id);
			context.ProductReviews.Add(laptop_review1);
			var laptop_review2 = new ProductReview("Bad", laptop.Id);
			context.ProductReviews.Add(laptop_review2);
			var laptop_review3 = new ProductReview("Average", laptop.Id);
			context.ProductReviews.Add(laptop_review3);

			var keyboard = new Product("Keyboard");
			context.Products.Add(keyboard);
			var keyboard_review1 = new ProductReview("Good", keyboard.Id);
			context.ProductReviews.Add(keyboard_review1);
			var keyboard_review2 = new ProductReview("Bad", keyboard.Id);
			context.ProductReviews.Add(keyboard_review2);
			var keyboard_review3 = new ProductReview("Average", keyboard.Id);
			context.ProductReviews.Add(keyboard_review3);

			var mouse = new Product("Mouse");
			context.Products.Add(mouse);
			var mouse_review1 = new ProductReview("Good", mouse.Id);
			context.ProductReviews.Add(mouse_review1);
			var mouse_review2 = new ProductReview("Bad", mouse.Id);
			context.ProductReviews.Add(mouse_review2);
			var mouse_review3 = new ProductReview("Average", mouse.Id);
			context.ProductReviews.Add(mouse_review3);

			context.SaveChanges();
		}
	}
}
