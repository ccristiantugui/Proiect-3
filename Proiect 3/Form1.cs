using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using WMPLib;
using MediaManager;
using System.Diagnostics;

namespace MediaManagerForm
{
    public partial class mmInterface : Form
    {
        private List<ComboBox> newAttributesList = new List<ComboBox>();
        private Dictionary<string, Media> searchResultsMap = new Dictionary<string, Media>();
        private List<string> addedPersons = new List<string>();
        private List<string> addedAttributes = new List<string>();

        public mmInterface()
        {
            InitializeComponent();
        }

        private void mmInterface_Load(object sender, EventArgs e)
        {
            this.newAttributesList.Add(attribute1_box);
            toolTip1.SetToolTip(persons_cmbBox, "To delete entry, type in the name again and press the \"add\" button.");
            toolTip1.SetToolTip(info_Box, "To modify an entry, fill in the desired path and the new characteristics,\n then press the \"Add\" button.");
            info_Box.Image = Image.FromFile("..\\..\\..\\Images\\info.png");
        }

        //////////// First tab
        private void openFile_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.ValidateNames = false;
            openFileDialog.CheckFileExists = false;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FileName = "Folder Selection.";
            openFileDialog.ShowDialog();
            string filename = openFileDialog.FileName;
            if(filename.EndsWith("Folder Selection"))
            {
                filename = Path.GetDirectoryName(openFileDialog.FileName);
            }

            if (Directory.Exists(filename))
            { 
                addMediaToPath(filename);
                path_CmbCox.SelectedIndex = 0;
            }
            else if (File.Exists(filename))
            {
                if (!path_CmbCox.Items.Contains(filename))
                {
                    if (API.fileType(filename) != "Unsupported")
                    {
                        path_CmbCox.Items.Add(filename);
                        path_CmbCox.SelectedIndex = 0;
                    }
                    else
                    {
                        Console.WriteLine("in");
                        setErrorMessage("File type unsupported");
                    }
                }
                else
                {
                    setErrorMessage("File already added");
                }
            } 
            else
            {
                Console.WriteLine(filename);
                setErrorMessage("Invalid path");
            }

            List<string> persons = API.getPersonsFromDB();
            List<string> customAttributes = API.getCustomAttributesFromDB();
        }

        private void addMediaToPath(string filename)
        {
            foreach(string file in Directory.GetFiles(filename))
            {
                if(API.fileType(file) != "Unsupported")
                {
                    if(!path_CmbCox.Items.Contains(file))
                        path_CmbCox.Items.Add(file);
                }
            }
        }

