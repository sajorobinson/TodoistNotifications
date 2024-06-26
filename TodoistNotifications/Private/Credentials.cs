namespace Private
{
    public class Credentials
    {
        public static string TodoistApiToken()
        {
            try
            {
                string token = Environment.GetEnvironmentVariable("TODOIST_API_TOKEN")!;
                return token;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Could not retrieve Todoist API token", ex);
            }
        }
        public static string SendGridApiToken()
        {
            try
            {
                string token = Environment.GetEnvironmentVariable("SENDGRID_API_TOKEN")!;
                return token;
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Could not retrieve SendGrid API token", ex);
            }
        }
    }
}