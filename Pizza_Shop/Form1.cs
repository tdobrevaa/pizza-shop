namespace Pizza_Shop
{
    public partial class Form1 : Form
    {
        private List<Pizza> pizzas = new List<Pizza>();
        private List<Item> order = new List<Item>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pizzas.Add(new Pizza("Маргарита", 10.00));
            pizzas.Add(new Pizza("Капричоза", 13.00));
            pizzas.Add(new Pizza("Пеперони", 14.00));
            pizzas.Add(new Pizza("Куатро Формаджи", 16.00));

            foreach (Pizza p in pizzas)
            {
                cmboxType.Items.Add(p);
            }

        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            if (cmboxType.SelectedIndex == -1)
            {
                MessageBox.Show("Изберете вид пица.");
                return;
            }

            if (!int.TryParse(txtBoxQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Броят пици трябва да е цяло положително число.");
                return;
            }

            Pizza pizza = (Pizza)cmboxType.SelectedItem;

            string size = "Малка";
            double sizePercentage = 1;
                    
            if (rbtnMiddle.Checked)
            {
                size = "Средна";
                sizePercentage = 1.25;
            }
            else if (rbtnFamily.Checked)
            {
                size = "Семейна";
                sizePercentage = 1.50;
            }

            List<string> adds = new List<string>();

            if (chboxCheese.Checked)
            {
                adds.Add("Двоен кашкавал");
            }

            if(chboxBacon.Checked)
            {
                adds.Add("Бекон");
            }

            if (chboxMushrooms.Checked)
            {
                adds.Add("Гъби");
            }

            if (chboxOlives.Checked)
            {
                adds.Add("Маслини");
            }

            Item item = new Item(pizza, size, sizePercentage, adds, quantity);

            order.Add(item);
            listBox1.Items.Add(item.ToString());

            ClearInputs();
        }

        private void ClearInputs()
        {
            cmboxType.SelectedIndex = -1;
            rbtnSmall.Checked = true;
            rbtnMiddle.Checked = false;
            rbtnFamily.Checked = false;
            chboxCheese.Checked = false; 
            chboxBacon.Checked = false;
            chboxMushrooms.Checked = false;
            chboxOlives.Checked = false;
            txtBoxQuantity.Clear();
        }

    
        private void btnFinishBill_Click(object sender, EventArgs e)
        {
            if (order.Count == 0)
            {
                MessageBox.Show("Сметката е празна.");
                return;
            }

            double total = 0;
            int pizzaCount = 0;
            Item mostExpensive = order[0];

            foreach (Item item in order)
            {
                total += item.Total;
                pizzaCount += item.Quantity;

                if (item.Total > mostExpensive.Total)
                {
                    mostExpensive = item;
                }
            }

            lblSummary.Text = "Обобщение: \n" +
                $"Обща сума: {total:F2} лв. \n" +
                $"Общ брой поръчани пици: {pizzaCount}\n" +
                $"Най-скъпа позиция: {mostExpensive.PizzaName}, " +
                $"{mostExpensive.Size} ({mostExpensive.Total:F2} лв.)";
        }
    }
}
