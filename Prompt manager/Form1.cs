using System.Collections;
using System.Diagnostics;
using System.Text;

namespace Prompt_manager
{
    public partial class Form1 : Form
    {
        public UI_mode UI_mode_now = UI_mode.WebUI;
        public static string enabled_text = "";
        public static string disabled_text = "!";
        public string lb_Description_Default = "";
        public List<PromptData> saved_prompts = new();
        public PromptData focusing_prompt = null;
        public List<PromptData> dirty_list = new();
        public string folderPath = Path.Combine(Application.StartupPath, "Prompt_Saved");
        public string path_optionFile = "option.txt";
        public List<string> registed_files = new();
        public string Ult_negatives = "low quality lowres multiple breasts, low quality lowres mutated hands and fingers, low quality lowres long body, low quality lowres mutation poorly drawn, low quality lowres black-white, low quality lowres bad anatomy, low quality lowres liquid body, low quality lowres liquid tongue, low quality lowres disfigured, low quality lowres malformed, low quality lowres mutated, low quality lowres anatomical nonsense, low quality lowres text font ui, low quality lowres error, low quality lowres malformed hands, low quality lowres long neck, low quality lowres blurred, low quality lowres lowers, low quality lowres low res, low quality lowres bad proportions, low quality lowres bad shadow, low quality lowres uncoordinated body, low quality lowres unnatural body, low quality lowres fused breasts, low quality lowres bad breasts, low quality lowres huge breasts, low quality lowres poorly drawn breasts, low quality lowres extra breasts, low quality lowres liquid breasts, low quality lowres heavy breasts, low quality lowres missing breasts, low quality lowres huge haunch, low quality lowres huge thighs, low quality lowres huge calf, low quality lowres bad hands, low quality lowres fused hand, low quality lowres missing hand, low quality lowres disappearing arms, low quality lowres disappearing thigh, low quality lowres disappearing calf, low quality lowres disappearing legs, low quality lowres fused ears, low quality lowres bad ears, low quality lowres poorly drawn ears, low quality lowres extra ears, low quality lowres liquid ears, low quality lowres heavy ears, low quality lowres missing ears, low quality lowres fused animal ears, low quality lowres bad animal ears, low quality lowres poorly drawn animal ears, low quality lowres extra animal ears, low quality lowres liquid animal ears, low quality lowres heavy animal ears, low quality lowres missing animal ears, low quality lowres text, low quality lowres ui, low quality lowres missing fingers, low quality lowres missing limb, low quality lowres fused fingers, low quality lowres one hand with more than 5 fingers, low quality lowres one hand with less than 5 fingers, low quality lowres one hand with more than 5 digit, low quality lowres one hand with less than 5 digit, low quality lowres extra digit, low quality lowres fewer digits, low quality lowres fused digit, low quality lowres missing digit, low quality lowres bad digit, low quality lowres liquid digit, low quality lowres colorful tongue, low quality lowres black tongue, low quality lowres cropped, low quality lowres watermark, low quality lowres username, low quality lowres blurry, low quality lowres JPEG artifacts, low quality lowres signature, low quality lowres 3D, low quality lowres 3D game, low quality lowres 3D game scene, low quality lowres 3D character, low quality lowres malformed feet, low quality lowres extra feet, low quality lowres bad feet, low quality lowres poorly drawn feet, low quality lowres fused feet, low quality lowres missing feet, low quality lowres extra shoes, low quality lowres bad shoes, low quality lowres fused shoes, low quality lowres more than two shoes, low quality lowres poorly drawn shoes, low quality lowres bad gloves, low quality lowres poorly drawn gloves, low quality lowres fused gloves, low quality lowres bad cum, low quality lowres poorly drawn cum, low quality lowres fused cum, low quality lowres bad hairs, low quality lowres poorly drawn hairs, low quality lowres fused hairs, low quality lowres big muscles, low quality lowres ugly, low quality lowres bad face, low quality lowres fused face, low quality lowres poorly drawn face, low quality lowres cloned face, low quality lowres big face, low quality lowres long face, low quality lowres bad eyes, low quality lowres fused eyes poorly drawn eyes, low quality lowres extra eyes, low quality lowres malformed limbs, low quality lowres more than 2 nipples, low quality lowres missing nipples, low quality lowres different nipples, low quality lowres fused nipples, low quality lowres bad nipples, low quality lowres poorly drawn nipples, low quality lowres black nipples, low quality lowres colorful nipples, low quality lowres gross proportions, short arm, low quality lowres missing arms, low quality lowres missing thighs, low quality lowres missing calf, low quality lowres missing legs, low quality lowres mutation, low quality lowres duplicate, low quality lowres morbid, low quality lowres mutilated, low quality lowres poorly drawn hands, low quality lowres more than 1 left hand, low quality lowres more than 1 right hand, low quality lowres deformed, low quality lowres extra arms, low quality lowres extra thighs, low quality lowres more than 2 thighs, low quality lowres extra calf, low quality lowres fused calf, low quality lowres extra legs, low quality lowres bad knee, low quality lowres extra knee, low quality lowres more than 2 legs, low quality lowres bad tails, low quality lowres bad mouth, low quality lowres fused mouth, low quality lowres poorly drawn mouth, low quality lowres bad tongue, low quality lowres tongue within mouth, low quality lowres too long tongue, low quality lowres big mouth, low quality lowres cracked mouth, low quality lowres dirty face, low quality lowres dirty teeth, low quality lowres dirty pantie, low quality lowres fused pantie, low quality lowres poorly drawn pantie, low quality lowres fused cloth, low quality lowres poorly drawn cloth, low quality lowres bad pantie, low quality lowres yellow teeth, low quality lowres thick lips, low quality lowres bad asshole, low quality lowres poorly drawn asshole, low quality lowres fused asshole, low quality lowres missing asshole, low quality lowres bad anus, low quality lowres bad pussy, low quality lowres bad crotch, low quality lowres bad crotch seam, low quality lowres fused anus, low quality lowres fused pussy, low quality lowres fused crotch, low quality lowres poorly drawn crotch, low quality lowres fused seam, low quality lowres poorly drawn anus, low quality lowres poorly drawn pussy, low quality lowres poorly drawn crotch seam, low quality lowres bad thigh gap, low quality lowres missing thigh gap, low quality lowres fused thigh gap, low quality lowres liquid thigh gap, low quality lowres poorly drawn thigh gap, low quality lowres bad collarbone, low quality lowres fused collarbone, low quality lowres missing collarbone, low quality lowres liquid collarbone, low quality lowres strong girl, low quality lowres obesity, low quality lowres worst quality, low quality lowres low quality, low quality lowres normal quality, low quality lowres liquid tentacles, low quality lowres bad tentacles, low quality lowres poorly drawn tentacles, low quality lowres split tentacles, low quality lowres fused tentacles, low quality lowres missing clit, low quality lowres bad clit, low quality lowres fused clit, low quality lowres colorful clit, low quality lowres black clit, low quality lowres liquid clit, low quality lowres QR code, low quality lowres bar code, low quality lowres censored, low quality lowres safety panties, low quality lowres safety knickers, low quality lowres beard, low quality lowres furry, pony, low quality lowres pubic hair, low quality lowres mosaic, low quality lowres excrement, low quality lowres shit, low quality lowres futa, low quality lowres testis, low quality lowres lowres, low quality lowres terrible, low quality lowres dirty, low quality lowres feces, low quality lowres organs, low quality lowres fat, low quality lowres thick thighs, low quality lowres low resolution rough, low quality lowres pedophile, low quality lowres bestiality, low quality lowres parody, low quality lowres traditional media, low quality lowres koma, low quality lowres comic, low quality lowres scary, low quality lowres severe, low quality lowres insects, low quality lowres gross scars, low quality lowres twisted human body, low quality lowres irrational human body, low quality lowres sharp fingers, low quality lowres parts of the body out of common sense, low quality lowres murder, low quality lowres beheading, low quality lowres zombie, low quality lowres mummy, low quality lowres graffiti, low quality lowres unfinished picture, low quality lowres terrible quality, low quality lowres Coprophilia, low quality lowres muscular, low quality lowres bald, low quality lowres monk, low quality lowres wrinkly, low quality lowres simple background, low quality lowres realistic, low quality lowres old, low quality lowres scan, low quality lowres touhou, low quality lowres yaoi, low quality lowres gay, low quality lowres femboy, low quality lowres trap, low quality lowres pee, low quality lowres doujinshi, low quality lowres monochrome, low quality lowres meme, low quality lowres demon, low quality lowres monstrous creature, low quality lowres tentacle, low quality lowres self harm, low quality lowres vomit, low quality lowres suicide, low quality lowres death, low quality lowres corpse, low quality lowres bone, low quality lowres skeleton, low quality lowres fingers over 6, low quality lowres framed, low quality lowres historical picture, low quality lowres futanari, low quality lowres shemale, low quality lowres transgender, low quality lowres dick girl, low quality lowres flat breasts, low quality lowres degenerate ass, low quality lowres retro artstyle, low quality lowres anime screencap, low quality lowres stitched, low quality lowres pokemon, low quality lowres ryona, low quality lowres animal, low quality lowres male focus, low quality lowres nipple penetration, low quality lowres sonic (series), low quality lowres bondage, low quality lowres bdsm, low quality lowres 2D, low quality lowres 2D game, low quality lowres 2D game scene, low quality lowres 2D character, low quality lowres game cg, low quality lowres watercolor (medium), low quality lowres 2koma, low quality lowres interlocked fingers, low quality lowres gloves, low quality lowres nitroplus, low quality lowres grayscale, low quality lowres sketch, low quality lowres line drawing, low quality lowres gorilla, low quality lowres meat, low quality lowres gundam, low quality lowres multiple views, low quality lowres cut, low quality lowres concept art, low quality lowres reference sheet, low quality lowres turnaround, low quality lowres chart, low quality lowres comparison, low quality lowres artist progress, low quality lowres lineup, low quality lowres before and after, low quality lowres orc, low quality lowres tusks, low quality lowres goblin, low quality lowres kobold, low quality lowres pony, low quality lowres nsfw, low quality lowres Humpbacked, low quality lowres text error, low quality lowres extra digits, low quality lowres standard quality, low quality lowres large breasts, low quality lowres shadow, low quality lowres nude, low quality lowres artist name, low quality lowres skeleton girl, low quality lowres bad legs, low quality lowres missing fingers, low quality lowres extra digit, low quality lowres artifacts, low quality lowres bad body, low quality lowres optical illusion, low quality lowres Glasses, low quality lowres girl, low quality lowres women, low quality lowres more than 1 moon, low quality lowres Multi foot, low quality lowres Multifold, low quality lowres Multi fingering, low quality lowres colored sclera, low quality lowres monster girl, low quality lowres Black hands, low quality lowres The background is incoherent, low quality lowres abnormal eye proportion, low quality lowres Abnormal hands, low quality lowres abnormal legs, low quality lowres abnormal feet abnormal fingers, low quality lowres sharp face, low quality lowres tranny, low quality lowres mutated hands, low quality lowres extra limbs, low quality lowres too many fingers, low quality lowres unclear eyes, low quality lowres bad, low quality lowres mutated hand and finger, low quality lowres malformed mutated, low quality lowres broken limb, low quality lowres incorrect limb, low quality lowres fusion finger, low quality lowres lose finger, low quality lowres multiple finger, low quality lowres multiple digit, low quality lowres fusion hand, low quality lowres lose leg, low quality lowres fused leg, low quality lowres multiple leg, low quality lowres bad cameltoe, low quality lowres colorful cameltoe, low quality lowres low polygon 3D game,over one person in focus, {, over three finger(fingers excluding thumb):2, fused anatomy, bad anatomy(body), bad anatomy(hand), bad anatomy(finger), over four fingers(finger):2, bad anatomy(arms), over two arms(body), bad anatomy(leg), over two legs(body), interrupted(body, arm, leg, finger), bad anatomy(arm), {, bad detail(finger), bad anatomy(fingers), multiful(fingers), bad anatomy(finger), bad anatomy(fingers), fused(fingers), over four fingers(finger):2, }, multiful(hands), multiful(arms), multiful(legs), bad detailed background, unclear architectural outline, non-linear background, },";

