using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week9Day1Demo
{
    public partial class WebFormGenericDemo : System.Web.UI.Page
    {
        protected void ButtonSwap_OnClick(object sender, EventArgs e)
        {
            var leftSide = TextBoxLeftSide.Text;
            var rightSide = TextBoxRightSide.Text;

            SwapString(ref leftSide, ref rightSide);

            TextBoxLeftSide.Text = leftSide;
            TextBoxRightSide.Text = rightSide;
        }

        protected void ButtonSwapGeneric_OnClick(object sender, EventArgs e)
        {
            var leftSide = TextBoxLeftSide.Text;
            var rightSide = TextBoxRightSide.Text;

            Swap<string>(ref leftSide, ref rightSide);

            TextBoxLeftSide.Text = leftSide;
            TextBoxRightSide.Text = rightSide;
        }

        protected void ButtonSwapNumbers_Click(object sender, EventArgs e)
        {
            var leftSide = int.Parse(TextBoxNumberLeftSide.Text);
            var rightSide = int.Parse(TextBoxNumberRightSide.Text);

            SwapNumber(ref leftSide, ref rightSide);

            TextBoxNumberLeftSide.Text = leftSide.ToString();
            TextBoxNumberRightSide.Text = rightSide.ToString();
        }

        protected void ButtonSwapNumbersGeneric_Click(object sender, EventArgs e)
        {
            var leftSide = int.Parse(TextBoxNumberLeftSide.Text);
            var rightSide = int.Parse(TextBoxNumberRightSide.Text);

            Swap<int>(ref leftSide, ref rightSide);

            TextBoxNumberLeftSide.Text = leftSide.ToString();
            TextBoxNumberRightSide.Text = rightSide.ToString();
        }

        private void Swap<T>(ref T leftSide, ref T rightSide)
        {
            var temp = leftSide;
            leftSide = rightSide;
            rightSide = temp;
        }

        private void SwapString(ref string leftSide, ref string rightSide)
        {
            var temp = leftSide;
            leftSide = rightSide;
            rightSide = temp;
        }

        private void SwapNumber(ref int leftSide, ref int rightSide)
        {
            int temp = leftSide;
            leftSide = rightSide;
            rightSide = temp;
        }
    }
}