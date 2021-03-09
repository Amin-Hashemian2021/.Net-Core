using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

public partial class CreatePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
            string root = Server.MapPath("~");

            string Template = root + "\\PageTemplate.temp";            
            StringBuilder line = new StringBuilder();
            using (StreamReader rwOpenTemplate = new StreamReader(Template))
            {
                while (!rwOpenTemplate.EndOfStream)
                {
                    line.Append(rwOpenTemplate.ReadToEnd());
                }
            }
           
           int ID = 0;
           string SaveFilePath = "";
           string SaveFileName = "";
           Random ran = new Random();
           ID = ran.Next();

                //Page Name Creator
               
                string Title = ID.ToString() + "-" + StripURLNotAllowedChars(txtTitle.Text);
                SaveFileName = "\\"+ Title + ".aspx";
                SaveFilePath = root + "\\Pages\\" + SaveFileName;
                 FileStream fsSave = File.Create(SaveFilePath);
                 if (line != null)
                 {                    
                     line.Replace("[Title]", txtTitle.Text.Replace("<", "&lt;").Replace(">", "&gt;").Replace('"', ' ').Replace('"', ' '));                    
                     line.Replace("[PageContent]", txtContent.Text);
                     line.Replace("[MetaDes]", txtDes.Text.Replace('"', ' ').Replace('"', ' ').Replace('<', '-').Replace('>', '-') );
                     line.Replace("[key]", txtKey.Text.Replace('"', ' ').Replace('"', ' ').Replace('<', '-').Replace('>', '-'));
                     line.Replace("[ID]", ID.ToString());            
                     StreamWriter sw = null;
                     try
                     {
                         sw = new StreamWriter(fsSave);
                         sw.Write(line);
                     }
                     catch (Exception ex)
                     {
                         lblMessage.Text = ex.Message;
                     }
                     finally
                     {
                         sw.Close();                         
                     }
                 }
    }
    private string StripURLNotAllowedChars(string htmlString)
    {
        string pattern = @"\s|\#|\$|\&|\||\!|\@|\%|\^|\*|\<\|\>|\\|\/|\+|\-|\=";
        return Regex.Replace(htmlString, pattern, "-");
    }
}
