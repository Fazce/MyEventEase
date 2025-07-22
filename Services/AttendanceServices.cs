public class AttendanceRecord
{
    public int Id { get; set; }
    public int EventId { get; set; }
    public string UserEmail { get; set; } = default!;
    public DateTime Timestamp { get; set; }
}

public interface IAttendanceService
{
    Task AddAsync(AttendanceRecord record);
    Task<List<AttendanceRecord>> GetByEventAsync(int eventId);
}

public class AttendanceService : IAttendanceService
{
    // In-memory store for simplicity
    private readonly List<AttendanceRecord> _store = new();

    public Task AddAsync(AttendanceRecord record)
    {
        record.Id = _store.Count + 1;
        _store.Add(record);
        return Task.CompletedTask;
    }

    public Task<List<AttendanceRecord>> GetByEventAsync(int eventId)
        => Task.FromResult(_store.Where(r => r.EventId == eventId).ToList());
}
