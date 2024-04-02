namespace Orhanization.Core.Application.Dtos;

public class UserForRegisterDto : IDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string LocalityId { get; set; }
    public int[] UserOperationClaimIds { get; set; }
    public Guid[] UserLocalityIds { get; set; }

    public UserForRegisterDto()
    {
        Email = string.Empty;
        Password = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
    }

    public UserForRegisterDto(string email, string password, string firstName, string lastName, string localityId, int[] userOperationClaimIds, Guid[] userLocalityIds)
    {
        Email = email;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
        LocalityId = localityId;
        UserOperationClaimIds = userOperationClaimIds;
        UserLocalityIds = userLocalityIds;
    }
}
