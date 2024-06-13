using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OpenAI.Interfaces;
using OpenAI.ObjectModels.RequestModels;

namespace BetalgoOpenAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenAIController : ControllerBase
    {
        private IOpenAIService _openAIService;

        public OpenAIController(IOpenAIService openAIService)
        {
            _openAIService = openAIService ?? throw new ArgumentNullException(nameof(openAIService));

        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAIResponseAsync(string prompt)
        {
            var chatMessages = new List<ChatMessage>
    {
        new ChatMessage
        {
            Role = "user",
            Content = prompt
        }
    };

            var completionResult = await _openAIService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = chatMessages,
                Model = "gpt-3.5-turbo",
                MaxTokens = 4000
            });

            var receivedMessage = completionResult.Choices.First().Message.Content;

            return Ok(new { Prompt = prompt, GeneratedText = receivedMessage });
        }
    }
}
