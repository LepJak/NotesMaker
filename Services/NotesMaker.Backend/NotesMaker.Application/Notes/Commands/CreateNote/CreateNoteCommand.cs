using MediatR;

namespace NotesMaker.Application.Notes.Commands.CreateNote
{
    public class CreateNoteCommand : IRequest<Guid>
    {
        public Guid UserUid { get; set; }
    }
}
