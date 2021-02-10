using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTest.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace XamarinTest
{
  public partial class App
  {
    public App()
    {
      InitializeComponent();

      MainPage = new NavigationPage( new MyFirstPage() );
    }

    protected override void OnStart()
    {
      // Handle when your app starts
    }

    protected override void OnSleep()
    {
      // Handle when your app sleeps
    }

    protected override void OnResume()
    {
      // Handle when your app resumes
    }
  }
}