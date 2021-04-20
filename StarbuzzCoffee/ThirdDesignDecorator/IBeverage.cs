namespace StarbuzzCoffee.ThirdDesignDecorator
{
    public interface IBeverage
    {
        decimal Cost { get; }
        string Description { get; }
        BeverageSize Size { get; set; }
    }
}