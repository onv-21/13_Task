// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Building building = new Building("Город Улан-Удэ, улица Бабушкина, 14а", "24","18","9");
MultiBuilding multiBuilding = new MultiBuilding("Город Улан-Удэ, улица Бабушкина, 14а", "24", "18", "9", "3");
multiBuilding.Print();
class Building
{
    public string Adress { get; set; }
    public string Length { get; set; }
    public string Width { get; set; }
    public string Height { get; set; }
    public Building (string adress, string length, string width, string height)
    {
        Adress = adress;
        Length = length;
        Width = width;
        Height = height;
    }
    public void Print()
    {
        Console.WriteLine("Здание находится по адресу {0}. Длина здания составляет {1} м, ширина здания - {2} м, высота здания - {3}", Adress, Length, Width, Height);
    }
}

sealed class MultiBuilding : Building
{
    public string Floor { get; set; }
    public MultiBuilding (string adress, string length, string width, string height, string floor )
        : base(adress,length,width,height)
    {
        Floor = floor;
    }
    public void Print()
    {
        base.Print();
        Console.WriteLine("Здание находится по адресу {0}. Длина здания составляет {1} м, ширина здания - {2} м, высота здания - {3}. Этажность здания {4}", Adress, Length, Width, Height,Floor);
    }

}