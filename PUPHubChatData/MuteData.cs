using Data;
using System;

public class MuteData
{
    private List<MuteModel> mutedMembers = new List<MuteModel>();

    public void AddMember(MuteModel member)
    {
        SQLDataUserStatus sQLUStatus = new SQLDataUserStatus();
        mutedMembers.Add(member);
        string mute = "Muted";
        sQLUStatus.MuteMember(mute);
    }

    public bool ContainsMember(MuteModel member)
    {
        return mutedMembers.Contains(member);
    }

    public void RemoveMember(MuteModel member)
    {
        SQLDataUserStatus sQLUStatus = new SQLDataUserStatus();
        mutedMembers.Remove(member);
        string mute = "Unmuted";
        sQLUStatus.MuteMember(mute);
    }

    public List<MuteModel> GetMutedMembers()
    {
        return mutedMembers;
    }
}

