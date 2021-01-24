using System;
using System.Linq.Expressions;
using System.Reflection;

namespace CyberCAT.Core.Classes.Mapping
{
    // http://geekswithblogs.net/Madman/archive/2008/06/27/faster-reflection-using-expression-trees.aspx
    public class PropertyHelper
    {
        public PropertyInfo Property { get; set; }

        private Func<object, object> _getDelegate;
        private Action<object, object> _setDelegate;

        private bool _defaultValueSet;
        private object _defaultValue;

        public PropertyHelper(PropertyInfo property)
        {
            Property = property;
        }

        private void InitializeGet()
        {
            var instance = Expression.Parameter(typeof(object), "instance");
            var instanceCast = (!Property.DeclaringType.IsValueType) ? Expression.TypeAs(instance, Property.DeclaringType) : Expression.Convert(instance, Property.DeclaringType);
            _getDelegate = Expression.Lambda<Func<object, object>>(Expression.TypeAs(Expression.Call(instanceCast, Property.GetGetMethod()), typeof(object)), instance).Compile();
        }

        private void InitializeSet()
        {
            var instance = Expression.Parameter(typeof(object), "instance");
            var value = Expression.Parameter(typeof(object), "value");
            var instanceCast = (!Property.DeclaringType.IsValueType) ? Expression.TypeAs(instance, Property.DeclaringType) : Expression.Convert(instance, Property.DeclaringType);
            var valueCast = (!Property.PropertyType.IsValueType) ? Expression.TypeAs(value, Property.PropertyType) : Expression.Convert(value, Property.PropertyType);
            _setDelegate = Expression.Lambda<Action<object, object>>(Expression.Call(instanceCast, Property.GetSetMethod(), valueCast), instance, value).Compile();
        }

        public object Get(object instance)
        {
            if (_getDelegate == null)
                InitializeGet();

            return _getDelegate(instance);
        }

        public void Set(object instance, object value)
        {
            if (_setDelegate == null)
                InitializeSet();

            _setDelegate(instance, value);
        }

        public bool IsDefault(object value)
        {
            if (!_defaultValueSet)
            {
                _defaultValue = Get(Activator.CreateInstance(Property.ReflectedType));
                _defaultValueSet = true;
            }

            return CompareValues(_defaultValue, value);
        }

        private bool CompareValues(object valueA, object valueB)
        {
            bool result;

            if (valueA == null && valueB != null || valueA != null && valueB == null)
                result = false; // one of the values is null
            else if (valueA is IComparable selfValueComparer && selfValueComparer.CompareTo(valueB) != 0)
                result = false; // the comparison using IComparable failed
            else if (!Equals(valueA, valueB))
                result = false; // the comparison using Equals failed
            else
                result = true; // match

            return result;
        }
    }
}