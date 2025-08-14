using System.Collections.ObjectModel;

namespace TestApp.ForCollectionViewBug.Views;

public record ItemData(string Value);

public partial class Bug1Page
{
    private PeriodicTimer? timer;
    private CancellationTokenSource cancel = new();
    
    public ObservableCollection<ItemData> Items { get; } = new();
    
    public Bug1Page()
    {
        InitializeComponent();
    }

    private void OnAddItem(object? sender, EventArgs e)
    {
        Items.Add(new("Some Item a little bit longer"));
    }

    private void OnShowColumn(object? sender, EventArgs e)
    {
        Col3.Width = 200;
    }

    protected override void OnHandlerChanging(HandlerChangingEventArgs args)
    {
        base.OnHandlerChanging(args);
        
        if (args.NewHandler is not null)
        {
            timer ??= new PeriodicTimer(TimeSpan.FromMilliseconds(300));
            var dateStart = DateTimeOffset.Now;
            cancel.Cancel();
            var c = cancel = new CancellationTokenSource();
            
            Task.Run(async () =>
            {
                while (!c.IsCancellationRequested)
                {
                    await MainThread.InvokeOnMainThreadAsync(() =>
                    {
                        TheTimer.Text = (DateTimeOffset.Now - dateStart).ToString("g");
                    });
                    try
                    {
                        await timer.WaitForNextTickAsync(c.Token);
                    }
                    catch (TaskCanceledException)
                    {
                    }
                }
                
                timer.Dispose();
            });
        }
        else
        {
            cancel.Cancel();
        }
    }
}