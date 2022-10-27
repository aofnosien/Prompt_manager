using System.Collections;

namespace Prompt_manager
{
    public partial class Form1 : Form
    {
        public NAI_type NAI_type_now = NAI_type.WebUI;
        public static string enabled_text = "";
        public static string disabled_text = "!";
        public List<TagData> received_tags = new();
        public Form1()
        {
            InitializeComponent();
            list_Tag.Items.Clear();
        }
        public void Apply_List_to_Prompt()
        {
            var prompts = Prompt_Parser.List_to_prompt(received_tags, NAI_type_now, cb_Option_Space.Checked);

            tb_Positive.Text = prompts.Item1;
            tb_Negative.Text = prompts.Item2;
        }
        private void btn_ToList_Click(object sender, EventArgs e)
        {
            list_Tag.Items.Clear();

            var newItems = new List<ListViewItem>();
            received_tags.Clear();

            var positive_tags = new Prompt_Parser(NAI_type_now, tb_Positive.Text).Prompt_to_list(1, 0);
            var negative_tags = new Prompt_Parser(NAI_type_now, tb_Negative.Text).Prompt_to_list(0, 1);

            var newTags = new List<TagData>();
            if (positive_tags != null)
                newTags.AddRange(positive_tags);
            if (negative_tags != null)
                newTags.AddRange(negative_tags);

            AddNewTags(newTags);
        }

        public void AddNewTag(TagData tagData)
        {
            var item = new ListViewItem();
            item.Text = tagData.tagName;
            item.SubItems.Add(Convert.ToString(list_Tag.Items.Count + 1));
            item.SubItems.Add(enabled_text);
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
            received_tags.Add(tagData);
            list_Tag.Items.Add(item);
        }
        public void AddNewTags(List<TagData> tags)
        {
            list_Tag.BeginUpdate();

            foreach (var tagData in tags)
                AddNewTag(tagData);

            list_Tag.EndUpdate();
        }

        private void btn_EnableTag_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                item.SubItems[2].Text = enabled_text;
                var tagData = item.Tag as TagData;
                if (tagData != null)
                {
                    tagData.disabled = false;
                }
            }
            Apply_List_to_Prompt();
        }

        private void btn_DisableTag_Click(object sender, EventArgs e)
        {
            var selected = list_Tag.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                item.SubItems[2].Text = disabled_text;
                var tagData = item.Tag as TagData;
                if (tagData != null)
                {
                    tagData.disabled = true;
                }
            }
            Apply_List_to_Prompt();
        }

        private void btn_AddTag_Click(object sender, EventArgs e)
        {
            var tagData = new TagData();
            tagData.tagName = tb_NewTag.Text;
            tagData.positive = Convert.ToDouble(nud_Positive.Value);
            tagData.negative = Convert.ToDouble(nud_Negative.Value);
            AddNewTag(tagData);
            Apply_List_to_Prompt();
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
                    if (NAI_type_now == NAI_type.NAI)
                    {
                        //tagData.positive *= 1.1;
                        tagData.positive = Math.Max(0.1, tagData.positive + offset);
                    }
                    else if (NAI_type_now == NAI_type.WebUI)
                    {
                        tagData.positive = Math.Max(0.1, tagData.positive + offset);
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
                    if (NAI_type_now == NAI_type.NAI)
                    {
                        //tagData.negative *= 1.1;
                        tagData.negative = Math.Max(0.1, tagData.negative + offset);
                    }
                    else if (NAI_type_now == NAI_type.WebUI)
                    {
                        tagData.negative = Math.Max(0.1, tagData.negative + offset);
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

        private void list_Tag_KeyDown(object sender, KeyEventArgs e)
        {
            if (list_Tag.SelectedItems.Count == 0)
                return;

            switch(e.KeyCode)
            {
                case Keys.F2:
                    var selectedItem = list_Tag.SelectedItems[0];
                    selectedItem.BeginEdit();
                    break;
                case Keys.A:
                    if (e.Control)
                    {
                        list_Tag.BeginUpdate();
                        foreach (ListViewItem item in list_Tag.Items)
                            item.Selected = true;
                        list_Tag.EndUpdate();
                    }
                    break;
                case Keys.Delete:
                    list_Tag.BeginUpdate();
                    var items = list_Tag.SelectedItems;
                    foreach (ListViewItem item in items)
                        item.Remove();
                    list_Tag.EndUpdate();
                    Apply_List_to_Prompt();
                    break;
                case Keys.Left:
                case Keys.Right:
                    var positive_exist = false;
                    var negative_exist = false;
                    foreach  (ListViewItem item in list_Tag.SelectedItems)
                    {
                        var tagData = item.Tag as TagData;
                        if (tagData.positive > 0)
                            positive_exist = true;
                        if (tagData.negative > 0)
                            negative_exist = true;
                        if (positive_exist && negative_exist)
                            break;
                    }
                    if (positive_exist && negative_exist)
                        break;
                    if (!positive_exist && !negative_exist)
                        break;

                    if (positive_exist)
                        Positive_Offset(list_Tag.SelectedItems, e.KeyData == Keys.Right ? 0.1 : -0.1);
                    else if (negative_exist)
                        Negative_Offset(list_Tag.SelectedItems, e.KeyData == Keys.Right ? 0.1 : -0.1);
                    break;
            }
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
        }

        private void btn_FixIndex_Click(object sender, EventArgs e)
        {
            var items = list_Tag.Items;

            received_tags.Clear();
            foreach (ListViewItem item in items)
            {
                item.SubItems[1].Text = (item.Index + 1).ToString();
                received_tags.Add((TagData)item.Tag);
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
            if (NAI_type_now == NAI_type.NAI)
            {
                NAI_type_now = NAI_type.WebUI;
                label8.Text = "State : WebUI";
                btn_Convert.Text = "WebUI ¡æ NAI";
            }
            else
            {
                NAI_type_now = NAI_type.NAI;
                label8.Text = "State : NAI";
                btn_Convert.Text = "NAI ¡æ WebUI";
            }
        }
    }
}