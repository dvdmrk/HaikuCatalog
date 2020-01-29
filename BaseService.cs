using System;

namespace HaikuCatalog
{
    public abstract class BaseService : IService
    {
        public abstract void DisplayMenu();

        public bool SelectMenuItem(ConsoleKeyInfo readKey)
        {
            return SelectMenuItem(readKey.KeyChar);
        }

        public abstract bool SelectMenuItem(char key);
    }
}