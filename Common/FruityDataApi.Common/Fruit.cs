namespace FruityDataApi.Common;
public class Fruit
{
    public int Id {get; set;}

    public string Name {get; set;}

    public string Family {get; set;}

    public string Order {get; set;}

    public string Genus {get; set;}

    public Nutrition Nutritions {get; set; }

    public Fruit()
    {
        Nutritions = new Nutrition();
    }
}

public class Nutrition
{
    public int Calories { get; set; }

    public decimal Fat { get; set; }  

    public decimal Sugar { get; set; }

    public decimal Carbohydrates { get; set; }

    public decimal Protien { get; set; }
    
}
