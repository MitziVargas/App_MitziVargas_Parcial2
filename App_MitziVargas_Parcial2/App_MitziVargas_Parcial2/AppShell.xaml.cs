using App_MitziVargas_Parcial2.ViewModels;
using App_MitziVargas_Parcial2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace App_MitziVargas_Parcial2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
