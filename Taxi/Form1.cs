using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Order". При необходимости она может быть перемещена или удалена.
            this.orderTableAdapter.Fill(this.dataBaseDataSet.Order);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataBaseDataSet.Worker". При необходимости она может быть перемещена или удалена.
            this.workerTableAdapter.Fill(this.dataBaseDataSet.Worker);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordkerAddForm newForm = new WordkerAddForm(this);
            if (newForm.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                string Wfull,Wposition,Wdate,Wpassprt,WInn,Wdrive,Wadde,Wphon,WcarNumb;
                Wfull = newForm.Wfullname.Text;
                Wposition = newForm.Wposition.Text;
                Wdate = newForm.Wdate.Text;
                Wpassprt = newForm.Wpassport.Text;
                WInn = newForm.WINN.Text;
                Wdrive = newForm.Wdrive.Text;
                Wadde = newForm.Waddress.Text;
                Wphon = newForm.Wphone.Text;
                WcarNumb = newForm.Wcar.Text;
 
                this.workerTableAdapter
                    .Insert(Wfull, Wposition, Wdate, Wpassprt, WInn, Wdrive, Wadde, Wphon, WcarNumb);
                this.workerTableAdapter.Fill(this.dataBaseDataSet.Worker); // отображение
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkerEditForm newForm = new WorkerEditForm(this);

            int index;
            string Wfull, Wposition, Wdate, Wpassprt, WInn, Wdrive, Wadde, Wphon, WcarNumb;
            int id_worker;

            if (dataGridView1.RowCount <= 1) return;

            index = dataGridView1.CurrentRow.Index;

            if (index == dataGridView1.RowCount - 1) return;


            Wdate = (string)dataGridView1.Rows[index].Cells[0].Value;
            id_worker = (int)dataGridView1.Rows[index].Cells[1].Value;
            Wfull = (string)dataGridView1.Rows[index].Cells[2].Value;
            Wadde = (string)dataGridView1.Rows[index].Cells[3].Value;
            Wpassprt = (string)dataGridView1.Rows[index].Cells[4].Value;
            Wdrive = (string)dataGridView1.Rows[index].Cells[5].Value;
            WcarNumb = (string)dataGridView1.Rows[index].Cells[6].Value;
            Wphon = (string)dataGridView1.Rows[index].Cells[7].Value;
            WInn = (string)dataGridView1.Rows[index].Cells[8].Value;
            Wposition = (string)dataGridView1.Rows[index].Cells[9].Value;

            newForm.Wdate_e.Text = Wdate;
            newForm.Wfullname_e.Text = Wfull;
            newForm.Waddress_e.Text = Wadde;
            newForm.Wpassport_e.Text = Wpassprt;
            newForm.Wdrive_e.Text = Wdrive;
            newForm.Wcar_e.Text = WcarNumb;
            newForm.Wphone_e.Text = Wphon;
            newForm.WINN_e.Text = WInn;
            newForm.Wposition_e.Text = Wposition;

            if (newForm.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                string nWfull, nWposition, nWdate, nWpassprt, nWInn, nWdrive, nWadde, nWphon, nWcarNumb;

                nWfull = newForm.Wfullname_e.Text;
                nWposition = newForm.Wposition_e.Text;
                nWdate = newForm.Wdate_e.Text;
                nWpassprt = newForm.Wpassport_e.Text;
                nWInn = newForm.WINN_e.Text;
                nWdrive = newForm.Wdrive_e.Text;
                nWadde = newForm.Waddress_e.Text;
                nWphon = newForm.Wphone_e.Text;
                nWcarNumb = newForm.Wcar_e.Text;

                this.workerTableAdapter.Update(nWdate, nWfull, nWadde, nWpassprt, nWdrive, nWcarNumb, nWphon, nWInn, nWposition,  Wdate, id_worker, Wfull, Wadde,Wpassprt,Wdrive,WcarNumb,Wphon,WInn,Wposition);
                this.workerTableAdapter.Fill(this.dataBaseDataSet.Worker); // отображение
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OrderAddForm newForm = new OrderAddForm(this);
            if (newForm.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                string Ofrom,Oto,Ophn,OdateAndTime,OCgildren,Obage;
                int Ocomplite;
                Ofrom = newForm.Ofrom.Text;
                Oto = newForm.Oto.Text;
                Ocomplite = Convert.ToInt32(newForm.Ocomp.Text);
                Ophn = newForm.Ophone.Text;
                OdateAndTime = newForm.Odate.Text;
                OCgildren = newForm.Ochild.Text;
                Obage = newForm.Obage.Text;

                this.orderTableAdapter.Insert(Ocomplite,Ofrom, Oto,  Ophn, OdateAndTime, OCgildren, Obage);
                this.orderTableAdapter.Fill(this.dataBaseDataSet.Order);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderEditForm newForm = new OrderEditForm(this);

     
            string Ofrom, Oto, Ophn, OdateAndTime, OCgildren, Obage;
            int Ocomplite, id_order, index;
          

            if (dataGridView2.RowCount <= 1) return;

            index = dataGridView2.CurrentRow.Index;

            if (index == dataGridView2.RowCount - 1) return;



            Ofrom = (string)dataGridView2.Rows[index].Cells[2].Value;
            id_order = (int)dataGridView2.Rows[index].Cells[0].Value;
            Oto = (string)dataGridView2.Rows[index].Cells[3].Value;
            Ophn = (string)dataGridView2.Rows[index].Cells[5].Value;
            OdateAndTime = (string)dataGridView2.Rows[index].Cells[4].Value;
            OCgildren = (string)dataGridView2.Rows[index].Cells[6].Value;
            Obage = (string)dataGridView2.Rows[index].Cells[7].Value;
            Ocomplite = (int)dataGridView2.Rows[index].Cells[1].Value;

            newForm.Odate_e.Text = OdateAndTime;
            newForm.Ocomp_e.Text = Convert.ToString(Ocomplite);
            newForm.Obage_e.Text = Obage;
            newForm.Ochild_e.Text = OCgildren;
            newForm.Ofrom_e.Text = Ofrom;
            newForm.Oto_e.Text = Oto;
            newForm.Ophn_e.Text = Ophn;
          


            if (newForm.ShowDialog() == DialogResult.OK) // отобразить форм
            {

                string nOfrom, nOto, nOphn, nOdateAndTime, nOCgildren, nObage;
                int nOcomplite;

                nOfrom = newForm.Ofrom_e.Text;
                nOto = newForm.Oto_e.Text;
                nOphn = newForm.Ophn_e.Text;
                nOdateAndTime = newForm.Odate_e.Text;
                nOcomplite = Convert.ToInt32(newForm.Ocomp_e.Text);
                nOCgildren = newForm.Ochild_e.Text;
                nObage = newForm.Obage_e.Text;

                this.orderTableAdapter.Update(nOcomplite, nOfrom,  nOto, nOdateAndTime, nOphn,  nOCgildren, nObage,id_order,Ocomplite,Ofrom,Oto,OdateAndTime,Ophn,OCgildren,Obage);
                this.orderTableAdapter.Fill(this.dataBaseDataSet.Order);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteWorkerForm newForm = new DeleteWorkerForm(this);

            int index;
            string Wfull, Wposition, Wdate, Wpassprt, WInn, Wdrive, Wadde, Wphon, WcarNumb;
            int id_worker;

            index = dataGridView1.CurrentRow.Index;


            Wdate = Convert.ToString(dataGridView1[0, index].Value);
            id_worker = Convert.ToInt32(dataGridView1[1, index].Value);
            Wfull = Convert.ToString(dataGridView1[2, index].Value);
            Wadde = Convert.ToString(dataGridView1[3, index].Value);
            Wpassprt = Convert.ToString(dataGridView1[4, index].Value);
            Wdrive = Convert.ToString(dataGridView1[5, index].Value);
            WcarNumb = Convert.ToString(dataGridView1[6, index].Value);
            Wphon = Convert.ToString(dataGridView1[7, index].Value);
            WInn = Convert.ToString(dataGridView1[8, index].Value);
            Wposition = Convert.ToString(dataGridView1[9, index].Value);

            if (newForm.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                this.workerTableAdapter
                   .Delete(Wdate, id_worker, Wfull, Wadde, Wpassprt, Wdrive, WcarNumb, Wphon, WInn, Wposition);
                this.workerTableAdapter.Fill(this.dataBaseDataSet.Worker); // отображение
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteOrderForm newForm = new DeleteOrderForm(this);
            string Ofrom, Oto, Ophn, OdateAndTime, OCgildren, Obage;
            int Ocomplite, id_order, index;

            index = dataGridView2.CurrentRow.Index;

            Ofrom = Convert.ToString(dataGridView2[2, index].Value);
            id_order = Convert.ToInt32(dataGridView2[0, index].Value);
            Oto = Convert.ToString(dataGridView2[3, index].Value);
            Ophn = Convert.ToString(dataGridView2[5, index].Value);
            OdateAndTime = Convert.ToString(dataGridView2[4, index].Value);
            OCgildren = Convert.ToString(dataGridView2[6, index].Value);
            Obage = Convert.ToString(dataGridView2[7, index].Value);
            Ocomplite = Convert.ToInt32(dataGridView2[1, index].Value);

            if (newForm.ShowDialog() == DialogResult.OK) // отобразить форму
            {
                this.orderTableAdapter.Delete(id_order,Ocomplite, Ofrom, Oto, OdateAndTime, Ophn, OCgildren, Obage);
                this.orderTableAdapter.Fill(this.dataBaseDataSet.Order);
       
            }
        }
    }
}
