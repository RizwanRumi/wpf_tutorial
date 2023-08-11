﻿using HotelReservation.Services;
using HotelReservation.Stores;
using HotelReservation.ViewModels;
using System;

namespace HotelReservation.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationService _navigationService;
        
        public NavigateCommand(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
                       
        }
    }
}
