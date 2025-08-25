using Microsoft.EntityFrameworkCore;
using NotesMaker.Backend.Domain.Common;

namespace NotesMaker.Application.Data;

public interface INoteDataContext
{
    DbSet<Note> Notes { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}