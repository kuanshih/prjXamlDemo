using prjMauiDemo.NewFolder2;

namespace prjMauiDemo.NewFolder1;

public partial class PGLotto : ContentPage
{
	public PGLotto()
	{
		InitializeComponent();
		labText.Text = (new CLotto()).getNumber();//�n���g�{����k�O�n�N�{���g�����O�A�A�N��k�g�b�����O�����I�s
    }
}