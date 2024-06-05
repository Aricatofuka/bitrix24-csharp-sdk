namespace BXRest.Models.Tasks.Task
{
    /// Краткая запись пользователя в задачу
    public class iPeople
    {
        /// Индификатор пользователя
        public int id { get; set; }
        
        /// Имя пользователя
        public string name { get; set; } = string.Empty;
        
        /// Ссылка
        public string link { get; set; } = string.Empty;
        
        /// Аватар в миниатюре
        public string icon { get; set; } = string.Empty;
        
        /// Позиция работника
        public string workPosition { get; set; } = string.Empty;
    }
}
