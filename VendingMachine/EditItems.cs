using System.Data.SqlClient;
using System.Windows.Forms;

namespace VendingMachine
{
    public partial class EditItems : Form
    {
        public EditItems()
        {
            InitializeComponent();
            DbConnect();
        }

        private void DbConnect()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=(localdb)\\MSSQLLocalDB;Database=VendingMachineDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command1, command2, command3;
            SqlDataReader dataReader1, dataReader2, dataReader3;
            string item1, item2, item3 = "";

            item1 = "Select ItemName, ItemPrice, ItemCount from ItemsTable where id = 1";
            item2 = "Select ItemName, ItemPrice, ItemCount from ItemsTable where id = 2";
            item3 = "Select ItemName, ItemPrice, ItemCount from ItemsTable where id = 3";

            command1 = new SqlCommand(item1, cnn);
            command2 = new SqlCommand(item2, cnn);
            command3 = new SqlCommand(item3, cnn);

            dataReader1 = command1.ExecuteReader();
            dataReader1.Read();
            
            Name1.Text = dataReader1.GetValue(0).ToString();
            Price1.Text = dataReader1.GetValue(1).ToString();
            Count1.Text = dataReader1.GetValue(2).ToString();

            
            cnn.Close();

            cnn.Open();
            dataReader2 = command2.ExecuteReader();
            dataReader2.Read();
            
            Name2.Text = dataReader2.GetValue(0).ToString();
            Price2.Text = dataReader2.GetValue(1).ToString();
            Count2.Text = dataReader2.GetValue(2).ToString();
            
            cnn.Close();

            cnn.Open();
            dataReader3 = command3.ExecuteReader();
            dataReader3.Read();
            
            Name3.Text = dataReader3.GetValue(0).ToString();
            Price3.Text = dataReader3.GetValue(1).ToString();
            Count3.Text = dataReader3.GetValue(2).ToString();
            
            cnn.Close();
        }

        private void Back_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            VendingMachine vendingForm = new VendingMachine();
            vendingForm.Show();
        }

        private void Save_Click(object sender, System.EventArgs e)
        {

            string name1 = Name1.Text;
            string name2 = Name2.Text;
            string name3 = Name3.Text;
            int price1 = int.Parse(Price1.Text);
            int price2 = int.Parse(Price2.Text);
            int price3 = int.Parse(Price3.Text);
            int count1 = int.Parse(Count1.Text);
            int count2 = int.Parse(Count2.Text);
            int count3 = int.Parse(Count3.Text);

            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=(localdb)\\MSSQLLocalDB;Database=VendingMachineDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand command1, command2, command3;

            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(), dataAdapter2 = new SqlDataAdapter(), dataAdapter3 = new SqlDataAdapter();
            string item1, item2, item3;

            item1 = "Update ItemsTable set ItemName='" + name1 + "', ItemPrice=" + price1 + ", ItemCount=" + count1 + " Where Id= 1";
            item2 = "Update ItemsTable set ItemName='" + name2 + "', ItemPrice=" + price2 + ", ItemCount=" + count2 + " Where Id= 2";
            item3 = "Update ItemsTable set ItemName='" + name3 + "', ItemPrice=" + price3 + ", ItemCount=" + count3 + " Where Id= 3";


            command1 = new SqlCommand(item1, cnn);
            command2 = new SqlCommand(item2, cnn);
            command3 = new SqlCommand(item3, cnn);

            dataAdapter1.UpdateCommand = command1;
            dataAdapter1.UpdateCommand.ExecuteNonQuery();
            command1.Dispose();

            dataAdapter2.UpdateCommand = command2;
            dataAdapter2.UpdateCommand.ExecuteNonQuery();
            command2.Dispose();

            dataAdapter3.UpdateCommand = command3;
            dataAdapter3.UpdateCommand.ExecuteNonQuery();
            command3.Dispose();

            cnn.Close();

            MessageBox.Show("Values Updated !!!", "Success");
        }
    }

}
