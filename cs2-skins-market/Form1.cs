using MongoDB.Driver;

namespace cs2_skins_market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                var client = MongoDBconnect.Instance();
                var databases = client.ListDatabaseNames().ToList();


                string allDb = string.Join(", ", databases);

                MessageBox.Show(allDb);
                MessageBox.Show("T'es trop fort");

            }
            catch (Exception)
            {
                MessageBox.Show("Could not connected to mongodb");
            }
        }
    }
}
