using Tiket.Data.Entities;

namespace Tiket.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext Context)
        {
            _context = Context;
        }
        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await CheckTicketAsync();
        }

        private async Task CheckTicketAsync()
        {
            if (!_context.Tickets.Any())
            {
                _context.Tickets.Add(new Ticket
                {
                    WasUsed = false,
                    Document = "",
                    Name = "",
                    Entrance = new Entrance()
                    {
                        Description = "",
                    }
                });
                await _context.SaveChangesAsync();
            }
        }
    }
}
