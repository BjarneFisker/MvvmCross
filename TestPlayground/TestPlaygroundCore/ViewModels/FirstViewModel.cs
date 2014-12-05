using Cirrious.MvvmCross.ViewModels;

namespace TestPlaygroundCore.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private int _hello = 0;
        public int Hello
		{ 
			get { return _hello; }
			set { _hello = value; RaisePropertyChanged(() => Hello); }
		}
    }
}
