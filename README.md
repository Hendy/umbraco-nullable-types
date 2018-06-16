# Umbraco Nullable Types
Property editors (and value converters) to enable a null value to be selected in preference to a default value.

## _Nullable Boolean_
A tri-state data-type where the default value is null.

The raw values are stored as strings: "", "0" or "1", which makes it compatable with the built-in true/false data-type.
The property-value-converter will return a nullable bool.

## _Nullable String_
'But strings are always nullable !' however with a textbox alone there's no way to distinguish between whitespace and null, 
so this data-type adds a checkbox to toggle between the textbox value and null.

The raw value stored is as json (which enables a previously nulled value to be restored) but the property-value-converter will return a string.