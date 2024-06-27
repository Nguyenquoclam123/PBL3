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
using System.Xml.Linq;

namespace PBL3_20_5
{
    public partial class GiaoDienChung : Form
    {
        public static GiaoDienChung Instance;
        private string Id_MotelGD;
        private int Id_Post = 0;
        public GiaoDienChung()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Instance = this;
            cbbCost.SelectedIndex = 5;
            LoadPostMotel(BLL_Manager.Instance.getAllPostByApprove());
            //datagridView1.DataSource = BLL_Room.Instance.LoadDGV();
            //dataGridView2.DataSource = BLL_Comment.Instance.getAll();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
        }
        private void b_DatPhong_Click(object sender, EventArgs e)
        {
            if (lbUsername.Visible == true)
            {
                (new DangKyDatPhong()).Show();
            }
            else
            {
                MessageBox.Show("Ban chua dang nhap");
            }

            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dataGridView1.SelectedRows[0];
            //    string ID_Motel = row.Cells[6].Value.ToString();
            //    string ID_Room = row.Cells[7].Value.ToString();
            //    del(ID_Motel, ID_Room);
            //}
            //else
            //{
            //    MessageBox.Show("Hãy chọn 1 hàng!");
            //    return;
            //}
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKy f = new DangKy();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
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

        public void LoadPostMotel(List<Post> listPost)
        {

            foreach (Control control in pnPostMotel.Controls)
            {
                pnPostMotel.Controls.Clear();
            }
            //màu chủ đạo #99b4d1
            foreach (Post post in listPost)
            {
                //pnItem
                Panel pnItem = new Panel();
                pnItem.Size = new System.Drawing.Size(pnPostMotel.Width - 20, 135);
                pnItem.BorderStyle = BorderStyle.FixedSingle;
                pnItem.BackColor = ColorTranslator.FromHtml("#f1f5f9");
                pnItem.MouseEnter += (sender, e) =>
                {
                    Panel enteredPanel = sender as Panel;
                    enteredPanel.BackColor = ColorTranslator.FromHtml("#e0e8f1");
                };
                pnItem.MouseLeave += (sender, e) =>
                {
                    Panel leftPanel = sender as Panel;
                    leftPanel.BackColor = ColorTranslator.FromHtml("#f1f5f9");
                };

                pnItem.Click += (sender, e) =>
                {
                    LoadRoom(BLL_Manager.Instance.getAllRoomByIDMotel(post.ID_Motel));
                    Id_MotelGD = post.ID_Motel;
                    Id_Post = post.PostID;

                };

                //pnImage
                Panel pnImage = new Panel();
                pnImage.Size = new Size(180, 140);
                pnImage.BackColor = ColorTranslator.FromHtml("#808080");
                pnImage.BorderStyle = BorderStyle.FixedSingle;

                //Image
                List<string> listimg = ExtractPaths(post.ImagePaths);
                //Image image = Image.FromFile("C:\\Users\\ASUS\\Pictures\\ImageWinform\\image_home.jpg");
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(180, 140);
                //pictureBox.Image = image;
                pictureBox.ImageLocation = listimg[0].Trim('"');
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


                int alignment = pnItem.Location.X + 200;
                int distance = 20;

                //Title
                System.Windows.Forms.Label lbtitle = new System.Windows.Forms.Label();
                lbtitle.Text = post.Title;
                lbtitle.AutoSize = true;
                //Font timesNewRomanFont = new Font("Segoe UI", 14, FontStyle.Bold);
                //Font timesNewRomanFont = new Font("Times New Roman", 14, FontStyle.Regular);
                Font timesNewRomanFont = new Font("Segoe UI Semibold", 14, FontStyle.Regular);
                lbtitle.Font = timesNewRomanFont;
                lbtitle.Location = new System.Drawing.Point(alignment, pnItem.Location.Y + 12);

                //Giá
                System.Windows.Forms.Label lbPrice = new System.Windows.Forms.Label();
                lbPrice.Text = post.Price.ToString(); // Thay đổi giá trị này thành giá tiền thực tế
                lbPrice.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                lbPrice.AutoSize = true;
                Font priceFont = new Font("Segoe UI", 15, FontStyle.Regular);
                lbPrice.Font = priceFont;
                // Đặt vị trí của Label cho giá tiền
                lbPrice.Location = new System.Drawing.Point(alignment, lbtitle.Location.Y + distance + 5); // Đặt Label này dưới lbtitle với khoảng cách 10 pixel


                //Địa chỉ
                System.Windows.Forms.Label lbAddress = new System.Windows.Forms.Label();
                lbAddress.Text = post.Address; // Thay đổi giá trị này thành địa chỉ thực tế
                lbAddress.AutoSize = true;
                Font addressFont = new Font("Segoe UI", 10, FontStyle.Regular);
                lbAddress.Font = addressFont;
                lbAddress.Location = new System.Drawing.Point(alignment, lbPrice.Location.Y + distance + 10);

                //Mô tả
                System.Windows.Forms.Label lbDes = new System.Windows.Forms.Label();
                lbDes.Text = post.Description;
                lbDes.AutoSize = true;
                Font desFont = new Font("Segoe UI", 10, FontStyle.Regular);
                lbDes.Font = desFont;
                lbDes.Location = new System.Drawing.Point(alignment, lbAddress.Location.Y + distance + 4);


                //them panel vao pnPostMotel
                pnImage.Controls.Add(pictureBox);
                pnItem.Controls.Add(lbtitle);
                pnItem.Controls.Add(lbPrice);
                pnItem.Controls.Add(lbAddress);
                pnItem.Controls.Add(lbDes);

                //them vào item
                pnItem.Controls.Add(pnImage);
                pnPostMotel.Controls.Add(pnItem);
            }
        }

        //pnPhong
        public void LoadRoom(List<Room> listRoom)
        {
            //ẩn các item comment
            foreach (Control control in pnDetail.Controls)
            {
                control.Visible = false;
            }

            foreach (Room room in listRoom)
            {
                //pnItem
                Panel pnItem = new Panel();
                pnItem.Size = new System.Drawing.Size(this.pnDetail.Width - 22, 70);
                pnItem.BorderStyle = BorderStyle.FixedSingle;
                pnItem.BackColor = ColorTranslator.FromHtml("#f1f5f9");

                //sự kiện
                pnItem.MouseEnter += (senderroom, eroom) =>
                {
                    Panel enteredPanel = senderroom as Panel;
                    enteredPanel.BackColor = ColorTranslator.FromHtml("#e0e8f1");
                };
                pnItem.MouseLeave += (senderroom, eroom) =>
                {
                    Panel leftPanel = senderroom as Panel;
                    leftPanel.BackColor = ColorTranslator.FromHtml("#f1f5f9");
                };

                int alignment = pnItem.Location.X + 4;
                int distance = 20;


                //Giá
                System.Windows.Forms.Label lbPrice = new System.Windows.Forms.Label();
                lbPrice.Text = room.Price.ToString();
                lbPrice.AutoSize = true;
                Font priceFont = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                lbPrice.Font = priceFont;
                lbPrice.Location = new System.Drawing.Point(alignment + 10, pnItem.Location.Y + 7);

                //Mô tả
                System.Windows.Forms.Label lbDes = new System.Windows.Forms.Label();
                lbDes.Text = room.fullDescription;
                lbDes.AutoSize = true;
                Font CommentFont = new Font("Segoe UI", 8, FontStyle.Regular);
                lbDes.Font = CommentFont;
                lbDes.Location = new System.Drawing.Point(alignment + 10, lbPrice.Location.Y + distance);

                //trạng thái
                System.Windows.Forms.Label lbState = new System.Windows.Forms.Label();
                //lbState.Text = string.Format("Trạng thái:  {0}", room.RoomState);
                //lbState.Text = string.Format("Trạng thái: <font color='red'>{0}</font>", room.RoomState);

                lbState.Text = "Trạng thái: " + room.RoomState;
                lbState.ForeColor = room.RoomState == "Đã thuê" ? Color.Red : Color.Black;
                lbState.AutoSize = true;
                Font lbStateF = new Font("Segoe UI", 8, FontStyle.Bold);
                //lbState.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                lbState.Font = lbStateF;
                lbState.Location = new System.Drawing.Point(alignment + 10, lbDes.Location.Y + distance - 2);

                //Button
                Button btnDatPhong = new Button();
                btnDatPhong.Text = "Đặt Phòng";
                btnDatPhong.Size = new Size(100, 30);
                btnDatPhong.Location = new Point(pnItem.Location.X + 168, pnItem.Location.Y + 36);
                btnDatPhong.BackColor = ColorTranslator.FromHtml("#99b4d1");
                if (GiaoDienChuTro.Instance != null || GiaoDienAdmin.Instance != null)
                {
                    btnDatPhong.Enabled = false;
                }
                btnDatPhong.Click += (senderroom, eroom) =>
                {
                    if (lbUsername.Visible == true)
                    {
                        if (room.RoomState == "Đã thuê")
                        {
                            MessageBox.Show("Phòng này đã được thuê");
                        }
                        else if (BLL_RegisterRoom.Instance.checkIDRoomRegisterR(lbUsername.Text, room.ID_Room))
                        {
                            MessageBox.Show("Phòng này đang chờ duyệt");
                        }
                        else
                        {
                            DangKyDatPhong form = new DangKyDatPhong();
                            form.Username = lbUsername.Text;
                            form.IDRoom = room.ID_Room;
                            form.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa đăng nhập, mời bạn đăng nhập!");
                    }
                };

                //them panel vao pnPostMotel
                pnItem.Controls.Add(lbPrice);
                pnItem.Controls.Add(lbState);
                pnItem.Controls.Add(lbDes);
                pnItem.Controls.Add(btnDatPhong);

                //them vào item
                this.pnDetail.Controls.Add(pnItem);
            }
        }

        //pnComment
        public void LoadComment(List<Comment> listComment)
        {
            foreach (Control control in pnDetail.Controls)
            {
                control.Visible = false;
            }
            foreach (Comment comment in listComment)
            //for (int i = 0; i < 10; i++)
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
                Image image = Image.FromFile("C:\\Users\\ASUS\\Pictures\\ImageWinform\\person_circle_icon_159926.png");
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(18, 18);
                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Location = new System.Drawing.Point(alignment, pnItem.Location.Y + 10);

                //UserName
                System.Windows.Forms.Label lbUsername = new System.Windows.Forms.Label();
                lbUsername.Text = comment.UserName;
                lbUsername.AutoSize = true;
                Font segoeSemiboldFont = new Font("Segoe UI Semibold", 8.0f, FontStyle.Bold);
                lbUsername.Font = segoeSemiboldFont;
                lbUsername.Location = new System.Drawing.Point(alignment + 20, pnItem.Location.Y + 11);

                //Comment
                System.Windows.Forms.Label lbComment = new System.Windows.Forms.Label();
                //lbComment.Text = "Phòng này còn không?";
                lbComment.Text = comment.CommentText;
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


        //btnComment
        private void btnComment_Click(object sender, EventArgs e)
        {
            if (lbUsername.Visible == true)
            {
                pnComment.Visible = true;
            }
            else
            {
                pnComment.Visible = false;
            }
            LoadComment(BLL_Comment.Instance.getCommentByIDPost(Id_Post));
        }
        //btnRoom
        private void btnRoom_Click(object sender, EventArgs e)
        {
            pnComment.Visible = false;
            LoadRoom(BLL_Manager.Instance.getAllRoomByIDMotel(Id_MotelGD));
        }





        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbbCost.SelectedItem.ToString() == "Tất cả")
            {
                LoadPostMotel(BLL_Room.Instance.FindInfoByCostandPos("0-10.000.000", txtPos.Text.ToString()));
            }
            else
            if (cbbCost.SelectedIndex != 5)
            {
                LoadPostMotel(BLL_Room.Instance.FindInfoByCostandPos(cbbCost.SelectedItem.ToString(), txtPos.Text.ToString()));
            }
        }

        private void btnsubm_Click(object sender, EventArgs e)
        {

            if (GiaoDienChung.Instance.lbUsername.Visible == true)
            {
                if (txtComment.Text == "")
                {
                    MessageBox.Show("ban chua comment");
                    return;
                }

                if (Id_Post == 0)
                {
                    MessageBox.Show("ban chua chon day tro");
                    return;
                }

                Comment comment = new Comment();
                //add data for obj comment
                comment.CommentText = txtComment.Text;
                comment.CommentDate = DateTime.Now.ToString();
                comment.UserName = GiaoDienChung.Instance.lbUsername.Text;
                comment.PostID = Id_Post;

                //them vao csdl
                BLL_Comment.Instance.addComment(comment);

                //Load lai pnComment
                LoadComment(BLL_Comment.Instance.getCommentByIDPost(Id_Post));

                //resert laij comment
                txtComment.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa đăng nhập");
            }
        }

        private void pbArow_Click(object sender, EventArgs e)
        {
            if (GiaoDienNguoiThue.Instance != null)
            {
                Destop_GUI.Instance.LoadForm(GiaoDienNguoiThue.Instance);
            }
            else
            if (GiaoDienChuTro.Instance != null)
            {
                Destop_GUI.Instance.LoadForm(GiaoDienChuTro.Instance);
            }
            else
            if (GiaoDienAdmin.Instance != null)
            {
                Destop_GUI.Instance.LoadForm(GiaoDienAdmin.Instance);
            }
        }

        //private void b_Cos_Click(object sender, EventArgs e)
        //{
        //datagridView1.DataSource = BLL_Room.Instance.FindInfoByCost(cb_Cos.SelectedItem.ToString());
        //}
    }
}
