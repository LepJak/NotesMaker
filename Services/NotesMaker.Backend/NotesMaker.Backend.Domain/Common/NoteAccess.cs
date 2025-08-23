
namespace NotesMaker.Backend.Domain.Common
{
    public class NoteAccess
    {
        public Guid Uid { get; set; }
        public Guid UserUid { get; set; }
        public Guid NoteUid { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        private bool Delete { get; set; }
    }
}
