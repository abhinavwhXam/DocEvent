using Doctors.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Doctors.Models
{
   public class DashBoardModel : ModelBase
    {
        public DelegateCommand HamburgerButtonCOmmand { get; set; }

        public DelegateCommand<string> CategoryCOmmand { get; set; }

        private bool _DrawerIsOpen = false;
        public bool DrawerIsOpen
        {
            get { return _DrawerIsOpen; }
            set { SetProperty(ref _DrawerIsOpen, value); }
        }
        private bool _IsBusy = false;
        public bool IsBusy
        {
            get { return _IsBusy; }
            set { SetProperty(ref _IsBusy, value); }
        }
        private ObservableCollection<MenuList> _MenuListCollection;
        public ObservableCollection<MenuList> MenuListCollection
        {
            get { return _MenuListCollection; }
            set { SetProperty(ref _MenuListCollection, value); }
        }
        private ObservableCollection<MenuList> _MenuFooterListCollection;
        public ObservableCollection<MenuList> MenuFooterListCollection
        {
            get { return _MenuFooterListCollection; }
            set { SetProperty(ref _MenuFooterListCollection, value); }
        }

        private ObservableCollection<DashBoardList> _DashBoardList;
        public ObservableCollection<DashBoardList> DashBoardListCol
        {
            get { return _DashBoardList; }
            set { SetProperty(ref _DashBoardList, value); }
        }


        public class MenuList
        {
            public string Icon { get; set; }
            public string Title { get; set; }
            public int Id { get; set; }
        }

        public class DashBoardList
        {
            public string Icon { get; set; }
            public string Title { get; set; }
            public string SubHeading { get; set; }
            public string Description { get; set; }
        }


    }
}
