namespace prjMauiDemo.view;

public partial class PgKeyword : ContentPage
{
	public PgKeyword()
	{
		InitializeComponent();
	}

    private void btnComfirm_Clicked(object sender, EventArgs e)
    {
		(Application.Current as App).keyword = txtKeyword.Text;
		Navigation.PopAsync();
    }
}