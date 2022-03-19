using System;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace ControlListView
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Pais> paises = new ObservableCollection<Pais>();
        public MainPage()
        {
            this.InitializeComponent();
            cargarListView();
        }
        private void cargarListView()
        {
            paises.Add(new Pais { Nombre = "Argentina", CantidadHabitantes = 40000000 });
            paises.Add(new Pais { Nombre = "Chile", CantidadHabitantes = 17000000 });
            paises.Add(new Pais { Nombre = "Bolivia", CantidadHabitantes = 10000000 });
            paises.Add(new Pais { Nombre = "Perú", CantidadHabitantes = 30000000 });
            paises.Add(new Pais { Nombre = "Ecuador", CantidadHabitantes = 16000000 });
            paises.Add(new Pais { Nombre = "Paraguay", CantidadHabitantes = 7000000 });
            paises.Add(new Pais { Nombre = "Uruguay", CantidadHabitantes = 3000000 });
            paises.Add(new Pais { Nombre = "Brasil", CantidadHabitantes = 200000000 });
            paises.Add(new Pais { Nombre = "Venezuela", CantidadHabitantes = 30000000 });
            paises.Add(new Pais { Nombre = "Colombia", CantidadHabitantes = 48000000 });
            paises.Add(new Pais { Nombre = "Surinam", CantidadHabitantes = 500000 });
            paises.Add(new Pais { Nombre = "Guyana", CantidadHabitantes = 800000 });
            paises.Add(new Pais { Nombre = "Guyana Francesa", CantidadHabitantes = 250000 });
            listView1.ItemsSource = paises;
        }
        private void ListView1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Pais pais = (Pais)(e.ClickedItem);
            textBox1.Text = pais.Nombre + "(" + pais.CantidadHabitantes + ")";
        }



    }
}

