namespace prjMauiDemo.view;

public partial class Pg1 : ContentPage
{
	public Pg1()
	{
		InitializeComponent();
	}

    private void BtnGoPage2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Pg2());
    }

    private void BtnLogin_Clicked(object sender, EventArgs e)
    {
        App app = Application.Current as App; //將目前應用的page 放到一個app 實體裡面，再藉由這個實體中的屬性存放資料 在建立page2
        app.userLogined = "Marco";
        Navigation.PushAsync(new Pg2());
    }
}