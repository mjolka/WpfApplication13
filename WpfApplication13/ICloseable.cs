namespace WpfApplication13
{
    using System;

    internal interface ICloseable
    {
        event EventHandler<EventArgs> RequestClose;
    }
}
