namespace TigerSoccerClub
{
    public class PlayerData
    {
        public string Name { get; set; }
        public string RegistrationType { get; set; } // Kids or Adult
        public string JerseyChoice { get; set; }     // Yes or No
        public double TotalPrice { get; set; }

        public PlayerData(string name, string registrationType, string jerseyChoice)
        {
            Name = name;
            RegistrationType = registrationType;
            JerseyChoice = jerseyChoice;
        }
    }
}
