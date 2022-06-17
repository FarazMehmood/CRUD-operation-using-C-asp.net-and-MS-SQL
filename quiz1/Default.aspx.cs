using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       

    }


    private void pointer()
    {

        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        try
        {
            SqlConnection objConn = new SqlConnection(connString);
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
                string comandString = "select * from BookDetail";
                SqlCommand cmnd = new SqlCommand(comandString, objConn);
                DataTable dt = new DataTable();
                
                SqlDataAdapter da = new SqlDataAdapter(cmnd);
                da.Fill(dt);
              
                GridView1.DataSource = dt;
                GridView1.DataBind();
                objConn.Close();
            }

        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        try
        {
            SqlConnection objConn = new SqlConnection(connString);
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
                string comandString = "insert into BookDetail values('"+int.Parse(TextBox1.Text)+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+ TextBox5.Text + "','" + TextBox6.Text + "')";
                SqlCommand cmnd = new SqlCommand(comandString, objConn);
                cmnd.ExecuteNonQuery();
                LblError.Text = "Data has been saved sucessfully";
                objConn.Close();
            }

        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }
    protected void Search_Click(object sender, EventArgs e)
    {

        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        try
        {
            SqlConnection objConn = new SqlConnection(connString);
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
                string comandString = "select * from BookDetail where BookID= '" + TextBox1.Text + "'";
                SqlCommand cmnd = new SqlCommand(comandString, objConn);
                SqlDataReader dr = cmnd.ExecuteReader();
                if (dr.HasRows)
                {

                    dr.Read();
                    TextBox2.Text = dr[1].ToString();
                    TextBox3.Text = dr[2].ToString();
                    TextBox4.Text = dr[3].ToString();
                    TextBox5.Text = dr[4].ToString();
                    TextBox6.Text = dr[5].ToString();
                    dr.Close();
                   
                }
                else
                {
                    LblError.Text = "No data to show";
                }

                objConn.Close();
            }
        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }
        protected void Button3_Click(object sender, EventArgs e)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        try
        {
            SqlConnection objConn = new SqlConnection(connString);
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
                LblError.Text = "Data has been saved sucessfully";
                objConn.Close();
            }

        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }
    protected void Update_Click(object sender, EventArgs e)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        try
        {
            SqlConnection objConn = new SqlConnection(connString);
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
                string comandString = "update BookDetail set  BookName = '" + TextBox2.Text + "', BookCategory = '" + TextBox3.Text + "',Edition ='" + TextBox4.Text + "',Publisher ='" + TextBox5.Text + "',PrintDate ='" + TextBox6.Text + "' where BookID = '" + TextBox1.Text + "'";
                SqlCommand cmnd = new SqlCommand(comandString, objConn);
                cmnd.ExecuteNonQuery();
                LblError.Text = "Data has been updated sucessfully";
                objConn.Close();
             
            }

        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }

    protected void ALL_Click(object sender, EventArgs e)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        try
        {
            SqlConnection objConn = new SqlConnection(connString);
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
                string comandString = "select * from BookDetail";
                SqlCommand cmnd = new SqlCommand(comandString, objConn);
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();

                SqlDataAdapter da = new SqlDataAdapter(cmnd);
                da.Fill(dt);
                da.Fill(ds);


                GridView1.DataSource = dt;
                GridView1.DataBind();
                objConn.Close();
            }

        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }
    protected void Delete_Click(object sender, EventArgs e)
    {
        string connString = System.Configuration.ConfigurationManager.ConnectionStrings["myconnection"].ConnectionString;
        try
        {
            SqlConnection objConn = new SqlConnection(connString);
            if (objConn.State == ConnectionState.Closed)
            {
                objConn.Open();
                string comandString = "Delete from BookDetail where BookID = '" + TextBox1.Text + "'";
                SqlCommand cmnd = new SqlCommand(comandString, objConn);
                cmnd.ExecuteNonQuery();
                LblError.Text = "Data has been Deleted sucessfully";
                objConn.Close();
                pointer();
            }

        }
        catch (Exception ex)
        {

            LblError.Text = ex.Message;
        }
    }
    protected void Reset_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";


    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {

    }
}