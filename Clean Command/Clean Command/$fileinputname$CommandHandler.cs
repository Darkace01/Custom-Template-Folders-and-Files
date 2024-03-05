using MediatR;

namespace $rootnamespace$;

internal sealed class $itemname$: IRequestHandler<$fileinputname$Command, $fileinputname$CommandResponse>
{
    public Task<$fileinputname$CommandResponse> Handle($fileinputname$Command request, CancellationToken cancellationToken)
    {
        // Implement your logic here
        throw new NotImplementedException();
    }
}