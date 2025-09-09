namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        // Change fields to properties
        public int GroceryListId { get; set; }  
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public Product Product { get; set; }

        public GroceryListItem(int id, int groceryListId, int productId, int amount)
            : base(id, "") // assuming Model needs id + name
        {
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;

            // Optional: initialize Product with a placeholder
            Product = new Product(0, "None", 0);
        }
    }
}