using MediatR;
using NotesMaker.Application.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NotesMaker.Application.Notes.Commands.DeleteNote
{
    public class DeleteNoteCommandHandler 
        : IRequestHandler<DeleteNoteCommand, Unit>
    {
        public DeleteNoteCommandHandler(INoteDataContext noteDataContext)
            => _noteDataContext = noteDataContext;

        private readonly INoteDataContext _noteDataContext;

        public async Task<Unit> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
        {
            var note = await _noteDataContext.Notes.FirstOrDefaultAsync(x => x.Uid == request.NoteUid, cancellationToken);
            //TODO: добавить проверку на null и проверку на пользователя
            _noteDataContext.Notes.Remove(note);
            return Unit.Value;
        }
    }
}
