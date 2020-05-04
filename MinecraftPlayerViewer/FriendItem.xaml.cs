using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace MinecraftPlayerViewer
{
    /// <summary>
    /// FriendItems.xaml の相互作用ロジック
    /// </summary>
    public partial class FriendItem : UserControl
    {
        public FriendItem(string player, string uuid, string path)
        {
            InitializeComponent();
            tbPlayerName.Text = player;
            tbPlayerUUID.Text = $"{{{uuid}}}";
            BitmapImage bmp = new BitmapImage();
            bmp.BeginInit();
            bmp.UriSource = new Uri(path, UriKind.Relative);
            bmp.EndInit();
            imgPlayer.Source = bmp;
        }
    }
}
