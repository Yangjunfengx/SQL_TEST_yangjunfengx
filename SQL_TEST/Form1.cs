using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace SQL_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {

                DataGridView grid = (DataGridView)sender;
                Int64 buff;
                grid.Rows[e.RowIndex].ErrorText = "";
                if ((grid.Columns[e.ColumnIndex].Name == "保持寄存器DataGridViewTextBoxColumn") | (grid.Columns[e.ColumnIndex].Name == "输入寄存器DataGridViewTextBoxColumn"))
                {
                    if (Int64.TryParse(e.FormattedValue.ToString(), out buff) == false || Int64.Parse(e.FormattedValue.ToString()) > short.MaxValue || Int64.Parse(e.FormattedValue.ToString()) < short.MinValue)
                    {
                        MessageBox.Show("数值上下限+ -32767");
                        dataGridView1.CancelEdit();
                        e.Cancel = true;
                    }
                }



            }

        }
        public  void GetDataSet()
        {
            string hostinfo = Dns.GetHostName();  //采用的连接方式是winodws认证，所以这里要获取计算机名。
            string s = "Data Source='" + hostinfo + "'" + ";initial Catalog='modbus_sql';integrated Security='true';MultipleActiveResultSets='true'";     //数据库连接字符串，其中“database”为数据库的名称。
            SqlConnection conn = new SqlConnection(s);  //实例化SqlConnection对象
            String sqlId = "select * from [modbus_buff_sql] ";
            DataSet ds = new DataSet();  //实例化DataSet
            conn.Open();    //打开数据库连接
            SqlDataAdapter sda = new SqlDataAdapter(sqlId,conn);   //sql是传递过来的SQL语句
            sda.Fill(ds, "modbus_buff_sql");  //填充DataSet
           
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "modbus_buff_sql";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////GetDataSet();
            //modbus_sqlDataSet x =( modbusbuffsqlBindingSource.DataSource)as modbus_sqlDataSet;

            //modbus_buff_sqlTableAdapter.Update(x);
            this.modbus_buff_sqlTableAdapter.Fill(this.modbus_sqlDataSet.modbus_buff_sql);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“modbus_sqlDataSet.modbus_buff_sql”中。您可以根据需要移动或删除它。
            this.modbus_buff_sqlTableAdapter.Fill(this.modbus_sqlDataSet.modbus_buff_sql);

        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            modbus_sqlDataSet x = (modbusbuffsqlBindingSource.DataSource) as modbus_sqlDataSet;

            modbus_buff_sqlTableAdapter.Update(x);
        }

    }
}
