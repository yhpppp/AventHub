using AventHub.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AventHub.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AventHubController : AbpControllerBase
{
    protected AventHubController()
    {
        LocalizationResource = typeof(AventHubResource);
    }
}
