using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTest.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class MyFirstPage
  {
    public MyFirstPage()
    {
      InitializeComponent();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new ListViewPage());
    }
  }
}