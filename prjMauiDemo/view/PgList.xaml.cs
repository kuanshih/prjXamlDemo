namespace prjMauiDemo.view;

public partial class PgList : ContentPage
{
	public PgList()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        App app = Application.Current as App;
        if(app.allCutomerForList != null)
        {
            lvCustomer.ItemsSource = app.allCutomerForList;
        }
    }

    private void lvCustomer_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        App app = Application.Current as App;
        app.selectedIndexOfCustomer = e.SelectedItemIndex;
        Navigation.PopAsync();
    }
}