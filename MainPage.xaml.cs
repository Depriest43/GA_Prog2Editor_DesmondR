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

        private void buttonAdd_Clicked(object sender, EventArgs e)
        {
            names.Add(entryName.Text); 
            UpdateInfoEditor(); 
            UpdateCountLabel();
        }

        private void buttonUpdate_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(entryIndex.Text, out int index) && index >= 0 && index < names.Count)
            {
                names[index] = entryName.Text; 
                UpdateInfoEditor(); 
            }
            names[index] = entryName.Text; 
            UpdateInfoEditor(); 
                               }

            private void buttonInsert_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(entryIndex.Text, out int index) && index >= 0 && index <= names.Count)
            {
                names.Insert(index, entryName.Text); 
                UpdateInfoEditor(); 
                UpdateCountLabel(); 
            }
        }

        private void buttonRemove_Clicked(object sender, EventArgs e)
{
            if (int.TryParse(entryIndex.Text, out int index) && index >= 0 && index < names.Count)
            {
                names.RemoveAt(index); // Remove the name at the specified index
                UpdateInfoEditor(); // Update the editor to display the new list
                UpdateCountLabel(); // Update the count label
            }
        }
        private void buttonClear_Clicked(object sender, EventArgs e)
        {
            names.Clear();
            UpdateInfoEditor();
            UpdateCountLabel();
        }
            private void UpdateInfoEditor()
                {
                editorInfo.Text = ""; // Clear the current text
            foreach (var name in names) ; 
            }
        
                        private void UpdateCountLabel()
                        {
                            
                            labelCount.Text = $"Count: {names.Count}";
                        }
                    


    }
}