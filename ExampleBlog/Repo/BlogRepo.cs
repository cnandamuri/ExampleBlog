using ExampleBlog.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExampleBlog.Repo
{
    public class BlogRepo
    {
        List<Blog> MyBlog;

        public BlogRepo() //ctor Tab Tab (this will create the default constructor)
        {
            Populate();
        }
        

        public void Populate()
        {
            //Blog b1 = new Blog();
            //b1.id = 1;
            //b1.Title = "Get started building .NET web apps that run in the browser with Blazor";
            //b1.Content = "Today we released our first public preview of Blazor, a new experimental .NET web framework using C#/Razor and HTML that runs in the browser with WebAssembly. Blazor enables full stack web development with the stability, consistency, and productivity of .NET. While this release is alpha quality and should not be used in production, the code for this release was written from the ground up with an eye towards building a production quality web UI framework.In this release we've laid the ground work for the Blazor component model and added other foundational features, like routing, dependency injection, and JavaScript interop. We've also been working on the tooling experience so that you get great IntelliSense and completions in the Razor editor. Other features that have been demonstrated previously in prototype form, like live reload, debugging, and prerendering, have not been implemented yet, but are planned for future preview updates. Even so, there is plenty in this release for folks to start kicking the tires and giving feedback on the current direction. For additional details on what's included in this release and known issue please see the release notes.";

            //Blog b2 = new Blog();
            //b2.id = 2;
            //b2.Title = "ASP.NET Core 2.1-preview1: Introducing HTTPClient factory";
            //b2.Content = "Provide a central location for naming and configuring logical HttpClients. For example, you may configure a client that is pre-configured to access the github API.Codify the concept of outgoing middleware via delegating handlers in HttpClient and implementing Polly based middleware to take advantage of that.";

            //MyBlog.Add(b1);
            //MyBlog.Add(b2);

            MyBlog = new List<Blog>()
            {
                new Blog {
                    id = 1,
                    Title = "Get started building .NET web apps that run in the browser with Blazor",
                    Content = "Today we released our first public preview of Blazor, a new experimental .NET web framework using C#/Razor and HTML that runs in the browser with WebAssembly. Blazor enables full stack web development with the stability, consistency, and productivity of .NET. While this release is alpha quality and should not be used in production, the code for this release was written from the ground up with an eye towards building a production quality web UI framework.In this release we've laid the ground work for the Blazor component model and added other foundational features, like routing, dependency injection, and JavaScript interop. We've also been working on the tooling experience so that you get great IntelliSense and completions in the Razor editor. Other features that have been demonstrated previously in prototype form, like live reload, debugging, and prerendering, have not been implemented yet, but are planned for future preview updates. Even so, there is plenty in this release for folks to start kicking the tires and giving feedback on the current direction. For additional details on what's included in this release and known issue please see the release notes."
                },
                new Blog
                {
                    id = 2,
                    Title = "ASP.NET Core 2.1-preview1: Introducing HTTPClient factory",
                    Content = "Provide a central location for naming and configuring logical HttpClients. For example, you may configure a client that is pre-configured to access the github API.Codify the concept of outgoing middleware via delegating handlers in HttpClient and implementing Polly based middleware to take advantage of that."
                },
                new Blog
                {
                    id = 3,
                    Title = "ASP.NET Core 2.1-preview1: Introducing HTTPClient factory",
                    Content = "Provide a central location for naming and configuring logical HttpClients. For example, you may configure a client that is pre-configured to access the github API.Codify the concept of outgoing middleware via delegating handlers in HttpClient and implementing Polly based middleware to take advantage of that."
                }
            };
        }
        
        public List<Blog> GetAllBlog()
        {
            return MyBlog;
        }

        public Blog GetBlogById(int id)
        {

            return MyBlog.FirstOrDefault(x => x.id == id); //Method syntax
        }
    }
}
