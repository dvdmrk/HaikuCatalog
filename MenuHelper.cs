using System;

namespace HaikuCatalog
{
    public class MenuHelper
    {
        public void InteractWithMenu<T>() where T : BaseService, new()
        {
            var service = new T();
            var quit = false;
            do
            {
                Console.Clear();
                //Show Primary Menu
                service.DisplayMenu();
                //Make CatalogService Selection
                quit = service.SelectMenuItem(Console.ReadKey().KeyChar);
            } while (!quit);
        }
    }
}