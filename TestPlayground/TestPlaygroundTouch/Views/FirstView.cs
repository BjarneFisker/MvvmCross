
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;
using TestPlaygroundCore.ViewModels;

namespace TestPlaygroundTouch
{
	public partial class FirstView : MvxViewController
	{
		public FirstView () : base ("FirstView", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var set = this.CreateBindingSet<FirstView, FirstViewModel> ();
			set.Bind (this.OutputLabel).To (vm => vm.Hello);
			set.Bind (this.InputTextField).To (vm => vm.Hello);
			set.Bind (this.TestSegmentedControl).For (w => w.SelectedSegment).To (vm => vm.Hello);
			set.Apply ();
		}
	}
}

