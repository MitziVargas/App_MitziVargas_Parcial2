using App_MitziVargas_Parcial2.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace App_MitziVargas_Parcial2.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}