        public Form1()
        {
            InitializeComponent();
            InitOptionQuests();
            list_Tag.ItemIndexChanged += () =>
            {
                Match_Items();
                focusing_prompt.tags.Clear();
                foreach (ListViewItem item in list_Tag.Items)
                {
                    focusing_prompt.tags.Add((TagData)item.Tag);
                }
            };
            list_Tag.Items.Clear();
            lb_Description_Default = lb_Description.Text;
            LoadPrompts();
            DisableAutoSave();
        }
        public void Match_Items()
        {
            if (cb_Option_HideDisabled.Checked)
            {
                foreach (ListViewItem item in list_Tag.Items)
                {
                    focusing_prompt.items.Remove(item);
                }
                for (var i = list_Tag.Items.Count - 1; i >= 0; i--)
                {
                    focusing_prompt.items.Insert(0, list_Tag.Items[i]);
                }
            }
            else
            {
                focusing_prompt.items.Clear();
                foreach (ListViewItem item in list_Tag.Items)
                {
                    focusing_prompt.items.Add(item);
                }
            }
        }
        public void LoadFiles()
        {
            if (Directory.Exists(folderPath) == false)
                Directory.CreateDirectory(folderPath);

            registed_files.Clear();
            var files = Directory.GetFiles(folderPath);
            foreach (var file in files)
            {
                // Use only extension '.txt'
                if (file.EndsWith(".txt") && file.EndsWith("option.txt") == false)
                {
                    string[] lines;
                    using (StreamReader sr = new StreamReader(file))
                        lines = sr.ReadToEnd().Split('\n');

                    var prompt = new PromptData();
                    var folderPathEnd = file.LastIndexOf('\\') + 1;
                    prompt.name = file[(folderPathEnd)..(file.Length - 4)];
                    saved_prompts.Add(prompt);
                    registed_files.Add(file);

                    for (var i = 0; i < lines.Length; i++)
                    {
                        var line = lines[i];
                        var splits = line.Split(",");
                        if (splits.Length == 1)
                            continue;
                        if (splits.Length != 5)
                        {
                            MessageBox.Show("Error occoured while loading.\nLine " + i + " : " + line + "");
                            return;
                        }
                        var item = new ListViewItem();
                        item.Text = splits[0];
                        for (var o = 1; o < splits.Length; o++)
                            item.SubItems.Add(splits[o]);
                        prompt.items.Add(item);

                        var index = -1;
                        if (int.TryParse(item.SubItems[1].Text, out index) == false)
                        {
                            MessageBox.Show("Error occoured while loading.\nLine " + i + " : " + line + "");
                            return;
                        }
                        bool disabled;
                        if (item.SubItems[2].Text != "!" && string.IsNullOrEmpty(item.SubItems[2].Text) == false)
                        {
                            MessageBox.Show("Error occoured while loading.\nLine " + i + " : " + line + "");
                            return;
                        }
                        double positive = 0, negative = 0;
                        if ((string.IsNullOrEmpty(item.SubItems[3].Text) == false && double.TryParse(item.SubItems[3].Text, out positive) == false) ||
                            (string.IsNullOrEmpty(item.SubItems[4].Text) == false && double.TryParse(item.SubItems[4].Text, out negative) == false))
                        {
                            MessageBox.Show("Error occoured while loading.\nLine " + i + " : " + line + "");
                            return;
                        }

                        var newTag = new TagData()
                        {
                            tagName = item.Text,
                            disabled = (item.SubItems[2].Text == "!" ? true : false),
                            positive = positive,
                            negative = negative,
                            index = index,
                        };
                        item.Tag = newTag;

                        var insertingIndex = 0;
                        prompt.tags.Add(newTag);

                    }
                }
            }

            if (saved_prompts.Count == 0)
                saved_prompts = new() { new PromptData() { name = "prompt_1" } };

            foreach (var prompt in saved_prompts)
            {
                var item = new ListViewItem();
                item.Text = prompt.name;
                item.Tag = prompt;
                list_Saved.Items.Add(item);
            }
            if (focusing_prompt == null)
                ChangeFocus(0);
        }
        public static string Option_Focusing = "Focusing",
                             Option_Space = "Space",
                             Option_HideDisabled = "HideDisabled",
                             Option_UI_mode = "UI_mode",
                             Option_Ult_negatives = "Ultimate negatives";

