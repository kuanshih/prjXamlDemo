using System.Text;

namespace prjMauiDemo.view;

public partial class PgFile : ContentPage
{
	public PgFile()
	{
		InitializeComponent();
	}

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine(folder, "hello.txt");
        File.WriteAllText(path, txtSet.Text,Encoding.UTF8);
    }

    private void btnRead_Clicked(object sender, EventArgs e)
    {
        string folder =Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string path = Path.Combine(folder, "hello.txt");
        labGet.Text =File.ReadAllText(path, Encoding.UTF8);
    }
}