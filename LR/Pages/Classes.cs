namespace RestaurantApp.Pages
{
    public class Dish
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Category
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
    