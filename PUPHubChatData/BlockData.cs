using System;
using System.Collections.Generic;

namespace PUPHubChatsData
{
    public class BlockData
    {
        private List<BlockModel> blockedMembers = new List<BlockModel>();

        public bool IsMemberBlocked(string memberName)
        {
            return blockedMembers.Exists(m => m.Name == memberName);
        }

        public void BlockMember(string memberName)
        {
            blockedMembers.Add(new BlockModel { Name = memberName });
        }

        public void UnblockMember(string memberName)
        {
            blockedMembers.RemoveAll(m => m.Name == memberName);
        }

        public List<BlockModel> GetBlockedMembers()
        {
            return blockedMembers;
        }
    }
}