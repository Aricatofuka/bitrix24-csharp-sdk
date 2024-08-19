using System;

namespace BXRest.Core.Models
{
    /// Общая модель для разных фильтров в методах
    public class Filter {

        /// Имя фильтра
        public string Name { get; set; }

        /// значение фильтра
        public object Value { get; set; }

        /// Дефолтный результат
        public FilterOperator Operator { get; set; } = FilterOperator.Default;

        /// Результат с префиксом 
        public string NameWithOperatorPrefix {
            get{
                return $"{OperatorPrefix}{Name}";
            }
        }

        /// Перефексы в стиле mySQL
        private string OperatorPrefix
        {
            get
            {
                switch (Operator)
                {
                    case FilterOperator.GreatThan:
                        return ">";
                    case FilterOperator.LessThan:
                        return "<";
                    case FilterOperator.GreatThanOrEqual:
                        return ">=";
                    case FilterOperator.LessThanOrEqual:
                        return "<=";
                    case FilterOperator.InArray:
                        return "@";
                    case FilterOperator.NotInArray:
                        return "!@";
                    case FilterOperator.Substring:
                        return "%";
                    case FilterOperator.NotEqual:
                        return "!";
                    case FilterOperator.NotSubstring:
                        return "!%";
                    case FilterOperator.Like:
                        return "=%";
                    case FilterOperator.Equal:
                        return "=";
                    case FilterOperator.Default:
                        return "";
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
