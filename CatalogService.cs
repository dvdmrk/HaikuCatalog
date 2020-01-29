using System;

namespace HaikuCatalog
{
    public class CatalogService : BaseService, ICatalogService
    {
        public override void DisplayMenu()
        {
            Console.WriteLine(@"
            Select from the following menu items:
                1) Give me a random Haiku
                2) Take me to the Author Menu
                3) Take me to the Haiku Menu
                4) Quit");

        }

        public Haiku GetRandomHaiku()
        {
            throw new NotImplementedException();
        }

        public override bool SelectMenuItem(char key)
        {
            var menuHelper = new MenuHelper();

            switch (key)
            {
                case '1':
                    GetRandomHaiku();
                    break;
                case '2':
                    menuHelper.InteractWithMenu<AuthorService>();
                    break;
                case '3':
                    menuHelper.InteractWithMenu<HaikuService>();
                    break;
                case '4':
                default:
                    return true;
            }
            return false;
        }
    }
}