namespace aa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            State.LoadData();
            ShowRounds();
        }

        public void ShowRounds()
        {
            foreach (Round round in Main.Rounds)
            {
                string message = $"Forduló: {round.Turn}\n" +
                    $"{round.HomeTeam.Name} - {round.AwayTeam.Name}\n" +
                    $"{round.HomeTeam.Goals} - {round.AwayTeam.Goals}\n" +
                    $"{round.HomeTeam.HalfTimeGoals} - {round.AwayTeam.HalfTimeGoals}";
                DisplayAlert("Meccs", message, "OK");
            }

        }
        private string allMessages;
        public void Ok(object sender, EventArgs e)
        {
            var no = szam.Text;
            foreach (Round round in Main.Rounds)
            {

                if (round.Turn == int.Parse(no))
                {
                    string message = $"Forduló: {round.Turn}  " +
                        $"{round.HomeTeam.Name} - {round.AwayTeam.Name}  " +
                        $"{round.HomeTeam.Goals} - {round.AwayTeam.Goals}  " +
                        $"{round.HomeTeam.HalfTimeGoals} - {round.AwayTeam.HalfTimeGoals}";
                    allMessages += message + "\n";
                }
            }
            DisplayAlert("Meccs", allMessages, "OK");
        }

        public void Feladat3(object sender, EventArgs e)
        {
            allMessages = "";
            foreach (Round round in Main.Rounds)
            {
                if (round.HomeTeam.HalfTimeGoals < round.AwayTeam.HalfTimeGoals && round.HomeTeam.Goals > round.AwayTeam.Goals)
                {
                    string message = $"Forduló: {round.Turn}  " +
                        $"{round.HomeTeam.Name} - {round.AwayTeam.Name}  " +
                        $"{round.HomeTeam.Goals} - {round.AwayTeam.Goals}  " +
                        $"{round.HomeTeam.HalfTimeGoals} - {round.AwayTeam.HalfTimeGoals}";
                    allMessages += message + "\n";
                }
            }
            DisplayAlert("Meccs", allMessages, "OK");
        }

        public void Feladat4(object sender, EventArgs e)
        {
            allMessages = "";

        }
    }

}
