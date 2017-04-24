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

namespace SerproShared.iOS
{
    [Register ("ListaPessoasController")]
    partial class ListaPessoasController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Lista_Pessoas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView listaPessoas { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Lista_Pessoas != null) {
                Lista_Pessoas.Dispose ();
                Lista_Pessoas = null;
            }

            if (listaPessoas != null) {
                listaPessoas.Dispose ();
                listaPessoas = null;
            }
        }
    }
}