using System;
using Social;
using UIKit;

namespace SharingApp
{
	public partial class ViewController : UIViewController
	{
		partial void UIButton14_TouchUpInside(UIButton sender)
		{
			var text = "Sharing from #Xamarin.iOS : https://www.youtube.com/c/HoussemDellai";

			var image = MyImage.Image;

			if (SLComposeViewController.IsAvailable(SLServiceType.Twitter))
			{
				var facebook = SLComposeViewController.FromService(SLServiceType.Twitter);

				facebook.SetInitialText(text);

				facebook.AddImage(image);

				PresentViewController(facebook, true, null);
			}
		}

		partial void UIButton12_TouchUpInside(UIButton sender)
		{
			var text = "Sharing from #Xamarin.iOS : https://www.youtube.com/c/HoussemDellai";

			var image = MyImage.Image;

			if (SLComposeViewController.IsAvailable(SLServiceType.Facebook))
			{
				var facebook = SLComposeViewController.FromService(SLServiceType.Facebook);

				facebook.SetInitialText(text);

				facebook.AddImage(image);

				PresentViewController(facebook, true, null);
			}
		}

		partial void UIButton6_TouchUpInside(UIButton sender)
		{
			var text = FromObject("Sharing from #Xamarin.iOS : https://www.youtube.com/c/HoussemDellai");

			var image = FromObject(MyImage.Image);

			var items = new[] { text, image };

			var activity = new UIActivityViewController(items, null);

			PresentViewController(activity, true, null);
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
