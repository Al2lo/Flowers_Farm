using Telegram.Bot;

namespace WebApi.FlowersFarm.BotModels
{
    public class TgBot
    {
        private readonly IConfiguration _configuration;

        public TgBot(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<TelegramBotClient> GetBotAsync()
        {
            var tgBot = new TelegramBotClient(_configuration["Token"]);
            var hookUrl = $"{_configuration["Url"]}api/message/update";

            await tgBot.SetWebhook(hookUrl);

            return tgBot;
        }
    }
}
