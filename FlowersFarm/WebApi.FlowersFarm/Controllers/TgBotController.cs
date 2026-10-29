using Microsoft.AspNetCore.Mvc;
using Telegram.Bot;
using Telegram.Bot.Types;
using WebApi.FlowersFarm.BotModels;

namespace WebApi.FlowersFarm.Controllers
{
    [ApiController]
    [Route("api/message")]
    public class TgBotController : ControllerBase
    {
        private readonly TelegramBotClient _tgBotClient;

        public TgBotController(TgBot tgBot)
        {
            _tgBotClient = tgBot.GetBotAsync().Result;
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(Update update)
        {
            var chat = update.Message.Chat;

            await _tgBotClient.SendMessage(chat.Id, "Hello");

            return Ok();
        }
    }
}
