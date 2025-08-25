using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace NotesMaker.Application.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommand : IRequest<Guid>
    {
        public Guid Uid { get; set; }
        public string? Tittle { get; set; }
        public string? Content { get; set; }
        public Guid UserUid { get; set; }
    }
}
