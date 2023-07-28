using System;
using PUPHubChatsModel;
using System.Collections.Generic;
using Data;

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
            SQLDataUserStatus sQLUStatus = new SQLDataUserStatus();
            blockedMembers.Add(new BlockModel { Name = memberName });
            string block = "Blocked";
            sQLUStatus.BlockMember(block);
        }

        public void UnblockMember(string memberName)
        {
            SQLDataUserStatus sQLUStatus = new SQLDataUserStatus();
            blockedMembers.RemoveAll(m => m.Name == memberName);
            string block = "Unblocked";
            sQLUStatus.BlockMember(block);
        }

        public List<BlockModel> GetBlockedMembers()
        {
            return blockedMembers;
        }
    }
}