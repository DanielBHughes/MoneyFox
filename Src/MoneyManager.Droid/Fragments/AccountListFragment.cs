using Android.OS;
using Android.Views;
using Cirrious.MvvmCross.Binding.Droid.BindingContext;
using Cirrious.MvvmCross.Binding.Droid.Views;
using Cirrious.MvvmCross.Droid.Support.Fragging.Fragments;
using MoneyManager.Core.ViewModels;

namespace MoneyManager.Droid.Fragments
{
    public class AccountListFragment : MvxFragment
    {
        public new AccountListViewModel ViewModel
        {
            get { return (AccountListViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Layout.AccountListLayout, null);

            //TODO: Move this to binding
            var list = view.FindViewById<MvxListView>(Resource.Id.accountList);
            list.ItemsSource = ViewModel.AllAccounts;

            return view;
        }
    }
}