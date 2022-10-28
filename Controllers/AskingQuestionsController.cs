//Griffin Parker
//Say Hello - Endpoint
//October 28, 2022
//This program takes the user's name and time they woke up from the user through the URL, inserts them in to a response and displays it in the endpoint 
//Peer Review - Chris Martinez, i was able to type in a name, along with the time, and it populated a sentence that read my name and the time I woke up.
// it was also nice to see that there was a local host https included on the comments, of the controller. Way to go Griffin.
//https://localhost:xxxx/AskingQuestions/AskingQuestions/{name}/{time}

using Microsoft.AspNetCore.Mvc;

namespace ParkerGAskingQuestionsEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
    [HttpGet]
    [Route("AskingQuestions/{nombre}/{time}")]
    public string Questions(string nombre, string time)
    {
        return $"You are {nombre} and you woke up at {time}!";
    }

}
