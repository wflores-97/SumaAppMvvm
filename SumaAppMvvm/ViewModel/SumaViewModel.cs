using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace SumaAppMvvm.ViewModel
{
    public partial class SumaViewModel : ObservableObject
    {
        [ObservableProperty]
        private int a;

        [ObservableProperty]
        private int b;

        [ObservableProperty]
        private int resultado;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void calcular()
        {
            try{
                Resultado = A + B;
            }
            catch (Exception ex)
            {
                Alerta("Error", ex.Message);
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            A = 0;
            B = 0;
            Resultado = 0;
        }
    }
}
