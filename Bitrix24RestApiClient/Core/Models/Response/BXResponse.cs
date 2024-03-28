using BXRest.Core.Models.Response.Common;

namespace BXRest.Core.Models.Response
{
    /// Базовый ответ REST API Bitrix
    public class iBXRespnse<T>
    {
        /// Основой ответ
        public T result { get; set; }

        /// следующий номер параметра "start" для постраничной навигации
        public int? next { get; set; }

        /// Всего элементов в ответе
        public int? total { get; set; }

        /// Время ответа
        public Time time { get; set; }
    }
}
