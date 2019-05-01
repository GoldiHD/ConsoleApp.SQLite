using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.SQLite
{
    class DataFiller
    {
        public static void Fill(BloggingContext db)
        {
            List<Blog> blogs = new List<Blog>
            {
                new Blog{ Url = "http://TotallyNotFakeNews.com/Blog/0", },
                new Blog{ Url = "http://TotallyNotFakeNews.com/Blog/1", },
                new Blog{ Url = "http://TotallyNotFakeNews.com/Blog/2", },
                new Blog{ Url = "http://TotallyNotFakeNews.com/Blog/3", },
                new Blog{ Url = "http://TotallyNotFakeNews.com/Blog/4", }
            };

            List<User> users = new List<User>
            {
                new User { Username = "Alucard" },
                new User { Username = "Tommmy" },
                new User { Username = "Astaroth" }
            };

            List<Post> posts = new List<Post>
            {
                new Post {Blog = blogs[0], Context = "Omg I love this Blog it's so bloggy", Title = "Look at my new blog"},
                new Post { Blog = blogs[0], Context = "I just had pizza so good, kawaii", Title = "Pizza num num"},
                new Post {Blog = blogs[4], Context = "Lol this blog is gonna be so great lmao", Title = "XDDDD"},
                new Post {Blog = blogs[3], Context = "Am I too late for the party?", Title = "where you all at?"},
                new Post {Blog = blogs[1], Context = "Follow crimson fuckers on twitter", Title = "Hellsing abriage is great"},
                new Post { Blog = blogs[1], Context = "I know if you look deep into your heart, which is currently all over that tree over there, I know you'll find a way to forgive me", Title = "Best quote ever"}
            };

            List<UserBlog> userBlogs = new List<UserBlog> { new UserBlog { User = users[2], Blog = blogs[1] } };

            foreach (Blog element in blogs)
            {
                db.Blogs.Add(element);
            }

            foreach (Post element in posts)
            {
                db.Posts.Add(element);
            }
        }
    }
}
