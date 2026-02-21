namespace _02Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandInfo = Console.ReadLine().Split(": ");
                string command = commandInfo[0];
                string changeInfo = commandInfo[1];

                if (command == "Edit")
                {
                    article.Edit(changeInfo);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(changeInfo);
                }
                else if (command == "Rename")
                {
                    article.Rename(changeInfo);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}