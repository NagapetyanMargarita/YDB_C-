using System;
using System.Data;
using System.Windows.Forms;
using Ydb.Sdk;
using Ydb.Sdk.Auth;
using Ydb.Sdk.Services.Table;
using Ydb.Sdk.Value;

namespace OnlineStore
{
    public partial class Form1 : Form
    {

        private string id = "";
        private int intRow = 0;
        private string nameTable = "worker";
        private Driver driver;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            resetMe();
            InitDB();

        }

        private async Task InitDB()
        {
            var endpoint = "grpcs://ydb.serverless.yandexcloud.net:2135";
            var database = "/ru-central1/b1gh8r4up6r1krtaa3ru/etno6eknoptpbvfdbra1";
            var token = "t1.9euelZrOnZyNyYmSnJPPlMaWypKPxu3rnpWak4-ciYmYi5LHnZyKyo6Py87l8_d-LglR-e9bazpn_t3z9z5dBlH571trOmf-zef1656VmsrGkpTKiZDKz43Gi5mLy57H7_zN5_XrnpWaz8_PkouQmM-Mk5KaiZOOzMzv_cXrnpWaysaSlMqJkMrPjcaLmYvLnsc.wr3BNr2RMeRcpYvAW-tAqJit0pHCC-KloCBIrDVyjftqFls48hEJNkSONWA7Vjos47LiWaNj2I0ecnzSluGACg";

            var config = new DriverConfig(
                endpoint: endpoint,
                database: database,
                credentials: new TokenProvider(token)
            );

            driver = new Driver(
                config: config
            );

            await driver.Initialize();
            loadData();
        }

        private void resetMe()
        {
            id = string.Empty;

            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            SpecialityTextBox.Text = "";
            

            customerUpdateButton.Text = "Update ()";
            customerDeleteButton.Text = "Delete ()";
            productUpdateButton.Text = "Update ()";
            productDeleteButton.Text = "Delete ()";
        }

        private async Task loadData()
        {

            var tableClient = new TableClient(driver, new TableClientConfig());

            var response = await tableClient.SessionExec(async session =>
            {
                var query = @$"SELECT * FROM {nameTable}";

                return await session.ExecuteDataQuery(
                query: query,
                txControl: TxControl.BeginSerializableRW().Commit()
                );
            });
            response.Status.EnsureSuccess();
            var queryResponse = (ExecuteDataQueryResponse)response;
            var resultSet = queryResponse.Result.ResultSets[0];

            dt = new DataTable();

            switch (nameTable)
            {
                case "worker":
                    dt.Columns.Add("id_worker", typeof(ulong));
                    dt.Columns.Add("date_birth", typeof(DateTime));
                    dt.Columns.Add("first_name", typeof(string));
                    dt.Columns.Add("middle", typeof(string));
                    dt.Columns.Add("speciality", typeof(string));
                    dt.Columns.Add("surname", typeof(string));
                    foreach (var row in resultSet.Rows)
                    {
                        dt.Rows.Add((ulong?)row["id_worker"], (DateTime?)row["date_birth"], (string?)row["first_name"], (string?)row["middle"], (string?)row["speciality"],
                            (string?)row["surname"]);
                    }
                    break;
                case "period":
                    dt.Columns.Add("id_period", typeof(ulong));
                    dt.Columns.Add("kon_period", typeof(DateTime));
                    dt.Columns.Add("nach_period", typeof(DateTime));
                    foreach (var row in resultSet.Rows)
                    {
                        dt.Rows.Add((ulong?)row["id_period"], (DateTime?)row["kon_period"],
                            (DateTime?)row["nach_period"]);
                    }
                    break;
                case "otchet":
                    dt.Columns.Add("id_otchet", typeof(ulong));
                    dt.Columns.Add("id_avans_otchet", typeof(ulong));
                    dt.Columns.Add("ost_summa", typeof(ulong));
                    dt.Columns.Add("status", typeof(string));
                    dt.Columns.Add("potr_summa", typeof(ulong));
                    foreach (var row in resultSet.Rows)
                    {
                        dt.Rows.Add((ulong?)row["id_otchet"], (ulong?)row["id_avans_otchet"],
                            (ulong?)row["ost_summa"], (string?)row["status"],
                            (ulong?)row["potr_summa"]);
                    }
                    break;
                case "avans_otchet":
                    dt.Columns.Add("id_avans_otchet", typeof(ulong));
                    dt.Columns.Add("id_worker", typeof(ulong));
                    dt.Columns.Add("article_zatrat", typeof(string));
                    dt.Columns.Add("kol", typeof(ulong));
                    dt.Columns.Add("summa", typeof(ulong));
                    foreach (var row in resultSet.Rows)
                    {
                        dt.Rows.Add((ulong?)row["id_avans_otchet"], (ulong?)row["id_worker"],
                            (string?)row["article_zatrat"], (ulong?)row["kol"], (ulong?)row["summa"]);
                    }
                    break;
                default:
                    break;
            }

            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }

