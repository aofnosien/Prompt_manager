namespace Prompt_manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Tag123");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Char123");
            this.list_Tag = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tb_NewTag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.nud_Positive = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PositiveSet = new System.Windows.Forms.Button();
            this.btn_PositiveDown = new System.Windows.Forms.Button();
            this.btn_PositiveUp = new System.Windows.Forms.Button();
            this.nud_Negative = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_NegativeDown = new System.Windows.Forms.Button();
            this.btn_NegativeSet = new System.Windows.Forms.Button();
            this.btn_NegativeUp = new System.Windows.Forms.Button();
            this.btn_AddTag = new System.Windows.Forms.Button();
            this.btn_FixIndex = new System.Windows.Forms.Button();
            this.btn_EnableTag = new System.Windows.Forms.Button();
            this.btn_DisableTag = new System.Windows.Forms.Button();
            this.btn_TagDown = new System.Windows.Forms.Button();
            this.btn_TagUp = new System.Windows.Forms.Button();
            this.cb_Option_Space = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Positive = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Negative = new System.Windows.Forms.TextBox();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.btn_ToList = new System.Windows.Forms.Button();
            this.list_Saved = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btn_SavedRemove = new System.Windows.Forms.Button();
            this.btn_SavedAdd = new System.Windows.Forms.Button();
            this.btn_SavedDown = new System.Windows.Forms.Button();
            this.btn_SavedUp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Positive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Negative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_Tag
            // 
            this.list_Tag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Tag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list_Tag.FullRowSelect = true;
            this.list_Tag.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.list_Tag.LabelEdit = true;
            this.list_Tag.Location = new System.Drawing.Point(3, 3);
            this.list_Tag.Name = "list_Tag";
            this.list_Tag.Size = new System.Drawing.Size(426, 265);
            this.list_Tag.TabIndex = 0;
            this.list_Tag.UseCompatibleStateImageBehavior = false;
            this.list_Tag.View = System.Windows.Forms.View.Details;
            this.list_Tag.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.list_Tag_AfterLabelEdit);
            this.list_Tag.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.list_Tag_ColumnClick);
            this.list_Tag.DoubleClick += new System.EventHandler(this.list_Tag_DoubleClick);
            this.list_Tag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.list_Tag_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tag";
            this.columnHeader1.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Index";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Disabled";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Positive";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Negative";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Location = new System.Drawing.Point(3, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tb_NewTag);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.list_Tag);
            this.splitContainer1.Panel1.Controls.Add(this.btn_AddTag);
            this.splitContainer1.Panel1.Controls.Add(this.btn_FixIndex);
            this.splitContainer1.Panel1.Controls.Add(this.btn_EnableTag);
            this.splitContainer1.Panel1.Controls.Add(this.btn_DisableTag);
            this.splitContainer1.Panel1.Controls.Add(this.btn_TagDown);
            this.splitContainer1.Panel1.Controls.Add(this.btn_TagUp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cb_Option_Space);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Convert);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ToList);
            this.splitContainer1.Size = new System.Drawing.Size(804, 399);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.TabIndex = 1;
            // 
            // tb_NewTag
            // 
            this.tb_NewTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NewTag.Location = new System.Drawing.Point(6, 303);
            this.tb_NewTag.MaxLength = 327670;
            this.tb_NewTag.Name = "tb_NewTag";
            this.tb_NewTag.Size = new System.Drawing.Size(350, 23);
            this.tb_NewTag.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "New tag name";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer2.Location = new System.Drawing.Point(3, 332);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.nud_Positive);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.btn_PositiveSet);
            this.splitContainer2.Panel1.Controls.Add(this.btn_PositiveDown);
            this.splitContainer2.Panel1.Controls.Add(this.btn_PositiveUp);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.nud_Negative);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.btn_NegativeDown);
            this.splitContainer2.Panel2.Controls.Add(this.btn_NegativeSet);
            this.splitContainer2.Panel2.Controls.Add(this.btn_NegativeUp);
            this.splitContainer2.Size = new System.Drawing.Size(426, 64);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 1;
            // 
            // nud_Positive
            // 
            this.nud_Positive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Positive.DecimalPlaces = 2;
            this.nud_Positive.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Positive.Location = new System.Drawing.Point(63, 9);
            this.nud_Positive.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Positive.Name = "nud_Positive";
            this.nud_Positive.Size = new System.Drawing.Size(132, 23);
            this.nud_Positive.TabIndex = 2;
            this.nud_Positive.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Positive";
            // 
            // btn_PositiveSet
            // 
            this.btn_PositiveSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PositiveSet.Location = new System.Drawing.Point(63, 38);
            this.btn_PositiveSet.Name = "btn_PositiveSet";
            this.btn_PositiveSet.Size = new System.Drawing.Size(132, 23);
            this.btn_PositiveSet.TabIndex = 0;
            this.btn_PositiveSet.Text = "Set";
            this.btn_PositiveSet.UseVisualStyleBackColor = true;
            this.btn_PositiveSet.Click += new System.EventHandler(this.btn_PositiveSet_Click);
            // 
            // btn_PositiveDown
            // 
            this.btn_PositiveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_PositiveDown.Location = new System.Drawing.Point(33, 38);
            this.btn_PositiveDown.Name = "btn_PositiveDown";
            this.btn_PositiveDown.Size = new System.Drawing.Size(24, 23);
            this.btn_PositiveDown.TabIndex = 0;
            this.btn_PositiveDown.Text = "-";
            this.btn_PositiveDown.UseVisualStyleBackColor = true;
            this.btn_PositiveDown.Click += new System.EventHandler(this.btn_PositiveDown_Click);
            // 
            // btn_PositiveUp
            // 
            this.btn_PositiveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_PositiveUp.Location = new System.Drawing.Point(3, 38);
            this.btn_PositiveUp.Name = "btn_PositiveUp";
            this.btn_PositiveUp.Size = new System.Drawing.Size(24, 23);
            this.btn_PositiveUp.TabIndex = 0;
            this.btn_PositiveUp.Text = "+";
            this.btn_PositiveUp.UseVisualStyleBackColor = true;
            this.btn_PositiveUp.Click += new System.EventHandler(this.btn_PositiveUp_Click);
            // 
            // nud_Negative
            // 
            this.nud_Negative.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Negative.DecimalPlaces = 2;
            this.nud_Negative.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_Negative.Location = new System.Drawing.Point(63, 9);
            this.nud_Negative.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Negative.Name = "nud_Negative";
            this.nud_Negative.Size = new System.Drawing.Size(158, 23);
            this.nud_Negative.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Negative";
            // 
            // btn_NegativeDown
            // 
            this.btn_NegativeDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NegativeDown.Location = new System.Drawing.Point(33, 38);
            this.btn_NegativeDown.Name = "btn_NegativeDown";
            this.btn_NegativeDown.Size = new System.Drawing.Size(24, 23);
            this.btn_NegativeDown.TabIndex = 0;
            this.btn_NegativeDown.Text = "-";
            this.btn_NegativeDown.UseVisualStyleBackColor = true;
            this.btn_NegativeDown.Click += new System.EventHandler(this.btn_NegativeDown_Click);
            // 
            // btn_NegativeSet
            // 
            this.btn_NegativeSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NegativeSet.Location = new System.Drawing.Point(63, 38);
            this.btn_NegativeSet.Name = "btn_NegativeSet";
            this.btn_NegativeSet.Size = new System.Drawing.Size(158, 23);
            this.btn_NegativeSet.TabIndex = 0;
            this.btn_NegativeSet.Text = "Set";
            this.btn_NegativeSet.UseVisualStyleBackColor = true;
            this.btn_NegativeSet.Click += new System.EventHandler(this.btn_NegativeSet_Click);
            // 
            // btn_NegativeUp
            // 
            this.btn_NegativeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_NegativeUp.Location = new System.Drawing.Point(3, 38);
            this.btn_NegativeUp.Name = "btn_NegativeUp";
            this.btn_NegativeUp.Size = new System.Drawing.Size(24, 23);
            this.btn_NegativeUp.TabIndex = 0;
            this.btn_NegativeUp.Text = "+";
            this.btn_NegativeUp.UseVisualStyleBackColor = true;
            this.btn_NegativeUp.Click += new System.EventHandler(this.btn_NegativeUp_Click);
            // 
            // btn_AddTag
            // 
            this.btn_AddTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddTag.Location = new System.Drawing.Point(362, 303);
            this.btn_AddTag.Name = "btn_AddTag";
            this.btn_AddTag.Size = new System.Drawing.Size(64, 23);
            this.btn_AddTag.TabIndex = 0;
            this.btn_AddTag.Text = "Add";
            this.btn_AddTag.UseVisualStyleBackColor = true;
            this.btn_AddTag.Click += new System.EventHandler(this.btn_AddTag_Click);
            // 
            // btn_FixIndex
            // 
            this.btn_FixIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FixIndex.Location = new System.Drawing.Point(162, 274);
            this.btn_FixIndex.Name = "btn_FixIndex";
            this.btn_FixIndex.Size = new System.Drawing.Size(64, 23);
            this.btn_FixIndex.TabIndex = 0;
            this.btn_FixIndex.Text = "Fix index";
            this.btn_FixIndex.UseVisualStyleBackColor = true;
            this.btn_FixIndex.Click += new System.EventHandler(this.btn_FixIndex_Click);
            // 
            // btn_EnableTag
            // 
            this.btn_EnableTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_EnableTag.Location = new System.Drawing.Point(232, 274);
            this.btn_EnableTag.Name = "btn_EnableTag";
            this.btn_EnableTag.Size = new System.Drawing.Size(64, 23);
            this.btn_EnableTag.TabIndex = 0;
            this.btn_EnableTag.Text = "Enable";
            this.btn_EnableTag.UseVisualStyleBackColor = true;
            this.btn_EnableTag.Click += new System.EventHandler(this.btn_EnableTag_Click);
            // 
            // btn_DisableTag
            // 
            this.btn_DisableTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DisableTag.Location = new System.Drawing.Point(302, 274);
            this.btn_DisableTag.Name = "btn_DisableTag";
            this.btn_DisableTag.Size = new System.Drawing.Size(64, 23);
            this.btn_DisableTag.TabIndex = 0;
            this.btn_DisableTag.Text = "Disable";
            this.btn_DisableTag.UseVisualStyleBackColor = true;
            this.btn_DisableTag.Click += new System.EventHandler(this.btn_DisableTag_Click);
            // 
            // btn_TagDown
            // 
            this.btn_TagDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TagDown.Enabled = false;
            this.btn_TagDown.Location = new System.Drawing.Point(402, 274);
            this.btn_TagDown.Name = "btn_TagDown";
            this.btn_TagDown.Size = new System.Drawing.Size(24, 23);
            this.btn_TagDown.TabIndex = 0;
            this.btn_TagDown.Text = "↓";
            this.btn_TagDown.UseVisualStyleBackColor = true;
            // 
            // btn_TagUp
            // 
            this.btn_TagUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TagUp.Enabled = false;
            this.btn_TagUp.Location = new System.Drawing.Point(372, 274);
            this.btn_TagUp.Name = "btn_TagUp";
            this.btn_TagUp.Size = new System.Drawing.Size(24, 23);
            this.btn_TagUp.TabIndex = 0;
            this.btn_TagUp.Text = "↑";
            this.btn_TagUp.UseVisualStyleBackColor = true;
            // 
            // cb_Option_Space
            // 
            this.cb_Option_Space.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_Option_Space.AutoSize = true;
            this.cb_Option_Space.Location = new System.Drawing.Point(102, 303);
            this.cb_Option_Space.Name = "cb_Option_Space";
            this.cb_Option_Space.Size = new System.Drawing.Size(63, 19);
            this.cb_Option_Space.TabIndex = 3;
            this.cb_Option_Space.Text = ", space";
            this.cb_Option_Space.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "State : WebUI";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.tb_Positive);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.tb_Negative);
            this.splitContainer3.Size = new System.Drawing.Size(362, 294);
            this.splitContainer3.SplitterDistance = 146;
            this.splitContainer3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Positive";
            // 
            // tb_Positive
            // 
            this.tb_Positive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Positive.Location = new System.Drawing.Point(3, 18);
            this.tb_Positive.MaxLength = 327670;
            this.tb_Positive.Multiline = true;
            this.tb_Positive.Name = "tb_Positive";
            this.tb_Positive.Size = new System.Drawing.Size(356, 125);
            this.tb_Positive.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Negative";
            // 
            // tb_Negative
            // 
            this.tb_Negative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Negative.Location = new System.Drawing.Point(3, 18);
            this.tb_Negative.MaxLength = 327670;
            this.tb_Negative.Multiline = true;
            this.tb_Negative.Name = "tb_Negative";
            this.tb_Negative.Size = new System.Drawing.Size(356, 123);
            this.tb_Negative.TabIndex = 0;
            // 
            // btn_Convert
            // 
            this.btn_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Convert.Location = new System.Drawing.Point(6, 370);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(90, 23);
            this.btn_Convert.TabIndex = 0;
            this.btn_Convert.Text = "WebUI → NAI";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
            // 
            // btn_ToList
            // 
            this.btn_ToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ToList.Location = new System.Drawing.Point(6, 303);
            this.btn_ToList.Name = "btn_ToList";
            this.btn_ToList.Size = new System.Drawing.Size(90, 42);
            this.btn_ToList.TabIndex = 0;
            this.btn_ToList.Text = "← Prompt\r\nto list";
            this.btn_ToList.UseVisualStyleBackColor = true;
            this.btn_ToList.Click += new System.EventHandler(this.btn_ToList_Click);
            // 
            // list_Saved
            // 
            this.list_Saved.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_Saved.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5});
            this.list_Saved.FullRowSelect = true;
            this.list_Saved.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.list_Saved.LabelEdit = true;
            this.list_Saved.Location = new System.Drawing.Point(3, 27);
            this.list_Saved.Name = "list_Saved";
            this.list_Saved.Size = new System.Drawing.Size(180, 362);
            this.list_Saved.TabIndex = 2;
            this.list_Saved.UseCompatibleStateImageBehavior = false;
            this.list_Saved.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Saved";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer4.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer4.Location = new System.Drawing.Point(12, 12);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label5);
            this.splitContainer4.Panel1.Controls.Add(this.list_Saved);
            this.splitContainer4.Panel1.Controls.Add(this.btn_SavedRemove);
            this.splitContainer4.Panel1.Controls.Add(this.btn_SavedAdd);
            this.splitContainer4.Panel1.Controls.Add(this.btn_SavedDown);
            this.splitContainer4.Panel1.Controls.Add(this.btn_SavedUp);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.label9);
            this.splitContainer4.Panel2.Controls.Add(this.label6);
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer4.Size = new System.Drawing.Size(1000, 426);
            this.splitContainer4.SplitterDistance = 186;
            this.splitContainer4.TabIndex = 3;
            // 
            // btn_SavedRemove
            // 
            this.btn_SavedRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SavedRemove.Enabled = false;
            this.btn_SavedRemove.Location = new System.Drawing.Point(33, 395);
            this.btn_SavedRemove.Name = "btn_SavedRemove";
            this.btn_SavedRemove.Size = new System.Drawing.Size(24, 23);
            this.btn_SavedRemove.TabIndex = 0;
            this.btn_SavedRemove.Text = "x";
            this.btn_SavedRemove.UseVisualStyleBackColor = true;
            // 
            // btn_SavedAdd
            // 
            this.btn_SavedAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SavedAdd.Enabled = false;
            this.btn_SavedAdd.Location = new System.Drawing.Point(3, 395);
            this.btn_SavedAdd.Name = "btn_SavedAdd";
            this.btn_SavedAdd.Size = new System.Drawing.Size(24, 23);
            this.btn_SavedAdd.TabIndex = 0;
            this.btn_SavedAdd.Text = "+";
            this.btn_SavedAdd.UseVisualStyleBackColor = true;
            // 
            // btn_SavedDown
            // 
            this.btn_SavedDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SavedDown.Enabled = false;
            this.btn_SavedDown.Location = new System.Drawing.Point(159, 395);
            this.btn_SavedDown.Name = "btn_SavedDown";
            this.btn_SavedDown.Size = new System.Drawing.Size(24, 23);
            this.btn_SavedDown.TabIndex = 0;
            this.btn_SavedDown.Text = "↓";
            this.btn_SavedDown.UseVisualStyleBackColor = true;
            // 
            // btn_SavedUp
            // 
            this.btn_SavedUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SavedUp.Enabled = false;
            this.btn_SavedUp.Location = new System.Drawing.Point(129, 395);
            this.btn_SavedUp.Name = "btn_SavedUp";
            this.btn_SavedUp.Size = new System.Drawing.Size(24, 23);
            this.btn_SavedUp.TabIndex = 0;
            this.btn_SavedUp.Text = "↑";
            this.btn_SavedUp.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(162, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "← → : Move weight, Del : Remove tag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tags";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.splitContainer4);
            this.Name = "Form1";
            this.Text = "Prompt manager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Positive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Negative)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView list_Tag;
        private ColumnHeader columnHeader1;
        private SplitContainer splitContainer1;
        private TextBox tb_Positive;
        private SplitContainer splitContainer2;
        private Button btn_PositiveUp;
        private NumericUpDown nud_Positive;
        private Label label1;
        private Button btn_PositiveDown;
        private Label label2;
        private Button btn_NegativeDown;
        private Button btn_NegativeUp;
        private SplitContainer splitContainer3;
        private Label label3;
        private Label label4;
        private TextBox tb_Negative;
        private Button btn_PositiveSet;
        private NumericUpDown nud_Negative;
        private Button btn_NegativeSet;
        private Button btn_ToList;
        private ColumnHeader columnHeader2;
        private Button btn_DisableTag;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btn_Convert;
        private Button btn_TagDown;
        private Button btn_TagUp;
        private ListView list_Saved;
        private ColumnHeader columnHeader5;
        private Label label5;
        private SplitContainer splitContainer4;
        private TextBox tb_NewTag;
        private Button btn_AddTag;
        private Button btn_SavedAdd;
        private Label label6;
        private Label label7;
        private Button btn_SavedRemove;
        private Button btn_SavedDown;
        private Button btn_SavedUp;
        private CheckBox cb_Option_Space;
        private Label label8;
        private Button btn_EnableTag;
        private ColumnHeader columnHeader6;
        private Button btn_FixIndex;
        private Label label9;
    }
}