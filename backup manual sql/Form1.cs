using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace backup_manual_sql
{
    
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlCommand command;
        private SqlDataReader reader;
        private string sql = "";
        private string connectionString = "";

        public Form1()
        {
            InitializeComponent();
            cmdDisconnect.Enabled = false;
            cmbDatabases.Enabled = false;
            cmdBackup.Enabled = false;
            cmdRestore.Enabled = false;
            cmdBrowseBkp.Enabled = false;
            cmdBrowseRestore.Enabled = false;
            cmdBrowsemove.Enabled = false;
            txtmove.Enabled = false;
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            if (!txtSource.Text.Equals(""))
            {
                try
                {
                    connectionString = "Data Source = " + txtSource.Text + "; User Id=" + txtid.Text + "; Password=" +
                                       txtpwd.Text + "";
                    conn = new SqlConnection(connectionString);
                    conn.Open();
                    // sql = "EXEC sp_databases";
                    sql = "SELECT * FROM sys.databases d";
                    command = new SqlCommand(sql, conn);
                    reader = command.ExecuteReader();
                    cmbDatabases.Items.Clear();

                    while (reader.Read())
                    {
                        cmbDatabases.Items.Add(reader[0].ToString());
                    }
                    txtSource.Enabled = false;
                    txtid.Enabled = false;
                    txtpwd.Enabled = false;
                    cmdConnect.Enabled = false;
                    cmbDatabases.Enabled = true;
                    cmdDisconnect.Enabled = true;
                    cmdBackup.Enabled = true;
                    cmdRestore.Enabled = true;
                    cmdBrowseBkp.Enabled = true;
                    cmdBrowseRestore.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Dados necessarios nao informados", "Erro!!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            txtSource.Enabled = true;
            txtid.Enabled = true;
            txtpwd.Enabled = true;
            cmbDatabases.Enabled = false;
            cmdBackup.Enabled = false;
            cmdRestore.Enabled = false;
            cmdConnect.Enabled = true;
            cmdDisconnect.Enabled = false;
            conn.Close();
        }

        private void cmdBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDatabases.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Selecione um banco de dados....");
                    return;
                }
                conn=new SqlConnection(connectionString);
                conn.Open();
                sql = "BACKUP DATABASE " + cmbDatabases.Text + " TO DISK = '" + txtDatabaseLoc.Text +"\\"+cmbDatabases.Text+"-"+ DateTime.Now.Ticks.ToString()+".bak'";
                command = new SqlCommand(sql,conn);
                command.CommandTimeout = 0;
                command.ExecuteNonQuery();
                MessageBox.Show("Backup do bando de dados completado com sucesso!!!");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmdBrowseBkp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK) 
            {
                txtDatabaseLoc.Text = dlg.SelectedPath;
            }
        }

        private void cmdBrowseRestore_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDataRestloc.Text = dlg.FileName;
            }
        }

        private void cmdRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDatabases.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Selecione um banco de dados....");
                    return;
                }

                  
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = " USE[master];";

                
                sql += "RESTORE DATABASE [" + cmbDatabases.Text + "] FROM  DISK = N'" + txtDataRestloc.Text +
                       "' WITH FILE = 1, ";
                if (checkBox1.Checked)
                {
                    sql += " MOVE N'" + cmbDatabases.Text + "' TO '" + txtmove.Text + "\\" + cmbDatabases.Text + ".mdf' ,";
                    sql += " MOVE N'" + cmbDatabases.Text + "_Log' TO N'" + txtmove.Text +"\\"+ cmbDatabases.Text + "_Log.ldf', ";
                   
                }
                sql += " NOUNLOAD,  REPLACE,  STATS = 5;";
                command = new SqlCommand(sql,conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Restauração do banco de dados restaurado com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmdLimpa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDatabases.Text.CompareTo("") == 0)
                {
                    MessageBox.Show("Selecione um banco de dados....");
                    return;
                }
                conn = new SqlConnection(connectionString);
                conn.Open();
                sql = " USE [" + cmbDatabases.Text + "]; ";
                sql += " ALTER DATABASE " + cmbDatabases.Text + " SET RECOVERY SIMPLE; ";
                sql += " DBCC SHRINKDATABASE(" + cmbDatabases.Text + ",TRUNCATEONLY ); ";
                sql += " DBCC SHRINKFILE (N'" + cmbDatabases.Text + "_log', 0,TRUNCATEONLY ); ";
                sql += " ALTER DATABASE " + cmbDatabases.Text + " SET RECOVERY full ; ";
                sql += " DBCC SHRINKFILE (2, TRUNCATEONLY) ; ";
                sql += " EXEC  sp_MSforeachtable ";
                sql +=" 'ALTER INDEX ALL ON ? REBUILD WITH (FILLFACTOR = 90, SORT_IN_TEMPDB = ON, ONLINE = OFF , STATISTICS_NORECOMPUTE = OFF );' ";
                sql += " DBCC SHRINKFILE (1, TRUNCATEONLY); DBCC SHRINKFILE (2, TRUNCATEONLY); ";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("Manutenção do banco de dados executado com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cmdBrowsemove.Enabled = true;
                txtmove.Enabled = true;
            }
            else
            {
                cmdBrowsemove.Enabled = false;
                txtmove.Enabled = false;
            }
        }

        private void cmdBrowsemove_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK) 
            {
                txtmove.Text = dlg.SelectedPath;
            }
        }
    }
}

