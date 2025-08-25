using MediatR;
using NotesMaker.Application.Data;
using NotesMaker.Application.Repositories;
using NotesMaker.Backend.Domain.Common;

namespace NotesMaker.Application.Notes.Commands.CreateNote
{
    public class CreateNoteCommandHandler 
        : IRequestHandler<CreateNoteCommand, Guid>
    {
        public CreateNoteCommandHandler(INoteDataContext noteDataContext)
            => _noteDataContext = noteDataContext; 

        private readonly INoteDataContext _noteDataContext;

        public async Task<Guid> Handle(CreateNoteCommand request, CancellationToken cancellationToken)
        {
            var note = new Note
            {
                Uid = Guid.NewGuid(),
                Owner = request.UserUid,
                Created = DateTime.UtcNow,
                Updated = DateTime.UtcNow,
            };
            await _noteDataContext.Notes.AddAsync(note, cancellationToken);
            return note.Uid;
        }
    }
}