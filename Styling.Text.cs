using System.Drawing;
using System.Text;

namespace ChaosMAUIComponents
{
    public partial class Styling
    {
        public class Text
        {
            public enum Align
            {
                Left,
                Center,
                Right,
                Justify
            }

            public static string GetAlign(Align align)
            {
                return align switch
                {
                    Align.Left => "text-align: left",
                    Align.Center => "text-align: center",
                    Align.Right => "text-align: right",
                    Align.Justify => "text-align: justify",
                    _ => "text-align: left"
                };
            }

            [Flags]
            public enum Decoration
            {
                None = 0,
                Underline = 1,
                Overline = 2,
                LineThrough = 4
            }

            public enum LineStyle
            {
                Dotted,
                Dashed,
                Solid,
                Double,
                Wavy
            }

            public static string GetTextDecoration(Decoration decoration, LineStyle? linestyle = null, Color? color = null)
            {
                if (decoration == Decoration.None)
                    return "text-decoration: none;";

                StringBuilder sb = new StringBuilder("text-decoration: ");
                if (decoration.HasFlag(Decoration.Underline))
                    sb.Append("underline ");
                if (decoration.HasFlag(Decoration.Overline))
                    sb.Append("overline ");
                if (decoration.HasFlag(Decoration.LineThrough))
                    sb.Append("line-through ");

                if (linestyle.HasValue)
                {
                    switch (linestyle.Value)
                    {
                        case LineStyle.Dotted:
                            sb.Append("dotted ");
                            break;

                        case LineStyle.Dashed:
                            sb.Append("dashed ");
                            break;

                        case LineStyle.Solid:
                            sb.Append("solid ");
                            break;

                        case LineStyle.Double:
                            sb.Append("double ");
                            break;

                        case LineStyle.Wavy:
                            sb.Append("wavy ");
                            break;
                    }
                }

                if (color.HasValue)
                    sb.Append($"{ColorTranslator.ToHtml(color.Value)} ");

                return sb.Remove(sb.Length - 1, 1).ToString();
            }

            public static string GetTextColor(Color color)
            {
                return $"color: {ColorTranslator.ToHtml(color)}";
            }

            public enum FontWeight
            {
                Normal,
                Bold,
                Bolder,
                Lighter
            }

            private static string GetFontWeight(FontWeight weight)
            {
                return weight switch
                {
                    FontWeight.Normal => "font-weight: normal",
                    FontWeight.Bold => "font-weight: bold",
                    FontWeight.Bolder => "font-weight: bolder",
                    FontWeight.Lighter => "font-weight: lighter",
                    _ => "font-weight: normal"
                };
            }

            public enum FontStyle
            {
                Normal,
                Italic,
                Oblique
            }

            private static string GetFontStyle(FontStyle style)
            {
                return style switch
                {
                    FontStyle.Normal => "font-style: normal",
                    FontStyle.Italic => "font-style: italic",
                    FontStyle.Oblique => "font-style: oblique",
                    _ => "font-style: normal"
                };
            }

            public enum Font
            {
                Arial,
                Verdana,
                TimesNewRoman,
                Georgia,
                CourierNew,
                TrebuchetMS
            }

            public enum FontGeneric
            {
                SansSerif,
                Serif,
                Monospace,
                Cursive,
                Fantasy
            }

            private static string GetFontGeneric(FontGeneric fontGeneric)
            {
                return fontGeneric switch
                {
                    FontGeneric.SansSerif => "sans-serif",
                    FontGeneric.Serif => "serif",
                    FontGeneric.Monospace => "monospace",
                    FontGeneric.Cursive => "cursive",
                    FontGeneric.Fantasy => "fantasy",
                    _ => "sans-serif"
                };
            }

            private static string GetFontName(Font font)
            {
                return font switch
                {
                    Font.Arial => "Arial",
                    Font.Verdana => "Verdana",
                    Font.TimesNewRoman => @"""Times New Roman""",
                    Font.Georgia => "Georgia",
                    Font.CourierNew => @"""Courier New""",
                    Font.TrebuchetMS => @"""Trebuchet MS""",
                    _ => "Arial"
                };
            }

            public static string GetFontFamily(FontGeneric fontGeneric, params Font[] fonts)
            {
                return "font-family: " + string.Join(", ", fonts.Select(f => GetFontName(f))) + ", " + GetFontGeneric(fontGeneric);
            }

            public static string GetFontFamily(FontGeneric fontGeneric, params string[] fontNames)
            {
                return "font-family: " + string.Join(", ", fontNames) + ", " + GetFontGeneric(fontGeneric);
            }

            public static string GetFontFamily(Font font, FontGeneric? fontGeneric = null)
            {
                return font switch
                {
                    Font.Arial => GetFontFamily(FontGeneric.SansSerif, font),
                    Font.Verdana => GetFontFamily(FontGeneric.SansSerif, font),
                    Font.TimesNewRoman => GetFontFamily(FontGeneric.Serif, font),
                    Font.Georgia => GetFontFamily(FontGeneric.Serif, font),
                    Font.CourierNew => GetFontFamily(FontGeneric.Monospace, font),
                    Font.TrebuchetMS => GetFontFamily(FontGeneric.SansSerif, font),
                    _ => GetFontFamily(FontGeneric.SansSerif, font),
                };
            }
        }
    }
}