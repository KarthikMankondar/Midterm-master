public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        this.ItemName = itemName;
        this.ItemId = itemId;
        this.Price = price;
        this.QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        this.Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        this.QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        // Make sure the stock doesn't go negative.
        this.QuantityInStock -= quantitySold;

        if (this.QuantityInStock < 0)
        {
            this.QuantityInStock = 0;
        }
        
    }

    // Check if an item is in stock
    public bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        if(this.QuantityInStock > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // Print item details
    public void PrintDetails()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine("ItemName {0}, ItemId {1}, Price {2}, QuantityInStock {3}", ItemName, ItemId, Price, QuantityInStock);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of InventoryItem
        InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
        InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

        // TODO: Implement logic to interact with these objects.
        // Example tasks:
        // 1. Print details of all items.
        // 2. Sell some items and then print the updated details.
        // 3. Restock an item and print the updated details.
        // 4. Check if an item is in stock and print a message accordingly.
        item1.UpdatePrice(5000.50);
        item1.RestockItem(200);
        item1.SellItem(500);
        Console.WriteLine(item1.IsInStock());
       item1.PrintDetails();

        item2.UpdatePrice(5000.50);
        item2.RestockItem(100);
        item2.SellItem(50);
        Console.WriteLine(item2.IsInStock());
        item2.PrintDetails();
    }
}
