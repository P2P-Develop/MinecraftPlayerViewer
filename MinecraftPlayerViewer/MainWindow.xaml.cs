using System.Windows;

namespace MinecraftPlayerViewer
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRun_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddElement();
        }

        public void AddElement()
        {
            spinner.Visibility = Visibility.Hidden;
            stItems.Children.Add(new FriendItem("Example", "example-hoge-fuga-piyo-hogehogehogera", @"Resources/ExamplePlayerIcon.png"));
        }
    }
}
