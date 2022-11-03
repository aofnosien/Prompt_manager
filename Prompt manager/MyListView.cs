using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prompt_manager
{
    internal class MyListView : ListView
    {
        public Action ItemIndexChanged = delegate { };
        public static IList MakeSure_Sorted(IList items)
        {
            var index = -1;
            var index_notSorted = false;
            foreach (ListViewItem item in items)
            {
                if (index >= item.Index)
                {
                    index_notSorted = true;
                    break;
                }
                index = item.Index;
            }
            if (index_notSorted)
            {
                var _items = new List<ListViewItem>();
                foreach (ListViewItem item in items)
                {
                    var i = 0;
                    for (; i < _items.Count; i++)
                    {
                        if (item.Index < _items[i].Index)
                        {
                            _items.Insert(i, item);
                            break;
                        }
                    }
                    if (i == _items.Count)
                        _items.Add(item);
                }
                return _items;
            }
            else
                return items;
        }

        public static ListViewItem ToListViewItem(object? whatever)
        {
            var item = whatever as ListViewItem;
            if (item == null)
                throw new Exception("Fix your code.");
            return item;
        }

        public void Selected_PushUp(IList items)
        {
            items = MakeSure_Sorted(items);

            var dict = new Dictionary<object, object>();
            foreach (var item in items)
                dict.Add(item, null);

            this.BeginUpdate();
            for (var i = 0; i < items.Count; i++)
            {
                var item = ToListViewItem(items[i]);

                var index = item.Index;
                if (index - 1 >= 0 && dict.ContainsKey(this.Items[index - 1]) == false)
                {
                    this.Items.Remove(item);
                    this.Items.Insert(index - 1, item);
                }
            }
            ItemIndexChanged();
            this.EndUpdate();
        }

        public void Selected_PushDown(IList items)
        {
            items = MakeSure_Sorted(items);

            var dict = new Dictionary<object, object>();
            foreach (var item in items)
                dict.Add(item, null);

            this.BeginUpdate();
            for (var i = items.Count - 1; i >= 0; i--)
            {
                var item = ToListViewItem(items[i]);

                var index = item.Index;
                if (index + 1 <= this.Items.Count - 1 && dict.ContainsKey(this.Items[index + 1]) == false)
                {
                    this.Items.Remove(item);
                    this.Items.Insert(index + 1, item);
                }
            }
            ItemIndexChanged();
            this.EndUpdate();
        }

        protected override void OnItemDrag(ItemDragEventArgs e)
        {
            var items = new List<ListViewItem>();
            items.Add(ToListViewItem(e.Item));

            foreach (ListViewItem item in this.SelectedItems)
            {
                if (!items.Contains(item))
                {
                    items.Add(item);
                }
            }
            // pass the items to move...
            this.DoDragDrop(items, DragDropEffects.Move);
        }
        protected override void OnDragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        protected override void OnDragOver(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }
        protected override void OnDragDrop(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));

                Point mousePt = this.PointToClient(new Point(e.X, e.Y));

                ListViewItem targetItem = this.GetItemAt(mousePt.X, mousePt.Y);
                var targetIndex = -1;

                if (targetItem != null)
                {
                    if (items.Contains(targetItem))
                    {
                        var i = targetItem.Index;
                        for (; i < this.Items.Count; i++)
                        {
                            var item = this.Items[i];
                            if (items.Contains(item))
                                continue;
                            targetItem = item;
                            break;
                        }
                        if (i == this.Items.Count)
                            targetItem = null;
                    }
                    else if (targetItem.Index > 0 && items.Contains(this.Items[targetItem.Index - 1]))
                    {
                        if (targetItem.Index == this.Items.Count - 1)
                            targetItem = null;
                        else
                            targetItem = this.Items[targetItem.Index + 1];
                    }
                }

                items = MakeSure_Sorted(items) as List<ListViewItem>;

                // Remove items from list
                foreach (ListViewItem item in items)
                    this.Items.Remove(item);

                if (targetItem != null)
                    targetIndex = targetItem.Index;

                // Add items to index (if not targeted, add)
                if (targetIndex == -1)
                {
                    foreach (var item in items)
                        this.Items.Add(item);
                }
                else
                {
                    items.Reverse();
                    foreach (var item in items)
                        this.Items.Insert(targetIndex, item);
                }
                ItemIndexChanged();
            }
        }
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            if (this.SelectedItems.Count == 0)
                return;

            e.IsInputKey = false;
            switch (e.KeyCode)
            {
                case Keys.F2:
                    var selectedItem = this.SelectedItems[0];
                    selectedItem.BeginEdit();
                    break;
                case Keys.A:
                    if (e.Control)
                    {
                        this.BeginUpdate();
                        foreach (ListViewItem item in this.Items)
                            item.Selected = true;
                        this.EndUpdate();
                    }
                    break;
                default:
                    e.IsInputKey = true;
                    break;
            }
            if (e.IsInputKey)
                base.OnPreviewKeyDown(e);
        }
        public string GetEmptyName(string baseName, int name_subItemIndex, int startCount = 1)
        {
            var name_count = startCount;
            var newName = "";

            var dict = new Dictionary<string, object>();
            foreach (ListViewItem item in this.Items)
                dict.Add(item.SubItems[name_subItemIndex].Text, null);

            while (true)
            {
                newName = baseName + name_count;
                if (dict.ContainsKey(newName))
                {
                    name_count++;
                    continue;
                }
                break;
            }
            return newName;
        }
    }
}
