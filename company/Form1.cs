using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company
{
    public partial class Form1 : Form
    {
        Dictionary<string,string[]> All_manafacturer = new Dictionary<string, string[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_search.Enabled = false;
            btn_final.Enabled = false;
            txt_result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        }
        private void ReadExcel(string path)
        {
            DataSet ds;
            string file = path;
            var extension = Path.GetExtension(file);
            var stream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            IExcelDataReader reader = ExcelReaderFactory.CreateOpenXmlReader(stream); ;
            ds = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                UseColumnDataType = false,
                ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration() {UseHeaderRow = true}
            });
            var table = ds.Tables[0];
           // Console.WriteLine("資料" + table.Rows[0][0]);
            //Add to Dictionary
            for (int row = 0; row < table.Rows.Count; row++)
            {
                string Manafacturer="";
                List<string> List_Manafacturer = new List<string>();
                for (var col = 0; col < table.Columns.Count; col++)
                {
                    string data = table.Rows[row][col].ToString();
                    if(col==0) Manafacturer = table.Rows[row][col].ToString();
                    if (col >= 2&& table.Rows[row][col].ToString()!="-") List_Manafacturer.Add(table.Rows[row][col].ToString());
                }
                All_manafacturer.Add(Manafacturer, List_Manafacturer.ToArray());
               
                List_Manafacturer.Clear();
            }
           
           
        }
        private void Search(string manafacturer)
        {
            List<string> result = new List<string>();
            if (manafacturer == "")
            {
                Console.WriteLine("manafacturer is null");
            }
            else
            {
                if (!All_manafacturer.ContainsKey(manafacturer))
                {
                    txt_result.Text += "Manafacturer:" + manafacturer+" 沒有供應商"+ Environment.NewLine;
                }
                else
                {
                    foreach (var data in All_manafacturer[manafacturer])
                    {
                        if (!result.Contains(data))
                        {
                            result.Add(data.ToString());
                        }
                        else
                        {
                            Console.WriteLine("有重複的manafacturer : {0}在list裡面", data);
                        }
                    }
                }
                //抓到底
                for(int i =0; i<result.Count;i++)
                {
                    if (All_manafacturer.ContainsKey(result[i]))
                    {
                       foreach(var data_manafacturer in All_manafacturer[result[i]])
                        {
                            if (!result.Contains(data_manafacturer))
                            {
                                result.Add(data_manafacturer.ToString());
                            }
                            else
                            {
                                txt_result.Text += "**在搜尋 " + result[i] + " 時發現重複的"+ data_manafacturer +"**"+ Environment.NewLine;
                            }
                        }
                    }        
                }
            }
            string temp = "";
            foreach(var data in result)
            {
                temp += data + ",";
            }
            txt_result.Text += manafacturer + "的搜尋結果:" + temp.TrimEnd(',') + ""+ Environment.NewLine;
            //取得出筆資料
        }

        private void btn_readExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*";
                ofd.Title = "open excel";
                if (ofd.ShowDialog(this) == DialogResult.Cancel) return;
                txt_excelPath.Text = ofd.FileName;
                //讀取中...
                ReadExcel(ofd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取失敗:"+ex.Message);
            }
            btn_search.Enabled = true;
            btn_final.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_result.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //txt_result.Text += "test" + Environment.NewLine; ;
            Search(txt_manafacturer.Text);
        }

        private void btn_final_Click(object sender, EventArgs e)
        {
            List<string> result = new List<string>();
            foreach (var mana in All_manafacturer.Keys)
            {
                Search(mana);
            }
        }
    }
}
