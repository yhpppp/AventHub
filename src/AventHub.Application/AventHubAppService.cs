using System;
using System.Collections.Generic;
using System.Text;
using AventHub.Localization;
using Volo.Abp.Application.Services;

namespace AventHub;

/* Inherit your application services from this class.
 */
public abstract class AventHubAppService : ApplicationService
{
    protected AventHubAppService()
    {
        LocalizationResource = typeof(AventHubResource);
    }
}
