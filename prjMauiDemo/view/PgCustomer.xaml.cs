//using AVFoundation;

using prjMauiDemo.model;
using prjMauiDemo.ViewModel;

namespace prjMauiDemo.view;


//此為:展示層
public partial class PgCustomer : ContentPage
{
    CCustomerViewModel _vm = null; //建立一個CCustomerHome的實體

    
	public PgCustomer()
	{
		InitializeComponent();
        _vm =this.BindingContext as CCustomerViewModel;
        /*_vm = new CCustomerViewModel(); *///並且將製作好的CCutomerHome指定給這個實體

    }


    private void first_Clicked(object sender, EventArgs e)
    {
        _vm.moveFirst(); //在展示層就只需要呼叫邏輯層中所撰寫好的方法就好了
        //displayCustomerInfo();
    }

    private void btnLast_Clicked(object sender, EventArgs e)
    {
        _vm.moveLast();
        //displayCustomerInfo();
    }

    private void btnPrevious_Clicked(object sender, EventArgs e)
    {
        _vm.movePrevious();
        //displayCustomerInfo();
    }

    private void btnNext_Clicked(object sender, EventArgs e)
    {
        _vm.moveNext();
        //displayCustomerInfo();
    }
    //private void displayCustomerInfo()
    //{
    //    CCustomers x = _vm.current;

    //    txtID.Text = x.Id.ToString();
    //    txtName.Text = x.Name;
    //    txtEmail.Text = x.email;
    //    txtPhone.Text = x.phone;
    //    txtAddress.Text = x.address;
    //}

    private void btnSearch_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new PgKeyword());
    }

    private void btnList_Clicked(object sender, EventArgs e)
    {
        App app = Application.Current as App;
        app.allCutomerForList = _vm.all;
        Navigation.PushAsync(new PgList());
    }
    protected override void OnAppearing()//切換表單時呼叫的方法，利用這樣的方法可以要帶入的資料再打開此page時就建立
    {
        base.OnAppearing();
        App app = Application.Current as App;
        if (!string.IsNullOrEmpty(app.keyword))
        {
            if (_vm.queryByKeyword(app.keyword)!=null)
            {
                //displayCustomerInfo();
            }
        }
        if(app.selectedIndexOfCustomer >= 0)
        {
            _vm.moveTo(app.selectedIndexOfCustomer);
            //displayCustomerInfo();
        }
    }
    protected override void OnDisappearing()//同時也可以在page時執行相關的動作
    {
        base.OnDisappearing();
        App app = Application.Current as App;
        app.keyword = "";
        app.selectedIndexOfCustomer = -1;
        _vm.persistant();
    }


}