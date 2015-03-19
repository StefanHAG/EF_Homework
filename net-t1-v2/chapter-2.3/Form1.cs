using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chapter_2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes3Entities())
            {
                // add an artist with two albums
                var artist = new Artist { FirstName = "Alan", LastName = "Jackson" };
                var album1 = new Album { AlbumName = "Drive" };
                var album2 = new Album { AlbumName = "Live at Texas Stadium" };
                artist.Albums.Add(album1);
                artist.Albums.Add(album2);
                context.Artists.AddObject(artist);

                // add an album for two artists
                var artist1 = new Artist { FirstName = "Tobby", LastName = "Keith" };
                var artist2 = new Artist { FirstName = "Merle", LastName = "Haggard" };
                var album = new Album { AlbumName = "Honkytonk University" };
                artist1.Albums.Add(album);
                artist2.Albums.Add(album);
                context.Albums.AddObject(album);

                context.SaveChanges();

                textBox.Text = "Data inserted!";
            }
        }

        private void showDataButton_Click(object sender, EventArgs e)
        {
            using (var context = new EF6Recipes3Entities())
            {
                String str = "";
                str += ("Artists and their albums...\r\n");
                var artists = context.Artists;
                foreach (var artist in artists)
                {
                    Console.WriteLine("{0} {1}", artist.FirstName, artist.LastName);
                    str += artist.FirstName + " " + artist.LastName + "\r\n";
                    foreach (var album in artist.Albums)
                    {
                        str += "\t" + album.AlbumName + "\r\n";
                        Console.WriteLine("\t{0}", album.AlbumName);
                    }
                }
                str += ("\r\nAlbums and their artists...\r\n");
                var albums = context.Albums;
                foreach (var album in albums)
                {
                    str += album.AlbumName + "\r\n";
                    Console.WriteLine("{0}", album.AlbumName);
                    foreach (var artist in album.Artists)
                    {
                        str += "\t" + artist.FirstName + " " + artist.LastName + "\r\n";
                        Console.WriteLine("\t{0} {1}", artist.FirstName, artist.LastName);
                    }
                }

                textBox.Text = str;
            }
        }
    }
}
