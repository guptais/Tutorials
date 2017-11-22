using System.Collections.Generic;
using System.Linq;
using FunWithSignalR.Data.Context;
using FunWithSignalR.Domain.Repository;

namespace FunWithSignalR.Data.Repository
{
    public class SqlBlogPostRepository : IBlogPostRepository
    {
        public IEnumerable<Domain.Model.BlogPost> GetAllBlogPosts()
        {
            using (BlogPostContext context = new BlogPostContext())
            {
                IList<Data.Model.BlogPost> blogposts = context.BlogPosts.ToList<Data.Model.BlogPost>();
                var posts = from post in blogposts
                            select post.ToDomainBlogPost();
                return posts.ToList<Domain.Model.BlogPost>();
            }
        }

        public void CreateBlogPost(Domain.Model.BlogPost post)
        {
            using (BlogPostContext context = new BlogPostContext())
            {
                context.Entry(new Data.Model.BlogPost { 
                    Post = post.Post, Title = post.Title 
                }).State = System.Data.EntityState.Added;
                context.SaveChanges();
            }
        }

        public Domain.Model.BlogPost ReadBlogPost(int id)
        {
            using (BlogPostContext context = new BlogPostContext())
            {
                var post = context.BlogPosts.Find(id);
                if (post != null)
                {
                    return post.ToDomainBlogPost();
                }
                return null;
            }
        }

        public void UpdateBlogPost(Domain.Model.BlogPost post)
        {
            using (BlogPostContext context = new BlogPostContext())
            {
                context.Entry(new Data.Model.BlogPost { 
                    Id = post.Id, Post = post.Post, Title = post.Title 
                }).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteBlogPost(int id)
        {
            using (BlogPostContext context = new BlogPostContext())
            {
                Data.Model.BlogPost post = context.BlogPosts.Find(id);
                context.Entry(post).State = System.Data.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
