namespace WpfApplication13.ViewModels
{
    using System;

    using GalaSoft.MvvmLight.Command;

    public class OptionsViewModel : ICloseable
    {
        public OptionsViewModel()
        {
            this.CloseOptionsCommand = new RelayCommand(CloseOptions);
        }

        public RelayCommand CloseOptionsCommand { get; private set; }

        public event EventHandler<EventArgs> RequestClose;

        private void CloseOptions()
        {
            var requestClose = this.RequestClose;
            if (requestClose != null)
            {
                requestClose(this, null);
            }
        }
    }
}
