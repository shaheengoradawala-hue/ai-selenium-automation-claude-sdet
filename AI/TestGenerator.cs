public class TestGenerator
{
    private ClaudeClient _client = new ClaudeClient();

    public void GenerateLoginTests()
    {
        string prompt = "Generate Selenium test cases for login page with edge cases";
        string response = _client.GenerateResponse(prompt);

        Console.WriteLine(response);
    }
}
