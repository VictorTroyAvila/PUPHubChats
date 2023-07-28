class Data
{
    private List<Model> mutedMembers = new List<Model>();

    public void AddMember(Model member)
    {
        mutedMembers.Add(member);
    }

    public bool ContainsMember(Model member)
    {
        return mutedMembers.Contains(member);
    }

    public void RemoveMember(Model member)
    {
        mutedMembers.Remove(member);
    }

    public List<Model> GetMutedMembers()
    {
        return mutedMembers;
    }
}

internal class Model
{
}