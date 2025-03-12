namespace layout
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            int count = 0;

            var layout = new VerticalStackLayout { Spacing = 30, Padding = new Thickness(15) };

            layout.Children.Add(new Label { Text = "Tekst 1", FontSize = 20 });

            layout.Children.Add(new Label { Text = "Tekst 2", FontSize = 20 });
            var button1 = new Button { Text = "Kliknij mnie" };
            button1.Clicked += (sender, args) =>
            {
                Application.Current.MainPage.DisplayAlert("Kliknięcie", "Przycisk został kliknięty!", "OK");
            };
            layout.Children.Add(button1);
            var button2 = new Button { Text = "Kliknij" };
            button2.Clicked += (sender, args) =>
            {
                Application.Current.MainPage.DisplayAlert("Pyk", "TomaszOłów", "Nie");
            };
            layout.Children.Add(button2);
            var button3 = new Button { Text = "Napis" };
            button3.Clicked += (sender, args) =>
            {
                Application.Current.MainPage.DisplayAlert("Napis", "Napis", "Napis");
            };
            layout.Children.Add(button3);
            for (int i = 0; i < 5; i++)
            {
                layout.Children.Add(new Label { Text = (i+1).ToString(), FontSize = 20 });

            }






            Content = layout;
        }

        //        <VerticalStackLayout Spacing = "10" >
        //    < HorizontalStackLayout Spacing="10">
        //        <Image Source = "dotnet_bot.png" />
        //        < Label Text="Obrazek z tekstem" />
                

        //    </HorizontalStackLayout>
        //    <Label Text = "Kolejny element" />
        //    < Button />
        //    < Button />
        //    < Button />
        //</ VerticalStackLayout >
    }

}
