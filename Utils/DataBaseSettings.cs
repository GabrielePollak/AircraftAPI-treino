namespace AircraftAPI.Utils
{
    public class DataBaseSettings : IDataBaseSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string AirCraftCollectionName { get; set; }
    }
}
