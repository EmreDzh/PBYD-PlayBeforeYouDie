using System.Globalization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PBYD___PlayBeforeYouDie.ModelBinders;

public class DecimalModelBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        ValueProviderResult valueResult = bindingContext.ValueProvider
            .GetValue(bindingContext.ModelName);

        if (valueResult != ValueProviderResult.None && !string.IsNullOrEmpty(valueResult.FirstValue))
        {
            decimal actuallValue = 0M;
            bool success = false;

            try
            {
                string decimalValue = valueResult.FirstValue;
                decimalValue =
                    decimalValue.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                
                decimalValue =
                    decimalValue.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                
                actuallValue = Convert.ToDecimal(decimalValue, CultureInfo.CurrentCulture);
                success = true;
            }
            catch (Exception fe)
            {
                bindingContext.ModelState.AddModelError(bindingContext.ModelName, fe, bindingContext.ModelMetadata);
            }

            if (success)
            {
                bindingContext.Result = ModelBindingResult.Success(actuallValue);
            }
        }

        return Task.CompletedTask;
    }
}