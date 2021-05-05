using Client_Rest.Models;
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
using System.Xml;


namespace Client_Rest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            
            
        }
        private void debugOutput(string strDebugText)
        {
           
        }

        private void AddDataTable(string link)
        {
            RestClient rClient = new RestClient();
            rClient.endPoint = link;

            List<RestClient> strResponse = rClient.makeRequest();
            
            if (strResponse.Count >= 0)
            {
                dgPais.Rows.Clear();
                foreach (RestClient ob in strResponse)
                {
                    string timezone = "";
                    for (int i = 0; i <= ob.timezones.Count; i++)
                    {
                        if (i == 0)
                        {
                            timezone = ob.timezones[i];
                        }
                        else
                        {
                            timezone += ", " + ob.timezones[i - 1];
                        }
                    }
                    dgPais.Rows.Add(ob.name, ob.capital, ob.region, ob.subregion, ob.population, ob.area, timezone, ob.nativeName, ob.flag);
                }
            }
            else
            {
                
                MessageBox.Show("Nenhum registro foi encontrado!!!!!");
                dgPais.Rows.Clear();
                AddDataTable("https://restcountries.eu/rest/v2/all");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    dgPais.DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    dgPais.DefaultCellStyle.SelectionForeColor = Color.Black;
                    AddDataTable("https://restcountries.eu/rest/v2/all");
                    cboFiltro.SelectedIndex = 0;
                }
                catch (Exception a)
                {
                    MessageBox.Show("Ocorreu um erro ao conectar com o servidor!!! Descrição: " + a.Message);
                }
            }
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            string export = "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                export = sfd.FileName;
            }
            exportCSV(export+".csv");
        }
        public void exportCSV(string filePath)
        {
            try
            {
                StreamWriter stWriter = new StreamWriter(filePath, false);
                foreach (DataGridViewRow dr in dgPais.Rows)
                {
                    for (int i = 0; i < dgPais.Columns.Count; i++)
                    {
                        if (!Convert.IsDBNull(dr.Cells[i]))
                        {
                            if (dr.Cells[i].Value != null)
                            {
                                string value = dr.Cells[i].Value.ToString();
                                if (value.Contains(','))
                                {
                                    value = String.Format("\"{0}\"", value);
                                    stWriter.Write(value);
                                }
                                else
                                {
                                    stWriter.Write(dr.Cells[i].Value.ToString());
                                }
                            }
                        }

                        if (i < dgPais.Columns.Count - 1)
                        {
                            stWriter.Write(",");
                        }
                    }

                    stWriter.Write(stWriter.NewLine);
                }
                stWriter.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar em CSV!!! Descrição do erro: " + ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                if (dgPais.Rows.Count > -1)
                {
                    XcelApp.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dgPais.Columns.Count + 1; i++)
                    {
                        XcelApp.Cells[1, i] = dgPais.Columns[i - 1].HeaderText;
                    }

                    for (int i = 0; i < dgPais.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgPais.Columns.Count; j++)
                        {
                            if (dgPais.Rows[i].Cells[j].Value != null)
                                XcelApp.Cells[i + 2, j + 1] = dgPais.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar em EXcel!!! Descrição do erro: " + ex.Message);
            }
            
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                string export = "";
                DataTable dt = getXML(dgPais);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    export = sfd.FileName;
                }
                ds.WriteXml(File.OpenWrite(export + ".xml"));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar em xml!!! Descrição do erro: " + ex.Message);
            }
            
        }
        private DataTable getXML(DataGridView view)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn item in view.Columns)
            {
                if (item.Visible)
                {
                    dt.Columns.Add(item.ToString());
                }
            }
            object[] cell = new object[view.Columns.Count];
            foreach (DataGridViewRow item in view.Rows)
            {
                for (int i = 0; i < item.Cells.Count; i++)
                {
                    cell[i] = item.Cells[i].Value;
                }
                dt.Rows.Add(cell);
            }
            return dt;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (cboFiltro.SelectedItem.ToString() == "Contem o nome")
            {
                AddDataTable("https://restcountries.eu/rest/v2/name/" + txtFiltro.Text);
            }
            else if (cboFiltro.SelectedItem.ToString() == "Nome completo")
            {
                AddDataTable("https://restcountries.eu/rest/v2/name/" + txtFiltro + "?fullText=true");
            }
            else if (cboFiltro.SelectedItem.ToString() == "Capital")
            {
                AddDataTable("https://restcountries.eu/rest/v2/capital/" + txtFiltro.Text);
            }
            else if (cboFiltro.SelectedItem.ToString() == "Regiao")
            {
                AddDataTable("https://restcountries.eu/rest/v2/region/" + txtFiltro.Text);
            }
            else
            {
                MessageBox.Show("Selecione camp que pretende usar no filtro");
            }
        }
    }
}
