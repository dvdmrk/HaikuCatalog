using System;

namespace HaikuCatalog
{
    public interface IService
    {
        void DisplayMenu();
        bool SelectMenuItem(char readKey);
        
    }
}