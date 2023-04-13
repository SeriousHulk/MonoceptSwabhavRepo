namespace LibraryManagementSystemFacade.Model
{
    internal class LibraryManagementSystem
    {
        private readonly UserManagementSystem userManagementSystem;
        private readonly BookManagementSystem bookManagementSystem;
        private readonly CatalogManagementSystem catalogManagementSystem;
        public LibraryManagementSystem()
        {
            userManagementSystem = new UserManagementSystem();
            bookManagementSystem = new BookManagementSystem();
            catalogManagementSystem = new CatalogManagementSystem();
        }
        public void AddUserAndBook(string username, string password, string title, string author)
        {
            userManagementSystem.AddUser(username, password);
            bookManagementSystem.AddBook(title, author);
        }
        public void IssueBook(string username, string title)
        {
            catalogManagementSystem.IssueBook(username, title);
        }
    }
}
