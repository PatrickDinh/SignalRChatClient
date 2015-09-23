using Nancy;

namespace SignalRChatClient.App.Modules
{
    public class Register : NancyModule
    {
        public Register()
        {
            Get["/register"] = _ =>
            {
                return View["index"];
            };
        }
    }
}
