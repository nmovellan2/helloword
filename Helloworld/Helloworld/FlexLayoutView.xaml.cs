using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Helloworld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlexLayoutView : ContentPage
	{
		public FlexLayoutView ()
		{
			InitializeComponent ();
		}

        private void btnColumn_Clicked(object sender, EventArgs e)
        {
            BtnsContainer.Direction = FlexDirection.Column;
        }

        private void btnRow_Clicked(object sender, EventArgs e)
        {
            BtnsContainer.Direction = FlexDirection.Row;
        }

        private void btnWrap_Clicked(object sender, EventArgs e)
        {
            BtnsContainer.Wrap = FlexWrap.Wrap;
        }

        private void btnAlignStart_Clicked(object sender, EventArgs e)
        {
            BtnsContainer.AlignContent = FlexAlignContent.Start;
        }

        private void btnAlignCenter_Clicked(object sender, EventArgs e)
        {
            BtnsContainer.AlignItems = FlexAlignItems.Center;
        }

        private void btnAlignEnd_Clicked(object sender, EventArgs e)
        {
            BtnsContainer.AlignItems = FlexAlignItems.End;
        }

        private void btnJustifyCenter_Clicked(object sender, EventArgs e)
        {
            BtnsContainer.JustifyContent = FlexJustify.Center;
        }

        private void btnSpaceArround_Clicked(object sender, EventArgs e)
        {
            BtnsContainer.JustifyContent = FlexJustify.SpaceAround;
        }

        private void btnSpaceEven_Clicked(object sender, EventArgs e)
        {
            BtnsContainer.AlignContent = FlexAlignContent.SpaceEvenly;
        }
    }
}