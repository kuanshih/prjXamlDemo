//using AVFoundation;
//using Network;
using prjMauiDemo.model;
using prjMauiDemo.ViewModel;

namespace prjMauiDemo.PracticeView;

public partial class PgstockEditor : ContentPage
{

    CStockViewModel _vm = null;
	public PgstockEditor()
	{
		InitializeComponent();
        _vm = new CStockViewModel();
	}

    public void displayStockInfo()
    {
        CStock x = _vm.current;
        txtID.Text = x.Id.ToString();
        txtName.Text = x.Name.ToString();
        txtPrice.Text = x.Price.ToString();
    }

    private void btnfirst_Clicked(object sender, EventArgs e)
    {
        _vm.movefirst();
        displayStockInfo();
    }

    private void btnPrevious_Clicked(object sender, EventArgs e)
    {
        _vm.moveprevious();
        displayStockInfo();
    }

    private void btnNext_Clicked(object sender, EventArgs e)
    {
        _vm.movenext();
        displayStockInfo();
    }

    private void btnLast_Clicked(object sender, EventArgs e)
    {
        _vm.movelast();
        displayStockInfo();
    }

    private void btnSearch_Clicked(object sender, EventArgs e)
    {

    }

    private void btnList_Clicked(object sender, EventArgs e)
    {

    }
}