//using AVFoundation;

using prjMauiDemo.model;
using prjMauiDemo.ViewModel;

namespace prjMauiDemo.view;


//����:�i�ܼh
public partial class PgCustomer : ContentPage
{
    CCustomerViewModel _vm = null; //�إߤ@��CCustomerHome������

    
	public PgCustomer()
	{
		InitializeComponent();
        _vm =this.BindingContext as CCustomerViewModel;
        /*_vm = new CCustomerViewModel(); *///�åB�N�s�@�n��CCutomerHome���w���o�ӹ���

    }


    private void first_Clicked(object sender, EventArgs e)
    {
        _vm.moveFirst(); //�b�i�ܼh�N�u�ݭn�I�s�޿�h���Ҽ��g�n����k�N�n�F
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
    protected override void OnAppearing()//�������ɩI�s����k�A�Q�γo�˪���k�i�H�n�a�J����ƦA���}��page�ɴN�إ�
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
    protected override void OnDisappearing()//�P�ɤ]�i�H�bpage�ɰ���������ʧ@
    {
        base.OnDisappearing();
        App app = Application.Current as App;
        app.keyword = "";
        app.selectedIndexOfCustomer = -1;
        _vm.persistant();
    }


}