using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PansoyIPT101Solution.PansoyDomain.Commands;
using PansoyIPT101Solution.PansoyFramework.DTOs;

namespace PansoyIPT101Solution.PansoyFramework.Commands
{
    public class DeleteYouTubeViewerCommand : IDeleteYouTubeViewerCommand
    {
        private readonly YouTubeViewersDbContextFactory _contextFactory;

        public DeleteYouTubeViewerCommand(YouTubeViewersDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task Execute(Guid id)
        {
            using (YouTubeViewersDbContext context = _contextFactory.Create())
            {
                YouTubeViewerDto youTubeViewerDto = new YouTubeViewerDto()
                {
                    Id = id,
                };

                context.YouTubeViewers.Remove(youTubeViewerDto);
                await context.SaveChangesAsync();
            }
        }
    }
}
