using System.Windows;
using System.Windows.Controls;

namespace MusicPlayer.UserControls
{

    public partial class SongItem : UserControl
    {
        // Constructor for the song
        public SongItem()
        {
            InitializeComponent();
        }


        // Song Title
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register
            ("Title", typeof(string), typeof(SongItem));


        // Song Number
        public string Number
        {
            get { return (string)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register
            ("Number", typeof(string), typeof(SongItem));


        // Song Time
        public string Time
        {
            get { return (string)GetValue(TimeProperty); }
            set { SetValue(TimeProperty, value); }
        }

        public static readonly DependencyProperty TimeProperty = DependencyProperty.Register
            ("Time", typeof(string), typeof(SongItem));

        
        // Check if the song is currently playing
        public bool IsActive
        {
            get { return (bool)GetValue(IsActiveProperty); }
            set { SetValue(IsActiveProperty, value); }
        }

        public static readonly DependencyProperty IsActiveProperty = DependencyProperty.Register
            ("IsActive", typeof(string), typeof(SongItem));


    }
}
