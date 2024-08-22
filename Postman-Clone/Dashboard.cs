namespace Postman_Clone;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

  

    private async void ApiUrlBtn_Click(object sender, EventArgs e)
    {
        try
        {
            SystemStatus.Text = "Calling Api ....";
            await Task.Delay(2000);
            SystemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            ResultsText.Text = "Error" + ex.Message;
            SystemStatus.Text = "Error";
        }
    }
}
