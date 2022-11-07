namespace AircraftAPI.Utils
{
    public interface IDataBaseSettings
    {
       string DatabaseName { get; set; }
       string ConnectionString { get; set; }
       string AirCraftCollectionName { get; set; }
    }
}
