class DataStorage
{
    private List<MemberModel> blockedMembers = new List<MemberModel>();

    public bool IsMemberBlocked(string memberName)
    {
        return blockedMembers.Exists(m => m.Name == memberName);
    }

    public void BlockMember(string memberName)
    {
        blockedMembers.Add(new MemberModel { Name = memberName });
    }

    public void UnblockMember(string memberName)
    {
        blockedMembers.RemoveAll(m => m.Name == memberName);
    }

    public List<MemberModel> GetBlockedMembers()
    {
        return blockedMembers;
    }
}

internal class MemberModel
{
    public string Name { get; internal set; }
}