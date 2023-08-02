namespace prjMauiDemo.view;

public partial class PgHttp : ContentPage
{
	public PgHttp()
	{
		InitializeComponent();
	}

    private async void btnHttp_Clicked(object sender, EventArgs e)
    {
		HttpClient client = new HttpClient();
		Uri uri = new Uri("https://udn.com/invoice");
		HttpResponseMessage responce =await client.GetAsync(uri);
		if(responce.IsSuccessStatusCode)
		{
			string html =await responce.Content.ReadAsStringAsync();
			string key = "last-three";
			int start =html.IndexOf(key)+key.Length+2;
			labHttp.Text ="¯S§O¼ú: "+html.Substring(start,8);
		}
    }

    private async void btnTesting_Clicked(object sender, EventArgs e)
    {
		HttpClient client = new HttpClient();
		Uri uri = new Uri("https://www.president.gov.tw/");
		HttpResponseMessage response = await client.GetAsync(uri);
		if (response.IsSuccessStatusCode)
		{
			string html = await response.Content.ReadAsStringAsync();
			
			
			labHttp.Text = html;
		}

    }
}