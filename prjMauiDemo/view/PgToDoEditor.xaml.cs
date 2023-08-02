using prjMauiDemo.model;

namespace prjMauiDemo.view;

public partial class PgToDoEditor : ContentPage
{
    CToDo _Current;
    public PgToDoEditor()
    {
        InitializeComponent();
    }

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        //���X�y�����N�X,
        int sn = Preferences.Default.Get("count", 0);
        sn++;
        Preferences.Default.Set("count", sn);

        //T,D�[�W�y����sn �@��Key �s�J
        Preferences.Default.Set("T" + sn.ToString(), txtToDo.Text);
        Preferences.Default.Set("D" + sn.ToString(), txtFinishDate.Text);

        //�M�ſ�Jentry
        txtToDo.Text = "";
        txtFinishDate.Text = "";
    }

    private void btnComfirm_Clicked(object sender, EventArgs e)
    {
        if (_Current != null)
        {
            Preferences.Default.Remove("T" + _Current.code.ToString());
            Preferences.Default.Remove("D" + _Current.code.ToString());
        }
        _Current = null;
        txtToDo.Text = "";
        txtFinishDate.Text = "";

    }

    private void btnViewList_Clicked(object sender, EventArgs e)
    {
        int sn = Preferences.Default.Get("count", 0);
        if (sn == 0)
            return;
        List<CToDo> toDos = new List<CToDo>();
        for (int i = 1; i <= sn; i++)
        {
            string keyT = "T" + i.ToString();
            if (Preferences.Default.ContainsKey(keyT))
            {
                CToDo x = new CToDo();
                x.Todo = Preferences.Default.Get(keyT, "");
                x.date = Preferences.Default.Get("D" + i.ToString(), "");
                x.code = i;
                toDos.Add(x);
            }
         

        }
        if (toDos.Count == 0)
            return;
        (Application.Current as App).toDoForList = toDos;
        Navigation.PushAsync(new PgToDoList());
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        App app = Application.Current as App;
        if (app.selectedToDoSn > 0)
        {
            _Current = app.toDoForList.FirstOrDefault(t => t.code == app.selectedToDoSn); //�o�q��linq���g�k �y�����n����������y����
            if(_Current!= null)
            txtToDo.Text = _Current.Todo;
            txtFinishDate.Text = _Current.date;
        }
    }
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        App app = Application.Current as App;
        app.selectedIndexOfCustomer = -1;
    }
}