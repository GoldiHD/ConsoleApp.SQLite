using System;

namespace ConsoleApp.SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                //DataFiller.Fill(db);
                //var count = db.SaveChanges();
                //Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var blog in db.Blogs)
                {
                    Console.WriteLine(" - {0}", blog.Url);
                    foreach (var post in db.Posts)
                    {
                        if (post.BlogId == blog.BlogId)
                        {
                            Console.WriteLine("    Title: " + post.Title);
                            Console.WriteLine("    Post: " + post.Context);
                        }
                    }
                    Console.WriteLine();
                }
                
            }
            Console.Read();
        }
    }
}
