using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_20_5
{
    public partial class ChiTietBaiDang : Form
    {
        private int IDPosst;
        public ChiTietBaiDang(int iDPosst)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IDPosst = iDPosst;
            SetView(iDPosst);
        }

        private void pnPostMotel_Paint(object sender, PaintEventArgs e)
        {

        }
        private List<string> ExtractPaths(string input)
        {
            List<string> paths = new List<string>();

            // Tách các đường dẫn bằng dấu cách, tuy nhiên cần xử lý đúng định dạng các dấu ngoặc đơn
            string[] pathArray = input.Split(new string[] { ") (" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string path in pathArray)
            {
                // Loại bỏ khoảng trắng ở đầu và cuối chuỗi
                string trimmedPath = path.Trim(new char[] { ' ', '(', ')' });

                // Thêm vào danh sách các đường dẫn đã định dạng đúng và bổ sung dấu ngoặc kép
                paths.Add('"' + trimmedPath + '"');
            }

            return paths;
        }
        public void SetView(int iDPosst)
        {
            Post post = BLL_Admin.Instance.Get_Post_by_ID(iDPosst);

            if (post == null)
            {
                MessageBox.Show("Post not found.");
                return;
            }

            label_TieuDe.Text = post.Title;
            label_Gia.Text = post.Price.ToString();
            label_Diachi.Text = post.Address;
            label_Mota.Text = post.Description;

            List<string> list = ExtractPaths(post.ImagePaths);

            if (list == null || list.Count == 0)
            {
                MessageBox.Show("No images found.");
                return;
            }

            panel_Image.Controls.Clear(); // Clear existing controls before adding new ones

            int panelWidth = panel_Image.Width;
            int panelHeight = panel_Image.Height;
            int xOffset = 10; // khoảng cách giữa các PictureBox

            int currentX = xOffset;

            foreach (string i in list)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Width = 100,
                    Height = panelHeight - 20,  
                    ImageLocation = i.Trim('"'),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(currentX, 10) // Đặt vị trí Y tùy ý
                };

                currentX += pictureBox.Width + xOffset;

                panel_Image.Controls.Add(pictureBox);
            }

            // comment

            foreach (Control control in pnDetail.Controls)
            {
                control.Visible = false;
            }
            // pnComment.Visible = true;
            foreach (Comment i in BLL_Admin.Instance.Get_Comment_by_PostID(IDPosst))
            {
                //pnItem
                Panel pnItem = new Panel();
                pnItem.Size = new System.Drawing.Size(this.pnDetail.Width - 22, 65);
                pnItem.BorderStyle = BorderStyle.FixedSingle;
                pnItem.BackColor = ColorTranslator.FromHtml("#f1f5f9");

                //sự kiện
                pnItem.MouseEnter += (sendercomment, ecom) =>
                {
                    Panel enteredPanel = sendercomment as Panel;
                    enteredPanel.BackColor = ColorTranslator.FromHtml("#e0e8f1");
                };
                pnItem.MouseLeave += (sendercomment, ecom) =>
                {
                    Panel leftPanel = sendercomment as Panel;
                    leftPanel.BackColor = ColorTranslator.FromHtml("#f1f5f9");
                };

                int alignment = pnItem.Location.X + 10;
                int distance = 22;

                //Image
                // Image image = Image.FromFile("C:\\Users\\ASUS\\Pictures\\ImageWinform\\person_circle_icon_159926.png");
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(18, 18);
                // pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new System.Drawing.Point(alignment, pnItem.Location.Y + 10);

                //UserName
                System.Windows.Forms.Label lbUsername = new System.Windows.Forms.Label();
                lbUsername.Text = i.UserName;
                lbUsername.AutoSize = true;
                Font segoeSemiboldFont = new Font("Segoe UI Semibold", 8.0f, FontStyle.Bold);
                lbUsername.Font = segoeSemiboldFont;
                lbUsername.Location = new System.Drawing.Point(alignment + 20, pnItem.Location.Y + 11);

                //Comment
                System.Windows.Forms.Label lbComment = new System.Windows.Forms.Label();
                lbComment.Text = i.CommentText;
                lbComment.AutoSize = true;
                Font CommentFont = new Font("Segoe UI", 8, FontStyle.Regular);
                lbComment.Font = CommentFont;
                lbComment.Location = new System.Drawing.Point(alignment + 17, lbUsername.Location.Y + distance);



                //them panel vao pnPostMotel
                pnItem.Controls.Add(pictureBox);
                pnItem.Controls.Add(lbUsername);
                pnItem.Controls.Add(lbComment);
                //pnItem.Controls.Add(lbAddress);
                //pnItem.Controls.Add(lbDes);

                //them vào item
                this.pnDetail.Controls.Add(pnItem);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }



}
