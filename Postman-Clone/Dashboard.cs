using PostManCloneLibrary;
using System.Net;

namespace Postman_Clone;

public partial class Dashboard : Form
{
    private readonly ApiAccess api = new();

    string statusCode;
    public Dashboard()
    {
        InitializeComponent();
    }



    private async void ApiUrlBtn_Click(object sender, EventArgs e)
    {
        SystemStatus.Text = "Calling Api ....";
        ResultsText.Text = "";
        if (!api.IsValidUrl(ApiUrl.Text))
        {
            SystemStatus.Text = "Invalid URL";
            return;
        }
        try
        {
            SystemStatus.Text = "Calling Api ....";

            ResultsText.Text = await api.CallApi(ApiUrl.Text);
            Status.Text = api.GetStatusCode();


            SystemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            ResultsText.Text = "Error" + ex.Message;
            SystemStatus.Text = "Error";
        }
    }

}
