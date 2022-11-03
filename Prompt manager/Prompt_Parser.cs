using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prompt_manager
{
    public class Prompt_Parser
    {
        public UI_mode type;
        public string prompt;
        public int cursor = 0;
        public int startPoint;
        public Prompt_Parser() { }
        public Prompt_Parser(UI_mode type, string prompt, int cursor = 0)
        {
            this.type = type;
            this.prompt = prompt;
            this.cursor = cursor;
            this.startPoint = cursor;
        }
        public List<TagData> Prompt_to_list(double positiveOffset, double negativeOffset, Func<Prompt_Parser, bool> enderMission = null)
        {
            var list = new List<TagData>();

            if (string.IsNullOrEmpty(prompt))
                return null;

            var quests = (type == UI_mode.NAI) ? Parsing_Quest.NAI_quests : Parsing_Quest.WebUI_quests;

            var token_start = this.startPoint;

            Action Cut_and_add = () =>
            {
                if (token_start < this.cursor)
                {
                    var tagText = prompt[token_start..this.cursor];
                    token_start = this.cursor + 1;

                    tagText = tagText.Trim();
                    if (string.IsNullOrEmpty(tagText) == false)
                    {
                        list.Add(new TagData()
                        {
                            tagName = tagText,
                            positive = positiveOffset,
                            negative = negativeOffset,
                        });
                    }
                }
            };

            for (; cursor < prompt.Length; cursor++)
            {
                if (enderMission != null && enderMission(this))
                {
                    Cut_and_add();
                    return list;
                }
                foreach (var quest in quests)
                {
                    if (cursor >= prompt.Length)
                        return list;
                    if (quest.trigger(this))
                    {
                        this.cursor += quest.trigger_length;

                        var parser = new Prompt_Parser(this.type, this.prompt, this.cursor);

                        var result = parser.Prompt_to_list(positiveOffset, negativeOffset, quest.ender);

                        this.cursor = parser.cursor;

                        this.cursor += quest.ender_length;

                        if (quest.afterAction != null && result != null)
                            quest.afterAction(parser, result);

                        list.AddRange(result);

                        token_start = this.cursor;
                        for (; cursor < prompt.Length; cursor++)
                        {
                            if (char.IsWhiteSpace(prompt[cursor]))
                                continue;

                            token_start = this.cursor;
                            if (prompt[cursor] == ',')
                                token_start = this.cursor + 1;

                            break;
                        }

                        if (cursor >= prompt.Length || (enderMission != null && enderMission(this)))
                        {
                            token_start = this.cursor + 1;
                            return list;
                        }

                        continue;
                    }
                }
                if (cursor >= prompt.Length)
                    break;
                if (prompt[cursor] == ',')
                {
                    Cut_and_add();
                }
            }

            Cut_and_add();

            return list;
        }
        public TagData ParseTag(string tag)
        {
            if (string.IsNullOrEmpty(tag))
                return null;

            var tagData = new TagData();



            return tagData;
        }
        public static (string, string) List_to_prompt(List<TagData> tags, UI_mode type, bool append_space, bool target_is_enabled = true)
        {
            var positive = new StringBuilder();
            var negative = new StringBuilder();

            var separator = "," + (append_space ? " " : "");

            foreach (var tagData in tags)
            {
                if (target_is_enabled == tagData.disabled)
                    continue;

                var result = tagData.ToString(type);

                if (string.IsNullOrEmpty(result.Item1) == false)
                    positive.Append(separator + result.Item1);

                if (string.IsNullOrEmpty(result.Item2) == false)
                    negative.Append(separator + result.Item2);
            }

            var positive_str = positive.ToString();
            var negative_str = negative.ToString();

            if (string.IsNullOrEmpty(positive_str) == false)
                positive_str = positive_str[(separator.Length)..];

            if (string.IsNullOrEmpty(negative_str) == false)
                negative_str = negative_str[(separator.Length)..];

            return (positive_str, negative_str);
        }
    }
}
