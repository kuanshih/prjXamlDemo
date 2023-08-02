using prjMauiDemo.NewFolder2;

namespace prjMauiDemo.NewFolder1;

public partial class PGLotto : ContentPage
{
	public PGLotto()
	{
		InitializeComponent();
		labText.Text = (new CLotto()).getNumber();//好的寫程式方法是要將程式寫成類別，再將方法寫在此類別中做呼叫
    }
}