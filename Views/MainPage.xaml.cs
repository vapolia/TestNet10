namespace TestApp.ForCollectionViewBug.Views;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Bug1_OnClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Bug1Page());
    }
}