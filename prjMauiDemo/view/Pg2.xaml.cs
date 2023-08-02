namespace prjMauiDemo.view;

public partial class Pg2 : ContentPage
{
	public Pg2()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        App app = Application.Current as App;
        if (!string.IsNullOrEmpty(app.userLogined))
        {
            labName.Text = "�w��"+app.userLogined+"�n�J";
        }
    }
    private void btnGoBack_Click(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}