        public Dictionary<string, (Func<string>, Action<StreamReader>)> option_quests = new();
        public void InitOptionQuests()
        {
            option_quests = new()
            {
                [Option_Focusing] = (() => focusing_prompt.name, (sr) =>
                {
                    if (sr.EndOfStream)
                        return;
                    var result = sr.ReadLine();
                    if (string.IsNullOrEmpty(result))
                        return;
                    for (var o = 0; o < saved_prompts.Count; o++)
                    {
                        if (saved_prompts[o].name == result)
                        {
                            ChangeFocus(o);
                            break;
                        }
                    }
                }),
                [Option_Space] = (() => Convert.ToString(cb_Option_Space.Checked), (sr) =>
                {
                    if (sr.EndOfStream)
                        return;
                    var result = sr.ReadLine();
                    if (string.IsNullOrEmpty(result))
                        return;
                    var disabled = Convert.ToBoolean(result);
                    cb_Option_Space.Checked = disabled;
                }),
                [Option_HideDisabled] = (() => Convert.ToString(cb_Option_HideDisabled.Checked), (sr) =>
                {
                    if (sr.EndOfStream)
                        return;
                    var result = sr.ReadLine();
                    if (string.IsNullOrEmpty(result))
                        return;
                    var disabled = Convert.ToBoolean(result);
                    cb_Option_HideDisabled.Checked = disabled;
                }),
                [Option_UI_mode] = (() => Convert.ToString(UI_mode_now == UI_mode.WebUI ? "WebUI" : "NAI"), (sr) =>
                {
                    if (sr.EndOfStream)
                        return;
                    var result = sr.ReadLine();
                    if (string.IsNullOrEmpty(result))
                        return;
                    var new_UI_mode = (result == "WebUI" ? UI_mode.WebUI : (result == "NAI" ? UI_mode.NAI : UI_mode.WebUI));
                    Set_UI_mode(new_UI_mode);
                }),
                [Option_Ult_negatives] = (() => (Ult_negatives.Count((c) => c == '\n') + 1) + "\n" + Ult_negatives, (sr) =>
                {
                    if (sr.EndOfStream)
                        return;
                    var result = sr.ReadLine();
                    if (string.IsNullOrEmpty(result))
                        return;
                    var lineCount = 0;
                    if (int.TryParse(result, out lineCount) == false)
                        return;

                    var new_Ult_negatives = "";
                    for (var i = 0; i < lineCount; i++)
                    {
                        new_Ult_negatives += sr.ReadLine();
                        if (i < lineCount - 1)
                            new_Ult_negatives += "\n";
                    }
                    Ult_negatives = new_Ult_negatives;
                }),
            };
        }
        public void LoadOptions()
        {
            var optionFilePath = folderPath + "\\" + path_optionFile;
            if (File.Exists(optionFilePath))
            {
                using (StreamReader sr = new StreamReader(optionFilePath))
                {
                    while(sr.EndOfStream == false)
                    {
                        var line = sr.ReadLine();
                        if (option_quests.ContainsKey(line))
                        {
                            var quest = option_quests[line].Item2;
                            quest(sr);
                            continue;
                        }
                    }
                }
            }
        }
        public void LoadPrompts()
        {
            list_Saved.Items.Clear();

            focusing_prompt = null;

            LoadOptions();

            LoadFiles();
        }
        public void ChangeFocus(int index)
        {
            if (index < 0 || index >= list_Saved.Items.Count)
                return;

            if (focusing_prompt == saved_prompts[index])
                return;

            focusing_prompt = saved_prompts[index];

            list_Tag.BeginUpdate();
            list_Tag.Items.Clear();

            if (cb_Option_HideDisabled.Checked)
            {
                foreach (var item in focusing_prompt.items)
                {
                    if (item.SubItems[2].Text != disabled_text)
                        list_Tag.Items.Add(item);
                }
            }
            else
            {
                list_Tag.Items.AddRange(focusing_prompt.items.ToArray());
            }
            list_Tag.EndUpdate();

            Apply_List_to_Prompt();
        }
        public void Apply_List_to_Prompt()
        {
            if (focusing_prompt == null)
                return;

            var prompts = Prompt_Parser.List_to_prompt(focusing_prompt.tags, UI_mode_now, cb_Option_Space.Checked);

            DisplayPrompt(prompts.Item1, PromptType.Positive);
            DisplayPrompt(prompts.Item2, PromptType.Negative);

            SetDirty();
        }
        private void btn_ToList_Click(object sender, EventArgs e)
        {
            list_Tag.Items.Clear();
            focusing_prompt.items.Clear();

            var newItems = new List<ListViewItem>();
            focusing_prompt.tags.Clear();

            var positive_prompt = tb_Positive.Text;
            var negative_prompt = tb_Negative.Text;

            var positive_tags = new Prompt_Parser(UI_mode_now, positive_prompt).Prompt_to_list(1, 0);
            var negative_tags = new Prompt_Parser(UI_mode_now, negative_prompt).Prompt_to_list(0, 1);

            var newTags = new List<TagData>();
            if (positive_tags != null)
                newTags.AddRange(positive_tags);
            if (negative_tags != null)
                newTags.AddRange(negative_tags);

            AddNewTags(newTags);

            SetDirty();
        }
        public void AddNewTag(TagData tagData, int inserting = -1, bool addToData = true)
        {
            var item = new ListViewItem();
            item.Text = tagData.tagName;
            if (tagData.index != -1)
            {
                item.SubItems.Add(Convert.ToString(tagData.index));
            }
            else
            {
                var newIndex = list_Tag.GetEmptyName("", 1);
                item.SubItems.Add(newIndex);
            }

            item.SubItems.Add(tagData.disabled ? disabled_text : enabled_text);
            var str = tagData.positive.ToString();
            item.SubItems.Add(str == "0" ? "" : str);
            str = tagData.negative.ToString();
            item.SubItems.Add(str == "0" ? "" : str);


            var multiplier_str = tagData.positive.ToString();
            if (multiplier_str.Length > multiplier_str.IndexOf('.') + 3)
                multiplier_str = multiplier_str[..(multiplier_str.IndexOf('.') + 3)];
            item.SubItems[3].Text = multiplier_str == "0" ? "" : multiplier_str;

            multiplier_str = tagData.negative.ToString();
            if (multiplier_str.Length > multiplier_str.IndexOf('.') + 3)
                multiplier_str = multiplier_str[..(multiplier_str.IndexOf('.') + 3)];
            item.SubItems[4].Text = multiplier_str == "0" ? "" : multiplier_str;


            item.Tag = tagData;
            if (inserting == -1)
            {
                list_Tag.Items.Add(item);
                if (addToData)
                {
                    focusing_prompt.items.Add(item);
                    focusing_prompt.tags.Add(tagData);
                }
            }
            else
            {
                list_Tag.Items.Insert(inserting, item);
                if (addToData)
                {
                    focusing_prompt.items.Insert(inserting, item);
                    focusing_prompt.tags.Insert(inserting, tagData);
                }
            }
        }
        public void AddNewTags(List<TagData> tags, bool addToData = true)
        {
            list_Tag.BeginUpdate();

            foreach (var tagData in tags)
                AddNewTag(tagData, -1, addToData);

            list_Tag.EndUpdate();
        }

