using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
using Social;

namespace TwitterHistory1
{
	public partial class ViewController : UIViewController
	{

		string[] tweet_dict; 
		//data we get back from Twitter needs to be parsed and the tweets to be pulled out of the dictionaries.

		// UIbutton action


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

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier.Equals("detail_segue"))
			{

				var viewController = (DetailViewController)segue.DestinationViewController;
                                        
				viewController.tweets = tweet_dict;
			}
		}



		//public void RetrieveTwitterHistory(string username)
		//{

		//	//Dictionary<string, int> dict = new Dictionary<string, int>();

		//	var parameters = new NSDictionary();
		//	var url = new NSUrl("https://api.twitter.com/1.1/statuses/user_timeline.json?count=10");
		//	var request = SLRequest.Create(SLServiceKind.Twitter, SLRequestMethod.Get, url, parameters);

		//	request.PerformRequest((data, response, error) =>
		//	{
		//		if (error == null)
		//		{
		//			if (response.StatusCode == 200)
		//			{
		//				// Yes, add it to the tweet_dict
		//				InvokeOnMainThread(() =>
		//				{
		//					//parse the data
		//					Results.Text = data.ToString();
		//				});
		//			}
		//			else {
		//				// No, display error
		//				InvokeOnMainThread(() =>
		//				{
		//				//	Results.Text = string.Format("Error: {0}", response.StatusCode);
		//				});
		//			}
		//		}
		//		else {
		//			// No, display error
		//			InvokeOnMainThread(() =>
		//			{
		//			//	Results.Text = string.Format("Error: {0}", error);
		//			});
		//		}
		//	});
		//}
	}

	//public void authenticate()
	//{
	//	var oauth_consumer_key = "Your API Key";
	//	var oauth_consumer_secret = "Your API Secret Key";
	//	//Token URL
	//	var oauth_url = "https://api.twitter.com/oauth2/token This link is external to TechNet Wiki. It will open in a new window. ";
	//	var headerFormat = "Basic {0}";
	//	var authHeader = string.Format(headerFormat,
	//	Convert.ToBase64String(Encoding.UTF8.GetBytes(Uri.EscapeDataString(oauth_consumer_key) + ":" +
	//	Uri.EscapeDataString((oauth_consumer_secret)))
	//	));

	//	var postBody = "grant_type=client_credentials";

	//	ServicePointManager.Expect100Continue = false;
	//	HttpWebRequest request = (HttpWebRequest)WebRequest.Create(oauth_url);
	//	request.Headers.Add("Authorization", authHeader);
	//	request.Method = "POST";
	//	request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";

	//	using (Stream stream = request.GetRequestStream())
	//	{
	//		byte[] content = ASCIIEncoding.ASCII.GetBytes(postBody);
	//		stream.Write(content, 0, content.Length);
	//	}

	//	request.Headers.Add("Accept-Encoding", "gzip");
	//	HttpWebResponse response = request.GetResponse() as HttpWebResponse;
	//	Stream responseStream = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress);
	//	using (var reader = new StreamReader(responseStream))
	//	{
	//		JavaScriptSerializer js = new JavaScriptSerializer();
	//		var objText = reader.ReadToEnd();
	//		JObject o = JObject.Parse(objText);

	//	}
	//}

	//search button action method: retrieve twitter history method, save to local dict/array
	//when to call authenticate method
	//method to retrieve history from Twitter API using text field text
	//data model for the twitter history recieved from API call.

}
