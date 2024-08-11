namespace GameStore.API.Dtos
{
    public record class GameSummaryDto(
        int Id,
        string Name,
        string GenreId,
        decimal Price,
        DateOnly ReleaseDate
        );
}
