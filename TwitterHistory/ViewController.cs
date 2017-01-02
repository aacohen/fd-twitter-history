using System;

using UIKit;

namespace TwitterHistory
{
	public partial class ViewController : UIViewController
	{

		string username_text;


		partial void UIButton6_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException();
		}


		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
