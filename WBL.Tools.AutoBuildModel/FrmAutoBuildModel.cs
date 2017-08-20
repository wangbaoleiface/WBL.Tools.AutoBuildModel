//==============================================
// 作者：王保雷
// 时间：2017/8/20 20:23:04
// 版本：V1.0.0.0
// 文件名：FrmAutoBuildModel
// 交流博客：http://www.cnblogs.com/wbl168/
// 说明：
//==============================================

using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WBL.Tools.AutoBuildModel
{
    /// <summary>
    /// 自动生成实体类   
    /// </summary>
    public partial class FrmAutoBuildModel : Form
    {
        /// <summary>
        /// 链接数据库字符串
        /// </summary>
        private string connString = "";

        public FrmAutoBuildModel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗体时候，退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAutoBuildModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("您确定要退出本程序吗？", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 登录服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtSerName.Text.Trim() == "")
            {
                MessageBox.Show("服务器名称不能为空！", "温馨提示");
                this.txtSerName.Focus();
                return;
            }
            if (this.txtDBName.Text.Trim() == "")
            {
                MessageBox.Show("数据库名不能为空！", "温馨提示");
                this.txtDBName.Focus();
                return;
            }
            if (this.txtLoginName.Text.Trim() == "")
            {
                MessageBox.Show("登录名不能为空！", "温馨提示");
                this.txtLoginName.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Trim() == "")
            {
                MessageBox.Show("登录密码不能为空！", "温馨提示");
                this.txtLoginPwd.Focus();
                return;
            }
            connString = string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}",
                this.txtSerName.Text.Trim(), this.txtDBName.Text.Trim(), this.txtLoginName.Text.Trim(), this.txtLoginPwd.Text.Trim());
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                conn.Close();
                this.lblMsg.Text = "您登录成功，可以进行生成工作！";
                this.lblMsg.ForeColor = Color.Green;
                this.grpOperation.Enabled = true;
                this.grpLogin.Enabled = false;
                this.btnReLogin.Enabled = true;
            }
            catch (Exception ex)
            {
                this.lblMsg.Text = "您登录失败，不能进行生成工作！\n失败原因：" + ex.Message;
                this.lblMsg.ForeColor = Color.Red;
                this.grpOperation.Enabled = false;
                this.grpLogin.Enabled = true;
                this.btnReLogin.Enabled = false;
            }
        }

        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.btnOK.Enabled = false;
            if (this.txtPath.Text.Trim() == "")
            {
                MessageBox.Show("保存路径不能为空！", "温馨提示");
                this.txtPath.Focus();
                this.btnOK.Enabled = true;
                return;
            }
            if (this.txtModelName.Text.Trim() == "")
            {
                MessageBox.Show("Model命名空间不能为空！", "温馨提示");
                this.txtModelName.Focus();
                this.btnOK.Enabled = true;
                return;
            }
            try
            {
                string tableSql = "SELECT [name] FROM sys.objects WHERE [type] = N'U'";
                DataTable tableTab = GetTable(tableSql);
                foreach (DataRow dr in tableTab.Rows)
                {
                    string tableName = dr["name"].ToString();
                    string columnNameSql = string.Format(@"SELECT C.[name] AS [name], (CASE WHEN (T.[name]='bigint' OR T.[name]='int' OR T.[name]='smallint' OR T.[name]='tinyint') THEN 'int'
                                                           WHEN (T.[name]='char' OR T.[name]='nchar' OR T.[name]='ntext' OR T.[name]='nvarchar' OR T.[name]='text' OR T.[name]='varchar') THEN 'string'
                                                           WHEN (T.[name]='datetime' OR T.[name]='smalldatetime') THEN 'DateTime'
                                                           WHEN (T.[name]='decimal' OR T.[name]='money' OR T.[name]='smallmoney') THEN 'decimal'
                                                           WHEN (T.[name]='float' OR T.[name]='real') THEN 'float' WHEN (T.[name]='numeric') THEN 'double' WHEN T.[name]='bit' THEN 'bool'
                                                           WHEN (T.[name]='image' OR T.[name]='binary' OR T.[name]='varbinary') THEN 'byte'
                                                           ELSE 'object' END) AS [type], ISNULL(E.value, '') AS columnDsc FROM sys.columns C 
                                                           INNER JOIN sys.types T ON C.user_type_id = T.user_type_id
                                                           LEFT JOIN sys.extended_properties E ON E.class = 1 AND E.major_id = C.[object_id] AND E.minor_id = C.column_id
                                                           WHERE C.[object_id] = OBJECT_ID('{0}', N'U')", tableName);
                    DataTable columnTab = GetTable(columnNameSql);
                    string path = this.txtPath.Text.Trim();
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    if (tableName.IndexOf('_') != -1)
                    {
                        string[] tableNames = tableName.Split('_');
                        tableName = "";
                        for (int i = 0; i < tableNames.Length; i++)
                        {
                            tableName += tableNames[i].Substring(0, 1).ToUpper() + tableNames[i].Substring(1);
                        }
                    }
                    else
                    {
                        tableName = tableName.Substring(0, 1).ToUpper() + tableName.Substring(1);
                    }
                    // 创建文件流
                    FileStream fs = new FileStream(path + @"\" + tableName + ".cs", FileMode.Create);
                    // 创建写入器
                    StreamWriter sw = new StreamWriter(fs);
                    // 将内容写入文件
                    sw.WriteLine("using System;");
                    sw.WriteLine("using System.Collections.Generic;");
                    sw.WriteLine("using System.Text;");
                    sw.WriteLine("");
                    sw.WriteLine("namespace " + this.txtModelName.Text.Trim());
                    sw.WriteLine("{");
                    sw.WriteLine("    [Serializable]");
                    sw.WriteLine("    public class " + tableName);
                    sw.WriteLine("    {");
                    sw.WriteLine("        #region 字段");
                    sw.WriteLine("");
                    foreach (DataRow colDr in columnTab.Rows)
                    {
                        sw.WriteLine("        private " + colDr["type"].ToString() + " _" +
                            colDr["name"].ToString().Substring(0, 1).ToLower() + colDr["name"].ToString().Substring(1) + ";");
                    }
                    sw.WriteLine("");
                    sw.WriteLine("        #endregion");
                    sw.WriteLine("");
                    sw.WriteLine("        #region 属性");
                    sw.WriteLine("");
                    foreach (DataRow colDr in columnTab.Rows)
                    {
                        string colName = "_" + colDr["name"].ToString().Substring(0, 1).ToLower() + colDr["name"].ToString().Substring(1);
                        sw.WriteLine("        /// <summary>");
                        sw.WriteLine("        /// " + colDr["columnDsc"].ToString());
                        sw.WriteLine("        /// </summary>");
                        sw.WriteLine("        public " + colDr["type"].ToString() + " " +
                            colDr["name"].ToString().Substring(0, 1).ToUpper() + colDr["name"].ToString().Substring(1));
                        sw.WriteLine("        {");
                        sw.WriteLine("            get { return this." + colName + "; }");
                        sw.WriteLine("            set { this." + colName + " = value; }");
                        sw.WriteLine("        }");
                        sw.WriteLine("");
                    }
                    sw.WriteLine("        #endregion");
                    sw.WriteLine("    }");
                    sw.WriteLine("}");
                    // 关闭写入器
                    sw.Close();
                    // 关闭文件流
                    fs.Close();
                    sw.Dispose();
                    fs.Dispose();
                }
                this.lblMsg.Text = "您的操作已完成，生成实体类成功！";
                this.lblMsg.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {

                this.lblMsg.Text = "您的操作已完成，生成实体类过程中失败！\n失败原因：" + ex.Message;
                this.lblMsg.ForeColor = Color.Red;
            }
            finally
            {
                this.btnOK.Enabled = true;
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShow_Click(object sender, EventArgs e)
        {
            this.fbdShowFilePath.Description = "请选择实体类（Model）生成的所有文件所保存的文件路径！";
            this.fbdShowFilePath.ShowDialog();
            this.txtPath.Text = fbdShowFilePath.SelectedPath;
        }

        /// <summary>
        /// 重新登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReLogin_Click(object sender, EventArgs e)
        {
            this.btnReLogin.Enabled = false;
            this.grpLogin.Enabled = true;
            this.grpOperation.Enabled = false;
        }

        /// <summary>
        /// 查看博客地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnklblBlog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.cnblogs.com/wbl168/");
        }

        /// <summary>
        /// 获取table数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        private DataTable GetTable(string sql)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
