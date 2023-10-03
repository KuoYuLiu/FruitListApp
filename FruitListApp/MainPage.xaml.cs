namespace FruitListApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            List<Fruit> list = new List<Fruit>()
            {
                new Fruit() { Name = "Apple", ImageUrl = "apple.png", Description = "An apple is a sweet, edible fruit produced by an apple tree (Malus domestica)." },
                new Fruit() { Name = "Banana", ImageUrl = "banana.png", Description = "A banana is an edible fruit – botanically a berry – produced by several kinds of large herbaceous flowering plants in the genus Musa." },
                new Fruit() { Name = "Apricot", ImageUrl = "apricot.png", Description = "An apricot is the fruit of many plants of the genus Prunus, and is a fleshy drupe (stone fruit)." },
                new Fruit() { Name = "Kiwi", ImageUrl = "kiwi.png", Description = "The lemon, Citrus limon (L.) Osbeck, is a species of small evergreen tree in the flowering plant family Rutaceae, native to South Asia, primarily North eastern India." },
                new Fruit() { Name = "Mango", ImageUrl = "mango.png", Description = "A mango is a juicy stone fruit (drupe) produced from numerous species of tropical trees belonging to the flowering plant genus Mangifera, cultivated mostly for their edible fruit." },
                new Fruit() { Name = "Pear", ImageUrl = "pear.png", Description = "The pear tree and shrub are a species of genus Pyrus, in the family Rosaceae, bearing the pomaceous fruit of the same name." },
                new Fruit() { Name = "Strawberry", ImageUrl = "strawberry.png", Description = "The garden strawberry (or simply strawberry; Fragaria × ananassa) is a widely grown hybrid species of the genus Fragaria, collectively known as the strawberries." },
                new Fruit() { Name = "Watermelon", ImageUrl = "watermelon.png", Description = "Watermelon (Citrullus lanatus) is a scrambling and trailing vine in the flowering plant family Cucurbitaceae." }
            };

            InitializeComponent();
            FruitListView.ItemsSource = list;
        }

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem == null)
            {
                return;
            }
            var selectedFruit = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedFruit.Name, selectedFruit.ImageUrl, selectedFruit.Description));
        }
    }
}