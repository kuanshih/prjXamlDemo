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
        App app = Application.Current as App; //�N�ثe���Ϊ�page ���@��app ����̭��A�A�ǥѳo�ӹ��餤���ݩʦs���� �b�إ�page2
        app.userLogined = "Marco";
        Navigation.PushAsync(new Pg2());
    }
}