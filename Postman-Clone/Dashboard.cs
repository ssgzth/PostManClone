using PostManCloneLibrary;

namespace Postman_Clone;

public partial class Dashboard : Form
{
    private readonly ApiAccess api = new();
    public Dashboard()
    {
        InitializeComponent();
    }

  

    private async void ApiUrlBtn_Click(object sender, EventArgs e)
    {
        try
        {
            SystemStatus.Text = "Calling Api ....";

            ResultsText.Text = await api.CallApi(ApiUrl.Text);
            SystemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            ResultsText.Text = "Error" + ex.Message;
            SystemStatus.Text = "Error";
        }
    }
}
