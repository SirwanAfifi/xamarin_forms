using System;
using Telerik.XamarinForms.Input;
using TelerikTest.Models;
using Xamarin.Forms;

namespace TelerikTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.dataForm.RegisterEditor("City", EditorType.Custom);
        }

        public void onSaveClicked(object e, EventArgs sender)
        {
            var sourceItem = (Person)this.dataForm.Source;

            if (sourceItem.City != null)
            {

            }
        }
    }
}
