namespace TestApp.ForCollectionViewBug;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        UserAppTheme = PlatformAppTheme;
    }

    protected override Window CreateWindow(IActivationState? activationState) =>
        new(new NavigationPage(new MainPage()))
        {
            Title = "CollectionView Bugs"
        };
}