﻿using MvvmCross.Forms.Presenters.Attributes;
using Xamarin.Forms.Xaml;

namespace MoneyFox.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[MvxTabbedPagePresentation(WrapInNavigationPage = false, Title = "Settings", Icon = "ic_settings")]
    public partial class SettingsPage 
	{
		public SettingsPage ()
		{
			InitializeComponent ();

		    SettingsList.ItemTapped += (sender, args) =>
		    {
		        SettingsList.SelectedItem = null;
		        ViewModel.GoToSettingCommand.Execute(args.Item);
		    };
        }
	}
}