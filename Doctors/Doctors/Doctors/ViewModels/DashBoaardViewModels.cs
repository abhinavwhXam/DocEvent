using Doctors.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using System.Linq;

namespace Doctors.ViewModels
{
   public class DashBoaardViewModels : DashBoardModel
    {

        public DashBoaardViewModels()
        {

            
            HamburgerButtonCOmmand = new Commands.DelegateCommand(HamburgerButtonCOmmand_function);
            CategoryCOmmand = new Commands.DelegateCommand<string>(CategoryCOmmand_function);

            MenuFooterListCollection = new System.Collections.ObjectModel.ObservableCollection<MenuList>();
            MenuFooterListCollection.Add(new MenuList { Icon = "PrivacyPolicy.png", Title = "Privacy Policy", Id = 5 });
            MenuFooterListCollection.Add(new MenuList { Icon = "Logout.png", Title = "Log Out", Id = 6 });
           


            MenuListCollection = new System.Collections.ObjectModel.ObservableCollection<MenuList>();
            MenuListCollection.Add(new MenuList { Icon = "HomeIcon.png", Title = "Home", Id = 1 });
            MenuListCollection.Add(new MenuList { Icon = "AccountIcon.png", Title = "Account", Id = 2 });
            MenuListCollection.Add(new MenuList { Icon = "EventIcon.png", Title = "Events", Id = 3 });


            DashBoardListCol = new System.Collections.ObjectModel.ObservableCollection<DashBoardList>();
            DashBoardListCol.Add(new DashBoardList { Icon = "Med.json" ,Title="CiplaMed", SubHeading="Cipla Sub heading",Description= "Cipla descripion goes here . Cipla descripion goes here . Cipla descripion goes here" });
            DashBoardListCol.Add(new DashBoardList { Icon = "healthr.json", Title = "Neuro", SubHeading = "Neuro Sub heading", Description = "Neuro descripion goes here . Neuro descripion goes here . Neuro descripion goes here" });
            DashBoardListCol.Add(new DashBoardList { Icon = "event.json", Title = "Events", SubHeading = "Events Sub heading", Description = "Events descripion goes here . Events descripion goes here . Events descripion goes here" });
        }

        private async void CategoryCOmmand_function(string obj)
        {
            IsBusy = true;
            var item = (from a in DashBoardListCol
                        where a.Title == obj
                        select a).FirstOrDefault();

           Uri uri = new Uri("https://www.google.com/");
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
           IsBusy = false;
        }

        private void HamburgerButtonCOmmand_function()
        {
            DrawerIsOpen = true;
        }
    }
}
