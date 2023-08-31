using System.ComponentModel;

namespace BXRest.Api.Models
{
    public class Base
    {
        public class iBXRestBaseParam
        {
            public int? start { get; set; }
        }

        public enum iBXRestYesNo
        {
            Y = 'Y',
            N = 'N'
        }

        public enum iBXRestOrder
        {
            [Description("asc")]
            Asc,
            [Description("desc")]
            Desc
        }

        /*
        enum MyEnum
        {
            Value1 = new List<char> { 's', 't' },
            Value2 = new List<char> { 's', 't' },
            Value3 = iBXRestOrder
        }
        */

        /*
        public sealed class iBXRestOrder : SmartEnum<iBXRestOrder>
        {
            public static readonly iBXRestOrder Asc = new("asc", 1);

            public static readonly iBXRestOrder Desc = new("desc", 2);

            private iBXRestOrder(string name, int value) : base(name, value)
            {
            }
        }
        */

        /*
        public enum iBXRestOrder 
        {
            [Description("asc")]
            asc,
            [Description("desc")]
            desc
        }
        */

        /*
        public abstract class Enumeration : IComparable
        {
            public string Name { get; private set; }

            public int Id { get; private set; }

            protected Enumeration(int id, string name) => (Id, Name) = (id, name);

            public override string ToString() => Name;

            public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
                typeof(T).GetFields(BindingFlags.Public |
                                    BindingFlags.Static |
                                    BindingFlags.DeclaredOnly)
                         .Select(f => f.GetValue(null))
                         .Cast<T>();

            public override bool Equals(object obj)
            {
                if (obj is not Enumeration otherValue)
                {
                    return false;
                }

                var typeMatches = GetType().Equals(obj.GetType());
                var valueMatches = Id.Equals(otherValue.Id);

                return typeMatches && valueMatches;
            }

            public int CompareTo(object other) => Id.CompareTo(((Enumeration)other).Id);


            // Other utility methods ...
        }

        /*
        public static Dictionary<int, string> iBXRestOrder = new Dictionary<int, string>()
        {
                { 1, "asc"},

                { 2, "desc"}
        };
        */

        /*
        public readonly struct iBXRestOrder : IEquatable<iBXRestOrder>
        {
            private readonly string _value;

            public static iBXRestOrder Asc { get; } = new iBXRestOrder("asc");
            public static iBXRestOrder Desc { get; } = new iBXRestOrder("desc");

            public iBXRestOrder(string value)
            {
                _value = value;
            }

            public override bool Equals(object obj)
            {
                return obj is iBXRestOrder p && Equals(p);
            }

            public bool Equals(iBXRestOrder other)
            {
                return _value == other._value;
            }

            public static bool operator ==(iBXRestOrder left, iBXRestOrder right) => Equals(left, right);

            public static bool operator !=(iBXRestOrder left, iBXRestOrder right) => !Equals(left, right);

            public static explicit operator string(iBXRestOrder value) => value.ToString();

            public static explicit operator iBXRestOrder(string value) => new iBXRestOrder(value);

            public override string? ToString() => _value;
        }


        // Console.WriteLine(CountryType.UnitedStates); // "United States"
       
        */
    }
}
