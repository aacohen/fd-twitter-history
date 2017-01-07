using System;

using UIKit;

using Foundation;

namespace TwitterHistory1
{
	public partial class DetailViewController : UIViewController
	{
		public DetailViewController() : base("DetailViewController", null)
		{
		}

		public string[] tweets;
		string CellIdentifier = "TableCell";

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

		public nint RowsInSection(UITableView tableview, nint section)
		{
			return tweets.Length;
		}

		public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
			string item = tweets[indexPath.Row];

			if (cell == null)
			{ cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = item;
			cell.BackgroundColor = UIColor.Orange;

			return cell;
		}
	}
}

