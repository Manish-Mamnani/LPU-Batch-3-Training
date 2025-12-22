// See https://aka.ms/new-console-template for more information

// IAdd math1 = new MathClass(); // Alok - Add
// IAddSub math2 = new MathClass(); // Riya - Add, Sub
// IAll math3 = new MathClass(); // Sameer - All operations
using InterfaceDemoProj;

//Approach 1 
Product pObj = new Product();

pObj.ProdID = 101;
pObj.Name = "Borosil Flask";
pObj.Price = 850;

//Approach 2 - Object Initializer
Product pObj1 = new Product()
{
    ProdID = 102,
    Name = "Luxor Marker",
    Price = 25
}; 

//Approach 3 - Collection Initializer
List<Product> productList = new List<Product>()
{
    new Product() { ProdID = 103, Name = "Camlin Sketch Pen", Price = 120 },
    new Product() { ProdID = 104, Name = "Dairy Milk", Price = 60 },
    new Product() { ProdID = 105, Name = "Fastrack Watch", Price = 3500 }
};

// foreach(var item in productList)
// {
//     Console.WriteLine($"Product ID: {item.ProdID}, Name: {item.Name}, Price: {item.Price}");
// }

int[] arr = new int[5];
for(int i=0;i<5;i++)
{
    Console.WriteLine(arr[i]);
}