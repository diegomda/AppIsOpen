using System;
using System.Collections.ObjectModel;

namespace IsOpen.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public LoginViewModel Login { get; set; }

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }

        #endregion
        #region Constructor
        public MainViewModel()
        {
            Login = new LoginViewModel();
            LoadMenu();
        }

        #endregion
        #region Metodos
        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            Menu.Add(new MenuItemViewModel
            {
                Icon = "negocio.png",
                PageName = "NegocioPage",
                Title = "Negocios",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "configuracion.png",
                PageName = "ConfigPage",
                Title = "Configuracion",
            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "salida.png",
                PageName = "LoginPage",
                Title = "Salir",
            });

        }

        #endregion
    }
}
