namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.ResponseDtos;

public class ExpectedSerialReceiptResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public DateTime InputDate { get; set; }
    public int StatusId { get; set; }
}
