namespace PartyInvites.Models;

public static class GuestRepository
{
    public static List<GuestResponse> responses = new List<GuestResponse>();

    public static IEnumerable<GuestResponse> Responses => responses;

    public static void AddGuest(GuestResponse guestResponse)
    {
        System.Console.WriteLine(guestResponse);
        responses.Add(guestResponse);
    }
}