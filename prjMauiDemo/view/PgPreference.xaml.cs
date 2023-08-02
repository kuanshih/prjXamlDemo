namespace prjMauiDemo.view;

public partial class PgPreference : ContentPage
{
	public PgPreference()
	{
		InitializeComponent();
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        //存入
        Preferences.Default.Set("KK",txtSet.Text);
    }

    private void btnRead_Clicked(object sender, EventArgs e)
    {
        //提取
        labGet.Text = Preferences.Default.Get("KK", "---");
    }
}