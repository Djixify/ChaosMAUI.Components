namespace ChaosMAUI.Components
{
    public partial class Styling
    {
        public class Layout
        {
            public enum Orientation
            {
                Horizontal,
                Vertical
            }

            public enum AlignItems
            {
                Normal,
                Start,
                Center,
                End,
                Stretch,
                Baseline
            }

            public static string GetAlignItems(AlignItems alignItems)
            {
                return alignItems switch
                {
                    AlignItems.Normal => "align-items: normal",
                    AlignItems.Start => "align-items: start",
                    AlignItems.Center => "align-items: center",
                    AlignItems.End => "align-items: end",
                    AlignItems.Stretch => "align-items: stretch",
                    AlignItems.Baseline => "align-items: baseline",
                    _ => "align-items: normal"
                };
            }

            public enum AlignContent
            {
                Normal,
                Start,
                Center,
                End,
                Stretch,
                SpaceBetween,
                SpaceAround,
                SpaceEvenly,
                Baseline
            }

            public static Dictionary<AlignContent, string> AlignContentClasses = new()
            {
                { Layout.AlignContent.Normal, "align-content: normal" },
                { Layout.AlignContent.Start, "align-content: start" },
                { Layout.AlignContent.Center, "align-content: center" },
                { Layout.AlignContent.End, "align-content: end" },
                { Layout.AlignContent.Stretch, "align-content: stretch" },
                { Layout.AlignContent.SpaceBetween, "align-content: space-between" },
                { Layout.AlignContent.SpaceAround, "align-content: space-around" },
                { Layout.AlignContent.SpaceEvenly, "align-content: space-evenly" },
                { Layout.AlignContent.Baseline, "align-content: baseline" }
            };

            public enum AlignSelf
            {
                Auto,
                Normal,
                Start,
                Center,
                End,
                Stretch,
                Baseline
            }

            public static Dictionary<AlignSelf, string> AlignSelfClasses = new()
            {
                { Layout.AlignSelf.Auto, "align-self: auto" },
                { Layout.AlignSelf.Normal, "align-self: normal" },
                { Layout.AlignSelf.Start, "align-self: start" },
                { Layout.AlignSelf.Center, "align-self: center" },
                { Layout.AlignSelf.End, "align-self: end" },
                { Layout.AlignSelf.Stretch, "align-self: stretch" },
                { Layout.AlignSelf.Baseline, "align-self: baseline" }
            };

            public enum JustifyContent
            {
                Start,
                Center,
                End,
                Stretch,
                SpaceBetween,
                SpaceAround,
                SpaceEvenly,
                Left,
                Right
            }

            public static Dictionary<JustifyContent, string> JustifyContentClasses = new()
            {
                { Layout.JustifyContent.Start, "justify-content: start" },
                { Layout.JustifyContent.Center, "justify-content: center" },
                { Layout.JustifyContent.End, "justify-content: end" },
                { Layout.JustifyContent.Stretch, "justify-content: stretch" },
                { Layout.JustifyContent.SpaceBetween, "justify-content: space-between" },
                { Layout.JustifyContent.SpaceAround, "justify-content: space-around" },
                { Layout.JustifyContent.SpaceEvenly, "justify-content: space-evenly" },
                { Layout.JustifyContent.Left, "justify-content: left" },
                { Layout.JustifyContent.Right, "justify-content: right" }
            };

            public enum JustifyItems
            {
                Auto,
                Normal,
                Stretch,
                Start,
                Center,
                End,
                Left,
                Right,
                Legacy,
                Baseline
            }

            public static Dictionary<JustifyItems, string> JustifyItemsClasses = new()
            {
                { Layout.JustifyItems.Auto, "justify-items: auto" },
                { Layout.JustifyItems.Normal, "justify-items: normal" },
                { Layout.JustifyItems.Stretch, "justify-items: stretch" },
                { Layout.JustifyItems.Start, "justify-items: start" },
                { Layout.JustifyItems.Center, "justify-items: center" },
                { Layout.JustifyItems.End, "justify-items: end" },
                { Layout.JustifyItems.Left, "justify-items: left" },
                { Layout.JustifyItems.Right, "justify-items: right" },
                { Layout.JustifyItems.Legacy, "justify-items: legacy" },
                { Layout.JustifyItems.Baseline, "justify-items: baseline" }
            };

            public enum JustifySelf
            {
                Auto,
                Normal,
                Start,
                Center,
                End,
                Stretch,
                Left,
                Right,
                Baseline,
                Legacy
            }

            public static Dictionary<JustifySelf, string> JustifySelfClasses = new()
            {
                { Layout.JustifySelf.Auto, "justify-self: auto" },
                { Layout.JustifySelf.Normal, "justify-self: normal" },
                { Layout.JustifySelf.Start, "justify-self: start" },
                { Layout.JustifySelf.Center, "justify-self: center" },
                { Layout.JustifySelf.End, "justify-self: end" },
                { Layout.JustifySelf.Stretch, "justify-self: stretch" },
                { Layout.JustifySelf.Left, "justify-self: left" },
                { Layout.JustifySelf.Right, "justify-self: right" },
                { Layout.JustifySelf.Baseline, "justify-self: baseline" },
                { Layout.JustifySelf.Legacy, "justify-self: legacy" }
            };

            public enum TextAlign
            {
                Left,
                Right,
                Center,
                Justify,
                Start,
                End
            }

            public static Dictionary<TextAlign, string> TextAlignClasses = new()
            {
                { Layout.TextAlign.Left, "text-align: left" },
                { Layout.TextAlign.Right, "text-align: right" },
                { Layout.TextAlign.Center, "text-align: center" },
                { Layout.TextAlign.Justify, "text-align: justify" },
                { Layout.TextAlign.Start, "text-align: start" },
                { Layout.TextAlign.End, "text-align: end" }
            };
        }
    }
}