namespace To_Do_List_App
{
    partial class ToDoList
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
            label1 = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            ToDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 9);
            label1.Name = "label1";
            label1.Size = new Size(883, 69);
            label1.TabIndex = 0;
            label1.Text = "To Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(12, 107);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(863, 27);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 163);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(863, 27);
            descriptionTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 139);
            label2.Name = "label2";
            label2.Size = new Size(863, 25);
            label2.TabIndex = 3;
            label2.Text = "Discription";
            // 
            // label3
            // 
            label3.Font = new Font("Viner Hand ITC", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(863, 25);
            label3.TabIndex = 4;
            label3.Text = "Title";
            // 
            // newButton
            // 
            newButton.BackColor = SystemColors.GradientActiveCaption;
            newButton.Location = new Point(12, 196);
            newButton.Name = "newButton";
            newButton.Size = new Size(203, 29);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = false;
            newButton.Click += newButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.GradientActiveCaption;
            editButton.Location = new Point(232, 197);
            editButton.Name = "editButton";
            editButton.Size = new Size(203, 28);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = SystemColors.GradientActiveCaption;
            deleteButton.Location = new Point(451, 196);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(203, 28);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.GradientActiveCaption;
            saveButton.Location = new Point(672, 197);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(203, 28);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // ToDoListView
            // 
            ToDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToDoListView.BackgroundColor = Color.White;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoListView.Location = new Point(12, 231);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.RowHeadersWidth = 51;
            ToDoListView.Size = new Size(863, 271);
            ToDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(887, 514);
            Controls.Add(ToDoListView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Name = "ToDoList";
            Text = "To Do List";
            FormClosing += ToDoList_FormClosing;
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label label2;
        private Label label3;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView ToDoListView;
    }
}
