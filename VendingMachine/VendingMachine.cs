using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using VendingMachine.Entities;

namespace VendingMachine
{
    public partial class VendingMachine : Form
    {
        private Item1 ItemEntity1 = new Item1();
        private Item2 ItemEntity2 = new Item2();
        private Item3 ItemEntity3 = new Item3();

        const int nickles = 5;
        const int dimes = 10;
        const int quarter = 25;

        private int TotalFunds;         
        private int itemPrice;         // the item price to be checked with.

        private IDictionary<string, int> items = new Dictionary<string, int>();

        public VendingMachine()
        {
            InitializeComponent();

            DbConnect();

            InitializeValues();      // set values for itemprice & TotalFunds

            UpdateDictionaryList();  // Filling the Dictionary with Data.

            UpdateInventoryList();   // Filling the Inventory list.
        }
        private void Nickles_Click(object sender, EventArgs e)
        { 
            addCoins(nickles);
        } 
        private void Dimes_Click(object sender, EventArgs e) 
        {
            addCoins(dimes);
        }   
        private void Quarter_Click(object sender, EventArgs e) 
        {
            addCoins(quarter);
        }  

        // This function will add the coins to the vending machine and check if it's reached dollar or not
        private void addCoins(int coins)
        {
            if ((TotalFunds + coins) > 100)
            {
                Alert.Text = "You Can't add funds more than One Dollar";
            }
            else
            {
                TotalFunds += coins;
                Alert.Text = null;
                ProcessLabel.Text = (coins + " cents added");
                if (TotalFunds == 100)
                {
                    TotalFundsLabel.Text = "Funds: 1.00$";
                }
                else
                {
                    TotalFundsLabel.Text = "Funds: " + TotalFunds.ToString() + " Cents";
                }
            }
        }

        private void Item1_Click(object sender, EventArgs e) 
        { 
            BuyItem(ItemEntity1.Price, ItemEntity1.Name); 
        } 
        private void Item2_Click(object sender, EventArgs e) 
        { 
            BuyItem(ItemEntity2.Price, ItemEntity2.Name); 
        } 
        private void Item3_Click(object sender, EventArgs e) 
        { 
            BuyItem(ItemEntity3.Price, ItemEntity3.Name); 
        }

 
    
        // This function handles the purchasing process and show if there is enough funds to buy or not.
        private void BuyItem(int PassingItemPrice, string itemName)
        {
            itemPrice = PassingItemPrice;
            int itemCount = items[itemName];
            if (itemCount == 0)
            {
                updateUIMessages(itemName + " is Not Available Now!", null);
            }
            else
            {
                if (TotalFunds < itemPrice)
                {
                    Refund();  // This function handle the refund process!
                    Alert.Text = "You Don't have enough funds, Money Refunded!";
                }
                else
                {
                    TotalFunds -= itemPrice;
                    items[itemName] = itemCount - 1;
                    TotalFundsLabel.Text = "Funds: " + TotalFunds.ToString() + " Cents";

                    updateUIMessages(null, itemName + " has purchased");
                    UpdateInventoryList();  //  refresh the ListView data.
                }
            }
        }
        private void ReturnBTN_Click(object sender, EventArgs e) 
        { 
            Refund(); // this function is responsible for refunding the money
        }

        private void ResetBTN_Click(object sender, EventArgs e)          // Reseting the Data.
        {
            TotalFundsLabel.Text = "Funds: 0 ";

            updateUIMessages(null, null);

            InitializeValues();

            UpdateDictionaryList();

            UpdateInventoryList();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EditItems editForm = new EditItems();
            editForm.Show();
        }

        private void Refund()         //  Get the Remaing funds.
        {
            if (TotalFunds != 0)
            {
                if (TotalFunds == 100)
                {
                    ProcessLabel.Text = "1.00 Dolar Returned";
                }
                else
                {
                    ProcessLabel.Text = (TotalFunds.ToString() + " Cents Returned, Take your money please");
                }
            }
            InitializeValues();
            TotalFundsLabel.Text = "Funds: 0";
            Alert.Text = null;
        }
        // This function updates the UI messages labels.
        void updateUIMessages(string alertText, string processText)
        {
            Alert.Text = alertText;
            ProcessLabel.Text = processText;
        }
        private void UpdateInventoryList()
        {
            Inventory.Items.Clear();
            foreach (KeyValuePair<string, int> itm in items)
                Inventory.Items.Add(itm.Key + " ---> " + itm.Value);
        }
        private void UpdateDictionaryList()
        {
            items.Clear();
            items.Add(ItemEntity1.Name, ItemEntity1.Count);
            items.Add(ItemEntity2.Name, ItemEntity2.Count);
            items.Add(ItemEntity3.Name, ItemEntity3.Count);
        }
        private void InitializeValues()
        {
            TotalFunds = 0;
            itemPrice = 0;
        }
        private void DbConnect()
        {
            string connetionString = "Server=(localdb)\\MSSQLLocalDB;Database=VendingMachineDB;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection cnn = new SqlConnection(connetionString);

            cnn.Open();
            SqlCommand command1, command2, command3;
            SqlDataReader dataReader1, dataReader2, dataReader3;
            string item1, item2, item3 ;

            item1 = "Select ItemName, ItemPrice, ItemCount from ItemsTable where id = 1";
            item2 = "Select ItemName, ItemPrice, ItemCount from ItemsTable where id = 2";
            item3 = "Select ItemName, ItemPrice, ItemCount from ItemsTable where id = 3";

            command1 = new SqlCommand(item1, cnn);
            command2 = new SqlCommand(item2, cnn);
            command3 = new SqlCommand(item3, cnn);

            dataReader1 = command1.ExecuteReader();
            dataReader1.Read();
            
            ItemEntity1.Name = dataReader1.GetValue(0).ToString();
            ItemEntity1.Price = int.Parse(dataReader1.GetValue(1).ToString());
            ItemEntity1.Count = int.Parse(dataReader1.GetValue(2).ToString());

            Item1.Text = ItemEntity1.Name + "  " + ItemEntity1.Price + "  Cents";
            
            cnn.Close();

            cnn.Open();
            dataReader2 = command2.ExecuteReader();
            dataReader2.Read();
            
            ItemEntity2.Name = dataReader2.GetValue(0).ToString();
            ItemEntity2.Price = int.Parse(dataReader2.GetValue(1).ToString());
            ItemEntity2.Count = int.Parse(dataReader2.GetValue(2).ToString());

            Item2.Text = ItemEntity2.Name + "  " + ItemEntity2.Price + "  Cents";
            
            cnn.Close();

            cnn.Open();
            dataReader3 = command3.ExecuteReader();
            dataReader3.Read();
            
            ItemEntity3.Name = dataReader3.GetValue(0).ToString();
            ItemEntity3.Price = int.Parse(dataReader3.GetValue(1).ToString());
            ItemEntity3.Count = int.Parse(dataReader3.GetValue(2).ToString());

            Item3.Text = ItemEntity3.Name + "  " + ItemEntity3.Price + "  Cents";
            
            cnn.Close();

        }

    }



}
