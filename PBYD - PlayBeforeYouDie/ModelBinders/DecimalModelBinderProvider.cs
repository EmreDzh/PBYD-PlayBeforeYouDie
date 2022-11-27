using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PBYD___PlayBeforeYouDie.ModelBinders;

public class DecimalModelBinderProvider : IModelBinderProvider
{
    // Just copy paste this and change the value type for example: Decimal
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
        if (context == null)
        {
            throw new ArgumentException(nameof(context));
        }

        if (context.Metadata.ModelType == typeof(Decimal) || context.Metadata.ModelType == typeof(Decimal?))
        {
            return new DecimalModelBinder();
        }

        return null;
    }
}