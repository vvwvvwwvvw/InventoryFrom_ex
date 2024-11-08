using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryFrom_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // listBox 설정
            lvInOutList.FullRowSelect = true;
            lvInOutList.GridLines = true;
            lvInOutList.View = View.Details;
            lvInOutList.Columns.Add("제품명",60);
            lvInOutList.Columns.Add("수량",60);
            lvInOutList.Columns.Add("입출고", 60);
            lvInOutList.Columns.Add("날짜",180);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string name = cbItem.Text; // 제품명
            string qty = tbQty.Text; // 수량
            string inotut = ""; // 라디오버튼 클릭에 따라 저장될 변수
            if (rbIn.Checked == true)
            {
                inotut = "입고";
            }
            else
            {
                inotut = "출고";
            }
            string data = dtDate.Text; // 날짜정보 불러오기

            string[] stringArray = new string[] {name, qty, inotut , data};
            ListViewItem item = new ListViewItem(stringArray);
            lvInOutList.Items.Add(item);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lvInOutList.SelectedItems.Count > 0)
            {
                lvInOutList.Items.Remove(lvInOutList.SelectedItems[0]);
            }
        }
    }
}
