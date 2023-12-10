namespace GA_Prog2Editor_DesmondR
{
    public partial class MainPage : ContentPage
    {
        List<string> names = new List<string>();


        public MainPage()
        {
            InitializeComponent();

            names.Add("Desmond");
            names.Add("Manjula");
            names.Add("Kristyn");
            names.Add("Josh");
            names.Add("Will");
            UpdateInfoEditor();
            UpdateCountLabel();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Clicked(object sender, EventArgs e)
        {

        }
    }

}
