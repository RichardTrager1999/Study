namespace App.Models;

public class TransferDataModel
{
    public string user_name { get; set; }
    public int ID {get; set; }
    public string IP { get; set; }
    public string OS { get; set; }
    public string Browser { get; set; }
    public Location location { get; set; }
}

public class Location
{
    public string Country { get; set; }
    public string City { get; set; }
    public string Continent { get; set; }
    public int Country_Code { get; set; }
    public int Postal_Code { get; set; }
}