using System;

public static class StringExtentions
{
    public static bool ContainsIgnoreCase(this string str, StringComparison comp, string toCheck)
    {
        try
        {
            return str?.IndexOf(toCheck, comp) >= 0;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool ContainsIgnoreCase(this string str, string toCheck)
    {
        try
        {
            return str?.IndexOf(toCheck, StringComparison.OrdinalIgnoreCase) >= 0;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool ContainsIgnoreCase(this string str, StringComparison comp, params string[] toCheck)
    {
        try
        {
            foreach (var item in toCheck)
                if (str.ContainsIgnoreCase(comp, item))
                    return true;

            return false;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool ContainsIgnoreCase(this string str, params string[] toCheck)
    {
        try
        {
            foreach (var item in toCheck)
                if (str.ContainsIgnoreCase(StringComparison.OrdinalIgnoreCase, item))
                    return true;

            return false;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool Contains(this string str, params string[] toCheck)
    {
        try
        {
            foreach (var item in toCheck)
                if (str.Contains(item))
                    return true;

            return false;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool EqualsIgnoreCase(this string str, string toCheck)
    {
        try
        {
            return str.Equals(toCheck, StringComparison.OrdinalIgnoreCase);
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool IsBase64(this string base64String)
    {
        if (string.IsNullOrEmpty(base64String) || base64String.Length % 4 != 0
           || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
            return false;

        try
        {
            Convert.FromBase64String(base64String);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public static bool StartsWith(this string str, params string[] toCheck)
    {
        try
        {
            foreach (var item in toCheck)
                if (str.StartsWith(item))
                    return true;

            return false;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool StartsWithIgnoreCase(this string str, string toCheck)
    {
        try
        {
            if (str.StartsWith(toCheck, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool StartsWithIgnoreCase(this string str, params string[] toCheck)
    {
        try
        {
            foreach (var item in toCheck)
                if (str.StartsWith(item, StringComparison.OrdinalIgnoreCase))
                    return true;

            return false;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool EndsWith(this string str, params string[] toCheck)
    {
        try
        {
            foreach (var item in toCheck)
                if (str.EndsWith(item))
                    return true;

            return false;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool EndsWithIgnoreCase(this string str, string toCheck)
    {
        try
        {
            if (str.EndsWith(toCheck, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public static bool EndsWithIgnoreCase(this string str, params string[] toCheck)
    {
        try
        {
            foreach (var item in toCheck)
                if (str.EndsWith(item, StringComparison.OrdinalIgnoreCase))
                    return true;

            return false;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}