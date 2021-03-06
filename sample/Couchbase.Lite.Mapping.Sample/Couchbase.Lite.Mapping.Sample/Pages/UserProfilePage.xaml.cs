﻿using System;
using Couchbase.Lite.Mapping.Sample.Core.ViewModels;
using Xamarin.Forms;

namespace Couchbase.Lite.Mapping.Sample.Pages
{
    public partial class UserProfilePage : ContentPage
    {
        public UserProfilePage(Action logoutSuccesful)
        {
            InitializeComponent();

            BindingContext = new UserProfileViewModel(logoutSuccesful);
        }
    }
}
