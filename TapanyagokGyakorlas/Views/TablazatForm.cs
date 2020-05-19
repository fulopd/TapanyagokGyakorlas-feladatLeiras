using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TapanyagokGyakorlas.Models;
using TapanyagokGyakorlas.Presenters;
using TapanyagokGyakorlas.ViewInterfaces;

namespace TapanyagokGyakorlas.Views
{
    public partial class TablazatForm : Form, ITablazatView
    {
        private TablazatPresenter presenter;
        // Oldaltördelés
        private int maxPage;
        private int sortIndex;
        public TablazatForm()
        {
            InitializeComponent();
            presenter = new TablazatPresenter(this);
            Init();
        }

        public void Init()
        {
            page = 1;
            itemPerPage = 20;
            sortBy = "Id";
            sortIndex = 0;
            ascending = true;
        }

        public BindingList<tapanyag> BindingList
        {
            get => (BindingList<tapanyag>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }
        public int page { get; set; }
        public int itemPerPage { get; set; }
        public string search { get => toolStripTextBoxKereses.Text; }
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems
        {
            set
            {
                maxPage = (value - 1) / itemPerPage + 1;
                labelPageInfo.Text = page.ToString() + "/" + maxPage.ToString();
            }
        }

        private void TablazatForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void toolStripButtonMentes_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void toolStripButtonUj_Click(object sender, EventArgs e)
        {
            using (var newTapanyagForm = new TapanyagForm())
            {
                DialogResult dr = newTapanyagForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    presenter.Add(newTapanyagForm.tapanyag);
                    newTapanyagForm.Close();
                }
            }
        }
        private void DGVSzerkesztes(int index) 
        {
            var selTapanyag = (tapanyag)dataGridView1.Rows[index].DataBoundItem;
            if (selTapanyag != null)
            {
                using (var editForm = new TapanyagForm())
                {
                    editForm.tapanyag = selTapanyag;
                    DialogResult dr = editForm.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        presenter.Modify(index, editForm.tapanyag);
                        editForm.Close();
                    }
                }
            }
        }
        private void szerkesztesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVSzerkesztes(dataGridView1.SelectedCells[0].RowIndex);
        }
        private void DGVTorles()
        {
            while (dataGridView1.SelectedRows.Count > 0)
            {
                presenter.Remove(dataGridView1.SelectedRows[0].Index);
            }
        }
        private void toolStripButtonTorles_Click(object sender, EventArgs e)
        {
            DGVTorles();
        }
        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVTorles();
        }

        private void toolStripButtonKereses_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            page = 1;
            presenter.LoadData();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                presenter.LoadData();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (maxPage != page)
            {
                page++;
                presenter.LoadData();
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            page = maxPage;
            presenter.LoadData();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                default:
                    sortBy = "Id";
                    break;
                case 1:
                    sortBy = "nev";
                    break;
                case 2:
                    sortBy = "energia";
                    break;
                case 3:
                    sortBy = "feherje";
                    break;
                case 4:
                    sortBy = "zsir";
                    break;
                case 5:
                    sortBy = "szenhidrat";
                    break;
            }

            sortIndex = e.ColumnIndex;
            presenter.LoadData();
        }

        
    }
}
