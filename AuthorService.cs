namespace HaikuCatalog
{
    public class AuthorService : BaseService
    {
        public AuthorService()
        {
        }

        public override void DisplayMenu()
        {
            System.Console.WriteLine(@"
            Select from the following menu options:
                1) List all Authors
                2) List all Haikus by Author
                3) Return to Main Menu");
        }

        public override bool SelectMenuItem(char key)
        {
            switch (key) 
            {
                case '1':
                    throw new System.NotImplementedException();
                case '2':
                    throw new System.NotImplementedException();
                case '3':
                default:
                    return true;
            }
        }
    }
}