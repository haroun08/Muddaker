using Microsoft.Extensions.Logging;
using Muddaker.Domain.Events;

namespace Muddaker.Application.TodoItems.EventHandlers;

public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Muddaker Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
