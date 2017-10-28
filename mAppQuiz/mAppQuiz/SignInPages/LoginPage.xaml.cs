﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mAppQuiz
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            
#pragma warning disable CS0618 // Type or member is obsolete
            logo.Source = Device.OnPlatform(
                iOS: ImageSource.FromResource("appealing_logo.png"),
                Android: ImageSource.FromFile("logical_logo.png"),
                WinPhone: ImageSource.FromFile("Images/appealing_logo.png"));
#pragma warning restore CS0618 // Type or member is obsolete
        }

        async void OnLoginClick(object sender, EventArgs e)
        {
            User existingUser = new User(this.Username.Text, this.Password.Text);
            //TODO: Needs to query against data store for a username and password combination
            await this.DisplayAlert("Alert", existingUser._userName, "Ok", "Cancel");
        }

        async void OnSignUpClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

    }
}
