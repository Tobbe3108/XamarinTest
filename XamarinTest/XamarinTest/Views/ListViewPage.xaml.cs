using Xamarin.Forms.Xaml;

namespace XamarinTest.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class ListViewPage
  {
    public ListViewPage()
    {
      InitializeComponent();
      Vegetables.ItemsSource = new[]
      {
        "Celery",
        "Tomato",
        "Zucchini"
      };
    }
  }
}