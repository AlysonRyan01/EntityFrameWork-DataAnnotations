using Microsoft.EntityFrameworkCore;
using ProjetoEntityFramework.Data;
using ProjetoEntityFramework.Models;

Console.Clear();
using (var context = new BlogDataContext())
{
    //CREATE
    //var tag = new Tag{Name = "ASP...NET", Slug = "asp..net"};
    //context.Tags.Add(tag);
    //context.SaveChanges();

    //UPDATE
    //var tag = context.Tags.FirstOrDefault<Tag>(x => x.Id == 3);
    //tag.Name = "C#";
    //tag.Slug = "csharp";
    //context.Update(tag);
    //context.SaveChanges();

    //REMOVE
    //var tag = context.Tags.FirstOrDefault<Tag>(x => x.Id == 3);
    //context.Remove(tag);
    //context.SaveChanges();

    //CONSULTA UM OU MAIS DE UMA TAG (QUERY)
    //var tags = context.Tags.Where(x => x.Name.Contains(".NET")).AsNoTracking().ToList(); // ToList() sempre no final e usar AsNoTracking na consulta (desemprenho);
    //foreach(var items in tags)
    //{
    //    System.Console.WriteLine(items.Name);
    //}

    var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 4);
    System.Console.WriteLine(tag.Name);
    
}