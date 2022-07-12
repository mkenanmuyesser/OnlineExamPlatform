using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI.WebControls;
using System.Collections.Specialized;

/// <summary>
/// Summary description for GenelIslemler
/// </summary>
public static class GenisletmeMetotlari
{
    public static string ToURL(this string s)
    {
        //s = oncul + id + "-" + s;
        if (string.IsNullOrEmpty(s)) return "";
        if (s.Length > 80)
            s = s.Substring(0, 80);
        s = s.Replace("�", "s");
        s = s.Replace("�", "S");
        s = s.Replace("�", "g");
        s = s.Replace("�", "G");
        s = s.Replace("�", "I");
        s = s.Replace("�", "i");
        s = s.Replace("�", "c");
        s = s.Replace("�", "C");
        s = s.Replace("�", "o");
        s = s.Replace("�", "O");
        s = s.Replace("�", "u");
        s = s.Replace("�", "U");
        s = s.Replace("'", "");
        s = s.Replace("\"", "");
        Regex r = new Regex("[^a-zA-Z0-9_-]");
        //if (r.IsMatch(s))
        s = r.Replace(s, "-");
        if (!string.IsNullOrEmpty(s))
            while (s.IndexOf("--") > -1)
                s = s.Replace("--", "-");
        if (s.StartsWith("-")) s = s.Substring(1);
        if (s.EndsWith("-")) s = s.Substring(0, s.Length - 1);
        return s;
    }

    public static bool IsInteger(this object sayi)
    {
        try
        {
            if (sayi == null) throw new Exception();
            Convert.ToInt32(sayi);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public static int ToInt32(this object sayi)
    {
        try
        {
            if (sayi == null) throw new Exception();
            int x = Convert.ToInt32(sayi);
            return x;
        }
        catch (Exception)
        {
            return 0;
        }
    }

}
