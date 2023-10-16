using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.DataLoader;
using Microsoft.EntityFrameworkCore;

namespace ConferencePlanner.GraphQL
{
    [Obsolete]
    public class Query
    {
        [UseDbContext(typeof(ApplicationDbContext))]
        public Task<List<Speaker>> GetSpeakers([ScopedService] ApplicationDbContext context) =>
            context.Speakers.ToListAsync();

        public Task<Speaker> GetSpeakerAsync(
                                            int id,
                                            SpeakerByIdDataLoader dataLoader,
                                            CancellationToken cancellationToken) =>
            dataLoader.LoadAsync(id, cancellationToken);
    }

}