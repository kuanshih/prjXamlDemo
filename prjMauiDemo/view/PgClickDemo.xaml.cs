namespace prjMauiDemo.NewFolder1;

public partial class PgClickDemo : ContentPage
{
	public PgClickDemo()
	{
		InitializeComponent();
	}

    private void Cul_Clicked(object sender, EventArgs e)
    {
		//����
		double x = double.Parse(a.Text);
		double y = double.Parse(b.Text);
		double z = double.Parse(c.Text);
		double r = y * y - 4 * x * z;
		//�ڸ�
		double d = Math.Sqrt(r);
        //�̫��
        double count1 = (-y + d) / 2 * x;
        double count2 = (-y - d) / 2 * x;

		result.Text = "�ѵ�: " + count1.ToString("0.00") + "��" + count2.ToString("0.0#");

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}