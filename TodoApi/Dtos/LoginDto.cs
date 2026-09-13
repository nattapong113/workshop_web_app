namespace TodoApi.Data;

    public record LoginDto(string Username, string Password);
    public record LoginResponseDto(string Token, DateTime Expiration);