            toolStripStatusLabel1.Text = "Number of row(s): " + intRow.ToString();

            DataGridView dgv1 = dataGridView1;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;

            dgv1.Columns[0].Width = 55;
        }

        private ulong GetLastIdFromTable()
        {
            ulong maxId = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {   if (nameTable == "worker")
                    if ((ulong)dt.Rows[i]["id_worker"] > maxId)
                        maxId = (ulong)dt.Rows[i]["id_worker"];
                if (nameTable == "period")
                    if ((ulong)dt.Rows[i]["id_period"] > maxId)
                        maxId = (ulong)dt.Rows[i]["id_period"];
            }
            return maxId + 1;
        }

        private async void customerInsertButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text.Trim())
                || string.IsNullOrEmpty(lastNameTextBox.Text.Trim())
                || string.IsNullOrEmpty(middleNameTextBox.Text.Trim())
                || string.IsNullOrEmpty(SpecialityTextBox.Text.Trim()))
            {
                MessageBox.Show("Please input Full Name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var tableClient = new TableClient(driver, new TableClientConfig());

            var response = await tableClient.SessionExec(async session =>
            {
                var query = @"
                    DECLARE $id_worker AS Uint64;
                    DECLARE $first_name AS Utf8;
                    DECLARE $middle AS Utf8;
                    DECLARE $speciality AS Utf8;
                    DECLARE $surname AS Utf8;
                    DECLARE $date_birth AS Date;

                    UPSERT INTO worker (id_worker, first_name, middle, speciality, surname, date_birth) VALUES
                        ($id_worker, $first_name, $middle, $speciality, $surname, $date_birth);
                ";
                DateTime startDate = BDateTextBox.Value;
                return await session.ExecuteDataQuery(
                    query: query,
                    txControl: TxControl.BeginSerializableRW().Commit(),
                    parameters: new Dictionary<string, YdbValue>
                        {
                { "$id_worker", YdbValue.MakeUint64(GetLastIdFromTable()) },
                { "$first_name", YdbValue.MakeUtf8(firstNameTextBox.Text.Trim()) },
                { "$surname", YdbValue.MakeUtf8(lastNameTextBox.Text.Trim()) },
                { "$middle", YdbValue.MakeUtf8(middleNameTextBox.Text.Trim()) },
                { "$speciality", YdbValue.MakeUtf8(SpecialityTextBox.Text.Trim()) },
                { "$date_birth", YdbValue.MakeDate(startDate) },
                        }
                );
            });

            response.Status.EnsureSuccess();
            if (response.Status.StatusCode == StatusCode.Success)
                MessageBox.Show("The record has been saved.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
            resetMe();
        }

        private async void customerUpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrEmpty(lastNameTextBox.Text.Trim())
                || string.IsNullOrEmpty(firstNameTextBox.Text.Trim()) ||
                string.IsNullOrEmpty(middleNameTextBox.Text.Trim())
                || string.IsNullOrEmpty(SpecialityTextBox.Text.Trim()))
            {
                MessageBox.Show("Please input Full Name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var tableClient = new TableClient(driver, new TableClientConfig());

            var response = await tableClient.SessionExec(async session =>
            {
                var query = @"
                    DECLARE $id_worker AS Uint64;
                    DECLARE $first_name AS Utf8;
                    DECLARE $middle AS Utf8;
                    DECLARE $speciality AS Utf8;
                    DECLARE $surname AS Utf8;
                    DECLARE $date_birth AS Date;

                    UPSERT INTO worker (id_worker, first_name, middle, speciality, surname, date_birth) VALUES
                        ($id_worker, $first_name, $middle, $speciality, $surname, $date_birth);
                    ";
                DateTime startDate = BDateTextBox.Value;
                return await session.ExecuteDataQuery(
                    query: query,
                    txControl: TxControl.BeginSerializableRW().Commit(),
                    parameters: new Dictionary<string, YdbValue>
                        {
                    { "$id_worker", YdbValue.MakeUint64(ulong.Parse(this.id)) },
                    { "$first_name", YdbValue.MakeUtf8(firstNameTextBox.Text.Trim()) },
                    { "$surname", YdbValue.MakeUtf8(lastNameTextBox.Text.Trim()) },
                    { "$middle", YdbValue.MakeUtf8(middleNameTextBox.Text.Trim()) },
                    { "$speciality", YdbValue.MakeUtf8(SpecialityTextBox.Text.Trim()) },
                    { "$date_birth", YdbValue.MakeDate(startDate) },
                        }
                );
            });

            response.Status.EnsureSuccess();
            if (response.Status.StatusCode == StatusCode.Success)
                MessageBox.Show("The record has been updated.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
            resetMe();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Do you want to permanently delete the selected record?", "Delete Data",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                var tableClient = new TableClient(driver, new TableClientConfig());
               

                    var response = await tableClient.SessionExec(async session =>
                    {
                       
                        var query = @$"
                                DECLARE $Id AS Uint64;        

                                DELETE FROM {nameTable} WHERE id_{nameTable} == $Id;
                            ";

                        return await session.ExecuteDataQuery(
                        query: query,
                        txControl: TxControl.BeginSerializableRW().Commit(),
                        parameters: new Dictionary<string, YdbValue>
                            {
                    { "$Id", YdbValue.MakeUint64(ulong.Parse(this.id)) }
                            }
                    );
                });
                response.Status.EnsureSuccess();
                if (response.Status.StatusCode == StatusCode.Success)
                    MessageBox.Show("The record has been deleted.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData();
                resetMe();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridView1;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                customerUpdateButton.Text = "Update (" + this.id + ")";
                customerDeleteButton.Text = "Delete (" + this.id + ")";
                productUpdateButton.Text = "Update (" + this.id + ")";
                productDeleteButton.Text = "Delete (" + this.id + ")";
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameTable = tabControl1.TabPages[tabControl1.SelectedIndex].Text;
            loadData();
            resetMe();
        }

        private async void productInsertButton_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrEmpty(nameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please input Name.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/
            var tableClient = new TableClient(driver, new TableClientConfig());
            
            var response = await tableClient.SessionExec(async session =>
            {
                var query = @"
                    DECLARE $id_period AS Uint64;
                    DECLARE $kon_period AS Date;
                    DECLARE $nach_period AS Date;

                    UPSERT INTO period (id_period, kon_period, nach_period) VALUES
                        ($id_period, $kon_period, $nach_period);
                ";
                DateTime startDate = StartTextBox.Value;
                DateTime endDate = EndTextBox.Value;
                return await session.ExecuteDataQuery(
                    query: query,
                    txControl: TxControl.BeginSerializableRW().Commit(),
                    parameters: new Dictionary<string, YdbValue>
                        {
                { "$id_period", YdbValue.MakeUint64(GetLastIdFromTable()) },
                { "$kon_period", YdbValue.MakeDate(endDate) },
                { "$nach_period", YdbValue.MakeDate(startDate) },
                        }
                );
            });
            response.Status.EnsureSuccess();
            if (response.Status.StatusCode == StatusCode.Success)
                MessageBox.Show("The record has been saved.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
            resetMe();
        }

        private async void productUpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //if (string.IsNullOrEmpty(nameTextBox.Text.Trim()))
            //{
            //    MessageBox.Show("Please input Name.", "Error",
            //        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            var tableClient = new TableClient(driver, new TableClientConfig());
            
            var response = await tableClient.SessionExec(async session =>
            {
                var query = @"
                    DECLARE $id_period AS Uint64;
                    DECLARE $kon_period AS Date;
                    DECLARE $nach_period AS Date;

                    UPSERT INTO period (id_period, kon_period, nach_period) VALUES
                        ($id_period, $kon_period, $nach_period);
                ";
                DateTime startDate = StartTextBox.Value;
                DateTime endDate = EndTextBox.Value;
                return await session.ExecuteDataQuery(
                    query: query,
                    txControl: TxControl.BeginSerializableRW().Commit(),
                    parameters: new Dictionary<string, YdbValue>
                        {
                { "$id_period", YdbValue.MakeUint64(ulong.Parse(this.id)) },
                { "$kon_period", YdbValue.MakeDate(endDate) },
                { "$nach_period", YdbValue.MakeDate(startDate) },
                        }
                );
            });
            response.Status.EnsureSuccess();
            if (response.Status.StatusCode == StatusCode.Success)
                MessageBox.Show("The record has been updated.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
            resetMe();
        }
    }
}