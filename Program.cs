using Microsoft.EntityFrameworkCore;
using ProjetoEntityFramework.Data;
using ProjetoEntityFramework.Models;

Console.Clear();

using var context = new BlogDataContext();
    /*
    //CREATE
    var tag = new Tag{Name = "ASP...NET", Slug = "asp..net"};
    context.Tags.Add(tag);
    context.SaveChanges();

    //UPDATE
    var tag = context.Tags.FirstOrDefault<Tag>(x => x.Id == 3);
    tag.Name = "C#";
    tag.Slug = "csharp";
    context.Update(tag);
    context.SaveChanges();

    //REMOVE
    var tag = context.Tags.FirstOrDefault<Tag>(x => x.Id == 3);
    context.Remove(tag);
    context.SaveChanges();

    //CONSULTA UM OU MAIS DE UMA TAG (QUERY)
    var tags = context.Tags.Where(x => x.Name.Contains(".NET")).AsNoTracking().ToList(); // ToList() sempre no final e usar AsNoTracking na consulta (desemprenho);
    foreach(var items in tags)
    {
        System.Console.WriteLine(items.Name);
    }

    //CONSULTA SOMENTE UMA TAG
    var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 4);
    System.Console.WriteLine(tag.Name);
    */

    /*
    var user = new User
    {
        Name = "André Baltieri",
        Slug = "andrebaltieri",
        Email = "andre@balta.io",
        Bio = "9x Microsoft MVP",
        Image = "https://balta.io",
        PasswordHash = "123098457"
    };

    var category = new Category {Name = "Backend", Slug = "backend"};

    var post = new Post
    {
        Author = user,
        Category = category,
        Body = "<p>Hello world</p>",
        Slug = "comecando-com-ef-core",
        Summary = "Neste artigo vamos aprender EF core",
        Title = "Começando com EF Core",
        CreateDate = DateTime.Now,
        LastUpdateDate = DateTime.Now,
    };

    context.Posts.Add(post);
    context.SaveChanges();
    */

    var post = context
                .Posts
                //.AsNoTracking()
                .Include(x => x.Author)
                .Where(x => x.Id == 1)
                .FirstOrDefault();

    post.Author.Name = "ALyson Ryan";
    context.Posts.Update(post);
    context.SaveChanges();
    
    
