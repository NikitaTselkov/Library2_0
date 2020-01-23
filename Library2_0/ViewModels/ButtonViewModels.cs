using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Library2_0.ViewModels
{
    public class ButtonViewModel
    {
        
        public string Content { get; set; }
        public int Id { get; set; }
        public string This { get; set; }

        public string Code { get; set; }
        public ICommand Command { get; set; }

        public ButtonViewModel(string content, int id, string this1, string code, ICommand command = null)
        {
            Content = content;
            Command = command;
            Id = id;
            This = this1;
            Code = code;
        }
    }
}
