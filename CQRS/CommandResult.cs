namespace CQRS
{
    public class CommandResult
    {
        public CommandStatus Status { get; set; }

        public int Id { get; set; }
    }
}