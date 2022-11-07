using AircraftAPI.Models;
using AircraftAPI.Utils;
using MongoDB.Driver;
using System.Collections.Generic;

namespace AircraftAPI.Services
{
    public class AirCraftServices
    {
        private readonly IMongoCollection<AirCraft> _aircraft;

        public AirCraftServices(IDataBaseSettings settings)
        {
            var aircraft = new MongoClient(settings.ConnectionString);
            var database = aircraft.GetDatabase(settings.DatabaseName);
            _aircraft = database.GetCollection<AirCraft>(settings.AirCraftCollectionName);
        }

        public AirCraft CreateAirCraft(AirCraft aircraft)
        {
            _aircraft.InsertOne(aircraft);
            return aircraft;
        }

        public List<AirCraft>  GetAll() => _aircraft.Find<AirCraft>(aircraft => true).ToList();

        //public List<AirCraft> GetAllByCnpj(stringcompanyCnpj => _aircraft.Company.CNPJ == companyCnpj).ToList(); - Qnd relacionar

        public AirCraft GetOneRAB(string rab) => _aircraft.Find<AirCraft>(aircraft => aircraft.RAB == rab).FirstOrDefault();

        public void RemoveAirCraft(AirCraft aircraftin) => _aircraft.DeleteOne(aircraft => aircraft.RAB == aircraft.RAB);

        public void UpdateAircraft(AirCraft aircraftUP, string rab)
        {
            _aircraft.ReplaceOne(aircraft => aircraft.RAB == rab, aircraftUP);
        }

    }
}
