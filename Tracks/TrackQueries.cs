using Microsoft.EntityFrameworkCore;
using ConferencePlanner.GraphQL.Data;
using ConferencePlanner.GraphQL.DataLoader;

namespace ConferencePlanner.GraphQL.Tracks;

[ExtendObjectType("Query")]
[Obsolete]
public class TrackQueries
{
    [UseDbContext(typeof(ApplicationDbContext))]
    public async Task<IEnumerable<Track>> GetTracksAsync(
        [ScopedService] ApplicationDbContext context,
        CancellationToken cancellationToken) =>
        await context.Tracks.ToListAsync(cancellationToken);

    [UseDbContext(typeof(ApplicationDbContext))]
    public Task<Track> GetTrackByNameAsync(
        string name,
        [ScopedService] ApplicationDbContext context,
        CancellationToken cancellationToken) =>
        context.Tracks.FirstAsync(t => t.Name == name);

    [UseDbContext(typeof(ApplicationDbContext))]
    public async Task<IEnumerable<Track>> GetTrackByNamesAsync(
        string[] names,
        [ScopedService] ApplicationDbContext context,
        CancellationToken cancellationToken) =>
        await context.Tracks.Where(t => names.Contains(t.Name)).ToListAsync();

    public Task<Track> GetTrackByIdAsync(
        [ID(nameof(Track))] int id,
        TrackByIdDataLoader trackById,
        CancellationToken cancellationToken) =>
        trackById.LoadAsync(id, cancellationToken);

    public async Task<IEnumerable<Track>> GetTracksByIdAsync(
        [ID(nameof(Track))] int[] ids,
        TrackByIdDataLoader trackById,
        CancellationToken cancellationToken) =>
        await trackById.LoadAsync(ids, cancellationToken);
}