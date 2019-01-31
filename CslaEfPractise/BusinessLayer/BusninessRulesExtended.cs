using System;
using System.Collections.Generic;
using Csla.Core;
using Csla.Rules;
using System.Globalization;
using System.Linq;

namespace BusinessLayer
{
    public class ToUpper : BusinessRule
    {
        public ToUpper(IPropertyInfo primaryProperty)
     : base(primaryProperty)
        {
            InputProperties = new List<IPropertyInfo>() { primaryProperty };
            AffectedProperties.Add(primaryProperty);
        }
        protected override void Execute(RuleContext context)
        {
            var value = (string)context.InputPropertyValues[PrimaryProperty];
            context.AddOutValue(PrimaryProperty, value.ToUpper());
        }

    }

    public class ToLower : BusinessRule
    {
        public ToLower(IPropertyInfo primaryProperty)
     : base(primaryProperty)
        {
            InputProperties = new List<IPropertyInfo>() { primaryProperty };
            AffectedProperties.Add(primaryProperty);
        }
        protected override void Execute(RuleContext context)
        {
            var value = (string)context.InputPropertyValues[PrimaryProperty];
            context.AddOutValue(PrimaryProperty, value.ToLower());
        }

    }

    public class CapitalizeFirst : BusinessRule
    {
        public CapitalizeFirst(IPropertyInfo primaryProperty)
     : base(primaryProperty)
        {
            InputProperties = new List<IPropertyInfo>() { primaryProperty };
            AffectedProperties.Add(primaryProperty);
        }
        protected override void Execute(RuleContext context)
        {
            var value = (string)context.InputPropertyValues[PrimaryProperty];
            context.AddOutValue(PrimaryProperty, CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value));
        }

    }


    public class PdvIznos : BusinessRule
    {
        public PdvIznos(IPropertyInfo primaryProperty)
     : base(primaryProperty)
        {
            InputProperties = new List<IPropertyInfo>() { primaryProperty };
            AffectedProperties.Add(primaryProperty);
        }
        protected override void Execute(RuleContext context)
        {
            var value = (int)context.InputPropertyValues[PrimaryProperty];
            context.AddOutValue(PrimaryProperty, value * 17 / 100);
        }

    }
    public class PdvOsnovica : BusinessRule
    {

        public PdvOsnovica(IPropertyInfo primaryProperty)
     : base(primaryProperty)
        {
            InputProperties = new List<IPropertyInfo>() { primaryProperty };
            AffectedProperties.Add(primaryProperty);
        }
        protected override void Execute(RuleContext context)
        {
            var value = (int)context.InputPropertyValues[PrimaryProperty];
            context.AddOutValue(PrimaryProperty, value / 117 * 100);
        }

    }

    public class CalcSum : PropertyRule
    {
        public CalcSum(IPropertyInfo primaryProperty, params IPropertyInfo[] inputProperties)
      : base(primaryProperty)
        {
            InputProperties = new List<IPropertyInfo>();
            InputProperties.AddRange(inputProperties);
            this.RuleUri.AddQueryParameter("input", string.Join(",", inputProperties.Select(p => p.Name).ToArray()));
            CanRunOnServer = false;
        }
        protected override void Execute(RuleContext context)
        {
            // Use linq Sum to calculate the sum value
            var sum = context.InputPropertyValues.Sum(property => (dynamic)property.Value);

            // add calculated value to OutValues
            // When rule is completed the RuleEngine will update businessobject
            context.AddOutValue(PrimaryProperty, sum);

        }

    }



}
