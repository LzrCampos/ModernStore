using FluentValidator;
using Microsoft.AspNetCore.Mvc;
using ModernStore.Infrastructure.Transaction;
using System.Collections.Generic;
using System.Linq;

namespace ModernStore.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly IUow _uow;

        public BaseController(IUow uow)
        {
            _uow = uow;
        }

        public new IActionResult Response(object result, IEnumerable<Notification> notification)
        {
            if (!notification.Any())
            {
                try
                {
                    _uow.Commit();
                    return Ok(new
                    {
                        success = true,
                        data = result
                    });
                }
                catch
                {
                    // logar o error
                    return BadRequest(new
                    {
                        success = false,
                        errors = new string[] { "Ocorreu um erro interno no servidor!" }
                    });
                }
            }
            else
            {
                return BadRequest(new
                {
                    success = false,
                    errors = notification
                });
            }
        }
    }
}
