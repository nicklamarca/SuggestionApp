﻿using Microsoft.AspNetCore.Components.Forms;

namespace SuggestionAppUI.Components
{
    //The out of the box InputRadioGroup is screwy causing a doubleclick to engage the radio button. This is a fix for that.
    public class MyInputRadioGroup<TValue> : InputRadioGroup<TValue>
    {
        private string _name;
        private string _fieldClass;

        protected override void OnParametersSet()
        {
          var fieldClass = EditContext?.FieldCssClass(FieldIdentifier) ?? string.Empty;
            if (fieldClass != _fieldClass || Name != _name)
            {
                _fieldClass = fieldClass;
                _name = Name;
                base.OnParametersSet();
            }
        }
    }
}
