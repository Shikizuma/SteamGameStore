using SteamGameStore.Models;

namespace SteamGameStore.Data
{
    public static class DatabaseMoq
    {
        public static List<GameModel> GameModels { get; set; }

        static DatabaseMoq()
        {
            GameModels = new List<GameModel>()
            {
                new GameModel()
                {

                }
            };
        }
    }
}
