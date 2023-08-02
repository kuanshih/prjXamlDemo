namespace prjMauiDemo.NewFolder1;

public partial class PgClickDemo : ContentPage
{
	public PgClickDemo()
	{
		InitializeComponent();
	}

    private void Cul_Clicked(object sender, EventArgs e)
    {
		//取直
		double x = double.Parse(a.Text);
		double y = double.Parse(b.Text);
		double z = double.Parse(c.Text);
		double r = y * y - 4 * x * z;
		//根號
		double d = Math.Sqrt(r);
        //最後值
        double count1 = (-y + d) / 2 * x;
        double count2 = (-y - d) / 2 * x;

		result.Text = "解答: " + count1.ToString("0.00") + "或" + count2.ToString("0.0#");

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}