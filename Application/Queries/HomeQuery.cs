using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Models;

namespace Application.Queries
{
    internal class HomeQuery : IHomeQuery
    {
        public Task<HomeModel> GetHomeModel(CancellationToken cancellationToken = default)
        {
            var result = new HomeModel
            {
                Banner = new List<Banner>
                {
                    new Banner
                    {
                        Description = "Nulla vitae elit libero, a pharetra augue mollis interdum.",
                        Title = "Titulo 1",
                        HeaderUri = "https://via.placeholder.com/1820x720"
                    },
                    new Banner
                    {
                        Description = "Nulla vitae elit libero, a pharetra augue mollis interdum.",
                        Title = "Titulo 2",
                        HeaderUri = "https://via.placeholder.com/1820x720"
                    },
                    new Banner
                    {
                        Description = "Nulla vitae elit libero, a pharetra augue mollis interdum.",
                        Title = "Titulo 3",
                        HeaderUri = "https://via.placeholder.com/1820x720"
                    },
                    new Banner
                    {
                        Description = "Nulla vitae elit libero, a pharetra augue mollis interdum.",
                        Title = "Titulo 4",
                        HeaderUri = "https://via.placeholder.com/1820x720"
                    }
                },
                Posts = new List<PostSummary>
                {
                    new PostSummary
                    {
                        Summary =
                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
                        Title = "Título de la noticia",
                        HeaderImageUri = "https://via.placeholder.com/328x225"
                    },
                    new PostSummary
                    {
                        Summary =
                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
                        Title = "Título de la noticia",
                        HeaderImageUri = "https://via.placeholder.com/328x225"
                    },
                    new PostSummary
                    {
                        Summary =
                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
                        Title = "Título de la noticia",
                        HeaderImageUri = "https://via.placeholder.com/328x225"
                    },
                    new PostSummary
                    {
                        Summary =
                            "This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.",
                        Title = "Título de la noticia",
                        HeaderImageUri = "https://via.placeholder.com/328x225"
                    }
                }
            };

            return Task.FromResult(result);
        }
    }
}