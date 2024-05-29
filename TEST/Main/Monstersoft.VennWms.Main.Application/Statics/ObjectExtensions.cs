using System.Reflection;

namespace Monstersoft.VennWms.Main.Application.Statics;

public static class ObjectExtensions
{
    public static bool AnyPropertyTrue<T>(this T obj)
    {
        if (obj == null)
        {
            return false;
        }

        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties();

        foreach (var property in properties)
        {
            if (property.PropertyType == typeof(bool))
            {
                bool value = (bool)property.GetValue(obj);
                if (value)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
