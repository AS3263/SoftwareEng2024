using System.Windows.Forms;

namespace SoftwareEng2024
{
    partial class chat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChat = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CONBTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.Memebrship_icon = new System.Windows.Forms.PictureBox();
            this.Profile = new System.Windows.Forms.Button();
            this.Event_icon = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.Chat_icon = new System.Windows.Forms.PictureBox();
            this.ChatBox_Button = new System.Windows.Forms.Button();
            this.Home_icon = new System.Windows.Forms.PictureBox();
            this.Event = new System.Windows.Forms.Button();
            this.Profile_icon = new System.Windows.Forms.PictureBox();
            this.Membership = new System.Windows.Forms.Button();
            this.dgvAllChats = new System.Windows.Forms.DataGridView();
            this.recentchat = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memebrship_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Event_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllChats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvAllChats);
            this.panel1.Controls.Add(this.recentchat);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.dgvMembers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 659);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(183, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 57);
            this.label2.TabIndex = 23;
            this.label2.Text = "Together Culture";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.btnChat);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.CONBTN);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.Memebrship_icon);
            this.panel2.Controls.Add(this.Profile);
            this.panel2.Controls.Add(this.Event_icon);
            this.panel2.Controls.Add(this.Home);
            this.panel2.Controls.Add(this.Chat_icon);
            this.panel2.Controls.Add(this.ChatBox_Button);
            this.panel2.Controls.Add(this.Home_icon);
            this.panel2.Controls.Add(this.Event);
            this.panel2.Controls.Add(this.Profile_icon);
            this.panel2.Controls.Add(this.Membership);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 659);
            this.panel2.TabIndex = 22;
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(64, 336);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(107, 32);
            this.btnChat.TabIndex = 46;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(179, 113);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(461, 157);
            this.panel7.TabIndex = 16;
            // 
            // CONBTN
            // 
            this.CONBTN.Location = new System.Drawing.Point(64, 276);
            this.CONBTN.Name = "CONBTN";
            this.CONBTN.Size = new System.Drawing.Size(109, 45);
            this.CONBTN.TabIndex = 45;
            this.CONBTN.Text = "DIGITAL CONTENT";
            this.CONBTN.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoftwareEng2024.Properties.Resources.logout;
            this.pictureBox1.Location = new System.Drawing.Point(14, 615);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(64, 615);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 32);
            this.btnLogout.TabIndex = 43;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // Memebrship_icon
            // 
            this.Memebrship_icon.Image = global::SoftwareEng2024.Properties.Resources.membership;
            this.Memebrship_icon.Location = new System.Drawing.Point(18, 236);
            this.Memebrship_icon.Name = "Memebrship_icon";
            this.Memebrship_icon.Size = new System.Drawing.Size(44, 34);
            this.Memebrship_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Memebrship_icon.TabIndex = 42;
            this.Memebrship_icon.TabStop = false;
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(68, 104);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(105, 34);
            this.Profile.TabIndex = 33;
            this.Profile.Text = "Profile";
            this.Profile.UseVisualStyleBackColor = true;
            // 
            // Event_icon
            // 
            this.Event_icon.Image = global::SoftwareEng2024.Properties.Resources.calendar_check;
            this.Event_icon.Location = new System.Drawing.Point(18, 191);
            this.Event_icon.Name = "Event_icon";
            this.Event_icon.Size = new System.Drawing.Size(44, 34);
            this.Event_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Event_icon.TabIndex = 41;
            this.Event_icon.TabStop = false;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(68, 56);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(105, 34);
            this.Home.TabIndex = 34;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // Chat_icon
            // 
            this.Chat_icon.Image = global::SoftwareEng2024.Properties.Resources.message;
            this.Chat_icon.Location = new System.Drawing.Point(18, 149);
            this.Chat_icon.Name = "Chat_icon";
            this.Chat_icon.Size = new System.Drawing.Size(44, 34);
            this.Chat_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chat_icon.TabIndex = 40;
            this.Chat_icon.TabStop = false;
            // 
            // ChatBox_Button
            // 
            this.ChatBox_Button.Location = new System.Drawing.Point(68, 151);
            this.ChatBox_Button.Name = "ChatBox_Button";
            this.ChatBox_Button.Size = new System.Drawing.Size(105, 32);
            this.ChatBox_Button.TabIndex = 35;
            this.ChatBox_Button.Text = "ChatBox";
            this.ChatBox_Button.UseVisualStyleBackColor = true;
            // 
            // Home_icon
            // 
            this.Home_icon.Image = global::SoftwareEng2024.Properties.Resources.home;
            this.Home_icon.Location = new System.Drawing.Point(18, 56);
            this.Home_icon.Name = "Home_icon";
            this.Home_icon.Size = new System.Drawing.Size(44, 34);
            this.Home_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Home_icon.TabIndex = 39;
            this.Home_icon.TabStop = false;
            // 
            // Event
            // 
            this.Event.Location = new System.Drawing.Point(68, 191);
            this.Event.Name = "Event";
            this.Event.Size = new System.Drawing.Size(105, 35);
            this.Event.TabIndex = 36;
            this.Event.Text = "Event";
            this.Event.UseVisualStyleBackColor = true;
            // 
            // Profile_icon
            // 
            this.Profile_icon.Image = global::SoftwareEng2024.Properties.Resources.user;
            this.Profile_icon.Location = new System.Drawing.Point(18, 104);
            this.Profile_icon.Name = "Profile_icon";
            this.Profile_icon.Size = new System.Drawing.Size(44, 34);
            this.Profile_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profile_icon.TabIndex = 38;
            this.Profile_icon.TabStop = false;
            // 
            // Membership
            // 
            this.Membership.Location = new System.Drawing.Point(68, 236);
            this.Membership.Name = "Membership";
            this.Membership.Size = new System.Drawing.Size(105, 32);
            this.Membership.TabIndex = 37;
            this.Membership.Text = "Membership";
            this.Membership.UseVisualStyleBackColor = true;
            // 
            // dgvAllChats
            // 
            this.dgvAllChats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllChats.Location = new System.Drawing.Point(176, 259);
            this.dgvAllChats.Name = "dgvAllChats";
            this.dgvAllChats.RowHeadersWidth = 51;
            this.dgvAllChats.RowTemplate.Height = 24;
            this.dgvAllChats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllChats.Size = new System.Drawing.Size(882, 398);
            this.dgvAllChats.TabIndex = 21;
            this.dgvAllChats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllChats_CellContentClick);
            // 
            // recentchat
            // 
            this.recentchat.AutoSize = true;
            this.recentchat.BackColor = System.Drawing.Color.IndianRed;
            this.recentchat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentchat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recentchat.Location = new System.Drawing.Point(198, 222);
            this.recentchat.Name = "recentchat";
            this.recentchat.Size = new System.Drawing.Size(115, 25);
            this.recentchat.TabIndex = 20;
            this.recentchat.Text = "Recent Chat";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(633, 118);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(150, 34);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(179, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(790, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(179, 113);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(448, 106);
            this.dgvMembers.TabIndex = 0;
            this.dgvMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 659);
            this.Controls.Add(this.panel1);
            this.Name = "chat";
            this.Text = "chat";
            this.Load += new System.EventHandler(this.chat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memebrship_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Event_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chat_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profile_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllChats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridView dgvAllChats;
        private System.Windows.Forms.Label recentchat;
        private Panel panel2;
        private Button btnChat;
        private Panel panel7;
        private Button CONBTN;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private PictureBox Memebrship_icon;
        private Button Profile;
        private PictureBox Event_icon;
        private Button Home;
        private PictureBox Chat_icon;
        private Button ChatBox_Button;
        private PictureBox Home_icon;
        private Button Event;
        private PictureBox Profile_icon;
        private Button Membership;
        private Label label2;
        private Button button1;
    }
}