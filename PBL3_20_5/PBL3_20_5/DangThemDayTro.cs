using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_20_5
{
    public partial class DangThemDayTro : Form
    {
        Manager manager;
        public DangThemDayTro(Manager manager)
        {
            InitializeComponent();
            this.manager = manager;
            setCBB();
        }

        public void setCBB()
        {
            cbbIdMotel.Items.AddRange(BLL_Manager.Instance.getIdMotelbyManager(manager.ID).ToArray());
        }

        private void DelPicture(object sender, EventArgs e)
        {
            pnImage.Controls.Remove((PictureBox)sender);
        }

        private void picture_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = MakeImageTransparent(((PictureBox)sender).Image, 0.2f);
        }

        private Bitmap MakeImageTransparent(System.Drawing.Image image, float opacity)
        {
            Bitmap transparentImage = new Bitmap(image.Width, image.Height);
            Graphics graphics = Graphics.FromImage(transparentImage);
            ColorMatrix colorMatrix = new ColorMatrix();
            colorMatrix.Matrix33 = opacity;
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
            graphics.Dispose();
            return transparentImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Tạo một PictureBox mới
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Width = 100;
                        pictureBox.Height = pnImage.Height - 6;
                        //pictureBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                        pictureBox.ImageLocation = openFileDialog.FileName.ToString();
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.BorderStyle = BorderStyle.FixedSingle;

                        // Thêm PictureBox vào Panel (pnImage)
                        pnImage.Controls.Add(pictureBox);


                        //MessageBox.Show(pictureBox.ImageLocation);

                        //  // Gắn sự kiện MouseEnter cho PictureBox
                        pictureBox.MouseEnter += new System.EventHandler(picture_MouseEnter);

                        // Gắn sự kiện MouseLeave cho PictureBox
                        pictureBox.MouseLeave += (s, _) =>
                        {
                            // Khi con chuột rời đi, khôi phục độ trong suốt của hình ảnh
                            pictureBox.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                        };

                        //Gan su kien click cho picturebox
                        pictureBox.Click += new System.EventHandler(DelPicture);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở hình ảnh: " + ex.Message);
                    }
                }
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "" || tbPrice.Text == "" || tbAddress.Text == "" || tbDescription.Text == "" || cbbIdMotel.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin");
                return;
            }

            //add property for Post
            Post post = new Post();
            post.Title = tbTitle.Text;
            post.Price = tbPrice.Text;
            post.Address = tbAddress.Text;

            //add Imagepath for post
            foreach (Control control in pnImage.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    post.ImagePaths = post.ImagePaths + string.Format("({0}) ", pictureBox.ImageLocation);
                }
            }
            post.Description = tbDescription.Text;

            post.ID_Motel = cbbIdMotel.SelectedItem.ToString();


            BLL_Manager.Instance.AddPost(post);
            ResetPost();

        }

        private void ResetPost()
        {
            tbTitle.Text = "";
            tbPrice.Text = "";
            tbAddress.Text = "";
            tbDescription.Text = "";
            cbbIdMotel.SelectedIndex = -1;
            pnImage.Controls.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetPost();
        }

        private void cbbIdMotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
