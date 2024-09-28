using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace RestaurantApp.Pages
{
    public class MenuModel : PageModel
    {
        public List<Category> Menu { get; set; }

        public void OnGet()
        {
            Menu = new List<Category>
            {
                new Category
                {
                    Name = "Appetizers",
                    Dishes = new List<Dish>
                    {
                        new Dish
                        {
                            Name = "Bruschetta",
                            Description = "Grilled bread with tomatoes",
                            Price = 6.99m,
                            ImageUrl = "/images/bruschetta.jpg" 
                        },
                        new Dish
                        {
                            Name = "Stuffed Mushrooms",
                            Description = "Mushrooms filled with cheese",
                            Price = 8.50m,
                            ImageUrl = "/images/stuffed_mushrooms.jpg"
                        }
                    }
                },
                new Category
                {
                    Name = "Main Courses",
                    Dishes = new List<Dish>
                    {
                        new Dish
                        {
                            Name = "Grilled Salmon",
                            Description = "Served with lemon and herbs",
                            Price = 15.99m,
                            ImageUrl = "/images/grilled_salmon.jpg"
                        },
                        new Dish
                        {
                            Name = "Pasta Carbonara",
                            Description = "Pasta with creamy sauce",
                            Price = 12.99m,
                            ImageUrl = "/images/pasta_carbonara.jpg"
                        }
                    }
                },
                new Category
                {
                    Name = "Desserts",
                    Dishes = new List<Dish>
                    {
                        new Dish
                        {
                            Name = "Cheesecake",
                            Description = "New York style cheesecake",
                            Price = 5.99m,
                            ImageUrl = "/images/cheesecake.jpg"
                        },
                        new Dish
                        {
                            Name = "Tiramisu",
                            Description = "Italian coffee-flavored dessert",
                            Price = 6.50m,
                            ImageUrl = "/images/tiramisu.jpg"
                        }
                    }
                }
            };
        }

    }
}
