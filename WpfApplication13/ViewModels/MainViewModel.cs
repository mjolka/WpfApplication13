namespace WpfApplication13.ViewModels
{
    using GalaSoft.MvvmLight;
    using GalaSoft.MvvmLight.Command;

    using Views;

    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            this.OpenOptionsCommand = new RelayCommand(OpenOptions);
        }

        public RelayCommand OpenOptionsCommand { get; private set; }

        private void OpenOptions()
        {
            new OptionsWindow().Show();
        }
    }
}
