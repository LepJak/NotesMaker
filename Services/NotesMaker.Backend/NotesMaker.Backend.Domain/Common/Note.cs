namespace NotesMaker.Backend.Domain.Common
{
    /// <summary>
    /// Заметка
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Уникальный идентификатор заметки
        /// </summary>
        public Guid Uid { get; set; }

        /// <summary>
        /// Идентификатор владельца заметки
        /// </summary>
        public Guid Owner { get; set; }

        /// <summary>
        /// Заголовок заметки
        /// </summary>
        public string? Tittle { get; set; }

        /// <summary>
        /// Дата создания заметки
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Дата последнего изменения заметки
        /// </summary>
        public DateTime Updated { get; set; }

        /// <summary>
        /// Содержимое заметки
        /// </summary>
        public string? Content { get; set; }

        /// <summary>
        /// Флаг, указывающий, удалена ли заметка
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Список прав доступа к заметке у сторонних пользователей
        /// </summary>
        public IEnumerable<NoteAccess> NoteAccess { get; set; } 
            = [];
    }
}
