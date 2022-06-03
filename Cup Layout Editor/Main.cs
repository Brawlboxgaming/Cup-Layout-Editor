using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace CupLayoutEditor
{
    public partial class Main : Form
    {
        readonly List<Panel> cupPanels;
        List<Track> ctgpTracks = new List<Track>() { new Track() { Name = "Select a track...", SlotID = "0x00" } };
        int currentPage;
        List<List<Cup>> pages;
        public Main()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            foreach (var track in JsonConvert.DeserializeObject<List<Track>>(webClient.DownloadString("https://brawlbox.xyz/cts.json")))
            {
                ctgpTracks.Add(track);
            }
            for (int i = 0; i < ctgpTracks.Count; i++)
            {
                if (ctgpTracks[i].Name == ctgpTracks[i + 1].Name)
                {
                    ctgpTracks.Remove(ctgpTracks[i + 1]);
                }
            }

            BindItemCollection(cup1Track1);
            BindItemCollection(cup1Track2);
            BindItemCollection(cup1Track3);
            BindItemCollection(cup1Track4);
            BindItemCollection(cup2Track1);
            BindItemCollection(cup2Track2);
            BindItemCollection(cup2Track3);
            BindItemCollection(cup2Track4);
            BindItemCollection(cup3Track1);
            BindItemCollection(cup3Track2);
            BindItemCollection(cup3Track3);
            BindItemCollection(cup3Track4);
            BindItemCollection(cup4Track1);
            BindItemCollection(cup4Track2);
            BindItemCollection(cup4Track3);
            BindItemCollection(cup4Track4);
            BindItemCollection(cup5Track1);
            BindItemCollection(cup5Track2);
            BindItemCollection(cup5Track3);
            BindItemCollection(cup5Track4);
            BindItemCollection(cup6Track1);
            BindItemCollection(cup6Track2);
            BindItemCollection(cup6Track3);
            BindItemCollection(cup6Track4);

            currentPage = 1;

            cupPanels = new List<Panel> { cupPanel1, cupPanel2, cupPanel3, cupPanel4, cupPanel5, cupPanel6 };

            new Track() { Name = "Select a track...", SlotID = "0x00" };

            pages = new List<List<Cup>> { new List<Cup> { new Cup(new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }) } };

            SetVisiblePanels();
        }

        public void BindItemCollection(ComboBox comboBox)
        {
            var bindingSource = new BindingSource();
            List<Track> tracks = new List<Track>(ctgpTracks);
            bindingSource.DataSource = tracks;
            comboBox.DataSource = bindingSource.DataSource;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "SlotID";
        }

        public void SetVisiblePanels()
        {
            for (int i = currentPage * 6 - 1; i >= (currentPage - 1) * 6; i--)
            {
                if (i >= cupCount.Value)
                {
                    cupPanels[i % 6].Visible = false;
                }
                else
                {
                    cupPanels[i % 6].Visible = true;
                }
            }
        }

        public void StoreText()
        {
            pages[currentPage - 1][0] = new Cup((Track)cup1Track1.SelectedItem, (Track)cup1Track2.SelectedItem, (Track)cup1Track3.SelectedItem, (Track)cup1Track4.SelectedItem);
            if (pages[currentPage - 1].Count > 1)
            {
                pages[currentPage - 1][1] = new Cup((Track)cup2Track1.SelectedItem, (Track)cup2Track2.SelectedItem, (Track)cup2Track3.SelectedItem, (Track)cup2Track4.SelectedItem);
            }
            if (pages[currentPage - 1].Count > 2)
            {
                pages[currentPage - 1][2] = new Cup((Track)cup3Track1.SelectedItem, (Track)cup3Track2.SelectedItem, (Track)cup3Track3.SelectedItem, (Track)cup3Track4.SelectedItem);
            }
            if (pages[currentPage - 1].Count > 3)
            {
                pages[currentPage - 1][3] = new Cup((Track)cup4Track1.SelectedItem, (Track)cup4Track2.SelectedItem, (Track)cup4Track3.SelectedItem, (Track)cup4Track4.SelectedItem);
            }
            if (pages[currentPage - 1].Count > 4)
            {
                pages[currentPage - 1][4] = new Cup((Track)cup5Track1.SelectedItem, (Track)cup5Track2.SelectedItem, (Track)cup5Track3.SelectedItem, (Track)cup5Track4.SelectedItem);
            }
            if (pages[currentPage - 1].Count > 5)
            {
                pages[currentPage - 1][5] = new Cup((Track)cup6Track1.SelectedItem, (Track)cup6Track2.SelectedItem, (Track)cup6Track3.SelectedItem, (Track)cup6Track4.SelectedItem);
            }
        }

        public void SetText()
        {
            cup1Label.Text = $"Cup {currentPage * 6 - 5}";
            cup2Label.Text = $"Cup {currentPage * 6 - 4}";
            cup3Label.Text = $"Cup {currentPage * 6 - 3}";
            cup4Label.Text = $"Cup {currentPage * 6 - 2}";
            cup5Label.Text = $"Cup {currentPage * 6 - 1}";
            cup6Label.Text = $"Cup {currentPage * 6}";


            cup1Track1.SelectedItem = pages[currentPage - 1][0].Track1;
            cup1Track2.SelectedItem = pages[currentPage - 1][0].Track2;
            cup1Track3.SelectedItem = pages[currentPage - 1][0].Track3;
            cup1Track4.SelectedItem = pages[currentPage - 1][0].Track4;
            if (pages[currentPage - 1].Count > 1)
            {
                cup2Track1.SelectedItem = pages[currentPage - 1][1].Track1;
                cup2Track2.SelectedItem = pages[currentPage - 1][1].Track2;
                cup2Track3.SelectedItem = pages[currentPage - 1][1].Track3;
                cup2Track4.SelectedItem = pages[currentPage - 1][1].Track4;
            }

            if (pages[currentPage - 1].Count > 2)
            {
                cup3Track1.SelectedItem = pages[currentPage - 1][2].Track1;
                cup3Track2.SelectedItem = pages[currentPage - 1][2].Track2;
                cup3Track3.SelectedItem = pages[currentPage - 1][2].Track3;
                cup3Track4.SelectedItem = pages[currentPage - 1][2].Track4;
            }

            if (pages[currentPage - 1].Count > 3)
            {
                cup4Track1.SelectedItem = pages[currentPage - 1][3].Track1;
                cup4Track2.SelectedItem = pages[currentPage - 1][3].Track2;
                cup4Track3.SelectedItem = pages[currentPage - 1][3].Track3;
                cup4Track4.SelectedItem = pages[currentPage - 1][3].Track4;
            }

            if (pages[currentPage - 1].Count > 4)
            {
                cup5Track1.SelectedItem = pages[currentPage - 1][4].Track1;
                cup5Track2.SelectedItem = pages[currentPage - 1][4].Track2;
                cup5Track3.SelectedItem = pages[currentPage - 1][4].Track3;
                cup5Track4.SelectedItem = pages[currentPage - 1][4].Track4;
            }

            if (pages[currentPage - 1].Count > 5)
            {
                cup6Track1.SelectedItem = pages[currentPage - 1][5].Track1;
                cup6Track2.SelectedItem = pages[currentPage - 1][5].Track2;
                cup6Track3.SelectedItem = pages[currentPage - 1][5].Track3;
                cup6Track4.SelectedItem = pages[currentPage - 1][5].Track4;
            }
        }

        private void cupCount_ValueChanged(object sender, EventArgs e)
        {
            int pageCountCalc = (int)Math.Ceiling(Decimal.Divide(cupCount.Value, 6));
            int cupCountCalc = (int)cupCount.Value % 6 == 0 ? 6 : (int)cupCount.Value % 6;
            if (pageCountCalc == 0)
            {
                pageCountCalc++;
            }

            while (pageCountCalc > pages.Count)
            {
                while (cupCountCalc > pages[pages.Count - 1].Count)
                {
                    pages[pages.Count - 1].Add(new Cup(new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }));
                }

                pages.Add(new List<Cup> { new Cup(new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }) });
            }
            while (cupCountCalc > pages[pages.Count - 1].Count)
            {
                pages[pages.Count - 1].Add(new Cup(new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }));
            }

            while (pageCountCalc < pages.Count)
            {
                pages.RemoveAt(pages.Count - 1);
            }

            while (cupCountCalc < pages[pages.Count - 1].Count)
            {
                pages[pages.Count - 1].RemoveAt(pages[pageCountCalc - 1].Count - 1);
            }

            while (pages.Count < currentPage)
            {
                currentPage--;
                SetText();
            }
            SetVisiblePanels();
        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            StoreText();
            currentPage++;
            if (currentPage > pages.Count)
            {
                currentPage = 1;
            }
            SetText();
            SetVisiblePanels();
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            StoreText();
            currentPage--;
            if (currentPage == 0)
            {
                currentPage = pages.Count;
            }
            SetText();
            SetVisiblePanels();
        }

        private void export_Click(object sender, EventArgs e)
        {
            StoreText();
            CommonSaveFileDialog dialog = new CommonSaveFileDialog();
            dialog.Title = "Export";
            dialog.AlwaysAppendDefaultExtension = true;
            dialog.DefaultExtension = ".cup";
            dialog.Filters.Add(new CommonFileDialogFilter("Cup Layouts", ".cup"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                for (int i = 0; i < pages.Count; i++)
                {
                    for (int j = 0; j < pages[i].Count; j++)
                    {
                        if (pages[i][j].Track1.SlotID == "0x00")
                        {
                            MessageBox.Show($"Cup {i * 6 + j + 1} is missing a track in slot 1.", "Error");
                            return;
                        }
                        if (pages[i][j].Track2.SlotID == "0x00")
                        {
                            MessageBox.Show($"Cup {i * 6 + j + 1} is missing a track in slot 2.", "Error");
                            return;
                        }
                        if (pages[i][j].Track3.SlotID == "0x00")
                        {
                            MessageBox.Show($"Cup {i * 6 + j + 1} is missing a track in slot 3.", "Error");
                            return;
                        }
                        if (pages[i][j].Track4.SlotID == "0x00")
                        {
                            MessageBox.Show($"Cup {i * 6 + j + 1} is missing a track in slot 4.", "Error");
                            return;
                        }
                    }
                }
                using (BinaryWriter binWriter = new BinaryWriter(File.Open(dialog.FileName, FileMode.Create)))
                {
                    var stream = binWriter.BaseStream;
                    var list = new List<byte>() { 0x43, 0x55, 0x50, 0x32, 0x00, 0x00, 0x00, Decimal.ToByte(cupCount.Value) };
                    foreach (var b in list)
                    {
                        binWriter.Write(b);
                    }
                    for (int i = 0; i < pages.Count; i++)
                    {
                        for (int j = 0; j < pages[i].Count; j++)
                        {
                            binWriter.Write(Convert.ToByte(Convert.ToInt32(pages[i][j].Track1.SlotID, 16)));
                            binWriter.Write(Convert.ToByte(Convert.ToInt32(pages[i][j].Track2.SlotID, 16)));
                            binWriter.Write(Convert.ToByte(Convert.ToInt32(pages[i][j].Track3.SlotID, 16)));
                            binWriter.Write(Convert.ToByte(Convert.ToInt32(pages[i][j].Track4.SlotID, 16)));
                        }
                    }
                    while (stream.Position != 224)
                    {
                        binWriter.Write(Convert.ToByte(0xFF));
                    }
                    MessageBox.Show($"Cup layout exported to {dialog.FileName}.", "Complete");
                }
            }
        }

        private void import_Click(object sender, EventArgs e)
        {
            StoreText();
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = false;
            dialog.Multiselect = false;
            dialog.Title = "Import";
            dialog.Filters.Add(new CommonFileDialogFilter("Cup Layouts", ".cup"));
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                using (BinaryReader binReader = new BinaryReader(File.Open(dialog.FileName, FileMode.Open)))
                {
                    var header = Encoding.Default.GetString(binReader.ReadBytes(4));
                    binReader.ReadBytes(3);

                    int fileCupCount = binReader.ReadByte();

                    if (header == "CUP2")
                    {
                        var file = binReader.ReadBytes(216);
                        pages = new List<List<Cup>> { new List<Cup> { new Cup(new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }) } };

                        List<string> inputtedTracks = new List<string>();

                        for (int i = 0; i < 216; i++)
                        {
                            string hex = "0x" + BitConverter.ToString(new byte[1] { file[i] });
                            if (hex != "0xFF")
                            {
                                inputtedTracks.Add(hex);
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (inputtedTracks.Count % 4 != 0)
                        {
                            MessageBox.Show("The file's format is incorrect.", "Error");
                            return;
                        }
                        int pageCount = (int)Math.Ceiling(Decimal.Divide(fileCupCount, 6));

                        while (pageCount > pages.Count)
                        {
                            while (inputtedTracks.Count / 4 / pageCount > pages[pages.Count - 1].Count)
                            {
                                pages[pages.Count - 1].Add(new Cup(new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }));
                            }

                            pages.Add(new List<Cup> { new Cup(new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }) });
                        }
                        while (inputtedTracks.Count / 4 / pageCount > pages[pages.Count - 1].Count)
                        {
                            pages[pages.Count - 1].Add(new Cup(new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }, new Track() { Name = "Select a track...", SlotID = "0x00" }));
                        }

                        while (pageCount < pages.Count)
                        {
                            pages.RemoveAt(pages.Count - 1);
                        }

                        while (fileCupCount < pages[pages.Count - 1].Count)
                        {
                            pages[pages.Count - 1].RemoveAt(pages[pageCount - 1].Count - 1);
                        }

                        for (int i = 0; i < pages.Count; i++)
                        {
                            for (int j = 0; j < pages[i].Count; j++)
                            {
                                Track Track1 = new Track();
                                Track Track2 = new Track();
                                Track Track3 = new Track();
                                Track Track4 = new Track();
                                for (int k = 0; k < ctgpTracks.Count; k++)
                                {
                                    if (inputtedTracks[i * 6 * 4 + j * 4] == ctgpTracks[k].SlotID)
                                    {
                                        Track1 = new Track() { Name = ctgpTracks[k].Name, SlotID = ctgpTracks[k].SlotID };
                                    }
                                    if (inputtedTracks[i * 6 * 4 + j * 4 + 1] == ctgpTracks[k].SlotID)
                                    {
                                        Track2 = new Track() { Name = ctgpTracks[k].Name, SlotID = ctgpTracks[k].SlotID };
                                    }
                                    if (inputtedTracks[i * 6 * 4 + j * 4 + 2] == ctgpTracks[k].SlotID)
                                    {
                                        Track3 = new Track() { Name = ctgpTracks[k].Name, SlotID = ctgpTracks[k].SlotID };
                                    }
                                    if (inputtedTracks[i * 6 * 4 + j * 4 + 3] == ctgpTracks[k].SlotID)
                                    {
                                        Track4 = new Track() { Name = ctgpTracks[k].Name, SlotID = ctgpTracks[k].SlotID };
                                    }
                                }
                                pages[i][j] = new Cup(Track1, Track2, Track3, Track4);
                            }
                        }
                        cupCount.Value = fileCupCount;
                        SetText();
                    }
                    else
                    {
                        MessageBox.Show("Not a valid .cup file", "Error");
                        return;
                    }
                }
            }
        }
    }
}
