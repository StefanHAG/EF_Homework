using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertData_Click(object sender, EventArgs e)
        {
            byte[] thumbBits = new byte[100];
            byte[] fullBits = new byte[2000];
            using (var context = new PhotographContext())
            {
                var photo = new Photograph
                {
                    Title = "My Dog",
                    ThumbnailBits = thumbBits
                };
                var fullImage = new PhotographFullImage { HighResolutionBits = fullBits };
                photo.PhotographFullImage = fullImage;
                context.Photographs.Add(photo);
                context.SaveChanges();
            }

            MessageBox.Show("Data inserted!");
        }

        private void showData_Click(object sender, EventArgs e)
        {
            using (var context = new PhotographContext())
            {
                foreach (var photo in context.Photographs)
                {
                    //console.writeline("photo: {0}, thumbnailsize {1} bytes",
                    //photo.title, photo.thumbnailbits.length);


                    //console.writeline("full image size: {0} bytes",
                    //photo.photographfullimage.highresolutionbits.length);


                    dataGridView.Rows.Add();
                    int RowIndex = dataGridView.RowCount - 1;
                    DataGridViewRow row = dataGridView.Rows[RowIndex];

                    row.Cells["Title"].Value = photo.Title;
                    row.Cells["ThumbnailSize"].Value = photo.ThumbnailBits.Length;

                    // explicitly load the "expensive" entity,
                    context.Entry(photo).Reference(p => p.PhotographFullImage).Load();
                    row.Cells["FullImageSize"].Value = photo.PhotographFullImage.HighResolutionBits.Length;
                }
            }
        }

    }
}
