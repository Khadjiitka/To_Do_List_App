using System.Data;

namespace To_Do_List_App
{
    public partial class ToDoList : Form
    {
        DataTable todoList = new DataTable(); // создание новой таблицы данных 
        bool isEditing = false;
       public ToDoList()
        {
            InitializeComponent();
        }

        private void ToDoList_Load(object sender, EventArgs e)
        {
            todoList.TableName = "Tasks";// Установить имя таблицы — обязательно для XML сериализации
            // Создание столбцов
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            
            // Укажите наш DataGridView на наш источник данных DataSource
            ToDoListView.DataSource = todoList;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = ""; // string.Empty;
            descriptionTextBox.Text = ""; // string.Empty;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Заполнение текстовых полей данными из таблицы
            titleTextBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) // Если в try возникнет ошибка (Exception), то выполнение переходит сюда
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                todoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;

            }
            else
            {
                todoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);
            }
            // clear fields
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            isEditing = false;
        }

       
    }
}
