

namespace prjMauiDemo;
using NewFolder1;
using prjMauiDemo.model;
using prjMauiDemo.PracticeView;
using prjMauiDemo.view;

public partial class App : Application
{

	//這邊用到很重要的觀念，如果是page間要傳遞資料，就需要在管理員(這一頁)，建立屬性，這樣就可以在各個表單呼叫(
	//呼叫的方法，需要先建立App app = Application.Current as App   app.就可以點到這邊建立的屬性
	public string userLogined { get; set; }
	public string keyword { get; set; }

    public int selectedIndexOfCustomer { get; set; }
    public int selectedToDoSn { get; set; }
    public List<CCustomers> allCutomerForList { get; set; }

    public List<CToDo> toDoForList { get; set; }
    public App()
	{
		InitializeComponent();
        MainPage = new NavigationPage(new PgHttp());
        /*MainPage = new NavigationPage(new PgstockEditor()); *///進入點 先建立 導覽頁面在建立頁面
        selectedIndexOfCustomer = -1; //這個值是用來控制從pglist跳還得值，因此一開始要預設-1才不會一開始就啟動跳出錯誤(當然也需要設定對應的if條件是)
		selectedToDoSn = -1;
    

}
}
