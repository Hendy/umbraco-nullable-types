# Umbraco Nullable Types
Property editors (and value converters) to enable a null value to be selected in preference to an empty value.

## _Nullable Boolean_
A tri-state data-type where the default value is null.
The raw values stored are: "", "0" or "1" so compatable with the built-in true/false data-type.
The property-value-converter returns a nullable bool.

## _Nullable String_
'But strings are always nullable !' however with a textbox alone there's no way to distinguish between whitespace and null, 
so this data-type adds a checkbox to toggle between the textbox value and null.
The raw value stored is json, but the property-value-converter will return a string.