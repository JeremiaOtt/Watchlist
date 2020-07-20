using System;
using System.Collections.Generic;
using System.Text;
using Watchlist.Enum;

namespace Watchlist.ViewModels
{
    public class ButtonViewModel : BaseViewModel
    {
        public string Content { get; }
        public UpdateView CommandParameter { get; }

        public ButtonViewModel(string content, UpdateView commandParameter)
        {
            Content = content;
            CommandParameter = commandParameter;
        }
    }
}
