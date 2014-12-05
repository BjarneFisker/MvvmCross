// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TestPlaygroundTouch
{
	[Register ("FirstView")]
	partial class FirstView
	{
		[Outlet]
		MonoTouch.UIKit.UITextField InputTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel OutputLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISegmentedControl TestSegmentedControl { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (InputTextField != null) {
				InputTextField.Dispose ();
				InputTextField = null;
			}

			if (OutputLabel != null) {
				OutputLabel.Dispose ();
				OutputLabel = null;
			}

			if (TestSegmentedControl != null) {
				TestSegmentedControl.Dispose ();
				TestSegmentedControl = null;
			}
		}
	}
}
