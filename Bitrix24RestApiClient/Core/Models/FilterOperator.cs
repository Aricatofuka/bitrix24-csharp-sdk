namespace BXRest.Core.Models
{
    /// Операторы взяты с https://dev.1c-bitrix.ru/learning/course/index.php?COURSE_ID=43&LESSON_ID=5753&LESSON_PATH=3913.3516.5748.5063.5753
    public enum FilterOperator
    {
        /// Без фильтра
        Default = 0,
        /// Оператор 'Равно'
        Equal,
        /// Оператор 'Больше чем'
        GreatThan,
        /// Оператор 'Меньше чем'
        LessThan,
        /// Оператор 'Больше или равно'
        GreatThanOrEqual,
        /// Оператор 'Меньше или равно'
        LessThanOrEqual,
        /// Оператор 'Содержится в массиве'
        InArray,
        /// Оператор 'Не содержится в массиве'
        NotInArray,
        /// Оператор 'Содержит подстроку'
        Substring,
        /// Оператор 'Не равно'
        NotEqual,
        /// Оператор 'Не равно'
        NotSubstring,
        /// Оператор 'Соответствует шаблону'
        Like
    }
}
