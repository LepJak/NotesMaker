namespace NotesMaker.Backend.Domain.Common
{
    public class Note
    {
        public Guid Uid { get; set; }
        public Guid Owner { get; set; }
        public string? Tittle { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string? Content { get; set; }
        public bool IsDeleted { get; set; }
        public IEnumerable<NoteAccess> NoteAccess { get; set; } 
            = Enumerable.Empty<NoteAccess>();
    }
}
