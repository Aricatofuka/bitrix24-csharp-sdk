using static BXRest.Api.Models.Base;

namespace BXRest.Models.Imbot.Message
{

    /// Параметры для добавления сообщения отл ица бота
    public class iAdd
    {
        /// Идентификатор чат-бота, от которого идет запрос; можно не указывать
        public int? BOT_ID { get; set; }

        /// Идентификатор диалога; это либо USER_ID пользователя, либо chatXX - где XX идентификатор чата
        /// передается в событии ONIMBOTMESSAGEADD и ONIMJOINCHAT
        public int DIALOG_ID { get; set; }

        /// Текст сообщения
        public string MESSAGE { get; set; }

        /// Вложение, необязательное поле
        public string ATTACH { get; set; }

        /// Вложение, необязательное поле
        public string KEYBOARD { get; set; }

        /// Контекстное меню, необязательное поле 
        public string MENU { get; set; }

        /// Отображать сообщения в виде системного сообщения, необязательное поле, по умолчанию 'N'
        public iBXRestYesNo SYSTEM { get; set; }

        /// Преобразовывать ссылки в rich-ссылки, необязательное поле, по умолчанию 'Y'
        public iBXRestYesNo URL_PREVIEW { get; set; }
    }
}
