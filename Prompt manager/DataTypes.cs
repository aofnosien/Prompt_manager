using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prompt_manager
{
    public enum UI_mode
    {
        NAI,
        WebUI,
    }

    public class TagData
    {
        public string tagName = "";
        public int index = -1;
        public double positive = 0;
        public double negative = 0;
        public bool disabled = false;

        public (string, string) ToString(UI_mode type)
        {
            var positive_str = new StringBuilder();
            var negative_str = new StringBuilder();

            if (this.positive != 0)
            {
                if (this.positive == 1)
                {
                    positive_str.Append(this.tagName);
                }
                else
                {
                    if (type == UI_mode.WebUI)
                    {
                        var multiplier = (Math.Floor(this.positive * 100) * 0.01).ToString();
                        if (multiplier.Length > multiplier.IndexOf('.') + 3)
                            multiplier = multiplier[..(multiplier.IndexOf('.') + 3)];
                        positive_str.Append("(" + this.tagName + ":" + multiplier + ")");
                    }
                    else
                    {
                        string prefix = "", suffix = "";
                        var multiplier = 1.0;
                        if (multiplier < this.positive)
                        {
                            while (multiplier + 0.001 < this.positive)
                            {
                                multiplier += 0.1;
                                prefix += "{";
                                suffix += "}";
                            }
                        }
                        else
                        {
                            while (multiplier - 0.001 > this.positive)
                            {
                                multiplier -= 0.1;
                                prefix += "[";
                                suffix += "]";
                            }
                        }
                        positive_str.Append(prefix + this.tagName + suffix);
                    }
                }
            }
            if (this.negative != 0)
            {
                if (this.negative == 1)
                {
                    negative_str.Append(this.tagName);
                }
                else
                {
                    if (type == UI_mode.WebUI)
                    {
                        var multiplier = (Math.Floor(this.negative * 100) * 0.01).ToString();
                        if (multiplier.Length > multiplier.IndexOf('.') + 3)
                            multiplier = multiplier[..(multiplier.IndexOf('.') + 3)];
                        negative_str.Append("(" + this.tagName + ":" + multiplier + ")");
                    }
                    else
                    {
                        string prefix = "", suffix = "";
                        var multiplier = 1.0;
                        if (multiplier < this.negative)
                        {
                            while (multiplier + 0.001 < this.negative)
                            {
                                multiplier += 0.1;
                                prefix += "{";
                                suffix += "}";
                            }
                        }
                        else
                        {
                            while (multiplier - 0.001 > this.negative)
                            {
                                multiplier -= 0.1;
                                prefix += "[";
                                suffix += "]";
                            }
                        }
                        negative_str.Append(prefix + this.tagName + suffix);
                    }
                }
            }
            return (positive_str.ToString(), negative_str.ToString());
        }
    }

    public class PromptData
    {
        public string name = "";
        public List<TagData> tags = new();
        public List<ListViewItem> items = new();
    }
}
