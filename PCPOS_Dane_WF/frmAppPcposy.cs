using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCPOS_Dane_WF
{
    public partial class frmAppPcposy : Form
    {
        public frmAppPcposy()
        {
            InitializeComponent();
        }






        private void btnPobierz_Click(object sender, EventArgs e)
        {
            PCPOSDANE.PCPOS_DataFromSql  par = new PCPOSDANE.PCPOS_DataFromSql();
            string ip = txtIP.Text.ToString();
            string dstart = txtDStart.Text.ToString();
            string dstop = txtDStop.Text.ToString();
            DataSet ds = par.PcPosParagony(ip);

            gvParagony.DataSource = ds.Tables[0];

        }

        





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PCPOSDANE.PCPOS_DataFromSql par = new PCPOSDANE.PCPOS_DataFromSql();
                string ip = txtIP.Text.ToString();
                if ((ip.Length) == 0)
                {
                    ip = "10.4.0.100";
                }

                //string dstart = dateTimePicker1.Value.ToString();
                //string dstop = dateTimePicker2.Value.ToString();

                // zmień format na YYYY-MM-DD 
                string dstart = (dateTimePicker1.Value).Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
                string dstop = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;


                DataSet ds = par.PcPosParDaty(ip, dstart, dstop);

                gvParagony.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }





        private void gvParagony_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvParagony_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int posid = Int32.Parse(gvParagony.CurrentRow.Cells[0].Value.ToString());
                int receiptid = Int32.Parse(gvParagony.CurrentRow.Cells[1].Value.ToString());


                PCPOSDANE.PCPOS_DataFromSql par = new PCPOSDANE.PCPOS_DataFromSql();
                string ip = txtIP.Text.ToString();
                if ((ip.Length) == 0)
                {
                    ip = "10.4.0.100";
                }


                DataSet ds = par.PcPosParItems(ip, posid, receiptid);


                dataGridParagonItems.DataSource = ds.Tables[0];
            }

            catch (Exception Ex)
            {
  //              Msgbox()
            }


            //dataGridParagonItems
        }

        private void gvParagony_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void wyjścieZProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           // txtIP.Text = cmbSklepy.SelectedValue.ToString();
           // MessageBox.Show(txtIP.Text + " a to jest w selected value w cmbSklepy  " + cmbSklepy.SelectedValue.ToString());
        }

        private void frmAppPcposy_Load(object sender, EventArgs e)
        {
            PCPOSDANE.PCPOS_DataFromSql ws = new PCPOSDANE.PCPOS_DataFromSql();
           
            DataSet dssklepy = ws.WebMetOdczytajListęSklepów();
            cmbSklepy.DataSource =dssklepy.Tables[0];
            cmbSklepy.ValueMember = "IPADDRESS";
            cmbSklepy.DisplayMember = "ZakładIpNazwaSklepu";
        }

        private void cmbSklepy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIP.Text = cmbSklepy.SelectedValue.ToString();
            MessageBox.Show(txtIP.Text + " a to jest w selected value w cmbSklepy  "+ cmbSklepy.SelectedValue.ToString());
        }

        private void cmbSklepy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //odśwież dane w combo z lisa sklepów
            PCPOSDANE.PCPOS_DataFromSql ws = new PCPOSDANE.PCPOS_DataFromSql();
            DataSet dssklepy = ws.WebMetOdczytajListęSklepów();
            cmbSklepy.DataSource = dssklepy.Tables[0];
            cmbSklepy.ValueMember = "IPADDRESS";
            cmbSklepy.DisplayMember = "ZakładIpNazwaSklepu";

            txtIP.Text = cmbSklepy.SelectedValue.ToString();
            //MessageBox.Show(txtIP.Text + " a to jest w selected value w cmbSklepy  " + cmbSklepy.SelectedValue.ToString());
        }
    }
}
