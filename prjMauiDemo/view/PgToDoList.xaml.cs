using prjMauiDemo.model;

namespace prjMauiDemo.view;

public partial class PgToDoList : ContentPage
{
	public PgToDoList()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        App app = Application.Current as App;
        if(app.toDoForList != null)
        {
            //lvtodo.ItemsSource = app.toDoForList;
            cvtodo.ItemsSource = app.toDoForList;
        }
    }
    private void lvtodo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        (Application.Current as App).selectedToDoSn = e.SelectedItemIndex;
        Navigation.PopAsync();
    }



    private void cvtodo_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        App app =Application.Current as App;
        app.selectedToDoSn = (e.CurrentSelection.FirstOrDefault() as CToDo).code; //為了樣讓流水號放進去
        Navigation.PopAsync();
    }
}