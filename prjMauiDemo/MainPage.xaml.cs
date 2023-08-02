namespace prjMauiDemo;

public partial class MainPage : ContentPage
{
	int count = 0;
	int a = 0;
	
	string r = "紅";
	string g = "綠";
	string b = "藍";
	string y = "黃";
	public MainPage()
	{
		InitializeComponent();
        string v = null;
		
		for (int i = 0; i < 4; i++)
		{
            if (i == 0)
            {
                v = "labA";
            }
            if (i == 1)
            {
                v = "labB";
            }
            if (i == 2)
            {
                v = "labC";
            }
            if (i == 3)
            {
                v = "labD";
            }
            CColor(v);

		}
	}

    private void CColor(string A)
    {
        Random Ron = new Random();
        a = Ron.Next(1, 4);
        if (a == 1)
        {
       
        }
        if (a == 2)
        {
     
        }
        if (a == 3)
        {
            
        }
        if (a == 4)
        {
      
        }
    }

    //private void OnCounterClicked(object sender, EventArgs e)
    //{
    //	count++;

    //	if (count == 1)
    //		CounterBtn.Text = $"Clicked {count} time";
    //	else
    //		CounterBtn.Text = $"Clicked {count} times";

    //	SemanticScreenReader.Announce(CounterBtn.Text);
    //}
}

