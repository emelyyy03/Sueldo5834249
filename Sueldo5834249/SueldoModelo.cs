using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo5834249
{
    public partial class SueldoModelo:ObservableObject
    {
        [ObservableProperty]
        public string? sueldo;

        [ObservableProperty]
        public double aumento;

        [RelayCommand]
        private void ActualizarDatos()
        {
            if(double.TryParse(Sueldo, out double sueldo))
            {
                if(sueldo <= 1000)
                {
                    Aumento = sueldo * 1.15;
                }
                else if(sueldo > 1000)
                {
                    Aumento = sueldo * 1.10;
                }
            }
            else
            {
                Aumento.ToString("Digite valores numericos");
            }
        }

    }
}
