//using Foundation;

namespace prjMauiDemo.view;

public partial class Pgcalc : ContentPage
{
	public Pgcalc()
	{
		InitializeComponent();
	}
	string x;
	double plusTemp;
    private void Number_Click(object sender, EventArgs e)
    {
		Double temp = Convert.ToDouble(labNumber.Text);
		Button btn = sender as Button;
		if(btn != null)
		{
			if(temp == 0)
			{
				labNumber.Text = btn.Text;
			}
			else
			{
				labNumber.Text += btn.Text;
			}
		}

    }

    private void onOperater_Clicked(object sender, EventArgs e)
    {
		x = null;
		plusTemp= Convert.ToDouble(labNumber.Text);
		labNumber.Text = null;
		Button btn = sender as Button;
		if(btn != null)
		{
			x= btn.Text;
		}

    }
    private void Equal_Clicked(object sender, EventArgs e)
    {
        double temp = Convert.ToDouble(labNumber.Text);
        if (x == "+")
		{
			labNumber.Text =(plusTemp + temp).ToString("0.0#");
        }
        else if(x == "-")
        {
            labNumber.Text = (plusTemp - temp).ToString("0.0#");
        }
        else if (x == "x")
        {
            labNumber.Text = (plusTemp * temp).ToString("0.0#");
        }
        else if (x == "/")
        {
            labNumber.Text = (plusTemp / temp).ToString("0.0#");
        }
    }


}