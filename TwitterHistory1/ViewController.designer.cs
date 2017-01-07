// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TwitterHistory1
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton search_button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField text_field { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (search_button != null) {
                search_button.Dispose ();
                search_button = null;
            }

            if (text_field != null) {
                text_field.Dispose ();
                text_field = null;
            }
        }
    }
}