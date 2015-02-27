namespace WpfApplication13.Views
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow
    {
        public OptionsWindow()
        {
            InitializeComponent();
            this.Loaded += (sender, args) =>
            {
                var dataContext = this.DataContext as ICloseable;
                if (dataContext != null)
                {
                    dataContext.RequestClose += (_, __) => this.Close();
                }
            };
        }
    }
}
