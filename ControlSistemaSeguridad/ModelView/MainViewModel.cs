using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;
using ControlSistemaSeguridad.View;

namespace ControlSistemaSeguridad.ModelView
{
    public class MainViewModel : ICommand
    {
        public MainViewModel Instancia { get; set; }
        public event EventHandler CanExecuteChanged;

        public MainViewModel ()
        {
            this.Instancia = this;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parametro)
        {
            if (parametro.Equals("Puestos"))
            {
                PuestoView ventana = new PuestoView();
                //se muestra la ventana frente a la ventana principal
                ventana.ShowDialog();
            }
        }
    }
}
