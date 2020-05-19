namespace MediaManagerForm
{
    partial class mmInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mmInterface));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.addMedia_tab = new System.Windows.Forms.TabPage();
            this.addMedia_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.persons_cmbBox = new System.Windows.Forms.ComboBox();
            this.moviePreview_MediaPly = new AxWMPLib.AxWindowsMediaPlayer();
            this.path_CmbCox = new System.Windows.Forms.ComboBox();
            this.addPerson_btn = new System.Windows.Forms.Button();
            this.persons_lbl = new System.Windows.Forms.Label();
            this.event_txt = new System.Windows.Forms.TextBox();
            this.event_lbl = new System.Windows.Forms.Label();
            this.location_txt = new System.Windows.Forms.TextBox();
            this.location_lbl = new System.Windows.Forms.Label();
            this.thumbnail_picBox = new System.Windows.Forms.PictureBox();
            this.error_lbl = new System.Windows.Forms.Label();
            this.openFile_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addAttribute_btn = new System.Windows.Forms.Button();
            this.newAttribute_lbl = new System.Windows.Forms.Label();
            this.attribute1_box = new System.Windows.Forms.ComboBox();
            this.browse_tab = new System.Windows.Forms.TabPage();
            this.search_btn = new System.Windows.Forms.Button();
            this.searchResults_box = new System.Windows.Forms.GroupBox();
            this.movie_MediaPly = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.extra_cmbBox = new System.Windows.Forms.ComboBox();
            this.persons2_cmbBox = new System.Windows.Forms.ComboBox();
            this.extra_lbl = new System.Windows.Forms.Label();
            this.persons2_lbl = new System.Windows.Forms.Label();
            this.event2_txt = new System.Windows.Forms.TextBox();
            this.event2_lbl = new System.Windows.Forms.Label();
            this.location2_txt = new System.Windows.Forms.TextBox();
            this.location2_lbl = new System.Windows.Forms.Label();
            this.separator1_lbl = new System.Windows.Forms.Label();
            this.searchResults_cmbBox = new System.Windows.Forms.ComboBox();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.delete_btn = new System.Windows.Forms.Button();
            this.info_Box = new System.Windows.Forms.PictureBox();
            this.TabControl.SuspendLayout();
            this.addMedia_tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePreview_MediaPly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail_picBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.browse_tab.SuspendLayout();
            this.searchResults_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_MediaPly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.addMedia_tab);
            this.TabControl.Controls.Add(this.browse_tab);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1029, 690);
            this.TabControl.TabIndex = 0;
            // 
            // addMedia_tab
            // 
            this.addMedia_tab.Controls.Add(this.addMedia_btn);
            this.addMedia_tab.Controls.Add(this.groupBox2);
            this.addMedia_tab.Controls.Add(this.groupBox1);
            this.addMedia_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addMedia_tab.Location = new System.Drawing.Point(4, 29);
            this.addMedia_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMedia_tab.Name = "addMedia_tab";
            this.addMedia_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMedia_tab.Size = new System.Drawing.Size(1021, 657);
            this.addMedia_tab.TabIndex = 0;
            this.addMedia_tab.Text = "Add Media";
            this.addMedia_tab.UseVisualStyleBackColor = true;
            // 
            // addMedia_btn
            // 
            this.addMedia_btn.Location = new System.Drawing.Point(455, 601);
            this.addMedia_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addMedia_btn.Name = "addMedia_btn";
            this.addMedia_btn.Size = new System.Drawing.Size(109, 33);
            this.addMedia_btn.TabIndex = 9;
            this.addMedia_btn.Text = "Add";
            this.addMedia_btn.UseVisualStyleBackColor = true;
            this.addMedia_btn.Click += new System.EventHandler(this.addMedia_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.info_Box);
            this.groupBox2.Controls.Add(this.persons_cmbBox);
            this.groupBox2.Controls.Add(this.moviePreview_MediaPly);
            this.groupBox2.Controls.Add(this.path_CmbCox);
            this.groupBox2.Controls.Add(this.addPerson_btn);
            this.groupBox2.Controls.Add(this.persons_lbl);
            this.groupBox2.Controls.Add(this.event_txt);
            this.groupBox2.Controls.Add(this.event_lbl);
            this.groupBox2.Controls.Add(this.location_txt);
            this.groupBox2.Controls.Add(this.location_lbl);
            this.groupBox2.Controls.Add(this.thumbnail_picBox);
            this.groupBox2.Controls.Add(this.error_lbl);
            this.groupBox2.Controls.Add(this.openFile_btn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox2.Location = new System.Drawing.Point(7, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1011, 326);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Premade Properties";
            // 
            // persons_cmbBox
            // 
            this.persons_cmbBox.FormattingEnabled = true;
            this.persons_cmbBox.Location = new System.Drawing.Point(148, 256);
            this.persons_cmbBox.Name = "persons_cmbBox";
            this.persons_cmbBox.Size = new System.Drawing.Size(187, 28);
            this.persons_cmbBox.TabIndex = 11;
            // 
            // moviePreview_MediaPly
            // 
            this.moviePreview_MediaPly.Enabled = true;
            this.moviePreview_MediaPly.Location = new System.Drawing.Point(448, 37);
            this.moviePreview_MediaPly.MaximumSize = new System.Drawing.Size(389, 272);
            this.moviePreview_MediaPly.Name = "moviePreview_MediaPly";
            this.moviePreview_MediaPly.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("moviePreview_MediaPly.OcxState")));
            this.moviePreview_MediaPly.Size = new System.Drawing.Size(386, 272);
            this.moviePreview_MediaPly.TabIndex = 10;
            this.moviePreview_MediaPly.Visible = false;
            // 
            // path_CmbCox
            // 
            this.path_CmbCox.FormattingEnabled = true;
            this.path_CmbCox.Location = new System.Drawing.Point(148, 37);
            this.path_CmbCox.Name = "path_CmbCox";
            this.path_CmbCox.Size = new System.Drawing.Size(375, 28);
            this.path_CmbCox.TabIndex = 9;
            this.path_CmbCox.SelectedIndexChanged += new System.EventHandler(this.path_CmbCox_SelectedIndexChanged);
            // 
            // addPerson_btn
            // 
            this.addPerson_btn.Location = new System.Drawing.Point(341, 254);
            this.addPerson_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addPerson_btn.Name = "addPerson_btn";
            this.addPerson_btn.Size = new System.Drawing.Size(29, 30);
            this.addPerson_btn.TabIndex = 3;
            this.addPerson_btn.Text = "+";
            this.addPerson_btn.UseVisualStyleBackColor = true;
            this.addPerson_btn.Click += new System.EventHandler(this.addPerson_btn_Click);
            // 
            // persons_lbl
            // 
            this.persons_lbl.AutoSize = true;
            this.persons_lbl.Location = new System.Drawing.Point(51, 258);
            this.persons_lbl.Name = "persons_lbl";
            this.persons_lbl.Size = new System.Drawing.Size(71, 20);
            this.persons_lbl.TabIndex = 1;
            this.persons_lbl.Text = "Persons:";
            // 
            // event_txt
            // 
            this.event_txt.Location = new System.Drawing.Point(148, 192);
            this.event_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.event_txt.MaxLength = 60;
            this.event_txt.Name = "event_txt";
            this.event_txt.Size = new System.Drawing.Size(187, 25);
            this.event_txt.TabIndex = 7;
            // 
            // event_lbl
            // 
            this.event_lbl.AutoSize = true;
            this.event_lbl.Location = new System.Drawing.Point(51, 194);
            this.event_lbl.Name = "event_lbl";
            this.event_lbl.Size = new System.Drawing.Size(54, 20);
            this.event_lbl.TabIndex = 6;
            this.event_lbl.Text = "Event:";
            // 
            // location_txt
            // 
            this.location_txt.Location = new System.Drawing.Point(148, 124);
            this.location_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.location_txt.MaxLength = 60;
            this.location_txt.Name = "location_txt";
            this.location_txt.Size = new System.Drawing.Size(187, 25);
            this.location_txt.TabIndex = 5;
            // 
            // location_lbl
            // 
            this.location_lbl.AutoSize = true;
            this.location_lbl.Location = new System.Drawing.Point(51, 124);
            this.location_lbl.Name = "location_lbl";
            this.location_lbl.Size = new System.Drawing.Size(74, 20);
            this.location_lbl.TabIndex = 4;
            this.location_lbl.Text = "Location:";
            // 
            // thumbnail_picBox
            // 
            this.thumbnail_picBox.Location = new System.Drawing.Point(595, 37);
            this.thumbnail_picBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thumbnail_picBox.Name = "thumbnail_picBox";
            this.thumbnail_picBox.Size = new System.Drawing.Size(388, 274);
            this.thumbnail_picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnail_picBox.TabIndex = 3;
            this.thumbnail_picBox.TabStop = false;
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.ForeColor = System.Drawing.Color.Red;
            this.error_lbl.Location = new System.Drawing.Point(144, 66);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 20);
            this.error_lbl.TabIndex = 2;
            // 
            // openFile_btn
            // 
            this.openFile_btn.Location = new System.Drawing.Point(19, 34);
            this.openFile_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.Size = new System.Drawing.Size(109, 33);
            this.openFile_btn.TabIndex = 0;
            this.openFile_btn.Text = "Open";
            this.openFile_btn.UseVisualStyleBackColor = true;
            this.openFile_btn.Click += new System.EventHandler(this.openFile_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.addAttribute_btn);
            this.groupBox1.Controls.Add(this.newAttribute_lbl);
            this.groupBox1.Controls.Add(this.attribute1_box);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.groupBox1.Location = new System.Drawing.Point(9, 336);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1011, 258);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom properties";
            // 
            // addAttribute_btn
            // 
            this.addAttribute_btn.Location = new System.Drawing.Point(339, 62);
            this.addAttribute_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addAttribute_btn.Name = "addAttribute_btn";
            this.addAttribute_btn.Size = new System.Drawing.Size(29, 30);
            this.addAttribute_btn.TabIndex = 2;
            this.addAttribute_btn.Text = "+";
            this.addAttribute_btn.UseVisualStyleBackColor = true;
            this.addAttribute_btn.Click += new System.EventHandler(this.addAttribute_btn_Click);
            // 
            // newAttribute_lbl
            // 
            this.newAttribute_lbl.AutoSize = true;
            this.newAttribute_lbl.Location = new System.Drawing.Point(25, 65);
            this.newAttribute_lbl.Name = "newAttribute_lbl";
            this.newAttribute_lbl.Size = new System.Drawing.Size(109, 20);
            this.newAttribute_lbl.TabIndex = 1;
            this.newAttribute_lbl.Text = "New Attribute:";
            // 
            // attribute1_box
            // 
            this.attribute1_box.FormattingEnabled = true;
            this.attribute1_box.Location = new System.Drawing.Point(147, 62);
            this.attribute1_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attribute1_box.Name = "attribute1_box";
            this.attribute1_box.Size = new System.Drawing.Size(187, 28);
            this.attribute1_box.TabIndex = 0;
            // 
            // browse_tab
            // 
            this.browse_tab.Controls.Add(this.delete_btn);
            this.browse_tab.Controls.Add(this.search_btn);
            this.browse_tab.Controls.Add(this.searchResults_box);
            this.browse_tab.Controls.Add(this.search_txt);
            this.browse_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.browse_tab.Location = new System.Drawing.Point(4, 29);
            this.browse_tab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browse_tab.Name = "browse_tab";
            this.browse_tab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browse_tab.Size = new System.Drawing.Size(1021, 657);
            this.browse_tab.TabIndex = 1;
            this.browse_tab.Text = "Browse";
            this.browse_tab.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(740, 30);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(109, 33);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // searchResults_box
            // 
            this.searchResults_box.Controls.Add(this.pictureBox2);
            this.searchResults_box.Controls.Add(this.extra_cmbBox);
            this.searchResults_box.Controls.Add(this.persons2_cmbBox);
            this.searchResults_box.Controls.Add(this.extra_lbl);
            this.searchResults_box.Controls.Add(this.persons2_lbl);
            this.searchResults_box.Controls.Add(this.event2_txt);
            this.searchResults_box.Controls.Add(this.event2_lbl);
            this.searchResults_box.Controls.Add(this.location2_txt);
            this.searchResults_box.Controls.Add(this.location2_lbl);
            this.searchResults_box.Controls.Add(this.separator1_lbl);
            this.searchResults_box.Controls.Add(this.searchResults_cmbBox);
            this.searchResults_box.Controls.Add(this.movie_MediaPly);
            this.searchResults_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.searchResults_box.Location = new System.Drawing.Point(19, 94);
            this.searchResults_box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchResults_box.Name = "searchResults_box";
            this.searchResults_box.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchResults_box.Size = new System.Drawing.Size(983, 543);
            this.searchResults_box.TabIndex = 2;
            this.searchResults_box.TabStop = false;
            this.searchResults_box.Text = "Search Results";
            // 
            // movie_MediaPly
            // 
            this.movie_MediaPly.Enabled = true;
            this.movie_MediaPly.Location = new System.Drawing.Point(423, 108);
            this.movie_MediaPly.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movie_MediaPly.MaximumSize = new System.Drawing.Size(388, 274);
            this.movie_MediaPly.Name = "movie_MediaPly";
            this.movie_MediaPly.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("movie_MediaPly.OcxState")));
            this.movie_MediaPly.Size = new System.Drawing.Size(388, 274);
            this.movie_MediaPly.TabIndex = 21;
            this.movie_MediaPly.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(540, 135);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 274);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // extra_cmbBox
            // 
            this.extra_cmbBox.FormattingEnabled = true;
            this.extra_cmbBox.Location = new System.Drawing.Point(160, 359);
            this.extra_cmbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.extra_cmbBox.Name = "extra_cmbBox";
            this.extra_cmbBox.Size = new System.Drawing.Size(187, 28);
            this.extra_cmbBox.TabIndex = 17;
            // 
            // persons2_cmbBox
            // 
            this.persons2_cmbBox.FormattingEnabled = true;
            this.persons2_cmbBox.Location = new System.Drawing.Point(160, 293);
            this.persons2_cmbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.persons2_cmbBox.Name = "persons2_cmbBox";
            this.persons2_cmbBox.Size = new System.Drawing.Size(187, 28);
            this.persons2_cmbBox.TabIndex = 16;
            // 
            // extra_lbl
            // 
            this.extra_lbl.AutoSize = true;
            this.extra_lbl.Location = new System.Drawing.Point(61, 362);
            this.extra_lbl.Name = "extra_lbl";
            this.extra_lbl.Size = new System.Drawing.Size(50, 20);
            this.extra_lbl.TabIndex = 15;
            this.extra_lbl.Text = "Extra:";
            // 
            // persons2_lbl
            // 
            this.persons2_lbl.AutoSize = true;
            this.persons2_lbl.Location = new System.Drawing.Point(61, 295);
            this.persons2_lbl.Name = "persons2_lbl";
            this.persons2_lbl.Size = new System.Drawing.Size(71, 20);
            this.persons2_lbl.TabIndex = 9;
            this.persons2_lbl.Text = "Persons:";
            // 
            // event2_txt
            // 
            this.event2_txt.Location = new System.Drawing.Point(160, 229);
            this.event2_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.event2_txt.MaxLength = 60;
            this.event2_txt.Name = "event2_txt";
            this.event2_txt.Size = new System.Drawing.Size(187, 25);
            this.event2_txt.TabIndex = 13;
            // 
            // event2_lbl
            // 
            this.event2_lbl.AutoSize = true;
            this.event2_lbl.Location = new System.Drawing.Point(61, 231);
            this.event2_lbl.Name = "event2_lbl";
            this.event2_lbl.Size = new System.Drawing.Size(54, 20);
            this.event2_lbl.TabIndex = 12;
            this.event2_lbl.Text = "Event:";
            // 
            // location2_txt
            // 
            this.location2_txt.Location = new System.Drawing.Point(160, 161);
            this.location2_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.location2_txt.MaxLength = 60;
            this.location2_txt.Name = "location2_txt";
            this.location2_txt.Size = new System.Drawing.Size(187, 25);
            this.location2_txt.TabIndex = 11;
            // 
            // location2_lbl
            // 
            this.location2_lbl.AutoSize = true;
            this.location2_lbl.Location = new System.Drawing.Point(61, 161);
            this.location2_lbl.Name = "location2_lbl";
            this.location2_lbl.Size = new System.Drawing.Size(74, 20);
            this.location2_lbl.TabIndex = 10;
            this.location2_lbl.Text = "Location:";
            // 
            // separator1_lbl
            // 
            this.separator1_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator1_lbl.Location = new System.Drawing.Point(491, 95);
            this.separator1_lbl.Name = "separator1_lbl";
            this.separator1_lbl.Size = new System.Drawing.Size(3, 350);
            this.separator1_lbl.TabIndex = 3;
            // 
            // searchResults_cmbBox
            // 
            this.searchResults_cmbBox.FormattingEnabled = true;
            this.searchResults_cmbBox.Location = new System.Drawing.Point(160, 34);
            this.searchResults_cmbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchResults_cmbBox.Name = "searchResults_cmbBox";
            this.searchResults_cmbBox.Size = new System.Drawing.Size(663, 28);
            this.searchResults_cmbBox.TabIndex = 0;
            this.searchResults_cmbBox.SelectedIndexChanged += new System.EventHandler(this.searchResults_cmbBox_SelectedIndexChanged);
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(287, 32);
            this.search_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_txt.MaxLength = 60;
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(447, 25);
            this.search_txt.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(456, 580);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(109, 33);
            this.delete_btn.TabIndex = 11;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // info_Box
            // 
            this.info_Box.ImageLocation = "";
            this.info_Box.Location = new System.Drawing.Point(977, 13);
            this.info_Box.Name = "info_Box";
            this.info_Box.Size = new System.Drawing.Size(31, 30);
            this.info_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.info_Box.TabIndex = 11;
            this.info_Box.TabStop = false;
            // 
            // mmInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 714);
            this.Controls.Add(this.TabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mmInterface";
            this.Text = "Media Manager";
            this.Load += new System.EventHandler(this.mmInterface_Load);
            this.TabControl.ResumeLayout(false);
            this.addMedia_tab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moviePreview_MediaPly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail_picBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.browse_tab.ResumeLayout(false);
            this.browse_tab.PerformLayout();
            this.searchResults_box.ResumeLayout(false);
            this.searchResults_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movie_MediaPly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage addMedia_tab;
        private System.Windows.Forms.TabPage browse_tab;
        private System.Windows.Forms.Button openFile_btn;
        private System.Windows.Forms.Label error_lbl;
        private System.Windows.Forms.PictureBox thumbnail_picBox;
        private System.Windows.Forms.Label location_lbl;
        private System.Windows.Forms.TextBox location_txt;
        private System.Windows.Forms.TextBox event_txt;
        private System.Windows.Forms.Label event_lbl;
        private System.Windows.Forms.Label persons_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addAttribute_btn;
        private System.Windows.Forms.Label newAttribute_lbl;
        private System.Windows.Forms.ComboBox attribute1_box;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.GroupBox searchResults_box;
        private System.Windows.Forms.Button addPerson_btn;
        private System.Windows.Forms.ComboBox searchResults_cmbBox;
        private System.Windows.Forms.Label separator1_lbl;
        private System.Windows.Forms.Label persons2_lbl;
        private System.Windows.Forms.TextBox event2_txt;
        private System.Windows.Forms.Label event2_lbl;
        private System.Windows.Forms.TextBox location2_txt;
        private System.Windows.Forms.Label location2_lbl;
        private System.Windows.Forms.Label extra_lbl;
        private System.Windows.Forms.ComboBox persons2_cmbBox;
        private System.Windows.Forms.ComboBox extra_cmbBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addMedia_btn;
        private System.Windows.Forms.Button search_btn;
        private AxWMPLib.AxWindowsMediaPlayer movie_MediaPly;
        private System.Windows.Forms.ComboBox path_CmbCox;
        private AxWMPLib.AxWindowsMediaPlayer moviePreview_MediaPly;
        private System.Windows.Forms.ComboBox persons_cmbBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox info_Box;
        private System.Windows.Forms.Button delete_btn;
    }
}