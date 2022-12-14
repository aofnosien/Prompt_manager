using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prompt_manager
{
    public class Parsing_Quest
    {
        public Func<Prompt_Parser, bool> trigger;
        public Func<Prompt_Parser, bool> ender;
        public Action<Prompt_Parser, List<TagData>> afterAction;
        public int trigger_length = 1;
        public int ender_length = 1;
        public Parsing_Quest() { }
        public Parsing_Quest(Func<Prompt_Parser, bool> trigger, Func<Prompt_Parser, bool> ender, Action<Prompt_Parser, List<TagData>> afterAction)
        {
            this.trigger = trigger;
            this.ender = ender;
            this.afterAction = afterAction;
            
        }
        public static Parsing_Quest WebUI_weighting = new()
        {
            trigger = (parser) =>
            {
                if (parser.prompt[parser.cursor] == '(' &&
                    (parser.cursor > 0 && parser.prompt[parser.cursor - 1] == '\\') == false)
                {
                    return true;
                }
                return false;
            },
            ender = (parser) =>
            {
                if (parser.prompt[parser.cursor] == ')' &&
                    (parser.cursor > 0 && parser.prompt[parser.cursor - 1] == '\\') == false)
                {
                    return true;
                }
                return false;
            },
            afterAction = (parser, tags) =>
            {
                if (tags == null || tags.Count() == 0)
                    return;
                TagData lastTag = tags.Last();

                for (var i = lastTag.tagName.Length - 1; i >= 0; i--)
                {
                    if (lastTag.tagName[i] == ':')
                    {
                        var multiplier_text = lastTag.tagName[(i + 1)..];

                        var multiplier = 1.0;
                        if (Double.TryParse(multiplier_text, out multiplier) == false)
                            break;

                        lastTag.tagName = lastTag.tagName[..i];
                        multiplier_text = multiplier_text.Trim();

                        foreach (var tag in tags)
                        {
                            tag.positive *= multiplier;
                            tag.negative *= multiplier;
                        }
                        return;
                    }
                }

                foreach (var tag in tags)
                {
                    //tag.positive *= 1.1;
                    //tag.negative *= 1.1;
                    if (tag.positive > 0)
                        tag.positive += 0.1;
                    if (tag.negative > 0)
                        tag.negative += 0.1;
                }
            }
        };
        public static Parsing_Quest WebUI_squareBracket = new()
        {
            trigger = (parser) =>
            {
                if (parser.prompt[parser.cursor] == '[' &&
                    (parser.cursor > 0 && parser.prompt[parser.cursor - 1] == '\\') == false)
                {
                    return true;
                }
                return false;
            },
            ender = (parser) =>
            {
                if (parser.prompt[parser.cursor] == ']' &&
                    (parser.cursor > 0 && parser.prompt[parser.cursor - 1] == '\\') == false)
                {
                    return true;
                }
                return false;
            },
            afterAction = (parser, tags) =>
            {
                if (tags == null || tags.Count() == 0)
                    return;
                TagData lastTag = tags.Last();

                for (var i = lastTag.tagName.Length - 1; i >= 0; i--)
                {
                    // [whatever]
                    if (lastTag.tagName[i] == ':')
                    {
                        var multiplier_text = lastTag.tagName[(i + 1)..];

                        var multiplier = 1.0;
                        if (Double.TryParse(multiplier_text, out multiplier) == false)
                            break;

                        // [whatever : number]
                        // Separated rendering related grammar...

                        lastTag.tagName = "[" + lastTag.tagName + "]";

                        return;
                    }
                }

                foreach (var tag in tags)
                {
                    //tag.positive /= 1.1;
                    //tag.negative /= 1.1;
                    if (tag.positive > 0)
                        tag.positive = Math.Max(0.1, tag.positive - 0.1);
                    if (tag.negative > 0)
                        tag.negative = Math.Max(0.1, tag.negative - 0.1);
                }
            }
        };
        public static Parsing_Quest NAI_weighting = new()
        {
            trigger = (parser) =>
            {
                if (parser.prompt[parser.cursor] == '{' &&
                    (parser.cursor > 0 && parser.prompt[parser.cursor - 1] == '\\') == false)
                {
                    return true;
                }
                return false;
            },
            ender = (parser) =>
            {
                if (parser.prompt[parser.cursor] == '}' &&
                    (parser.cursor > 0 && parser.prompt[parser.cursor - 1] == '\\') == false)
                {
                    return true;
                }
                return false;
            },
            afterAction = (parser, tags) =>
            {
                foreach (var tag in tags)
                {
                    //tag.positive /= 1.1;
                    //tag.negative /= 1.1;
                    if (tag.positive > 0)
                        tag.positive += 0.1;
                    if (tag.negative > 0)
                        tag.negative += 0.1;
                }
            }
        };
        public static List<Parsing_Quest> WebUI_quests = new()
        {
            WebUI_weighting,
            WebUI_squareBracket,
        };
        public static List<Parsing_Quest> NAI_quests = new()
        {
            NAI_weighting,
            WebUI_squareBracket,
        };
    }
}
