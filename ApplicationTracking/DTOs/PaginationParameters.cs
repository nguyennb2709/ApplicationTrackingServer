using System.Text.Json;

namespace ApplicationTracking.DTOs;

public class PaginationParameters
{
    public int Offset { get; set; } = 0;
    public int Limit { get; set; } = 10;
}