using HumbleMediator;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Api;

[ApiController]
[Route("api/[controller]")]
public abstract class AppControllerBase : ControllerBase
{
    protected readonly IMediator _mediator;

    public AppControllerBase(IMediator mediator)
    {
        _mediator = mediator;
    }
}
