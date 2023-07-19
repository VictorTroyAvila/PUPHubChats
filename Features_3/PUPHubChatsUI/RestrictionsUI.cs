using System;
using System.Collections.Generic;

class ChatRestrictionUI
{
    static void Main(string[] args)
    {
        RestrictionsModel restrictionsModel = new RestrictionsModel();
        ChatController chatController = new ChatController(restrictionsModel.GetUserType());
        chatController.StartChat();
    }
}
