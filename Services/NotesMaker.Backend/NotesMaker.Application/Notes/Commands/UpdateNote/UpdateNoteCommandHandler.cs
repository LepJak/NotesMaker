using MediatR;
using NotesMaker.Application.Data;
using NotesMaker.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NotesMaker.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandHandler 
        : IRequestHandler<UpdateNoteCommand, Guid>
    {
        public UpdateNoteCommandHandler(INoteDataContext noteDataContext)
            => _noteDataContext = noteDataContext;

        private readonly INoteDataContext _noteDataContext;
        public async Task<Guid> Handle(UpdateNoteCommand request, CancellationToken cancellationToken)
        {
            var note = await _noteDataContext.Notes
                .FirstOrDefaultAsync(x => x.Uid == request.Uid, cancellationToken);
           
            //TODO: добавить проверку
            if (note == null)
                throw new Exception();

            note.Content = request.Content;
            note.Tittle = request.Tittle;
            note.Updated = DateTime.UtcNow;
            await _noteDataContext.SaveChangesAsync(cancellationToken);
            return note.Uid;
        }
    }
}
