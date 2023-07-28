using System;

public class MuteData
{
    private List<MuteModel> mutedMembers = new List<MuteModel>();

    public void AddMember(MuteModel member)
    {
        mutedMembers.Add(member);
    }

    public bool ContainsMember(MuteModel member)
    {
        return mutedMembers.Contains(member);
    }

    public void RemoveMember(MuteModel member)
    {
        mutedMembers.Remove(member);
    }

    public List<MuteModel> GetMutedMembers()
    {
        return mutedMembers;
    }
}