        public void SetEnabled(IEnumerable items, bool enabled)
        {
            foreach (ListViewItem item in items)
            {
                item.SubItems[2].Text = enabled ? enabled_text : disabled_text;
                var tagData = item.Tag as TagData;
                if (tagData != null)
                {
                    tagData.disabled = !enabled;
                }
                var colorValue = enabled ? 0 : 200;
                item.ForeColor = Color.FromArgb(colorValue, colorValue, colorValue);
            }
            Apply_List_to_Prompt();
        }

        private void btn_EnableTag_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            SetEnabled(selected, true);
        }

        private void btn_DisableTag_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            SetEnabled(selected, false);
        }

        public void Do_AddTagByTextBox(bool isNegative)
        {
            if (string.IsNullOrEmpty(tb_NewTag.Text))
                return;
            var tagData = new TagData();
            tagData.tagName = tb_NewTag.Text.Trim();
            tb_NewTag.Clear();
            tagData.positive = isNegative ? 0 : 1;
            tagData.negative = isNegative ? 1 : 0;

            var index = -1;
            if (list_Tag.SelectedItems.Count > 0)
                index = list_Tag.SelectedItems[0].Index;

            AddNewTag(tagData, index);
            Apply_List_to_Prompt();
        }

        private void btn_AddTag_Positive_Click(object sender, EventArgs e)
        {
            Do_AddTagByTextBox(false);
        }

        private void btn_AddTag_Negative_Click(object sender, EventArgs e)
        {
            Do_AddTagByTextBox(true);
        }

        private void btn_PositiveSet_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            var setting_value = Convert.ToDouble(nud_Positive.Value);

            foreach (ListViewItem item in selected)
            {
                var tagData = item.Tag as TagData;
                if (tagData != null)
                {
                    tagData.positive = setting_value;
                    var multiplier_str = tagData.positive.ToString();
                    if (multiplier_str.Length > multiplier_str.IndexOf('.') + 3)
                        multiplier_str = multiplier_str[..(multiplier_str.IndexOf('.') + 3)];
                    item.SubItems[3].Text = (multiplier_str == "0" ? "" : multiplier_str);
                }
            }
            Apply_List_to_Prompt();
        }

        private void btn_NegativeSet_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            var setting_value = Convert.ToDouble(nud_Negative.Value);

            foreach (ListViewItem item in selected)
            {
                var tagData = item.Tag as TagData;
                if (tagData != null)
                {
                    tagData.negative = setting_value;
                    var multiplier_str = tagData.negative.ToString();
                    if (multiplier_str.Length > multiplier_str.IndexOf('.') + 3)
                        multiplier_str = multiplier_str[..(multiplier_str.IndexOf('.') + 3)];
                    item.SubItems[4].Text = (multiplier_str == "0" ? "" : multiplier_str);
                }
            }
            Apply_List_to_Prompt();
        }

        public void Positive_Offset(IEnumerable items, double offset)
        {
            foreach (ListViewItem item in items)
            {
                var tagData = item.Tag as TagData;
                if (tagData != null)
                {
                    if (UI_mode_now == UI_mode.NAI)
                    {
                        //tagData.positive *= 1.1;
                        tagData.positive = Math.Round(Math.Max(0.1, tagData.positive + offset), 2);
                    }
                    else if (UI_mode_now == UI_mode.WebUI)
                    {
                        tagData.positive = Math.Round(Math.Max(0.1, tagData.positive + offset), 2);
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                    var multiplier_str = tagData.positive.ToString();
                    if (multiplier_str.Length > multiplier_str.IndexOf('.') + 3)
                        multiplier_str = multiplier_str[..(multiplier_str.IndexOf('.') + 3)];
                    item.SubItems[3].Text = multiplier_str;
                }
            }
            Apply_List_to_Prompt();
        }

        public void Negative_Offset(IEnumerable items, double offset)
        {
            foreach (ListViewItem item in items)
            {
                var tagData = item.Tag as TagData;
                if (tagData != null)
                {
                    if (UI_mode_now == UI_mode.NAI)
                    {
                        //tagData.negative *= 1.1;
                        tagData.negative = Math.Round(Math.Max(0.1, tagData.negative + offset), 2);
                    }
                    else if (UI_mode_now == UI_mode.WebUI)
                    {
                        tagData.negative = Math.Round(Math.Max(0.1, tagData.negative + offset), 2);
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                    var multiplier_str = tagData.negative.ToString();
                    if (multiplier_str.Length > multiplier_str.IndexOf('.') + 3)
                        multiplier_str = multiplier_str[..(multiplier_str.IndexOf('.') + 3)];
                    item.SubItems[4].Text = multiplier_str;
                }
            }
            Apply_List_to_Prompt();
        }

        private void btn_PositiveUp_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            Positive_Offset(selected, 0.1);
        }

        private void btn_PositiveDown_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            Positive_Offset(selected, -0.1);
        }

        private void btn_NegativeUp_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            Negative_Offset(selected, 0.1);
        }

        private void btn_NegativeDown_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            Negative_Offset(selected, -0.1);
        }

        private void list_Tag_DoubleClick(object sender, EventArgs e)
        {
            if (list_Tag.SelectedItems.Count == 0)
                return;

            var selectedItem = list_Tag.SelectedItems[0];
            selectedItem.BeginEdit();
        }

        class MyListViewComparer : IComparer
        {
            private int col;
            private SortOrder order;
            public MyListViewComparer()
            {
                col = 0;
                order = SortOrder.Ascending;
            }
            public MyListViewComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }
            public int Compare(object x, object y)
            {
                int returnVal = -1;

                var x_str = ((ListViewItem)x).SubItems[col].Text;
                var y_str = ((ListViewItem)y).SubItems[col].Text;
                double x_num, y_num;
                if (Double.TryParse(x_str, out x_num) && Double.TryParse(y_str, out y_num))
                {
                    returnVal = x_num > y_num ? 1 : -1;
                }
                else
                {
                    returnVal = String.Compare(x_str, y_str);
                }

                if (order == SortOrder.Descending)
                    returnVal *= -1;
                return returnVal;
            }
        }
        int list_Tag_lastSorted = -1;
        private void list_Tag_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            list_Tag.BeginUpdate();
            if (e.Column != list_Tag_lastSorted)
            {
                list_Tag.Sorting = SortOrder.Ascending;
            }
            else
            {

                // SortOrder.Ascending or Descending Flip Flop
                // 2 --> 1
                // 1 --> 2
                list_Tag.Sorting = 3 - list_Tag.Sorting;
            }
            list_Tag_lastSorted = e.Column;

            list_Tag.ListViewItemSorter = new MyListViewComparer(e.Column, list_Tag.Sorting);
            list_Tag.Sort();
            list_Tag.EndUpdate();

            Match_Items();
        }

        private void btn_FixIndex_Click(object sender, EventArgs e)
        {
            var items = list_Tag.Items;

            Match_Items();
            focusing_prompt.tags.Clear();
            foreach (ListViewItem item in items)
            {
                ((TagData)item.Tag).index = (item.Index + 1);
                item.SubItems[1].Text = (item.Index + 1).ToString();
                focusing_prompt.tags.Add((TagData)item.Tag);
            }

            Apply_List_to_Prompt();
        }

        private void list_Tag_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            var index = e.Item;
            var item = list_Tag.Items[index];
            var tagData = item.Tag as TagData;
            tagData.tagName = e.Label == null ? item.Text : e.Label;
            Apply_List_to_Prompt();
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            if (UI_mode_now == UI_mode.NAI)
                Set_UI_mode(UI_mode.WebUI);
            else
                Set_UI_mode(UI_mode.NAI);
            SetDirty();
        }
        public void Set_UI_mode(UI_mode mode)
        {
            if (UI_mode_now == mode)
                return;

            var old_mode = UI_mode_now;
            UI_mode_now = mode;

            if (UI_mode_now == UI_mode.WebUI)
            {
                label8.Text = "State : WebUI";
                btn_Convert.Text = "WebUI > NAI";
            }
            else
            {
                label8.Text = "State : NAI";
                btn_Convert.Text = "NAI > WebUI";
            }

            var positive_tags = new Prompt_Parser(old_mode, tb_Positive.Text).Prompt_to_list(1, 0);
            var negative_tags = new Prompt_Parser(old_mode, tb_Negative.Text).Prompt_to_list(0, 1);

            if (positive_tags == null && negative_tags == null)
                return;

            var all_tags = positive_tags;
            if (all_tags == null)
                all_tags = negative_tags;
            else
                all_tags.AddRange(negative_tags);

            var prompts = Prompt_Parser.List_to_prompt(all_tags, UI_mode_now, cb_Option_Space.Checked);

            DisplayPrompt(prompts.Item1, PromptType.Positive);
            DisplayPrompt(prompts.Item2, PromptType.Negative);
        }

        public enum PromptType
        {
            Positive,
            Negative,
        }
        public void DisplayPrompt(string prompt, PromptType type)
        {
            if (type == PromptType.Positive)
            {
                tb_Positive.Text = prompt;
            }
            else if (type == PromptType.Negative)
            {
                //if (cb_UltNegatives.Checked)
                //    prompt = Ult_negatives + prompt;
                tb_Negative.Text = prompt;
            }
            else
                throw new NotImplementedException();
        }

        private void list_Tag_KeyDown(object sender, KeyEventArgs e)
        {
            if (list_Tag.SelectedItems.Count == 0)
                return;

            e.SuppressKeyPress = true;
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    list_Tag.BeginUpdate();
                    var items = list_Tag.SelectedItems;
                    foreach (ListViewItem item in items)
                    {
                        focusing_prompt.items.Remove(item);
                        focusing_prompt.tags.Remove((TagData)item.Tag);
                        item.Remove();
                    }
                    list_Tag.EndUpdate();
                    Apply_List_to_Prompt();
                    break;
                case Keys.Left:
                case Keys.Right:
                    List<ListViewItem> positives = new();
                    List<ListViewItem> negatives = new();
                    foreach (ListViewItem item in list_Tag.SelectedItems)
                    {
                        var tagData = item.Tag as TagData;
                        if (tagData.positive > 0)
                            positives.Add(item);
                        if (tagData.negative > 0)
                            negatives.Add(item);
                    }

                    Positive_Offset(positives, e.KeyData == Keys.Right ? 0.1 : -0.1);
                    Negative_Offset(negatives, e.KeyData == Keys.Right ? 0.1 : -0.1);

                    list_Tag.Focus();
                    break;
                case Keys.D:
                    SetEnabled(list_Tag.SelectedItems, false);
                    break;
                case Keys.E:
                    SetEnabled(list_Tag.SelectedItems, true);
                    break;
                default:
                    e.SuppressKeyPress = false;
                    break;
            }
        }

        private void list_Tag_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void tb_NewTag_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Do_AddTagByTextBox(e.Shift);
                e.IsInputKey = false;
            }
        }

        private void tb_NewTag_Enter(object sender, EventArgs e)
        {
            lb_Description.Text = "Enter : Add positive tag, Shift + Enter : Add negative tag";
        }

        private void tb_NewTag_Leave(object sender, EventArgs e)
        {
            lb_Description.Text = lb_Description_Default;
        }

        public void ShowTooltip(object sender, string title, string text)
        {
            var ctrl = sender as Control;
            if (ctrl == null)
                return;

            this.toolTip1.ToolTipTitle = title;
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(ctrl, text);
        }
        private void btn_EnableTag_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, "Enable tags", "Remove disable option from this tags (key : E)");
        }

        private void btn_DisableTag_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, "Disable tags", "Apply disable option to this tags (key : D)");
        }

        private void btn_AddTag_Positive_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, "Add positive tag", "Add new positive tag by the contents of the left textbox (key : Enter)");
        }

        private void btn_AddTag_Negative_MouseHover(object sender, EventArgs e)
        {
            ShowTooltip(sender, "Add negative tag", "Add new negative tag by the contents of the left textbox (key : Shift + Enter)");
        }

        private void btn_PositiveUp_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_PositiveDown_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_PositiveSet_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_NegativeUp_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_NegativeDown_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_NegativeSet_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_ToList_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_Convert_MouseHover(object sender, EventArgs e)
        {

        }

        private void cb_Option_Space_MouseHover(object sender, EventArgs e)
        {

        }

        private void checkBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void checkBox2_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_TagUp_Click(object sender, EventArgs e)
        {
            list_Tag.Selected_PushUp(list_Tag.SelectedItems);
        }

        private void btn_TagDown_Click(object sender, EventArgs e)
        {
            list_Tag.Selected_PushDown(list_Tag.SelectedItems);
        }

        public void MatchPromptList()
        {
            saved_prompts.Clear();
            foreach (ListViewItem item in list_Tag.Items)
            {
                var prompt = item.Tag as PromptData;
                saved_prompts.Add(prompt);
            }
        }

        private void btn_SavedUp_Click(object sender, EventArgs e)
        {
            list_Saved.Selected_PushUp(list_Saved.SelectedItems);
            MatchPromptList();
        }

        private void btn_SavedDown_Click(object sender, EventArgs e)
        {
            list_Saved.Selected_PushDown(list_Saved.SelectedItems);
            MatchPromptList();
        }

        private void cb_Option_HideDisabled_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_MergeDuplicates_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_AddNegativeDump_MouseHover(object sender, EventArgs e)
        {

        }

        public void AddPrompt()
        {
            var newName = list_Saved.GetEmptyName("prompt_", 0);
            var newPrompt = new PromptData();
            newPrompt.name = newName;

            var newItem = new ListViewItem(newName);
            newItem.Tag = newPrompt;

            if (list_Saved.SelectedItems.Count > 0)
            {
                var newIndex = list_Saved.SelectedItems[0].Index;
                list_Saved.Items.Insert(newIndex, newItem);
                saved_prompts.Insert(newIndex, newPrompt);
            }
            else
            {
                list_Saved.Items.Add(newItem);
                saved_prompts.Add(newPrompt);
            }
        }
        private void btn_SavedAdd_Click(object sender, EventArgs e)
        {
            AddPrompt();
        }

        private void list_Saved_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (list_Saved.SelectedItems.Count == 0)
                return;

            e.IsInputKey = false;
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    list_Saved.BeginUpdate();
                    var items = list_Saved.SelectedItems;
                    foreach (ListViewItem item in items)
                    {
                        item.Remove();
                        saved_prompts.Remove(item.Tag as PromptData);
                    }
                    if (list_Saved.Items.Count == 0)
                    {
                        AddPrompt();
                        ChangeFocus(0);
                    }
                    list_Saved.EndUpdate();
                    break;
                default:
                    e.IsInputKey = true;
                    break;
            }
        }
        public async void SaveOptions()
        {
            if (Directory.Exists(folderPath) == false)
            {
                Directory.CreateDirectory(folderPath);
            }

            var di = new DirectoryInfo(folderPath);
            di.Attributes &= ~FileAttributes.ReadOnly;
            var optionFilePath = folderPath + "\\option.txt";

            if (File.Exists(optionFilePath) == false)
                File.Create(optionFilePath);

            var fi = new FileInfo(optionFilePath);
            fi.Attributes &= ~FileAttributes.ReadOnly;

            using StreamWriter file = new(optionFilePath, append: false);

            var str = "";
            foreach (var kv in option_quests)
                str += kv.Key + "\n" + kv.Value.Item1() + "\n";

            await file.WriteAsync(str);
        }
        public async void SaveAll()
        {
            if (Directory.Exists(folderPath) == false)
            {
                Directory.CreateDirectory(folderPath);
            }
            var di = new DirectoryInfo(folderPath);
            di.Attributes &= ~FileAttributes.ReadOnly;

            SaveOptions();

            var files = Directory.GetFiles(folderPath);
            foreach (var file in files)
            {
                if (registed_files.Contains(file) == false)
                    continue;
                if (file.EndsWith(".txt") && file.EndsWith("option.txt") == false)
                {
                    var folderPathEnd = file.LastIndexOf('\\') + 1;
                    var fileName = file[(folderPathEnd)..(file.Length - 4)];

                    var nameFound = false;
                    foreach (var prompt in saved_prompts)
                    {
                        if (prompt.name == fileName)
                        {
                            nameFound = true;
                            break;
                        }
                    }
                    if (nameFound)
                        continue;
                    File.Delete(file);
                }
            }
            registed_files.Clear();
            
            foreach (var prompt in saved_prompts)
            {
                var filePath = folderPath + "\\" + prompt.name + ".txt";

                if (File.Exists(filePath) == false)
                    File.Create(filePath);

                var fi = new FileInfo(filePath);
                fi.Attributes &= ~FileAttributes.ReadOnly;

                var str = "";

                foreach (var item in prompt.items)
                {
                    for (var i = 0; i < item.SubItems.Count; i++)
                    {
                        var subItem = item.SubItems[i];
                        str += subItem.Text;
                        if (i < item.SubItems.Count - 1)
                            str += ",";
                    }
                    str += "\n";
                }

                registed_files.Add(filePath);
                using StreamWriter file = new(filePath, append: false);
                await file.WriteAsync(str);
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DisableAutoSave("Saved");
            SaveAll();
        }

        private void list_Saved_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_Saved.SelectedItems.Count == 0)
                return;
            ChangeFocus(list_Saved.SelectedItems[0].Index);
        }

        private void btn_OpenFolder_Click(object sender, EventArgs e)
        {

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = folderPath,
                FileName = "explorer.exe",
            };
            Process.Start(startInfo);
        }

        private void cb_Option_Space_CheckedChanged(object sender, EventArgs e)
        {
            Apply_List_to_Prompt();
            SetDirty();
        }

        public int AutoSaveCount = 5;
        public void AutoSaveCount_Apply(string text = null)
        {
            if (text == null)
                lb_AutoSaveAlert.Text = "AutoSave..." + Convert.ToString(AutoSaveCount);
            else
                lb_AutoSaveAlert.Text = text;
        }
        public void SetDirty()
        {
            AutoSaveCount = 5;
            AutoSaveCount_Apply();
            tmr_AutoSave.Start();
            tmr_HideAutoSaveMsg.Stop();
        }
        private void tmr_AutoSave_Tick(object sender, EventArgs e)
        {
            AutoSaveCount--;
            if (AutoSaveCount == 0)
            {
                tmr_AutoSave.Stop();
                SaveAll();
                AutoSaveCount_Apply("Saved");
                tmr_HideAutoSaveMsg.Start();
            }
            else
            {
                AutoSaveCount_Apply();
            }
        }
        private void tmr_HideAutoSaveMsg_Tick(object sender, EventArgs e)
        {
            lb_AutoSaveAlert.Text = "";
            tmr_HideAutoSaveMsg.Stop();
        }
        public void DisableAutoSave(string message = "")
        {
            AutoSaveCount = 5;
            AutoSaveCount_Apply(message);
            tmr_AutoSave.Stop();
            tmr_HideAutoSaveMsg.Stop();
        }

        private void tb_Positive_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_UltNegatives_CheckedChanged(object sender, EventArgs e)
        {
            Apply_List_to_Prompt();
        }
        public static string LineBreak_Format_Text = "\n",
                             LineBreak_Format_Form = "\r\n";
        private void btn_UltNegatives_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();

            var txt = Ult_negatives;
            txt = txt.Replace(LineBreak_Format_Text, LineBreak_Format_Form);
            newForm.tb_Ult_negatives.Text = txt;
            newForm.tb_Ult_negatives.TextChanged += (sender, e) =>
            {
                Ult_negatives = newForm.tb_Ult_negatives.Text.Replace(LineBreak_Format_Form, LineBreak_Format_Text);
                SetDirty();
            };

            newForm.ShowDialog();
        }

        private void btn_Copy_Positive_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tb_Positive.Text);
        }

        private void btn_Copy_Negative_Click(object sender, EventArgs e)
        {
            var txt = tb_Negative.Text;
            if (cb_UltNegatives.Checked)
                txt = Ult_negatives + txt;
            Clipboard.SetText(txt);
        }

        private void tb_Negative_TextChanged(object sender, EventArgs e)
        {

        }


        private void list_Saved_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Label))
                return;

            if (e.Label.ToLower() == "option")
                e.CancelEdit = true;

            foreach (ListViewItem item in list_Saved.Items)
            {
                if (item.Text == e.Label)
                {
                    e.CancelEdit = true;
                    break;
                }
            }
            SetDirty();
        }

        private void cb_Option_HideDisabled_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Option_HideDisabled.Checked)
            {
                for (var i = list_Tag.Items.Count - 1; i >= 0; i--)
                {
                    if (list_Tag.Items[i].SubItems[2].Text == disabled_text)
                    {
                        list_Tag.Items.RemoveAt(i);
                    }
                }
            }
            else
            {
                list_Tag.Items.Clear();
                list_Tag.Items.AddRange(focusing_prompt.items.ToArray());
            }
            SetDirty();
        }
    }
}