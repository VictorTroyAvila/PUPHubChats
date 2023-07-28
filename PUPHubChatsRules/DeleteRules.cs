using System;
using System.Collections.Generic;

public class DeleteRules
{
    public DeleteModel FindMessageById(List<DeleteModel> messages, int messageId)
    {
        return messages.Find(m => m.Id == messageId);
    }
}