        private void path_CmbCox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filename = path_CmbCox.SelectedItem.ToString();
            switch (API.fileType(filename))
            {
                case "Image":
                    moviePreview_MediaPly.Visible = false;
                    moviePreview_MediaPly.Ctlcontrols.stop();
                    thumbnail_picBox.Visible = true;
                    thumbnail_picBox.Image = Image.FromFile(filename);
                    break;
                case "Video":
                    moviePreview_MediaPly.Visible = true;
                    thumbnail_picBox.Visible = false;
                    moviePreview_MediaPly.URL = filename;
                    break;
                case "Unsupported":
                    //TODO
                    break;
            }
        }

        private void addAttribute_btn_Click(object sender, EventArgs e)
        {
            /// Adauga dinamic un camp nou pentru atribute "custom". (Maxim: 6)
            if (String.IsNullOrWhiteSpace(this.newAttributesList[this.newAttributesList.Count - 1].Text))
            {
                return;
            }

            ComboBox newAttribute = new ComboBox();

            if (this.newAttributesList.Count != 3 )
            {
                ComboBox lastAttribute = this.newAttributesList[this.newAttributesList.Count - 1];
                newAttribute.Font = new Font(newAttribute.Font.FontFamily, 10);
                newAttribute.Width = lastAttribute.Width;
                newAttribute.Location = lastAttribute.FindForm().PointToClient(lastAttribute.Parent.PointToScreen(lastAttribute.Location));
                newAttribute.Top += 5;
                newAttribute.Left -= 13;
                newAttribute.Name = "attribute" + this.newAttributesList.Count + "_box";
                
                newAttribute.BringToFront();
                addAttribute_btn.Top += 40;
                newAttribute.Parent = groupBox1;
                Debug.WriteLine(newAttribute.Parent);
                this.Controls.Add(newAttribute);
                addMedia_tab.Controls.Add(newAttribute);
                newAttribute.BringToFront();
                newAttributesList.Add(newAttribute);

                if (this.newAttributesList.Count > 5)
                {
                    addAttribute_btn.Visible = false;
                }
            }
            else
            {
                newAttribute.Font = new Font(newAttribute.Font.FontFamily, 10);
                newAttribute.Width = attribute1_box.Width;
                newAttribute.Location = this.attribute1_box.FindForm().PointToClient(this.attribute1_box.Parent.PointToScreen(this.attribute1_box.Location));
                newAttribute.Left += 427;
                addAttribute_btn.Top = 50;
                addAttribute_btn.Left = newAttribute.Left + 125;
                newAttribute.Parent = groupBox1;
                Debug.WriteLine(newAttribute.Parent);
                this.Controls.Add(newAttribute);
                newAttribute.BringToFront();
                newAttributesList.Add(newAttribute);
            }
        }

        private void addPerson_btn_Click(object sender, EventArgs e)
        {
            string person = persons_cmbBox.Text;

            if (String.IsNullOrWhiteSpace(person))
                return;

            if (persons_cmbBox.Items.Contains(person))
            {
                this.addedPersons.Remove(person);
                persons_cmbBox.Items.Remove(person);
            }
            else
            {
                this.addedPersons.Add(person);
                persons_cmbBox.Items.Add(person);
            }
            persons_cmbBox.Text = "";
        }

        private void addMedia_btn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(path_CmbCox.Text))
            {
                setErrorMessage("No media selected.");
                return;
            }

            string mediaPath = path_CmbCox.SelectedIndex.ToString();
            string mediaLocation = location_txt.Text;
            string mediaEvent = event_txt.Text;
            List<string> mediaPersons = this.addedPersons;
            //foreach(object item in persons_cmbBox.SelectedItems)
            //{
            //    mediaPersons.Add(item.ToString());
            //}
            List<string> customAttributes = new List<string>();
            foreach(ComboBox att in newAttributesList)
            {
                customAttributes.Add(att.SelectedItem.ToString());
            }

            bool succes = API.addMediaToDatabase(mediaPath, mediaLocation, mediaEvent, mediaPersons, customAttributes);
        }

        private void setErrorMessage(string error)
        {
            error_lbl.Text = error;
            addHideErrorHandlerToControls(this);
        }

        private void hideErrorMessage(object sender, EventArgs e)
        {
            Console.WriteLine("Event");
            error_lbl.Text = "";
            removeHideErrorHandlerToControls(this);
        }

        private void addHideErrorHandlerToControls(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                c.Click += new EventHandler(hideErrorMessage);
                addHideErrorHandlerToControls(c);
            }
        }

        private void removeHideErrorHandlerToControls(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                c.Click -= new EventHandler(hideErrorMessage);
                removeHideErrorHandlerToControls(c);
            }
        }
        //////////////////////

        /////////// Second tab
        private void search_btn_Click(object sender, EventArgs e)
        {
            List<Media> searchResults = API.searchInDB(search_txt.Text);
            if (!searchResults.Any())
            {
                initializeSearchResults((searchResults));
            }
        }

        private void initializeSearchResults(List<Media> searchResults)
        {
            foreach(Media result in searchResults)
            {
                searchResults_cmbBox.Items.Add(result.Path);
                this.searchResultsMap.Add(result.Path, result);
            }
        }

        private void searchResults_cmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Media selectedMedia = this.searchResultsMap[searchResults_cmbBox.SelectedItem.ToString()];
            location2_txt.Text = selectedMedia.Location.ToString();
            event2_txt.Text = selectedMedia.Event.ToString();
            List<string> personsList = API.getPersonsFromMedia(selectedMedia);
            foreach(string person in personsList)
            {
                persons2_cmbBox.Items.Add(person);
            }

            List<string> customAttributes = API.getCustomAttributesFromMedia(selectedMedia);
            foreach(string attribute in customAttributes)
            {
                extra_cmbBox.Items.Add(attribute);
            }

            if(selectedMedia.MediaType == MediaType.Photo)
            {
                movie_MediaPly.Visible = false;
            }
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            movie_MediaPly.Visible = true;
            //movie_MediaPly.URL = searchResults_cmbBox.SelectedItem.ToString();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }


        //////////////////////
    }
}
