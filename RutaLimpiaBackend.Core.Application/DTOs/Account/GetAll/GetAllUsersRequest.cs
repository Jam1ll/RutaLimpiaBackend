namespace RutaLimpiaBackend.Core.Application.DTOs.Account.GetAll
{
    public class GetAllUsersRequest
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
