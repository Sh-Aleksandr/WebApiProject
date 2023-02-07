using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoSQLite
{
    // код работает с папкой bin -> Debug -> db.sqlite
    public partial class Form1 : Form
    {
        private List<DAL.User> _list;

        public Form1()
        {
            InitializeComponent();

            _list= new List<DAL.User>();
            bsUser.DataSource = _list;
            dataGridView1.AutoGenerateColumns = true; // добавили для автогенерации столбцов
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _list.Clear(); // перед получением списка - очищаем список на форме

            List<DAL.User> list = DAL.SqliteHelper.GetUsers();
            if(list != null && list.Count > 0)
            {
                _list.AddRange(list); // добавляем наш список в пустой список формы
                bsUser.ResetBindings(false); // чтобы не перестраивал таблицу по колонкам
            }
        }
    }
}
