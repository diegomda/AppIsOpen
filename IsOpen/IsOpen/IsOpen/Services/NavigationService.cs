﻿using IsOpen.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsOpen.Services
{
    public class NavigationService
    {
        public void SetMainPage(string pageName)
        {
            switch (pageName)
            {
                case "MasterPage":
                    App.Current.MainPage = new MasterPage();
                    break;
                case "LoginPage":
                    //Logout();
                    App.Current.MainPage = new LoginPage();
                    break;
                default:
                    break;
            }
        }

    }
}
