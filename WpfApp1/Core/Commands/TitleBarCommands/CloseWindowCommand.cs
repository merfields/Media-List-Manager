using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1.Core.Commands.TitleBarCommands
{
    class MinimizeWindowCommand : CommandBase
    {
        private Window windowToMinimize;
        public override void Execute(object? parameter)
        {
            windowToMinimize.WindowState = WindowState.Minimized;
        }

        public MinimizeWindowCommand(Window windowToMinimize)
        {
            this.windowToMinimize = windowToMinimize;
        }

    }
}
