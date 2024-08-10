namespace Todolist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            title = new TextBox();
            description = new TextBox();
            desc_txt = new Label();
            title_txt = new Label();
            newbtn = new Button();
            delbtn = new Button();
            editbtn = new Button();
            savebtn = new Button();
            todoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)todoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1203, 62);
            label1.TabIndex = 0;
            label1.Text = "ToDo List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            title.Location = new Point(28, 149);
            title.Name = "title";
            title.Size = new Size(1176, 23);
            title.TabIndex = 1;
            title.TextChanged += title_TextChanged;
            // 
            // description
            // 
            description.Location = new Point(28, 226);
            description.Name = "description";
            description.Size = new Size(1176, 23);
            description.TabIndex = 2;
            // 
            // desc_txt
            // 
            desc_txt.BackColor = Color.Transparent;
            desc_txt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            desc_txt.ForeColor = Color.White;
            desc_txt.Location = new Point(28, 191);
            desc_txt.Name = "desc_txt";
            desc_txt.Size = new Size(154, 32);
            desc_txt.TabIndex = 3;
            desc_txt.Text = "Description";
            desc_txt.Click += label2_Click;
            // 
            // title_txt
            // 
            title_txt.BackColor = Color.Transparent;
            title_txt.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_txt.ForeColor = Color.White;
            title_txt.Location = new Point(28, 114);
            title_txt.Name = "title_txt";
            title_txt.Size = new Size(154, 32);
            title_txt.TabIndex = 4;
            title_txt.Text = "Title";
            title_txt.Click += label3_Click;
            // 
            // newbtn
            // 
            newbtn.BackColor = Color.Transparent;
            newbtn.BackgroundImage = (Image)resources.GetObject("newbtn.BackgroundImage");
            newbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newbtn.Location = new Point(456, 269);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(60, 60);
            newbtn.TabIndex = 5;
            newbtn.UseVisualStyleBackColor = false;
            newbtn.Click += newbtn_Click;
            // 
            // delbtn
            // 
            delbtn.BackColor = Color.Transparent;
            delbtn.BackgroundImage = (Image)resources.GetObject("delbtn.BackgroundImage");
            delbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delbtn.Location = new Point(522, 269);
            delbtn.Name = "delbtn";
            delbtn.Size = new Size(60, 60);
            delbtn.TabIndex = 6;
            delbtn.UseVisualStyleBackColor = false;
            delbtn.Click += delbtn_Click;
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.Transparent;
            editbtn.BackgroundImage = (Image)resources.GetObject("editbtn.BackgroundImage");
            editbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editbtn.Location = new Point(588, 269);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(60, 60);
            editbtn.TabIndex = 7;
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            // 
            // savebtn
            // 
            savebtn.BackColor = Color.Transparent;
            savebtn.BackgroundImage = (Image)resources.GetObject("savebtn.BackgroundImage");
            savebtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savebtn.Location = new Point(654, 269);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(60, 60);
            savebtn.TabIndex = 8;
            savebtn.UseVisualStyleBackColor = false;
            savebtn.Click += savebtn_Click;
            // 
            // todoListView
            // 
            todoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            todoListView.BackgroundColor = SystemColors.Window;
            todoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todoListView.Location = new Point(28, 335);
            todoListView.Name = "todoListView";
            todoListView.Size = new Size(1176, 371);
            todoListView.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1227, 710);
            Controls.Add(todoListView);
            Controls.Add(savebtn);
            Controls.Add(editbtn);
            Controls.Add(delbtn);
            Controls.Add(newbtn);
            Controls.Add(title_txt);
            Controls.Add(desc_txt);
            Controls.Add(description);
            Controls.Add(title);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "To Do List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)todoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox title;
        private TextBox description;
        private Label desc_txt;
        private Label title_txt;
        private Button newbtn;
        private Button delbtn;
        private Button editbtn;
        private Button savebtn;
        private DataGridView todoListView;
    }
}
