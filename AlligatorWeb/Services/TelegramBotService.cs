using Telegram.Bot;

namespace AlligatorWeb.Services;

public class TelegramBotService
{
    private readonly TelegramBotClient _botClient;
    private readonly long _chatId; // Replace this with your actual chat ID

    public TelegramBotService(string botToken, long chatId)
    {
        _botClient = new TelegramBotClient(botToken);
        _chatId = chatId;
    }

    public async Task SendMessageAsync(string message)
    {
        try
        {
            await _botClient.SendTextMessageAsync(_chatId, message);
        }
        catch (Exception ex)
        {
            // Handle exception here, e.g., log it
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}