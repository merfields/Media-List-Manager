using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Core.Commands.TitleBarCommands
{
    class CloseWindowCommand : CommandBase
    {
        private Window windowToClose;
        public override void Execute(object? parameter)
        {
            windowToClose.Close();
        }

        public CloseWindowCommand(Window windowToClose)
        {
            this.windowToClose = windowToClose;
        }

    }
}
