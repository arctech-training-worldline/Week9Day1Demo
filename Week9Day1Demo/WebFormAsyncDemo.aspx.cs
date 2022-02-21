using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Week9Day1Demo
{
    public partial class WebFormAsyncDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonTest_OnClick(object sender, EventArgs e)
        {
            TestIt();
        }

        protected async void ButtonTestAsync_Click(object sender, EventArgs e)
        {
            await TestItAsync();
        }

        private async Task TestItAsync()
        {
            var fileManager = new MyFileManager(@"C:\Users\avina\OneDrive - arctechinfo.com\Documents\Training\Sessions\C#\21-Feb-2022\Week9Day1Demo\Week9Day1Demo\files\File1.txt");

            var count = await fileManager.CountCharactersAsync();

            var fileTextPreSort = await fileManager.GetAllTextAsync();

            await fileManager.SortAsync();

            var fileTextPostSort = await fileManager.GetAllTextAsync();

            TextBoxMessage.Text = $"Count = {count}\n\nBefore Sort = \n{fileTextPreSort}\n\nAfter Sort = \n{fileTextPostSort}";
        }

        private void TestIt()
        {
            var fileManager = new MyFileManager(@"C:\Users\avina\OneDrive - arctechinfo.com\Documents\Training\Sessions\C#\21-Feb-2022\Week9Day1Demo\Week9Day1Demo\files\File1.txt");

            var count = fileManager.CountCharacters();
            
            var fileTextPreSort = fileManager.GetAllText();

            fileManager.Sort();
            
            var fileTextPostSort = fileManager.GetAllText();

            TextBoxMessage.Text = $"Count = {count}\n\nBefore Sort = \n{fileTextPreSort}\n\nAfter Sort = \n{fileTextPostSort}";
        }
    }
}