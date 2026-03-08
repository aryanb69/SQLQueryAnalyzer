using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace WinFormsApp1
{
    public partial class frmOptimizer : Form
    {
        public frmOptimizer()
        { 
            InitializeComponent();
        }
        private void frmOptimizer_Load(object sender, EventArgs e)
        {
            OracleConfiguration.TnsAdmin = @"C:\oraclexe\app\oracle\product\11.2.0\server\network\admin";

        }
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            string query = txtQuery.Text.Trim().TrimEnd(';');

            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Please enter a Sql Query");
                return;
            }
            string connectionString ="User Id=SQLOptimizer;Password=optimizer123;Data Source=XE";
            try
            {
                OracleConnection con = new OracleConnection(connectionString);

                con.Open();

                string clearQuery = "DELETE FROM PLAN_TABLE" ;
                OracleCommand cmd1 = new OracleCommand(clearQuery, con);

                cmd1.ExecuteNonQuery();

                string explainQuery = "EXPLAIN PLAN FOR " + query;

                OracleCommand cmd = new OracleCommand(explainQuery, con);

                cmd.ExecuteNonQuery();

                string planQuery = "SELECT OPERATION, OPTIONS, OBJECT_NAME, COST, CARDINALITY " +"FROM PLAN_TABLE ORDER BY ID";

                OracleCommand cmd2 = new OracleCommand(planQuery, con);

                OracleDataAdapter da = new OracleDataAdapter(cmd2);

                DataTable dt = new DataTable();
                da.Fill(dt);

                gridPlan.DataSource=dt;
                // Optimization suggestions
               listSuggestions.Items.Clear();

foreach (DataRow row in dt.Rows)
{
    string operation = row["OPERATION"].ToString();
    string options = row["OPTIONS"].ToString();
    string table = row["OBJECT_NAME"].ToString();
    int cost = row["COST"] == DBNull.Value ? 0 : Convert.ToInt32(row["COST"]);
    int rows = row["CARDINALITY"] == DBNull.Value ? 0 : Convert.ToInt32(row["CARDINALITY"]);

    // 1️⃣ Full Table Scan
    if (operation == "TABLE ACCESS" && options == "FULL")
    {
        listSuggestions.Items.Add(
        "Full Table Scan detected on table: " + table +
        ". Consider creating an index on frequently filtered columns.");
    }

    // 2️⃣ Missing Index
    if (operation == "TABLE ACCESS" && options == "FULL" && rows > 1000)
    {
        listSuggestions.Items.Add(
        "Possible Missing Index on table: " + table +
        ". Large number of rows scanned.");
    }

    // 3️⃣ High Cost Query
    if (cost > 50)
    {
        listSuggestions.Items.Add(
        "High Cost Query detected. Consider optimizing joins or adding indexes.");
    }

    // 4️⃣ Cartesian Join
    if (operation.Contains("JOIN") && options.Contains("CARTESIAN"))
    {
        listSuggestions.Items.Add(
        "Cartesian Join detected. Missing join condition between tables.");
    }

    // 5️⃣ Nested Loop Join
    if (operation.Contains("NESTED LOOPS"))
    {
        listSuggestions.Items.Add(
        "Nested Loop Join detected. Ensure proper indexing on join columns.");
    }
}


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuery.Text))
            {
                btnAnalysis.Enabled = false;
            }
            else
            {
                btnAnalysis.Enabled = true;
            }
        }
    }
}